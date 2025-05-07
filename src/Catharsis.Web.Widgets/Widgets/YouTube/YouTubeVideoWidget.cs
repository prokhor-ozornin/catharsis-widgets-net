using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IYouTubeVideoWidget"/>
public class YouTubeVideoWidget : WebWidget, IYouTubeVideoWidget
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string IdValue { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string WidthValue { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string HeightValue { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual bool PrivateModeValue { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual bool SecureModeValue { get; set; }

  /// <inheritdoc cref="IYouTubeVideoWidget.Id(string)"/>
  public virtual IYouTubeVideoWidget Id(string id)
  {
    if (id is null) throw new ArgumentNullException(nameof(id));
    if (id.IsEmpty()) throw new ArgumentException(nameof(id));

    IdValue = id;

    return this;
  }

  /// <inheritdoc cref="IYouTubeVideoWidget.Height(string)"/>
  public virtual IYouTubeVideoWidget Height(string height)
  {
    if (height is null) throw new ArgumentNullException(nameof(height));
    if (height.IsEmpty()) throw new ArgumentException(nameof(height));

    HeightValue = height;

    return this;
  }

  /// <inheritdoc cref="IYouTubeVideoWidget.PrivateMode(bool)"/>
  public virtual IYouTubeVideoWidget PrivateMode(bool enabled)
  {
    PrivateModeValue = enabled;
    return this;
  }

  /// <inheritdoc cref="IYouTubeVideoWidget.SecureMode(bool)"/>
  public virtual IYouTubeVideoWidget SecureMode(bool enabled)
  {
    SecureModeValue = enabled;
    return this;
  }

  /// <inheritdoc cref="IYouTubeVideoWidget.Width(string)"/>
  public virtual IYouTubeVideoWidget Width(string width)
  {
    if (width is null) throw new ArgumentNullException(nameof(width));
    if (width.IsEmpty()) throw new ArgumentException(nameof(width));

    WidthValue = width;

    return this;
  }

  /// <inheritdoc cref="ICloneable.Clone()"/>
  public override object Clone() => new YouTubeVideoWidget
  {
    IdValue = IdValue,
    WidthValue = WidthValue,
    HeightValue = HeightValue,
    PrivateModeValue = PrivateModeValue,
    SecureModeValue = SecureModeValue
  };

  /// <inheritdoc cref="IWebWidget.ToHtml()"/>
  public override string ToHtml() => IdValue.IsUnset() || WidthValue.IsUnset() || HeightValue.IsUnset() ? string.Empty : new TagBuilder("iframe")
      .Attribute("src", string.Format("{2}://{1}/embed/{0}", IdValue, PrivateModeValue ? "www.youtube-nocookie.com" : "www.youtube.com", SecureModeValue ? "https" : "http"))
      .Attribute("width", WidthValue)
      .Attribute("height", HeightValue)
      .Attribute("frameborder", 0)
      .Attribute("allowfullscreen", true)
      .Attribute("webkitallowfullscreen", true)
      .Attribute("mozallowfullscreen", true)
      .ToString();
}