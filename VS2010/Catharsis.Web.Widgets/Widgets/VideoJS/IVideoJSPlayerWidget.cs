using System;
using System.Collections.Generic;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Renders Video.JS web player widget.</para>
  ///   <para>Requires VideoJS scripts and CSS bundles to be included.</para>
  /// </summary>
  /// <seealso cref="http://www.videojs.com"/>
  /// <seealso cref="IWidgetsScriptsRendererExtensions.VideoJS(IWidgetsScriptsRenderer)"/>
  /// <seealso cref="IWidgetsStylesRendererExtensions.VideoJS(IWidgetsStylesRenderer)"/>
  public interface IVideoJSPlayerWidget : IHtmlWidget
  {
    /// <summary>
    ///   <para>Custom HTML code to be part of <c>video</c> tag.</para>
    /// </summary>
    /// <param name="extra">Additional HTML code fragment.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="extra"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="extra"/> is <see cref="string.Empty"/> string.</exception>
    IVideoJSPlayerWidget Extra(string extra);

    /// <summary>
    ///   <para>Custom HTML code to be part of <c>video</c> tag.</para>
    /// </summary>
    /// <returns>Additional HTML code fragment.</returns>
    string Extra();

    /// <summary>
    ///   <para>Vertical height of video.</para>
    /// </summary>
    /// <param name="height">Height of video.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="height"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="height"/> is <see cref="string.Empty"/> string.</exception>
    /// <remarks>This attribute is required.</remarks>
    IVideoJSPlayerWidget Height(string height);

    /// <summary>
    ///   <para>Vertical height of video.</para>
    /// </summary>
    /// <returns>Height of video.</returns>
    string Height();

    /// <summary>
    ///   <para>Collection of video sources to use.</para>
    /// </summary>
    /// <param name="videos">Collection of videos.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="videos"/> is a <c>null</c> reference.</exception>
    /// <remarks>This attribute is required.</remarks>
    IVideoJSPlayerWidget Videos(IEnumerable<IMediaSource> videos);

    /// <summary>
    ///   <para>Collection of video sources to use.</para>
    /// </summary>
    /// <returns>Collection of videos.</returns>
    IEnumerable<IMediaSource> Videos();

    /// <summary>
    ///   <para>Horizontal width of video.</para>
    /// </summary>
    /// <param name="width">Width of video.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="width"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="width"/> is <see cref="string.Empty"/> string.</exception>
    /// <remarks>This attribute is required.</remarks>
    IVideoJSPlayerWidget Width(string width);

    /// <summary>
    ///   <para>Horizontal width of video.</para>
    /// </summary>
    /// <returns>Width of video.</returns>
    string Width();
  }
}