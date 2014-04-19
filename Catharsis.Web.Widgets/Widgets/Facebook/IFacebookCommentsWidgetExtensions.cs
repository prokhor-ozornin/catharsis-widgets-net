using System;
using System.Globalization;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Set of extension methods for interface <see cref="IFacebookCommentsWidget"/>.</para>
  /// </summary>
  /// <seealso cref="IFacebookCommentsWidget"/>
  public static class IFacebookCommentsWidgetExtensions
  {
    /// <summary>
    ///   <para>he width of the widget.</para>
    /// </summary>
    /// <param name="widget">Widget to call method on.</param>
    /// <param name="width">Width of widget.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="IFacebookCommentsWidget.Width(string)"/>
    public static IFacebookCommentsWidget Width(this IFacebookCommentsWidget widget, short width)
    {
      Assertion.NotNull(widget);

      return widget.Width(width.ToString(CultureInfo.InvariantCulture));
    }

    /// <summary>
    ///   <para>The color scheme used by the widget.</para>
    /// </summary>
    /// <param name="widget">Widget to call method on.</param>
    /// <param name="colorScheme">Color scheme of widget.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="IFacebookCommentsWidget.ColorScheme(string)"/>
    public static IFacebookCommentsWidget ColorScheme(this IFacebookCommentsWidget widget, FacebookColorScheme colorScheme)
    {
      Assertion.NotNull(widget);

      return widget.ColorScheme(colorScheme.ToString().ToLowerInvariant());
    }

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
      Assertion.NotNull(widget);

      switch (order)
      {
        case FacebookCommentsOrder.ReverseTime :
          return widget.Order("reverse_time");

        case FacebookCommentsOrder.Time :
          return widget.Order("time");

        default:
          return widget.Order("social");
      }
    }
  }
}