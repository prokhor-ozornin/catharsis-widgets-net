using System;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Set of extension methods for interface <see cref="IYandexMoneyButtonWidget"/>.</para>
  /// </summary>
  /// <seealso cref="IYandexMoneyButtonWidget"/>
  public static class IYandexMoneyButtonWidgetExtensions
  {
    /// <summary>
    ///   <para>Color of button.</para>
    /// </summary>
    /// <param name="widget">Widget to call method on.</param>
    /// <param name="color">Button's color.</param>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="IYandexMoneyButtonWidget.Color(string)"/>
    public static IYandexMoneyButtonWidget Color(this IYandexMoneyButtonWidget widget, YandexMoneyButtonColor color)
    {
      Assertion.NotNull(widget);

      return widget.Color(color.ToString().ToLowerInvariant());
    }

    /// <summary>
    ///   <para>Size of button.</para>
    /// </summary>
    /// <param name="widget">Widget to call method on.</param>
    /// <param name="size">Button's size.</param>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    public static IYandexMoneyButtonWidget Size(this IYandexMoneyButtonWidget widget, YandexMoneyButtonSize size)
    {
      Assertion.NotNull(widget);

      switch (size)
      {
        case YandexMoneyButtonSize.Medium :
          return widget.Size("m");

        case YandexMoneyButtonSize.Small :
          return widget.Size("s");

        default :
          return widget.Size("l");
      }
    }

    /// <summary>
    ///   <para>Monetary sum to transfer to Yandex.Money account.</para>
    /// </summary>
    /// <param name="widget">Widget to call method on.</param>
    /// <param name="sum">Payment sum.</param>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    public static IYandexMoneyButtonWidget Sum(this IYandexMoneyButtonWidget widget, double sum)
    {
      Assertion.NotNull(widget);

      return widget.Sum((decimal) sum);
    }

    /// <summary>
    ///   <para>Text to display on button.</para>
    /// </summary>
    /// <param name="widget">Widget to call method on.</param>
    /// <param name="text">Numeric text type to display.</param>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    public static IYandexMoneyButtonWidget Text(this IYandexMoneyButtonWidget widget, YandexMoneyButtonText text)
    {
      Assertion.NotNull(widget);

      return widget.Text((byte) text);
    }

    /// <summary>
    ///   <para>Type of payment option.</para>
    /// </summary>
    /// <param name="widget">Widget to call method on.</param>
    /// <param name="type">Payment source.</param>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    public static IYandexMoneyButtonWidget Type(this IYandexMoneyButtonWidget widget, YandexMoneyButtonType type)
    {
      Assertion.NotNull(widget);

      switch (type)
      {
        case YandexMoneyButtonType.Card :
          return widget.Type("any-card-payment-type");

        default:
          return widget.Type("yamoney-payment-type");
      }
    }
  }
}