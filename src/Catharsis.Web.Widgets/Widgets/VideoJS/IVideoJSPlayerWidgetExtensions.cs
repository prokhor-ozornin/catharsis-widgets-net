using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

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
  public static IVideoJSPlayerWidget Width(this IVideoJSPlayerWidget widget, short width) => widget?.Width(width.ToInvariantString()) ?? throw new ArgumentNullException(nameof(widget));

  /// <summary>
  ///   <para>Vertical height of video.</para>
  /// </summary>
  /// <param name="widget">Widget to call method on.</param>
  /// <param name="height">Height of video.</param>
  /// <returns>Reference to provided <paramref name="widget"/>.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
  /// <seealso cref="IVideoJSPlayerWidget.Height(string)"/>
  public static IVideoJSPlayerWidget Height(this IVideoJSPlayerWidget widget, short height) => widget?.Height(height.ToInvariantString()) ?? throw new ArgumentNullException(nameof(widget));

  /// <summary>
  ///   <para>Collection of video sources to use.</para>
  /// </summary>
  /// <param name="widget">Widget to call method on.</param>
  /// <param name="videos">Collection of videos.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
  /// <seealso cref="IVideoJSPlayerWidget.Videos(IEnumerable{ValueTuple{string, string}})"/>
  public static IVideoJSPlayerWidget Videos(this IVideoJSPlayerWidget widget, params (string Url, string ContentType)[] videos) => widget?.Videos(videos) ?? throw new ArgumentNullException(nameof(widget));
}