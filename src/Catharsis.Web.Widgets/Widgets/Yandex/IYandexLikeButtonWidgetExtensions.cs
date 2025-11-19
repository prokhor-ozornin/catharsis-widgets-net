namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Set of extension methods for interface <see cref="IYandexLikeButtonWidget"/>.</para>
/// </summary>
/// <seealso cref="IYandexLikeButtonWidget"/>
public static class IYandexLikeButtonWidgetExtensions
{
  /// <param name="widget">Widget to call method on.</param>
  extension(IYandexLikeButtonWidget widget)
  {
    /// <summary>
    ///   <para>Size of the button.</para>
    /// </summary>
    /// <param name="size">Size of button.</param>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="IYandexLikeButtonWidget.Size(string)"/>
    public IYandexLikeButtonWidget Size(YandexLikeButtonSize size) => widget?.Size(size.ToString().ToLowerInvariant()) ?? throw new ArgumentNullException(nameof(widget));

    /// <summary>
    ///   <para>Visual layout/appearance of the button.</para>
    /// </summary>
    /// <param name="layout">Layout of button.</param>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="IYandexLikeButtonWidget.Layout(string)"/>
    public IYandexLikeButtonWidget Layout(YandexLikeButtonLayout layout) => widget?.Layout(layout.ToString().ToLowerInvariant()) ?? throw new ArgumentNullException(nameof(widget));

    /// <summary>
    ///   <para></para>
    /// </summary>
    /// <param name="url"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is <see langword="null"/>.</exception>
    public IYandexLikeButtonWidget Url(Uri url) => widget?.Url(url?.ToString()) ?? throw new ArgumentNullException(nameof(widget));
  }
}