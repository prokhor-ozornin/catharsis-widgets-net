using System;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Set of extension methods for interface <see cref="IYandexLikeButtonWidget"/>.</para>
  ///   <seealso cref="IYandexLikeButtonWidget"/>
  /// </summary>
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
    public static IYandexLikeButtonWidget Size(this IYandexLikeButtonWidget widget, YandexLikeButtonSize size)
    {
      Assertion.NotNull(widget);

      return widget.Size(size.ToString().ToLowerInvariant());
    }

    /// <summary>
    ///   <para>Visual layout/appearance of the button.</para>
    /// </summary>
    /// <param name="widget">Widget to call method on.</param>
    /// <param name="layout">Layout of button.</param>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="IYandexLikeButtonWidget.Layout(string)"/>
    public static IYandexLikeButtonWidget Layout(this IYandexLikeButtonWidget widget, YandexLikeButtonLayout layout)
    {
      Assertion.NotNull(widget);

      return widget.Layout(layout.ToString().ToLowerInvariant());
    }
  }
}