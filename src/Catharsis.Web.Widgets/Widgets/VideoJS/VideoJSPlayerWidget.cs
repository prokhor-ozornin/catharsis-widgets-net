using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IVideoJSPlayerWidget"/>
public class VideoJSPlayerWidget : WebWidget, IVideoJSPlayerWidget
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string ExtraValue { get; set; }

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
  protected virtual IEnumerable<(string ContentType, string Url)> VideosValue { get; set; } = [];

  /// <inheritdoc cref="IVideoJSPlayerWidget.Extra(string)"/>
  public virtual IVideoJSPlayerWidget Extra(string extra)
  {
    if (extra is null) throw new ArgumentNullException(nameof(extra));
    if (extra.IsEmpty()) throw new ArgumentException(nameof(extra));

    ExtraValue = extra;
    return this;
  }

  /// <inheritdoc cref="IVideoJSPlayerWidget.Height(string)"/>
  public virtual IVideoJSPlayerWidget Height(string height)
  {
    if (height is null) throw new ArgumentNullException(nameof(height));
    if (height.IsEmpty()) throw new ArgumentException(nameof(height));

    HeightValue = height;
    return this;
  }

  /// <inheritdoc cref="IVideoJSPlayerWidget.Videos(IEnumerable{ValueTuple{string, string}})"/>
  public virtual IVideoJSPlayerWidget Videos(IEnumerable<(string Url, string ContentType)> videos)
  {
    VideosValue = videos ?? throw new ArgumentNullException(nameof(videos));
    return this;
  }

  /// <inheritdoc cref="IVideoJSPlayerWidget.Width(string)"/>
  public virtual IVideoJSPlayerWidget Width(string width)
  {
    if (width is null) throw new ArgumentNullException(nameof(width));
    if (width.IsEmpty()) throw new ArgumentException(nameof(width));

    WidthValue = width;
    return this;
  }

  /// <inheritdoc cref="ICloneable.Clone()"/>
  public override object Clone() => new VideoJSPlayerWidget
  {
    ExtraValue = ExtraValue,
    WidthValue = WidthValue,
    HeightValue = HeightValue,
    VideosValue = VideosValue?.ToArray()
  };

  /// <inheritdoc cref="IWebWidget.ToHtml()"/>
  public override string ToHtml() => !VideosValue.Any() || WidthValue.IsUnset() || HeightValue.IsUnset() ? string.Empty : new TagBuilder("video")
      .Attribute("class", "video-js vjs-default-skin")
      .Attribute("controls", "controls")
      .Attribute("preload", "auto")
      .Attribute("data-setup", "{}")
      .Attribute("height", HeightValue)
      .Attribute("width", WidthValue)
      .Html(VideosValue.Join(string.Empty) + ExtraValue)
      .ToString();
}