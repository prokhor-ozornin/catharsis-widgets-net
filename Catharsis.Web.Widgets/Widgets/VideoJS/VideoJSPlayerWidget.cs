using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Renders Video.JS web player widget.</para>
  ///   <para>Requires <see cref="WidgetsScripts.VideoJS"/> script and <see cref="WidgetsStyles.VideoJS"/> style to be included.</para>
  /// </summary>
  /// <seealso cref="http://www.videojs.com"/>
  public class VideoJSPlayerWidget : HtmlWidgetBase, IVideoJSPlayerWidget
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
    ///   <para>Returns HTML markup text of widget.</para>
    /// </summary>
    /// <returns>Widget's HTML markup.</returns>
    public override string ToHtmlString()
    {
      if (!this.videos.Any() || this.width.IsEmpty() || this.height.IsEmpty())
      {
        return string.Empty;
      }

      return new TagBuilder("video")
        .Attribute("class", "video-js vjs-default-skin")
        .Attribute("controls", "controls")
        .Attribute("preload", "auto")
        .Attribute("data-setup", "{}")
        .Attribute("height", this.height)
        .Attribute("width", this.width)
        .InnerHtml(this.videos.Join(string.Empty) + this.extra)
        .ToString();
    }
  }
}