namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Set of extension methods for interface <see cref="IYandexLikeButtonWidget"/>.</para>
/// </summary>
/// <seealso cref="IYandexLikeButtonWidget"/>
public static class IYandexLikeButtonWidgetExtensions
{
  /// <summary>
  ///   <para>Size of the button.</para>
  /// </summary>
  /// <param name="widget">Widget to call method on.</param>
  /// <param name="size">Size of button.</param>
  /// <returns>Reference to provided <paramref name="widget"/>.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
  /// <seealso cref="IYandexLikeButtonWidget.Size(string)"/>
  public static IYandexLikeButtonWidget Size(this IYandexLikeButtonWidget widget, YandexLikeButtonSize size) => widget is not null ? widget.Size(size.ToString().ToLowerInvariant()) : throw new ArgumentNullException(nameof(widget));

  /// <summary>
  ///   <para>Visual layout/appearance of the button.</para>
  /// </summary>
  /// <param name="widget">Widget to call method on.</param>
  /// <param name="layout">Layout of button.</param>
  /// <returns>Reference to provided <paramref name="widget"/>.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
  /// <seealso cref="IYandexLikeButtonWidget.Layout(string)"/>
  public static IYandexLikeButtonWidget Layout(this IYandexLikeButtonWidget widget, YandexLikeButtonLayout layout) => widget is not null ? widget.Layout(layout.ToString().ToLowerInvariant()) : throw new ArgumentNullException(nameof(widget));

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="widget"></param>
  /// <param name="url"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  public static IYandexLikeButtonWidget Url(this IYandexLikeButtonWidget widget, Uri url) => widget is not null ? widget.Url(url?.ToString()) : throw new ArgumentNullException(nameof(widget));
}