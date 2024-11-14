using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IVideoJSPlayerWidget"/>
public class VideoJSPlayerWidget : WebWidget, IVideoJSPlayerWidget
{
  private string extra;
  private string width;
  private string height;
  private IEnumerable<IMediaSource> videos = Enumerable.Empty<IMediaSource>();

  /// <summary>
  ///   <para>Custom HTML code to be part of <c>video</c> tag.</para>
  /// </summary>
  /// <param name="extra">Additional HTML code fragment.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="extra"/> is a <c>null</c> reference.</exception>
  /// <exception cref="ArgumentException">If <paramref name="extra"/> is <see cref="string.Empty"/> string.</exception>
  public IVideoJSPlayerWidget Extra(string extra)
  {
    if (extra is null) throw new ArgumentNullException(nameof(extra));
    if (extra.IsEmpty()) throw new ArgumentException(nameof(extra));

    this.extra = extra;
    return this;
  }

  /// <summary>
  ///   <para>Custom HTML code to be part of <c>video</c> tag.</para>
  /// </summary>
  /// <returns>Additional HTML code fragment.</returns>
  public string Extra() => extra;

  /// <summary>
  ///   <para>Vertical height of video.</para>
  /// </summary>
  /// <param name="height">Height of video.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="height"/> is a <c>null</c> reference.</exception>
  /// <exception cref="ArgumentException">If <paramref name="height"/> is <see cref="string.Empty"/> string.</exception>
  /// <remarks>This attribute is required.</remarks>
  public IVideoJSPlayerWidget Height(string height)
  {
    if (height is null) throw new ArgumentNullException(nameof(height));
    if (height.IsEmpty()) throw new ArgumentException(nameof(height));

    this.height = height;
    return this;
  }

  /// <summary>
  ///   <para>Vertical height of video.</para>
  /// </summary>
  /// <returns>Height of video.</returns>
  public string Height() => height;

  /// <summary>
  ///   <para>Collection of video sources to use.</para>
  /// </summary>
  /// <param name="videos">Collection of videos.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="videos"/> is a <c>null</c> reference.</exception>
  /// <remarks>This attribute is required.</remarks>
  public IVideoJSPlayerWidget Videos(IEnumerable<IMediaSource> videos)
  {
    if (videos is null) throw new ArgumentNullException(nameof(videos));

    this.videos = videos;
    return this;
  }

  /// <summary>
  ///   <para>Collection of video sources to use.</para>
  /// </summary>
  /// <returns>Collection of videos.</returns>
  public IEnumerable<IMediaSource> Videos() => videos;

  /// <summary>
  ///   <para>Horizontal width of video.</para>
  /// </summary>
  /// <param name="width">Width of video.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="width"/> is a <c>null</c> reference.</exception>
  /// <exception cref="ArgumentException">If <paramref name="width"/> is <see cref="string.Empty"/> string.</exception>
  /// <remarks>This attribute is required.</remarks>
  public IVideoJSPlayerWidget Width(string width)
  {
    if (width is null) throw new ArgumentNullException(nameof(width));
    if (width.IsEmpty()) throw new ArgumentException(nameof(width));

    this.width = width;
    return this;
  }

  /// <summary>
  ///   <para>Horizontal width of video.</para>
  /// </summary>
  /// <returns>Width of video.</returns>
  public string Width() => width;

  /// <inheritdoc cref="IWebWidget.ToHtml()"/>
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
      .InnerHtml(Videos().Join(string.Empty) + Extra())
      .ToString();
  }
}