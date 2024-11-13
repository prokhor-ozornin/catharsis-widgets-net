using System.Globalization;

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
  public static IFacebookFacePileWidget Actions(this IFacebookFacePileWidget widget, params string[] actions) => widget is not null ? widget.Actions(actions) : throw new ArgumentNullException(nameof(widget));

  /// <summary>
  ///   <para>Controls the size of the photos shown in the widget.</para>
  /// </summary>
  /// <param name="widget">Widget to call method on.</param>
  /// <param name="size">Size of photos.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
  /// <seealso cref="IFacebookFacePileWidget.PhotoSize(string)"/>
  public static IFacebookFacePileWidget PhotoSize(this IFacebookFacePileWidget widget, FacebookFacePilePhotoSize size) => widget is not null ? widget.PhotoSize(size.ToString().ToLowerInvariant()) : throw new ArgumentNullException(nameof(widget));

  /// <summary>
  ///   <para>The width of the widget in pixels.</para>
  /// </summary>
  /// <param name="widget">Widget to call method on.</param>
  /// <param name="width">Width of widget.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
  /// <seealso cref="IFacebookFacePileWidget.Width(string)"/>
  public static IFacebookFacePileWidget Width(this IFacebookFacePileWidget widget, short width) => widget is not null ? widget.Width(width.ToString(CultureInfo.InvariantCulture)) : throw new ArgumentNullException(nameof(widget));

  /// <summary>
  ///   <para>The height of the widget in pixels.</para>
  /// </summary>
  /// <param name="widget">Widget to call method on.</param>
  /// <param name="height">Height of widget.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
  /// <seealso cref="IFacebookFacePileWidget.Height(string)"/>
  public static IFacebookFacePileWidget Height(this IFacebookFacePileWidget widget, short height) => widget is not null ? widget.Height(height.ToString(CultureInfo.InvariantCulture)) : throw new ArgumentNullException(nameof(widget));

  /// <summary>
  ///   <para>The color scheme used by the widget.</para>
  /// </summary>
  /// <param name="widget">Widget to call method on.</param>
  /// <param name="colorScheme">Color scheme of widget.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
  /// <seealso cref="IFacebookFacePileWidget.ColorScheme(string)"/>
  public static IFacebookFacePileWidget ColorScheme(this IFacebookFacePileWidget widget, FacebookColorScheme colorScheme) => widget is not null ? widget.ColorScheme(colorScheme.ToString().ToLowerInvariant()) : throw new ArgumentNullException(nameof(widget));
}