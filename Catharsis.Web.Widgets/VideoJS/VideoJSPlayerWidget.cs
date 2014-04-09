using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Renders Video.JS web player widget.</para>
  ///   <para>Requires <see cref="WidgetsScripts.VideoJS"/> script and <see cref="WidgetsStyles.VideoJS"/> style to be included.</para>
  /// </summary>
  /// <seealso cref="http://www.videojs.com"/>
  public sealed class VideoJSPlayerWidget : HtmlWidgetBase, IVideoJSPlayerWidget
  {
    private string width;
    private string height;
    private IEnumerable<IMediaSource> videos = Enumerable.Empty<IMediaSource>();

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
    ///   <para>Generates and writes HTML markup of widget, using specified text writer.</para>
    /// </summary>
    /// <param name="writer">Text writer to use as output destination.</param>
    public override void Write(TextWriter writer)
    {
      Assertion.NotNull(writer);

      if (!this.videos.Any() || this.width.IsEmpty() || this.height.IsEmpty())
      {
        return;
      }

      writer.Write(this.ToTag("video", tag => tag
        .Attribute("class", "video-js vjs-default-skin")
        .Attribute("controls", "controls")
        .Attribute("preload", "auto")
        .Attribute("data-setup", "{}")
        .Attribute("height", this.height)
        .Attribute("width", this.width)
        .InnerHtml(this.videos.Join(string.Empty) + this.HtmlBody)));
    }
  }
}