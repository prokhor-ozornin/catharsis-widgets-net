using System;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Renders button for Yandex.Money (http://money.yandex.ru) payment system that allows financial transactions to be performed.</para>
  /// </summary>
  /// <seealso cref="https://money.yandex.ru/embed/quickpay/small.xml"/>
  public interface IYandexMoneyButtonWidget : IHtmlWidget
  {
    /// <summary>
    ///   <para>Identifier of account in the Yandex.Money payment system which is to receive money.</para>
    /// </summary>
    /// <param name="account">Identifier of account.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="account"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="account"/> is <see cref="string.Empty"/> string.</exception>
    /// <remarks>This attribute is required.</remarks>
    IYandexMoneyButtonWidget Account(string account);

    /// <summary>
    ///   <para>Color of button. Default is "orange".</para>
    /// </summary>
    /// <param name="color">Button's color.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="color"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="color"/> is <see cref="string.Empty"/> string.</exception>
    IYandexMoneyButtonWidget Color(string color);

    /// <summary>
    ///   <para>Description of payment goal/purpose.</para>
    /// </summary>
    /// <param name="description">Description of purpose.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="description"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="description"/> is <see cref="string.Empty"/> string.</exception>
    /// <remarks>This attribute is required.</remarks>
    IYandexMoneyButtonWidget Description(string description);

    /// <summary>
    ///   <para>Whether to ask for full name of payer during transaction. Default is <c>false</c>.</para>
    /// </summary>
    /// <param name="require"><c>true</c> to make payer's full name required, <c>false</c> to not.</param>
    /// <returns>Reference to the current widget.</returns>
    IYandexMoneyButtonWidget PayerFullName(bool require = true);

    /// <summary>
    ///   <para>Whether to ask for email address of payer during transaction. Default is <c>false</c>.</para>
    /// </summary>
    /// <param name="require"><c>true</c> to make payer's email required, <c>false</c> to not.</param>
    /// <returns>Reference to the current widget.</returns>
    IYandexMoneyButtonWidget PayerEmail(bool require = true);

    /// <summary>
    ///   <para>Whether to ask for payer phone number during transaction. Default is <c>false</c>.</para>
    /// </summary>
    /// <param name="require"><c>true</c> to make payer's phone required, <c>false</c> to not.</param>
    /// <returns>Reference to the current widget.</returns>
    IYandexMoneyButtonWidget PayerPhone(bool require = true);

    /// <summary>
    ///   <para>Whether to ask for payer address during transaction. Default is <c>false</c>.</para>
    /// </summary>
    /// <param name="require"><c>true</c> to make payer's address required, <c>false</c> to not.</param>
    /// <returns>Reference to the current widget.</returns>
    IYandexMoneyButtonWidget PayerAddress(bool require = true);

    /// <summary>
    ///   <para>Size of button. Default is "l" (large)</para>
    /// </summary>
    /// <param name="size">Button's size.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="size"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="size"/> is <see cref="string.Empty"/> string.</exception>
    IYandexMoneyButtonWidget Size(string size);

    /// <summary>
    ///   <para>Monetary sum to transfer to Yandex.Money account.</para>
    /// </summary>
    /// <param name="sum">Payment sum.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <remarks>This attribute is required.</remarks>
    IYandexMoneyButtonWidget Sum(decimal sum);

    /// <summary>
    ///   <para>Text to display on button. Default is 1 ("Pay").</para>
    /// </summary>
    /// <param name="text">Numeric code of text to display.</param>
    /// <returns>Reference to the current widget.</returns>
    IYandexMoneyButtonWidget Text(byte text);

    /// <summary>
    ///   <para>Type of payment option. Default is "yamoney-payment-type" (pay from Yandex.Money wallet balance).</para>
    /// </summary>
    /// <param name="type">Payment source.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="type"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="type"/> is <see cref="string.Empty"/> string.</exception>
    IYandexMoneyButtonWidget Type(string type);
  }
}