using System;
using System.Web.Mvc;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Renders Tumblr "Share" button.</para>
  ///   <para>Requires Tumblr scripts bundle to be included.</para>
  /// </summary>
  /// <seealso cref="http://www.tumblr.com/buttons"/>
  /// <seealso cref="IWidgetsScriptsRendererExtensions.Tumblr(IWidgetsScriptsRenderer)"/>
  public class TumblrShareButtonWidget : HtmlWidget, ITumblrShareButtonWidget
  {
    private byte type = (byte) TumblrShareButtonType.First;
    private string colorScheme;

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
    ///   <para>Visual color scheme of button.</para>
    /// </summary>
    /// <returns>Color scheme for button.</returns>
    public string ColorScheme()
    {
      return this.colorScheme;
    }

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
    ///   <para>Visual layout/appearance of button.</para>
    /// </summary>
    /// <returns>Layout of button.</returns>
    public byte Type()
    {
      return this.type;
    }

    /// <summary>
    ///   <para>Returns HTML markup text of widget.</para>
    /// </summary>
    /// <returns>Widget's HTML markup.</returns>
    public override string ToHtmlString()
    {
      byte width;
      switch (this.Type().To<TumblrShareButtonType>())
      {
        case TumblrShareButtonType.First:
          width = 80;
          break;

        case TumblrShareButtonType.Second:
          width = 70;
          break;

        case TumblrShareButtonType.Third:
          width = 130;
          break;

        case TumblrShareButtonType.Forth:
          width = 20;
          break;

        default:
          width = 80;
          break;
      }

      return new TagBuilder("a")
        .Attribute("href", "http://www.tumblr.com/share")
        .Attribute("title", "Share on Tumblr")
        .Attribute("style", "display:inline-block; text-indent:-9999px; overflow:hidden; width:{2}px; height:20px; background:url('http://platform.tumblr.com/v1/share_{0}{1}.png') top left no-repeat transparent;".FormatSelf(this.Type(), this.ColorScheme() != null && string.Equals(this.ColorScheme(), TumblrShareButtonColorScheme.Gray.ToString(), StringComparison.InvariantCultureIgnoreCase) ? "T" : string.Empty, width))
        .InnerHtml("Share on Tumblr")
        .ToString();
    }
  }
}