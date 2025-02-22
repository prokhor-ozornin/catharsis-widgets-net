using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="ITumblrShareButtonWidget"/>
public class TumblrShareButtonWidget : WebWidget, ITumblrShareButtonWidget
{
  private byte TypeProperty { get; set; } = (byte) TumblrShareButtonType.First;
  private string ColorSchemeProperty { get; set; }

  /// <inheritdoc cref="ITumblrShareButtonWidget.ColorScheme(string)"/>
  public ITumblrShareButtonWidget ColorScheme(string scheme)
  {
    if (scheme is null) throw new ArgumentNullException(nameof(scheme));
    if (scheme.IsEmpty()) throw new ArgumentException(nameof(scheme));

    ColorSchemeProperty = scheme;
      
    return this;
  }

  /// <inheritdoc cref="ITumblrShareButtonWidget.ColorScheme()"/>
  public string ColorScheme() => ColorSchemeProperty;

  /// <inheritdoc cref="ITumblrShareButtonWidget.Type(byte)"/>
  public ITumblrShareButtonWidget Type(byte type)
  {
    TypeProperty = type;
    return this;
  }

  /// <inheritdoc cref="ITumblrShareButtonWidget.Type()"/>
  public byte Type() => TypeProperty;

  /// <inheritdoc cref="IHtmlContent.ToHtml()"/>
  public override string ToHtml()
  {
    byte width = Type().To<TumblrShareButtonType>() switch
    {
      TumblrShareButtonType.First => 80,
      TumblrShareButtonType.Second => 70,
      TumblrShareButtonType.Third => 130,
      TumblrShareButtonType.Forth => 20,
      _ => 80
    };

    return new TagBuilder("a")
      .Attribute("href", "http://www.tumblr.com/share")
      .Attribute("title", "Share on Tumblr")
      .Attribute("style", string.Format("display:inline-block; text-indent:-9999px; overflow:hidden; width:{2}px; height:20px; background:url('http://platform.tumblr.com/v1/share_{0}{1}.png') top left no-repeat transparent;", Type(), ColorScheme() is not null && string.Equals(ColorScheme(), TumblrShareButtonColorScheme.Gray.ToString(), StringComparison.InvariantCultureIgnoreCase) ? "T" : string.Empty, width))
      .Html("Share on Tumblr")
      .ToString();
  }
}