using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="ISoundCloudProfileIconWidget"/>
public class SoundCloudProfileIconWidget : WebWidget, ISoundCloudProfileIconWidget
{
  private string account;
  private string color = "orange_white";
  private short size = (short) SoundCloudProfileIconSize.Size32;

  /// <inheritdoc cref="ISoundCloudProfileIconWidget.Account(string)"/>
  public ISoundCloudProfileIconWidget Account(string account)
  {
    if (account is null) throw new ArgumentNullException(nameof(account));
    if (account.IsEmpty()) throw new ArgumentException(nameof(account));

    this.account = account;
    return this;
  }

  /// <inheritdoc cref="ISoundCloudProfileIconWidget.Account()"/>
  public string Account() => account;

  /// <inheritdoc cref="ISoundCloudProfileIconWidget.Color(string)"/>
  public ISoundCloudProfileIconWidget Color(string color)
  {
    if (color is null) throw new ArgumentNullException(nameof(color));
    if (color.IsEmpty()) throw new ArgumentException(nameof(color));

    this.color = color;
    return this;
  }

  /// <inheritdoc cref="ISoundCloudProfileIconWidget.Size(short)"/>
  public string Color() => color;

  /// <inheritdoc cref="ISoundCloudProfileIconWidget.Size(short)"/>
  public ISoundCloudProfileIconWidget Size(short size)
  {
    this.size = size;
    return this;
  }

  /// <inheritdoc cref="ISoundCloudProfileIconWidget.Size()"/>
  public short Size() => size;

  /// <inheritdoc cref="IHtmlContent.ToHtml()"/>
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