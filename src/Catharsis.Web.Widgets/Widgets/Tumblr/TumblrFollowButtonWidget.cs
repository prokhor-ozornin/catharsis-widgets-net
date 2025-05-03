using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="ITumblrFollowButtonWidget"/>
public class TumblrFollowButtonWidget : WebWidget, ITumblrFollowButtonWidget
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string AccountProperty { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual byte TypeProperty { get; set; } = (byte) TumblrFollowButtonType.First;

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string ColorSchemeProperty { get; set; } = nameof(TumblrFollowButtonColorScheme.Light).ToLowerInvariant();

  /// <inheritdoc cref="ITumblrFollowButtonWidget.Account(string)"/>
  public virtual ITumblrFollowButtonWidget Account(string account)
  {
    if (account is null) throw new ArgumentNullException(nameof(account));
    if (account.IsEmpty()) throw new ArgumentException(nameof(account));

    AccountProperty = account;

    return this;
  }

  /// <inheritdoc cref="ITumblrFollowButtonWidget.ColorScheme(string)"/>
  public virtual ITumblrFollowButtonWidget ColorScheme(string scheme)
  {
    if (scheme is null) throw new ArgumentNullException(nameof(scheme));
    if (scheme.IsEmpty()) throw new ArgumentException(nameof(scheme));

    ColorSchemeProperty = scheme;
      
    return this;
  }

  /// <inheritdoc cref="ITumblrFollowButtonWidget.Type(byte)"/>
  public virtual ITumblrFollowButtonWidget Type(byte type)
  {
    TypeProperty = type;
    return this;
  }

  /// <inheritdoc cref="ICloneable.Clone()"/>
  public override object Clone() => new TumblrFollowButtonWidget
  {
    AccountProperty = AccountProperty,
    TypeProperty = TypeProperty,
    ColorSchemeProperty = ColorSchemeProperty
  };
  
  /// <inheritdoc cref="IWebWidget.ToHtml()"/>
  public override string ToHtml()
  {
    if (AccountProperty.IsUnset())
    {
      return string.Empty;
    }

    byte width = (TumblrFollowButtonType) TypeProperty switch
    {
      TumblrFollowButtonType.Second => 113,
      TumblrFollowButtonType.Third => 18,
      TumblrFollowButtonType.First => 189,
      _ => throw new ArgumentOutOfRangeException()
    };

    return new TagBuilder("iframe")
      .Attribute("border", 0)
      .Attribute("allowtransparency", true)
      .Attribute("src", $"http://platform.tumblr.com/v1/follow_button.html?button_type=${TypeProperty}&tumblelog=${AccountProperty}&color_scheme=${ColorSchemeProperty}")
      .Attribute("frameborder", 0)
      .Attribute("height", 25)
      .Attribute("scrolling", "no")
      .Attribute("width", width)
      .CssClass("btn")
      .ToString();
  }
}