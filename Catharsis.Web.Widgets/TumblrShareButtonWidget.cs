using System;
using System.IO;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Renders Tumblr "Share" button.</para>
  ///   <para>Requires <see cref="WidgetsScripts.TumblrShare"/> scripts bundle to be included.</para>
  ///   <seealso cref="http://www.tumblr.com/buttons"/>
  /// </summary>
  public sealed class TumblrShareButtonWidget : HtmlWidgetBase<ITumblrShareButtonWidget>, ITumblrShareButtonWidget
  {
    private byte type = (byte) TumblrShareButtonType.First;
    private string colorScheme;

    /// <summary>
    ///   <para>Visual layout/appearance of button.</para>
    /// </summary>
    /// <param name="type">Layout of button.</param>
    /// <returns>Reference to the current widget.</returns>
    public ITumblrShareButtonWidget Type(byte type)
    {
      this.type = type;
      return this;
    }

    /// <summary>
    ///   <para>Visual color scheme of button.</para>
    /// </summary>
    /// <param name="scheme">Color scheme for button.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="scheme"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="scheme"/> is <see cref="string.Empty"/> string.</exception>
    public ITumblrShareButtonWidget ColorScheme(string scheme)
    {
      Assertion.NotEmpty(scheme);

      this.colorScheme = scheme;
      return this;
    }

    /// <summary>
    ///   <para>Generates and writes HTML markup of widget, using specified text writer.</para>
    /// </summary>
    /// <param name="writer">Text writer to use as output destination.</param>
    public override void Write(TextWriter writer)
    {
      Assertion.NotNull(writer);

      byte width;
      switch (this.type.To<TumblrShareButtonType>())
      {
        case TumblrShareButtonType.First :
          width = 80;
        break;

        case TumblrShareButtonType.Second :
          width = 70;
        break;

        case TumblrShareButtonType.Third :
          width = 130;
        break;

        case TumblrShareButtonType.Forth :
          width = 20;
        break;

        default:
          width = 80;
          break;
      }

      writer.Write(this.ToTag("a", tag => tag
        .Attribute("href", "http://www.tumblr.com/share")
        .Attribute("title", "Share on Tumblr")
        .Attribute("style", "display:inline-block; text-indent:-9999px; overflow:hidden; width:{2}px; height:20px; background:url('http://platform.tumblr.com/v1/share_{0}{1}.png') top left no-repeat transparent;".FormatSelf(this.type, this.colorScheme != null && this.colorScheme.ToLowerInvariant() == TumblrShareButtonColorScheme.Gray.ToString().ToLowerInvariant() ? "T" : string.Empty, width))
        .InnerHtml("Share on Tumblr")));
    }
  }
}