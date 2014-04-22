using System;
using System.Collections.Generic;
using System.Globalization;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Set of extension methods for interface <see cref="IVideoJSPlayerWidget"/>.</para>
  /// </summary>
  /// <seealso cref="IVideoJSPlayerWidget"/>
  public static class IVideoJSPlayerWidgetExtensions
  {
    /// <summary>
    ///   <para>Horizontal width of video.</para>
    /// </summary>
    /// <param name="widget">Widget to call method on.</param>
    /// <param name="width">Width of video.</param>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="IVideoJSPlayerWidget.Width(string)"/>
    public static IVideoJSPlayerWidget Width(this IVideoJSPlayerWidget widget, short width)
    {
      Assertion.NotNull(widget);

      return widget.Width(width.ToString(CultureInfo.InvariantCulture));
    }

    /// <summary>
    ///   <para>Vertical height of video.</para>
    /// </summary>
    /// <param name="widget">Widget to call method on.</param>
    /// <param name="height">Height of video.</param>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="IVideoJSPlayerWidget.Height(string)"/>
    public static IVideoJSPlayerWidget Height(this IVideoJSPlayerWidget widget, short height)
    {
      Assertion.NotNull(widget);

      return widget.Height(height.ToString(CultureInfo.InvariantCulture));
    }

    /// <summary>
    ///   <para>Collection of video sources to use.</para>
    /// </summary>
    /// <param name="widget">Widget to call method on.</param>
    /// <param name="videos">Collection of videos.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="IVideoJSPlayerWidget.Videos(IEnumerable{IMediaSource})"/>
    public static IVideoJSPlayerWidget Videos(this IVideoJSPlayerWidget widget, params IMediaSource[] videos)
    {
      Assertion.NotNull(widget);

      return widget.Videos(videos);
    }
  }
}