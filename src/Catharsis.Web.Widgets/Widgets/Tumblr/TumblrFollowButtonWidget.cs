using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="ITumblrFollowButtonWidget"/>
public class TumblrFollowButtonWidget : WebWidget, ITumblrFollowButtonWidget
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string AccountValue { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual byte TypeValue { get; set; } = (byte) TumblrFollowButtonType.First;

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string ColorSchemeValue { get; set; } = nameof(TumblrFollowButtonColorScheme.Light).ToLowerInvariant();

  /// <inheritdoc cref="ITumblrFollowButtonWidget.Account(string)"/>
  public virtual ITumblrFollowButtonWidget Account(string account)
  {
    if (account is null) throw new ArgumentNullException(nameof(account));
    if (account.IsEmpty()) throw new ArgumentException(nameof(account));

    AccountValue = account;

    return this;
  }

  /// <inheritdoc cref="ITumblrFollowButtonWidget.ColorScheme(string)"/>
  public virtual ITumblrFollowButtonWidget ColorScheme(string scheme)
  {
    if (scheme is null) throw new ArgumentNullException(nameof(scheme));
    if (scheme.IsEmpty()) throw new ArgumentException(nameof(scheme));

    ColorSchemeValue = scheme;
      
    return this;
  }

  /// <inheritdoc cref="ITumblrFollowButtonWidget.Type(byte)"/>
  public virtual ITumblrFollowButtonWidget Type(byte type)
  {
    TypeValue = type;
    return this;
  }

  /// <inheritdoc cref="ICloneable.Clone()"/>
  public override object Clone() => new TumblrFollowButtonWidget
  {
    AccountValue = AccountValue,
    TypeValue = TypeValue,
    ColorSchemeValue = ColorSchemeValue
  };
  
  /// <inheritdoc cref="IWebWidget.ToHtml()"/>
  public override string ToHtml()
  {
    if (AccountValue.IsUnset())
    {
      return string.Empty;
    }

    byte width = (TumblrFollowButtonType) TypeValue switch
    {
      TumblrFollowButtonType.Second => 113,
      TumblrFollowButtonType.Third => 18,
      TumblrFollowButtonType.First => 189,
      _ => throw new ArgumentOutOfRangeException()
    };

    return new TagBuilder("iframe")
      .Attribute("border", 0)
      .Attribute("allowtransparency", true)
      .Attribute("src", $"http://platform.tumblr.com/v1/follow_button.html?button_type=${TypeValue}&tumblelog=${AccountValue}&color_scheme=${ColorSchemeValue}")
      .Attribute("frameborder", 0)
      .Attribute("height", 25)
      .Attribute("scrolling", "no")
      .Attribute("width", width)
      .CssClass("btn")
      .ToString();
  }
}