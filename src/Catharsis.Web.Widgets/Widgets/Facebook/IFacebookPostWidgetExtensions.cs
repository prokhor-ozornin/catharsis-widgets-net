using Catharsis.Extensions;


namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Set of extension methods for interface <see cref="IFacebookPostWidget"/>.</para>
/// </summary>
/// <seealso cref="IFacebookPostWidget"/>
public static class IFacebookPostWidgetExtensions
{
  public static IFacebookPostWidget Url(this IFacebookPostWidget widget, Uri url) => widget is not null ? widget.Url(url?.ToString()) : throw new ArgumentNullException(nameof(widget));

  /// <summary>
  ///   <para>Specifies width of Facebook post area on page.</para>
  /// </summary>
  /// <param name="widget">Widget to call method on.</param>
  /// <param name="width">Width of post.</param>
  /// <returns>Reference to provided <paramref name="widget"/>.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
  /// <seealso cref="IFacebookPostWidget.Width(string)"/>
  public static IFacebookPostWidget Width(this IFacebookPostWidget widget, short width) => widget is not null ? widget.Width(width.ToInvariantString()) : throw new ArgumentNullException(nameof(widget));
}