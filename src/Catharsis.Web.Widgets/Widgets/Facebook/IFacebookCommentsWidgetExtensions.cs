using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Set of extension methods for interface <see cref="IFacebookCommentsWidget"/>.</para>
/// </summary>
/// <seealso cref="IFacebookCommentsWidget"/>
public static class IFacebookCommentsWidgetExtensions
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="widget"></param>
  /// <param name="url"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  public static IFacebookCommentsWidget Url(this IFacebookCommentsWidget widget, Uri url) => widget is not null ? widget.Url(url?.ToString()) : throw new ArgumentNullException(nameof(widget));

  /// <summary>
  ///   <para>The width of the widget.</para>
  /// </summary>
  /// <param name="widget">Widget to call method on.</param>
  /// <param name="width">Width of widget.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
  /// <seealso cref="IFacebookCommentsWidget.Width(string)"/>
  public static IFacebookCommentsWidget Width(this IFacebookCommentsWidget widget, short width) => widget is not null ? widget.Width(width.ToInvariantString()) : throw new ArgumentNullException(nameof(widget));

  /// <summary>
  ///   <para>The color scheme used by the widget.</para>
  /// </summary>
  /// <param name="widget">Widget to call method on.</param>
  /// <param name="scheme">Color scheme of widget.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
  /// <seealso cref="IFacebookCommentsWidget.ColorScheme(string)"/>
  public static IFacebookCommentsWidget ColorScheme(this IFacebookCommentsWidget widget, FacebookColorScheme scheme) => widget is not null ? widget.ColorScheme(scheme.ToString().ToLowerInvariant()) : throw new ArgumentNullException(nameof(widget));

  /// <summary>
  ///   <para>The order to use when displaying comments.</para>
  /// </summary>
  /// <param name="widget">Widget to call method on.</param>
  /// <param name="order">Order of comments.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
  /// <seealso cref="IFacebookCommentsWidget.Order(string)"/>
  public static IFacebookCommentsWidget Order(this IFacebookCommentsWidget widget, FacebookCommentsOrder order)
  {
    if (widget is null) throw new ArgumentNullException(nameof(widget));

    return order switch
    {
      FacebookCommentsOrder.ReverseTime => widget.Order("reverse_time"),
      FacebookCommentsOrder.Time => widget.Order("time"),
      _ => widget.Order("social")
    };
  }
}