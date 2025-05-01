using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IVideoJSPlayerWidget"/>
public class VideoJSPlayerWidget : WebWidget, IVideoJSPlayerWidget
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string ExtraProperty { get; set; }

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
  protected virtual IEnumerable<(string ContentType, string Url)> VideosProperty { get; set; } = [];

  /// <inheritdoc cref="IVideoJSPlayerWidget.Extra(string)"/>
  public virtual IVideoJSPlayerWidget Extra(string extra)
  {
    if (extra is null) throw new ArgumentNullException(nameof(extra));
    if (extra.IsEmpty()) throw new ArgumentException(nameof(extra));

    ExtraProperty = extra;
    return this;
  }

  /// <inheritdoc cref="IVideoJSPlayerWidget.Height(string)"/>
  public virtual IVideoJSPlayerWidget Height(string height)
  {
    if (height is null) throw new ArgumentNullException(nameof(height));
    if (height.IsEmpty()) throw new ArgumentException(nameof(height));

    HeightProperty = height;
    return this;
  }

  /// <inheritdoc cref="IVideoJSPlayerWidget.Videos(IEnumerable{ValueTuple{string, string}})"/>
  public virtual IVideoJSPlayerWidget Videos(IEnumerable<(string Url, string ContentType)> videos)
  {
    VideosProperty = videos ?? throw new ArgumentNullException(nameof(videos));
    return this;
  }

  /// <inheritdoc cref="IVideoJSPlayerWidget.Width(string)"/>
  public virtual IVideoJSPlayerWidget Width(string width)
  {
    if (width is null) throw new ArgumentNullException(nameof(width));
    if (width.IsEmpty()) throw new ArgumentException(nameof(width));

    WidthProperty = width;
    return this;
  }

  public override object Clone() => new VideoJSPlayerWidget { };

  /// <inheritdoc cref="IWebWidget.ToHtml()"/>
  public override string ToHtml() => !VideosProperty.Any() || WidthProperty.IsUnset() || HeightProperty.IsUnset() ? string.Empty : new TagBuilder("video")
      .Attribute("class", "video-js vjs-default-skin")
      .Attribute("controls", "controls")
      .Attribute("preload", "auto")
      .Attribute("data-setup", "{}")
      .Attribute("height", HeightProperty)
      .Attribute("width", WidthProperty)
      .Html(VideosProperty.Join(string.Empty) + ExtraProperty)
      .ToString();
}