using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Renders Video.JS web player widget.</para>
  ///   <para>Requires VideoJS scripts and CSS bundles to be included.</para>
  /// </summary>
  /// <seealso cref="http://www.videojs.com"/>
  /// <seealso cref="IWidgetsScriptsRendererExtensions.VideoJS(IWidgetsScriptsRenderer)"/>
  /// <seealso cref="IWidgetsStylesRendererExtensions.VideoJS(IWidgetsStylesRenderer)"/>
  public class VideoJSPlayerWidget : HtmlWidget, IVideoJSPlayerWidget
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
      Assertion.NotEmpty(extra);

      this.extra = extra;
      return this;
    }

    /// <summary>
    ///   <para>Custom HTML code to be part of <c>video</c> tag.</para>
    /// </summary>
    /// <returns>Additional HTML code fragment.</returns>
    public string Extra()
    {
      return this.extra;
    }

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
      Assertion.NotEmpty(height);

      this.height = height;
      return this;
    }

    /// <summary>
    ///   <para>Vertical height of video.</para>
    /// </summary>
    /// <returns>Height of video.</returns>
    public string Height()
    {
      return this.height;
    }

    /// <summary>
    ///   <para>Collection of video sources to use.</para>
    /// </summary>
    /// <param name="videos">Collection of videos.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="videos"/> is a <c>null</c> reference.</exception>
    /// <remarks>This attribute is required.</remarks>
    public IVideoJSPlayerWidget Videos(IEnumerable<IMediaSource> videos)
    {
      Assertion.NotNull(videos);

      this.videos = videos;
      return this;
    }

    /// <summary>
    ///   <para>Collection of video sources to use.</para>
    /// </summary>
    /// <returns>Collection of videos.</returns>
    public IEnumerable<IMediaSource> Videos()
    {
      return this.videos;
    }

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
      Assertion.NotEmpty(width);

      this.width = width;
      return this;
    }

    /// <summary>
    ///   <para>Horizontal width of video.</para>
    /// </summary>
    /// <returns>Width of video.</returns>
    public string Width()
    {
      return this.width;
    }

    /// <summary>
    ///   <para>Returns HTML markup text of widget.</para>
    /// </summary>
    /// <returns>Widget's HTML markup.</returns>
    public override string ToHtmlString()
    {
      if (!this.Videos().Any() || this.Width().IsEmpty() || this.Height().IsEmpty())
      {
        return string.Empty;
      }

      return new TagBuilder("video")
        .Attribute("class", "video-js vjs-default-skin")
        .Attribute("controls", "controls")
        .Attribute("preload", "auto")
        .Attribute("data-setup", "{}")
        .Attribute("height", this.Height())
        .Attribute("width", this.Width())
        .InnerHtml(this.Videos().Join(string.Empty) + this.Extra())
        .ToString();
    }
  }
}