using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IVideoJSPlayerWidget"/>
public class VideoJSPlayerWidget : WebWidget, IVideoJSPlayerWidget
{
  private string ExtraProperty { get; set; }
  private string WidthProperty { get; set; }
  private string HeightProperty { get; set; }
  private IEnumerable<(string ContentType, string Url)> VideosProperty { get; set; } = [];

  /// <inheritdoc cref="IVideoJSPlayerWidget.Extra(string)"/>
  public IVideoJSPlayerWidget Extra(string extra)
  {
    if (extra is null) throw new ArgumentNullException(nameof(extra));
    if (extra.IsEmpty()) throw new ArgumentException(nameof(extra));

    ExtraProperty = extra;
    return this;
  }

  /// <inheritdoc cref="IVideoJSPlayerWidget.Extra()"/>
  public string Extra() => ExtraProperty;

  /// <inheritdoc cref="IVideoJSPlayerWidget.Height(string)"/>
  public IVideoJSPlayerWidget Height(string height)
  {
    if (height is null) throw new ArgumentNullException(nameof(height));
    if (height.IsEmpty()) throw new ArgumentException(nameof(height));

    HeightProperty = height;
    return this;
  }

  /// <inheritdoc cref="IVideoJSPlayerWidget.Height()"/>
  public string Height() => HeightProperty;

  /// <inheritdoc cref="IVideoJSPlayerWidget.Videos(IEnumerable{ValueTuple{string, string}})"/>
  public IVideoJSPlayerWidget Videos(IEnumerable<(string Url, string ContentType)> videos)
  {
    VideosProperty = videos ?? throw new ArgumentNullException(nameof(videos));
    return this;
  }

  /// <inheritdoc cref="IVideoJSPlayerWidget.Videos()"/>
  public IEnumerable<(string Url, string ContentType)> Videos() => VideosProperty;

  /// <inheritdoc cref="IVideoJSPlayerWidget.Width(string)"/>
  public IVideoJSPlayerWidget Width(string width)
  {
    if (width is null) throw new ArgumentNullException(nameof(width));
    if (width.IsEmpty()) throw new ArgumentException(nameof(width));

    WidthProperty = width;
    return this;
  }

  /// <inheritdoc cref="IVideoJSPlayerWidget.Width()"/>
  public string Width() => WidthProperty;

  /// <inheritdoc cref="IHtmlContent.ToHtml()"/>
  public override string ToHtml()
  {
    if (!Videos().Any() || Width().IsEmpty() || Height().IsEmpty())
    {
      return string.Empty;
    }

    return new TagBuilder("video")
      .Attribute("class", "video-js vjs-default-skin")
      .Attribute("controls", "controls")
      .Attribute("preload", "auto")
      .Attribute("data-setup", "{}")
      .Attribute("height", Height())
      .Attribute("width", Width())
      .Html(Videos().Join(string.Empty) + Extra())
      .ToString();
  }
}