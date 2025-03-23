using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="ISoundCloudProfileIconWidget"/>
public class SoundCloudProfileIconWidget : WebWidget, ISoundCloudProfileIconWidget
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string AccountProperty { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string ColorProperty { get; set; } = "orange_white";

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual short SizeProperty { get; set; } = (short) SoundCloudProfileIconSize.Size32;

  /// <inheritdoc cref="ISoundCloudProfileIconWidget.Account(string)"/>
  public virtual ISoundCloudProfileIconWidget Account(string account)
  {
    if (account is null) throw new ArgumentNullException(nameof(account));
    if (account.IsEmpty()) throw new ArgumentException(nameof(account));

    AccountProperty = account;
    return this;
  }

  /// <inheritdoc cref="ISoundCloudProfileIconWidget.Color(string)"/>
  public virtual ISoundCloudProfileIconWidget Color(string color)
  {
    if (color is null) throw new ArgumentNullException(nameof(color));
    if (color.IsEmpty()) throw new ArgumentException(nameof(color));

    ColorProperty = color;
    return this;
  }

  /// <inheritdoc cref="ISoundCloudProfileIconWidget.Size(short)"/>
  public virtual ISoundCloudProfileIconWidget Size(short size)
  {
    SizeProperty = size;
    return this;
  }

  /// <inheritdoc cref="IHtmlContent.ToHtml()"/>
  public override string ToHtml()
  {
    if (AccountProperty.IsEmpty())
    {
      return string.Empty;
    }

    return new TagBuilder("iframe")
      .Attribute("allowtransparency", true)
      .Attribute("frameborder", 0)
      .Attribute("scrolling", "no")
      .Attribute("style", string.Format("width: {0}px; height: {0}px;", SizeProperty))
      .Attribute("src", $"https://w.soundcloud.com/icon/?url=http://soundcloud.com/${AccountProperty}&color=${ColorProperty}&size=${SizeProperty}")
      .ToString();
  }
}