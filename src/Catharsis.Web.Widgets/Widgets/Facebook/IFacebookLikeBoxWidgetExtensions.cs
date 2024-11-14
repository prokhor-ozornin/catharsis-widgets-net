using System.Globalization;

namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Set of extension methods for interface <see cref="IFacebookLikeBoxWidget"/>.</para>
/// </summary>
/// <seealso cref="IFacebookLikeBoxWidget"/>
public static class IFacebookLikeBoxWidgetExtensions
{
  /// <summary>
  ///   <para>The width of the widget in pixels.</para>
  /// </summary>
  /// <param name="widget">Widget to call method on.</param>
  /// <param name="width">Width of button.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
  /// <seealso cref="IFacebookLikeBoxWidget.Width(string)"/>
  public static IFacebookLikeBoxWidget Width(this IFacebookLikeBoxWidget widget, short width) => widget is not null ? widget.Width(width.ToString(CultureInfo.InvariantCulture)) : throw new ArgumentNullException(nameof(widget));

  /// <summary>
  ///   <para>The height of the widget in pixels.</para>
  /// </summary>
  /// <param name="widget">Widget to call method on.</param>
  /// <param name="height">Height of widget.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
  /// <seealso cref="IFacebookLikeBoxWidget.Height(string)"/>
  public static IFacebookLikeBoxWidget Height(this IFacebookLikeBoxWidget widget, short height) => widget is not null ? widget.Height(height.ToString(CultureInfo.InvariantCulture)) : throw new ArgumentNullException(nameof(widget));

  /// <summary>
  ///   <para>The color scheme used by the widget.</para>
  /// </summary>
  /// <param name="widget">Widget to call method on.</param>
  /// <param name="colorScheme">Color scheme of widget.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
  /// <seealso cref="IFacebookLikeBoxWidget.ColorScheme(string)"/>
  public static IFacebookLikeBoxWidget ColorScheme(this IFacebookLikeBoxWidget widget, FacebookColorScheme colorScheme) => widget is not null ? widget.ColorScheme(colorScheme.ToString().ToLowerInvariant()) : throw new ArgumentNullException(nameof(widget));
}