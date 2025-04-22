using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IYouTubeVideoWidget"/>
public class YouTubeVideoWidget : WebWidget, IYouTubeVideoWidget
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string IdProperty { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string WidthProperty { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string HeightProperty { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual bool PrivateModeProperty { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual bool SecureModeProperty { get; set; }

  /// <inheritdoc cref="IYouTubeVideoWidget.Id(string)"/>
  public virtual IYouTubeVideoWidget Id(string id)
  {
    if (id is null) throw new ArgumentNullException(nameof(id));
    if (id.IsEmpty()) throw new ArgumentException(nameof(id));

    IdProperty = id;

    return this;
  }

  /// <inheritdoc cref="IYouTubeVideoWidget.Height(string)"/>
  public virtual IYouTubeVideoWidget Height(string height)
  {
    if (height is null) throw new ArgumentNullException(nameof(height));
    if (height.IsEmpty()) throw new ArgumentException(nameof(height));

    HeightProperty = height;

    return this;
  }

  /// <inheritdoc cref="IYouTubeVideoWidget.PrivateMode(bool)"/>
  public virtual IYouTubeVideoWidget PrivateMode(bool enabled)
  {
    PrivateModeProperty = enabled;
    return this;
  }

  /// <inheritdoc cref="IYouTubeVideoWidget.SecureMode(bool)"/>
  public virtual IYouTubeVideoWidget SecureMode(bool enabled)
  {
    SecureModeProperty = enabled;
    return this;
  }

  /// <inheritdoc cref="IYouTubeVideoWidget.Width(string)"/>
  public virtual IYouTubeVideoWidget Width(string width)
  {
    if (width is null) throw new ArgumentNullException(nameof(width));
    if (width.IsEmpty()) throw new ArgumentException(nameof(width));

    WidthProperty = width;

    return this;
  }

  /// <inheritdoc cref="IHtmlContent.ToHtml()"/>
  public override string ToHtml() => IdProperty.IsUnset() || WidthProperty.IsUnset() || HeightProperty.IsUnset() ? string.Empty : new TagBuilder("iframe")
      .Attribute("src", string.Format("{2}://{1}/embed/{0}", IdProperty, PrivateModeProperty ? "www.youtube-nocookie.com" : "www.youtube.com", SecureModeProperty ? "https" : "http"))
      .Attribute("width", WidthProperty)
      .Attribute("height", HeightProperty)
      .Attribute("frameborder", 0)
      .Attribute("allowfullscreen", true)
      .Attribute("webkitallowfullscreen", true)
      .Attribute("mozallowfullscreen", true)
      .ToString();
}