using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Set of extension methods for interface <see cref="IFacebookFacePileWidget"/>.</para>
/// </summary>
/// <seealso cref="IFacebookFacePileWidget"/>
public static class IFacebookFacePileWidgetExtensions
{
  /// <summary>
  ///   <para>Collection of Open Graph action types.</para>
  /// </summary>
  /// <param name="widget">Widget to call method on.</param>
  /// <param name="actions">Collection of Facebook action types.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
  /// <seealso cref="IFacebookFacePileWidget.Actions(IEnumerable{string})"/>
  public static IFacebookFacePileWidget Actions(this IFacebookFacePileWidget widget, params string[] actions) => widget?.Actions(actions) ?? throw new ArgumentNullException(nameof(widget));

  /// <summary>
  ///   <para>Controls the size of the photos shown in the widget.</para>
  /// </summary>
  /// <param name="widget">Widget to call method on.</param>
  /// <param name="size">Size of photos.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
  /// <seealso cref="IFacebookFacePileWidget.PhotoSize(string)"/>
  public static IFacebookFacePileWidget PhotoSize(this IFacebookFacePileWidget widget, FacebookFacePilePhotoSize size) => widget?.PhotoSize(size.ToString().ToLowerInvariant()) ?? throw new ArgumentNullException(nameof(widget));

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="widget"></param>
  /// <param name="url"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException">Если параметр <paramref name="widget"/> является <see langword="null"/> ссылкой.</exception>
  public static IFacebookFacePileWidget Url(this IFacebookFacePileWidget widget, Uri url) => widget?.Url(url?.ToString()) ?? throw new ArgumentNullException(nameof(widget));

  /// <summary>
  ///   <para>The width of the widget in pixels.</para>
  /// </summary>
  /// <param name="widget">Widget to call method on.</param>
  /// <param name="width">Width of widget.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
  /// <seealso cref="IFacebookFacePileWidget.Width(string)"/>
  public static IFacebookFacePileWidget Width(this IFacebookFacePileWidget widget, short width) => widget?.Width(width.ToInvariantString()) ?? throw new ArgumentNullException(nameof(widget));

  /// <summary>
  ///   <para>The height of the widget in pixels.</para>
  /// </summary>
  /// <param name="widget">Widget to call method on.</param>
  /// <param name="height">Height of widget.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
  /// <seealso cref="IFacebookFacePileWidget.Height(string)"/>
  public static IFacebookFacePileWidget Height(this IFacebookFacePileWidget widget, short height) => widget?.Height(height.ToInvariantString()) ?? throw new ArgumentNullException(nameof(widget));

  /// <summary>
  ///   <para>The color scheme used by the widget.</para>
  /// </summary>
  /// <param name="widget">Widget to call method on.</param>
  /// <param name="scheme">Color scheme of widget.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
  /// <seealso cref="IFacebookFacePileWidget.ColorScheme(string)"/>
  public static IFacebookFacePileWidget ColorScheme(this IFacebookFacePileWidget widget, FacebookColorScheme scheme) => widget?.ColorScheme(scheme.ToString().ToLowerInvariant()) ?? throw new ArgumentNullException(nameof(widget));
}