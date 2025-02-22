using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="ITumblrFollowButtonWidget"/>
public class TumblrFollowButtonWidget : WebWidget, ITumblrFollowButtonWidget
{
  private string AccountProperty { get; set; }
  private byte TypeProperty { get; set; } = (byte) TumblrFollowButtonType.First;
  private string ColorSchemeProperty { get; set; } = TumblrFollowButtonColorScheme.Light.ToString().ToLowerInvariant();

  /// <inheritdoc cref="ITumblrFollowButtonWidget.Account(string)"/>
  public ITumblrFollowButtonWidget Account(string account)
  {
    if (account is null) throw new ArgumentNullException(nameof(account));
    if (account.IsEmpty()) throw new ArgumentException(nameof(account));

    AccountProperty = account;

    return this;
  }

  /// <inheritdoc cref="ITumblrFollowButtonWidget.Account()"/>
  public string Account() => AccountProperty;

  /// <inheritdoc cref="ITumblrFollowButtonWidget.ColorScheme(string)"/>
  public ITumblrFollowButtonWidget ColorScheme(string scheme)
  {
    if (scheme is null) throw new ArgumentNullException(nameof(scheme));
    if (scheme.IsEmpty()) throw new ArgumentException(nameof(scheme));

    ColorSchemeProperty = scheme;
      
    return this;
  }

  /// <inheritdoc cref="ITumblrFollowButtonWidget.ColorScheme()"/>
  public string ColorScheme() => ColorSchemeProperty;

  /// <inheritdoc cref="ITumblrFollowButtonWidget.Type(byte)"/>
  public ITumblrFollowButtonWidget Type(byte type)
  {
    TypeProperty = type;
    return this;
  }

  /// <inheritdoc cref="ITumblrFollowButtonWidget.Type()"/>
  public byte Type() => TypeProperty;

  /// <inheritdoc cref="IHtmlContent.ToHtml()"/>
  public override string ToHtml()
  {
    if (Account().IsEmpty())
    {
      return string.Empty;
    }

    byte width = (TumblrFollowButtonType)Type() switch
    {
      TumblrFollowButtonType.Second => 113,
      TumblrFollowButtonType.Third => 18,
      TumblrFollowButtonType.First => 189,
      _ => throw new ArgumentOutOfRangeException()
    };

    return new TagBuilder("iframe")
      .Attribute("border", 0)
      .Attribute("allowtransparency", true)
      .Attribute("src", $"http://platform.tumblr.com/v1/follow_button.html?button_type=${Type()}&tumblelog=${Account()}&color_scheme=${ColorScheme()}")
      .Attribute("frameborder", 0)
      .Attribute("height", 25)
      .Attribute("scrolling", "no")
      .Attribute("width", width)
      .CssClass("btn")
      .ToString();
  }
}