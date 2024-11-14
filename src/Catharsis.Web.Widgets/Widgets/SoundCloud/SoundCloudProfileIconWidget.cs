using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="ISoundCloudProfileIconWidget"/>
public class SoundCloudProfileIconWidget : WebWidget, ISoundCloudProfileIconWidget
{
  private string account;
  private string color = "orange_white";
  private short size = (short) SoundCloudProfileIconSize.Size32;

  /// <summary>
  ///   <para>SoundCloud user's account name.</para>
  /// </summary>
  /// <param name="account">Account name.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="account"/> is a <c>null</c> reference.</exception>
  /// <exception cref="ArgumentException">If <paramref name="account"/> is <see cref="string.Empty"/> string.</exception>
  /// <remarks>This attribute is required.</remarks>
  public ISoundCloudProfileIconWidget Account(string account)
  {
    if (account is null) throw new ArgumentNullException(nameof(account));
    if (account.IsEmpty()) throw new ArgumentException(nameof(account));

    this.account = account;
    return this;
  }

  /// <summary>
  ///   <para>SoundCloud user's account name.</para>
  /// </summary>
  /// <returns>Account name.</returns>
  public string Account() => account;

  /// <summary>
  ///   <para>Color of profile icon.</para>
  /// </summary>
  /// <param name="color">Icon's color.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="color"/> is a <c>null</c> reference.</exception>
  /// <exception cref="ArgumentException">If <paramref name="color"/> is <see cref="string.Empty"/> string.</exception>
  public ISoundCloudProfileIconWidget Color(string color)
  {
    if (color is null) throw new ArgumentNullException(nameof(color));
    if (color.IsEmpty()) throw new ArgumentException(nameof(color));

    this.color = color;
    return this;
  }

  /// <summary>
  ///   <para>Color of profile icon.</para>
  /// </summary>
  /// <returns>Icon's color.</returns>
  public string Color() => color;

  /// <summary>
  ///   <para>Edge size of profile icon in pixels.</para>
  /// </summary>
  /// <param name="size">Icon's size.</param>
  /// <returns>Reference to the current widget.</returns>
  public ISoundCloudProfileIconWidget Size(short size)
  {
    this.size = size;
    return this;
  }

  /// <summary>
  ///   <para>Edge size of profile icon in pixels.</para>
  /// </summary>
  /// <returns>Icon's size.</returns>
  public short Size() => size;

  /// <inheritdoc cref="IWebWidget.ToHtml()"/>
  public override string ToHtml()
  {
    if (Account().IsEmpty())
    {
      return string.Empty;
    }

    return new TagBuilder("iframe")
      .Attribute("allowtransparency", true)
      .Attribute("frameborder", 0)
      .Attribute("scrolling", "no")
      .Attribute("style", string.Format("width: {0}px; height: {0}px;", Size()))
      .Attribute("src", $"https://w.soundcloud.com/icon/?url=http://soundcloud.com/${Account()}&color=${Color()}&size=${Size()}")
      .ToString();
  }
}