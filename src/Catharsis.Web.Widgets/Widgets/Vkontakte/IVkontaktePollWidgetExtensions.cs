using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Set of extension methods for interface <see cref="IVkontaktePollWidget"/>.</para>
/// </summary>
/// <seealso cref="IVkontaktePollWidget"/>
public static class IVkontaktePollWidgetExtensions
{
  /// <summary>
  ///   <para>Horizontal width of widget.</para>
  /// </summary>
  /// <param name="widget">Widget to call method on.</param>
  /// <param name="width">Width of widget.</param>
  /// <returns>Reference to provided <paramref name="widget"/>.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
  public static IVkontaktePollWidget Width(this IVkontaktePollWidget widget, short width) => widget is not null ? widget.Width(width.ToInvariantString()) : throw new ArgumentNullException(nameof(widget));

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="widget"></param>
  /// <param name="url"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  public static IVkontaktePollWidget Url(this IVkontaktePollWidget widget, Uri url) => widget is not null ? widget.Url(url?.ToString()) : throw new ArgumentNullException(nameof(widget));
}