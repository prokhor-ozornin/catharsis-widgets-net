using System.Web.Mvc;
using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="ITumblrShareButtonWidget"/>
public class TumblrShareButtonWidget : WebWidget, ITumblrShareButtonWidget
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
    if (scheme is null) throw new ArgumentNullException(nameof(scheme));
    if (scheme.IsEmpty()) throw new ArgumentException(nameof(scheme));

    colorScheme = scheme;
      
    return this;
  }

  /// <summary>
  ///   <para>Visual color scheme of button.</para>
  /// </summary>
  /// <returns>Color scheme for button.</returns>
  public string ColorScheme() => colorScheme;

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
  public byte Type() => type;

  /// <inheritdoc cref="IWebWidget.ToHtml()"/>
  public override string ToHtml()
  {
    byte width;

    switch (Type().To<TumblrShareButtonType>())
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
      .Attribute("style", string.Format("display:inline-block; text-indent:-9999px; overflow:hidden; width:{2}px; height:20px; background:url('http://platform.tumblr.com/v1/share_{0}{1}.png') top left no-repeat transparent;", this.Type(), this.ColorScheme() is not null && string.Equals(this.ColorScheme(), TumblrShareButtonColorScheme.Gray.ToString(), StringComparison.InvariantCultureIgnoreCase) ? "T" : string.Empty, width))
      .InnerHtml("Share on Tumblr")
      .ToString();
  }
}