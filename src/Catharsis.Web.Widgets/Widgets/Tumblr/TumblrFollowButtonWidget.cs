using System.Web.Mvc;
using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="ITumblrFollowButtonWidget"/>
public class TumblrFollowButtonWidget : WebWidget, ITumblrFollowButtonWidget
{
  private string account;
  private byte type = (byte) TumblrFollowButtonType.First;
  private string colorScheme = TumblrFollowButtonColorScheme.Light.ToString().ToLowerInvariant();

  /// <summary>
  ///   <para>Name of Tumblr account (blog).</para>
  /// </summary>
  /// <param name="account">Name of blog.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="account"/> is a <c>null</c> reference.</exception>
  /// <exception cref="ArgumentException">If <paramref name="account"/> is <see cref="string.Empty"/> string.</exception>
  /// <remarks>This attribute is required.</remarks>
  public ITumblrFollowButtonWidget Account(string account)
  {
    if (account is null) throw new ArgumentNullException(nameof(account));
    if (account.IsEmpty()) throw new ArgumentException(nameof(account));

    this.account = account;

    return this;
  }

  /// <summary>
  ///   <para>Name of Tumblr account (blog).</para>
  /// </summary>
  /// <returns>Name of blog.</returns>
  public string Account() => account;

  /// <summary>
  ///   <para>Visual color scheme of button.</para>
  /// </summary>
  /// <param name="scheme">Color scheme for button.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="scheme"/> is a <c>null</c> reference.</exception>
  /// <exception cref="ArgumentException">If <paramref name="scheme"/> is <see cref="string.Empty"/> string.</exception>
  public ITumblrFollowButtonWidget ColorScheme(string scheme)
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
  public ITumblrFollowButtonWidget Type(byte type)
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
    if (Account().IsEmpty())
    {
      return string.Empty;
    }

    byte width;

    switch ((TumblrFollowButtonType) Type())
    {
      case TumblrFollowButtonType.Second:
        width = 113;
        break;

      case TumblrFollowButtonType.Third:
        width = 18;
        break;

      case TumblrFollowButtonType.First:
        width = 189;
        break;

      default:
        throw new ArgumentOutOfRangeException();
    }

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