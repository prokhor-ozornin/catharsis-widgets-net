using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Set of extension methods for interface <see cref="IFacebookCommentsWidget"/>.</para>
/// </summary>
/// <seealso cref="IFacebookCommentsWidget"/>
public static class IFacebookCommentsWidgetExtensions
{
  /// <param name="widget">Widget to call method on.</param>
  extension(IFacebookCommentsWidget widget)
  {
    /// <summary>
    ///   <para></para>
    /// </summary>
    /// <param name="url"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentNullException">Если параметр <paramref name="widget"/> является <see langword="null"/> ссылкой.</exception>
    public IFacebookCommentsWidget Url(Uri url) => widget?.Url(url?.ToString()) ?? throw new ArgumentNullException(nameof(widget));

    /// <summary>
    ///   <para>The width of the widget.</para>
    /// </summary>
    /// <param name="width">Width of widget.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="IFacebookCommentsWidget.Width(string)"/>
    public IFacebookCommentsWidget Width(short width) => widget?.Width(width.ToInvariantString()) ?? throw new ArgumentNullException(nameof(widget));

    /// <summary>
    ///   <para>The color scheme used by the widget.</para>
    /// </summary>
    /// <param name="scheme">Color scheme of widget.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="IFacebookCommentsWidget.ColorScheme(string)"/>
    public IFacebookCommentsWidget ColorScheme(FacebookColorScheme scheme) => widget?.ColorScheme(scheme.ToString().ToLowerInvariant()) ?? throw new ArgumentNullException(nameof(widget));

    /// <summary>
    ///   <para>The order to use when displaying comments.</para>
    /// </summary>
    /// <param name="order">Order of comments.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="IFacebookCommentsWidget.Order(string)"/>
    public IFacebookCommentsWidget Order(FacebookCommentsOrder order)
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
}