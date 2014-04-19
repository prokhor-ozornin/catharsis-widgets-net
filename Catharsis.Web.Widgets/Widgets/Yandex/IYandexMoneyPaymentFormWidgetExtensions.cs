using System;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Set of extension methods for interface <see cref="IYandexMoneyPaymentFormWidget"/>.</para>
  /// </summary>
  /// <seealso cref="IYandexMoneyPaymentFormWidget"/>
  public static class IYandexMoneyPaymentFormWidgetExtensions
  {
    /// <summary>
    ///   <para>Monetary sum to transfer to Yandex.Money account.</para>
    /// </summary>
    /// <param name="widget">Widget to call method on.</param>
    /// <param name="sum">Payment sum.</param>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    public static IYandexMoneyPaymentFormWidget Sum(this IYandexMoneyPaymentFormWidget widget, double sum)
    {
      Assertion.NotNull(widget);

      return widget.Sum((decimal)sum);
    }

    /// <summary>
    ///   <para>Text to display on button.</para>
    /// </summary>
    /// <param name="widget">Widget to call method on.</param>
    /// <param name="text">Numeric code of text to display.</param>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="IYandexMoneyPaymentFormWidget.Text(byte)"/>
    public static IYandexMoneyPaymentFormWidget Text(this IYandexMoneyPaymentFormWidget widget, YandexMoneyPaymentFormText text)
    {
      Assertion.NotNull(widget);

      return widget.Text((byte)text);
    }
  }
}