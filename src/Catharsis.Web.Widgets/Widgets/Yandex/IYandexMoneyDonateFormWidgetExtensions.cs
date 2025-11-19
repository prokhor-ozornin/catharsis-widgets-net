namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Set of extension methods for interface <see cref="IYandexMoneyDonateFormWidget"/>.</para>
/// </summary>
/// <seealso cref="IYandexMoneyDonateFormWidget"/>
public static class IYandexMoneyDonateFormWidgetExtensions
{
  /// <param name="widget"></param>
  extension(IYandexMoneyDonateFormWidget widget)
  {
    /// <summary>
    ///   <para></para>
    /// </summary>
    /// <param name="url"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is <see langword="null"/>.</exception>
    public IYandexMoneyDonateFormWidget ProjectSite(Uri url) => widget?.ProjectSite(url?.ToString()) ?? throw new ArgumentNullException(nameof(widget));

    /// <summary>
    ///   <para>Monetary sum to transfer to Yandex.Money account.</para>
    /// </summary>
    /// <param name="sum">Payment sum.</param>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    public IYandexMoneyDonateFormWidget Sum(double sum) => widget?.Sum((decimal) sum) ?? throw new ArgumentNullException(nameof(widget));

    /// <summary>
    ///   <para>Text to display on button.</para>
    /// </summary>
    /// <param name="text">Numeric code of text to display.</param>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="IYandexMoneyDonateFormWidget.Text(byte)"/>
    public IYandexMoneyDonateFormWidget Text(YandexMoneyDonateFormText text) => widget?.Text((byte) text) ?? throw new ArgumentNullException(nameof(widget));
  }
}