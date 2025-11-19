namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Set of extension methods for interface <see cref="IYandexMoneyPaymentFormWidget"/>.</para>
/// </summary>
/// <seealso cref="IYandexMoneyPaymentFormWidget"/>
public static class IYandexMoneyPaymentFormWidgetExtensions
{
  /// <param name="widget">Widget to call method on.</param>
  extension(IYandexMoneyPaymentFormWidget widget)
  {
    /// <summary>
    ///   <para>Monetary sum to transfer to Yandex.Money account.</para>
    /// </summary>
    /// <param name="sum">Payment sum.</param>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    public IYandexMoneyPaymentFormWidget Sum(double sum) => widget?.Sum((decimal) sum) ?? throw new ArgumentNullException(nameof(widget));

    /// <summary>
    ///   <para>Text to display on button.</para>
    /// </summary>
    /// <param name="text">Numeric code of text to display.</param>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="IYandexMoneyPaymentFormWidget.Text(byte)"/>
    public IYandexMoneyPaymentFormWidget Text(YandexMoneyPaymentFormText text) => widget?.Text((byte) text) ?? throw new ArgumentNullException(nameof(widget));
  }
}