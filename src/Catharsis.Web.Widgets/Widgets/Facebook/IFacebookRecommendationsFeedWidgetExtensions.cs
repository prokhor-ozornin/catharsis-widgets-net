using System.Globalization;

namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Set of extension methods for interface <see cref="IFacebookRecommendationsFeedWidget"/>.</para>
/// </summary>
/// <seealso cref="IFacebookRecommendationsFeedWidget"/>
public static class IFacebookRecommendationsFeedWidgetExtensions
{
  /// <summary>
  ///   <para>Collection of Open Graph action types to show in the feed.</para>
  /// </summary>
  /// <param name="widget">Widget to call method on.</param>
  /// <param name="actions">Collection of Facebook action types.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
  /// <seealso cref="IFacebookRecommendationsFeedWidget.Actions(IEnumerable{string})"/>
  public static IFacebookRecommendationsFeedWidget Actions(this IFacebookRecommendationsFeedWidget widget, params string[] actions) => widget is not null ? widget.Actions(actions) : throw new ArgumentNullException(nameof(widget));

  /// <summary>
  ///   <para>The width of the widget in pixels.</para>
  /// </summary>
  /// <param name="widget">Widget to call method on.</param>
  /// <param name="width">Width of widget.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
  /// <seealso cref="IFacebookRecommendationsFeedWidget.Width(string)"/>
  public static IFacebookRecommendationsFeedWidget Width(this IFacebookRecommendationsFeedWidget widget, short width) => widget is not null ? widget.Width(width.ToString(CultureInfo.InvariantCulture)) : throw new ArgumentNullException(nameof(widget));

  /// <summary>
  ///   <para>The height of the widget in pixels.</para>
  /// </summary>
  /// <param name="widget">Widget to call method on.</param>
  /// <param name="height">Height of widget.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
  /// <seealso cref="IFacebookRecommendationsFeedWidget.Height(string)"/>
  public static IFacebookRecommendationsFeedWidget Height(this IFacebookRecommendationsFeedWidget widget, short height) => widget is not null ? widget.Height(height.ToString(CultureInfo.InvariantCulture)) : throw new ArgumentNullException(nameof(widget));

  /// <summary>
  ///   <para>The color scheme used by the widget.</para>
  /// </summary>
  /// <param name="widget">Widget to call method on.</param>
  /// <param name="scheme">Color scheme of widget.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
  /// <seealso cref="IFacebookRecommendationsFeedWidget.ColorScheme(string)"/>
  public static IFacebookRecommendationsFeedWidget ColorScheme(this IFacebookRecommendationsFeedWidget widget, FacebookColorScheme scheme) => widget is not null ? widget.ColorScheme(scheme.ToString().ToLowerInvariant()) : throw new ArgumentNullException(nameof(widget));
}