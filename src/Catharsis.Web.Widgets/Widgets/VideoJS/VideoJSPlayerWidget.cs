using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IVideoJSPlayerWidget"/>
public class VideoJSPlayerWidget : WebWidget, IVideoJSPlayerWidget
{
  private string extra;
  private string width;
  private string height;
  private IEnumerable<(string ContentType, string Url)> videos = [];

  /// <inheritdoc cref="IVideoJSPlayerWidget.Extra(string)"/>
  public IVideoJSPlayerWidget Extra(string extra)
  {
    if (extra is null) throw new ArgumentNullException(nameof(extra));
    if (extra.IsEmpty()) throw new ArgumentException(nameof(extra));

    this.extra = extra;
    return this;
  }

  /// <inheritdoc cref="IVideoJSPlayerWidget.Extra()"/>
  public string Extra() => extra;

  /// <inheritdoc cref="IVideoJSPlayerWidget.Height(string)"/>
  public IVideoJSPlayerWidget Height(string height)
  {
    if (height is null) throw new ArgumentNullException(nameof(height));
    if (height.IsEmpty()) throw new ArgumentException(nameof(height));

    this.height = height;
    return this;
  }

  /// <inheritdoc cref="IVideoJSPlayerWidget.Height()"/>
  public string Height() => height;

  /// <inheritdoc cref="IVideoJSPlayerWidget.Videos(IEnumerable{ValueTuple{string, string}})"/>
  public IVideoJSPlayerWidget Videos(IEnumerable<(string ContentType, string Url)> videos)
  {
    this.videos = videos ?? throw new ArgumentNullException(nameof(videos));
    return this;
  }

  /// <inheritdoc cref="IVideoJSPlayerWidget.Videos()"/>
  public IEnumerable<(string ContentType, string Url)> Videos() => videos;

  /// <inheritdoc cref="IVideoJSPlayerWidget.Width(string)"/>
  public IVideoJSPlayerWidget Width(string width)
  {
    if (width is null) throw new ArgumentNullException(nameof(width));
    if (width.IsEmpty()) throw new ArgumentException(nameof(width));

    this.width = width;
    return this;
  }

  /// <inheritdoc cref="IVideoJSPlayerWidget.Width()"/>
  public string Width() => width;

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