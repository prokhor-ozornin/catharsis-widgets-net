namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Set of extension methods for interface <see cref="IYandexMoneyDonateFormWidget"/>.</para>
/// </summary>
/// <seealso cref="IYandexMoneyDonateFormWidget"/>
public static class IYandexMoneyDonateFormWidgetExtensions
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="widget"></param>
  /// <param name="url"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is <see langword="null"/>.</exception>
  public static IYandexMoneyDonateFormWidget ProjectSite(this IYandexMoneyDonateFormWidget widget, Uri url) => widget is not null ? widget.ProjectSite(url?.ToString()) : throw new ArgumentNullException(nameof(widget));

  /// <summary>
  ///   <para>Monetary sum to transfer to Yandex.Money account.</para>
  /// </summary>
  /// <param name="widget">Widget to call method on.</param>
  /// <param name="sum">Payment sum.</param>
  /// <returns>Reference to provided <paramref name="widget"/>.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
  public static IYandexMoneyDonateFormWidget Sum(this IYandexMoneyDonateFormWidget widget, double sum) => widget is not null ? widget.Sum((decimal) sum) : throw new ArgumentNullException(nameof(widget));

  /// <summary>
  ///   <para>Text to display on button.</para>
  /// </summary>
  /// <param name="widget">Widget to call method on.</param>
  /// <param name="text">Numeric code of text to display.</param>
  /// <returns>Reference to provided <paramref name="widget"/>.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
  /// <seealso cref="IYandexMoneyDonateFormWidget.Text(byte)"/>
  public static IYandexMoneyDonateFormWidget Text(this IYandexMoneyDonateFormWidget widget, YandexMoneyDonateFormText text) => widget is not null ? widget.Text((byte) text) : throw new ArgumentNullException(nameof(widget));
}