using System;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Renders payment form for Yandex.Money (http://money.yandex.ru) payment system that allows financial transactions to be performed.</para>
  /// </summary>
  /// <seealso cref="https://money.yandex.ru/embed/quickpay/shop.xml"/>
  public interface IYandexMoneyPaymentFormWidget : IHtmlWidget
  {
    /// <summary>
    ///   <para>Identifier of account in the Yandex.Money payment system which is to receive money.</para>
    /// </summary>
    /// <param name="account">Identifier of account.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="account"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="account"/> is <see cref="string.Empty"/> string.</exception>
    /// <remarks>This attribute is required.</remarks>
    IYandexMoneyPaymentFormWidget Account(string account);

    /// <summary>
    ///   <para>Identifier of account in the Yandex.Money payment system which is to receive money.</para>
    /// </summary>
    /// <returns>Identifier of account.</returns>
    string Account();

    /// <summary>
    ///   <para>Whether to ask for payer address during transaction. Default is <c>false</c>.</para>
    /// </summary>
    /// <param name="ask"><c>true</c> to make payer's address required, <c>false</c> to not.</param>
    /// <returns>Reference to the current widget.</returns>
    IYandexMoneyPaymentFormWidget AskPayerAddress(bool ask);

    /// <summary>
    ///   <para>Whether to ask for payer address during transaction. Default is <c>false</c>.</para>
    /// </summary>
    /// <returns><c>true</c> to make payer's address required, <c>false</c> to not.</returns>
    bool AskPayerAddress();

    /// <summary>
    ///   <para>Whether to allow payer add custom payment comment. Default is <c>false</c>.</para>
    /// </summary>
    /// <param name="ask"><c>true</c> to allow payer to add a form's comment, <c>false</c> to not.</param>
    /// <returns>Reference to the current widget.</returns>
    IYandexMoneyPaymentFormWidget AskPayerComment(bool ask);

    /// <summary>
    ///   <para>Whether to allow payer add custom payment comment. Default is <c>false</c>.</para>
    /// </summary>
    /// <returns><c>true</c> to allow payer to add a form's comment, <c>false</c> to not.</returns>
    bool AskPayerComment();

    /// <summary>
    ///   <para>Whether to ask for email address of payer during transaction. Default is <c>false</c>.</para>
    /// </summary>
    /// <param name="ask"><c>true</c> to make payer's email required, <c>false</c> to not.</param>
    /// <returns>Reference to the current widget.</returns>
    IYandexMoneyPaymentFormWidget AskPayerEmail(bool ask);

    /// <summary>
    ///   <para>Whether to ask for email address of payer during transaction. Default is <c>false</c>.</para>
    /// </summary>
    /// <returns><c>true</c> to make payer's email required, <c>false</c> to not.</returns>
    bool AskPayerEmail();

    /// <summary>
    ///   <para>Whether to ask for full name of payer during transaction. Default is <c>false</c>.</para>
    /// </summary>
    /// <param name="ask"><c>true</c> to make payer's full name required, <c>false</c> to not.</param>
    /// <returns>Reference to the current widget.</returns>
    IYandexMoneyPaymentFormWidget AskPayerFullName(bool ask);

    /// <summary>
    ///   <para>Whether to ask for full name of payer during transaction. Default is <c>false</c>.</para>
    /// </summary>
    /// <returns><c>true</c> to make payer's full name required, <c>false</c> to not.</returns>
    bool AskPayerFullName();

    /// <summary>
    ///   <para>Whether to ask for payer phone number during transaction. Default is <c>false</c>.</para>
    /// </summary>
    /// <param name="ask"><c>true</c> to make payer's phone required, <c>false</c> to not.</param>
    /// <returns>Reference to the current widget.</returns>
    IYandexMoneyPaymentFormWidget AskPayerPhone(bool ask);

    /// <summary>
    ///   <para>Whether to ask for payer phone number during transaction. Default is <c>false</c>.</para>
    /// </summary>
    /// <returns><c>true</c> to make payer's phone required, <c>false</c> to not.</returns>
    bool AskPayerPhone();

    /// <summary>
    ///   <para>Whether to allow payer specify custom payment purpose text (<c>true</c>) or use predefined purpose text (<c>false</c>). Default is <c>false</c>.</para>
    /// </summary>
    /// <param name="ask"><c>true</c> to allow payer specify payment purpose, <c>false</c> to not.</param>
    /// <returns>Reference to the current widget.</returns>
    IYandexMoneyPaymentFormWidget AskPayerPurpose(bool ask);

    /// <summary>
    ///   <para>Whether to allow payer specify custom payment purpose text (<c>true</c>) or use predefined purpose text (<c>false</c>). Default is <c>false</c>.</para>
    /// </summary>
    /// <returns><c>true</c> to allow payer specify payment purpose, <c>false</c> to not.</returns>
    bool AskPayerPurpose();

    /// <summary>
    ///   <para>Whether to accept payment from Visa/Master Card cards. Default is <c>true</c>.</para>
    /// </summary>
    /// <param name="accept"><c>true</c> to accept Visa/Master Card payments, <c>false</c> to not.</param>
    /// <returns>Reference to the current widget.</returns>
    IYandexMoneyPaymentFormWidget Cards(bool accept);

    /// <summary>
    ///   <para>Whether to accept payment from Visa/Master Card cards. Default is <c>true</c>.</para>
    /// </summary>
    /// <returns><c>true</c> to accept Visa/Master Card payments, <c>false</c> to not.</returns>
    bool Cards();
    
    /// <summary>
    ///   <para>Description of payment goal/purpose (for predefined purpose) or purpose hint (for custom purpose).</para>
    /// </summary>
    /// <param name="description">Description of purpose/purpose hint.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="description"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="description"/> is <see cref="string.Empty"/> string.</exception>
    /// <remarks>This attribute is required.</remarks>
    IYandexMoneyPaymentFormWidget Description(string description);

    /// <summary>
    ///   <para>Description of payment goal/purpose (for predefined purpose) or purpose hint (for custom purpose).</para>
    /// </summary>
    /// <returns>Description of purpose/purpose hint.</returns>
    string Description();

    /// <summary>
    ///   <para>Monetary sum to transfer to Yandex.Money account.</para>
    /// </summary>
    /// <param name="sum">Payment sum.</param>
    /// <returns>Reference to the current widget.</returns>
    IYandexMoneyPaymentFormWidget Sum(decimal sum);

    /// <summary>
    ///   <para>Monetary sum to transfer to Yandex.Money account.</para>
    /// </summary>
    /// <returns>Payment sum.</returns>
    decimal? Sum();

    /// <summary>
    ///   <para>Text to display on button. Default is 1 ("Pay").</para>
    /// </summary>
    /// <param name="text">Numeric code of text to display.</param>
    /// <returns>Reference to the current widget.</returns>
    IYandexMoneyPaymentFormWidget Text(byte text);

    /// <summary>
    ///   <para>Text to display on button. Default is 1 ("Pay").</para>
    /// </summary>
    /// <returns>Numeric code of text to display.</returns>
    byte Text();
  }
}