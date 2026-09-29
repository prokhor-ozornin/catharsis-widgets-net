namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Renders payment form for Yandex.Money (http://money.yandex.ru) payment system that allows financial transactions to be performed.</para>
/// </summary>
/// <seealso href="https://money.yandex.ru/embed/quickpay/shop.xml"/>
public interface IYandexMoneyPaymentFormWidget : IWebWidget
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
  ///   <para>Whether to ask for payer address during transaction. Default is <see langword="false"/>.</para>
  /// </summary>
  /// <param name="enabled"><see langword="true"/> to make payer's address required, <see langword="false"/> to not.</param>
  /// <returns>Reference to the current widget.</returns>
  IYandexMoneyPaymentFormWidget AskPayerAddress(bool enabled);

  /// <summary>
  ///   <para>Whether to allow payer add custom payment comment. Default is <see langword="false"/>.</para>
  /// </summary>
  /// <param name="enabled"><see langword="true"/> to allow payer to add a form's comment, <see langword="false"/> to not.</param>
  /// <returns>Reference to the current widget.</returns>
  IYandexMoneyPaymentFormWidget AskPayerComment(bool enabled);

  /// <summary>
  ///   <para>Whether to ask for email address of payer during transaction. Default is <see langword="false"/>.</para>
  /// </summary>
  /// <param name="enabled"><see langword="true"/> to make payer's email required, <see langword="false"/> to not.</param>
  /// <returns>Reference to the current widget.</returns>
  IYandexMoneyPaymentFormWidget AskPayerEmail(bool enabled);

  /// <summary>
  ///   <para>Whether to ask for full name of payer during transaction. Default is <see langword="false"/>.</para>
  /// </summary>
  /// <param name="enabled"><see langword="true"/> to make payer's full name required, <see langword="false"/> to not.</param>
  /// <returns>Reference to the current widget.</returns>
  IYandexMoneyPaymentFormWidget AskPayerFullName(bool enabled);

  /// <summary>
  ///   <para>Whether to ask for payer phone number during transaction. Default is <see langword="false"/>.</para>
  /// </summary>
  /// <param name="enabled"><see langword="true"/> to make payer's phone required, <see langword="false"/> to not.</param>
  /// <returns>Reference to the current widget.</returns>
  IYandexMoneyPaymentFormWidget AskPayerPhone(bool enabled);

  /// <summary>
  ///   <para>Whether to allow payer specify custom payment purpose text (<see langword="true"/>) or use predefined purpose text (<see langword="false"/>). Default is <see langword="false"/>.</para>
  /// </summary>
  /// <param name="enabled"><see langword="true"/> to allow payer specify payment purpose, <see langword="false"/> to not.</param>
  /// <returns>Reference to the current widget.</returns>
  IYandexMoneyPaymentFormWidget AskPayerPurpose(bool enabled);

  /// <summary>
  ///   <para>Whether to accept payment from Visa/Master Card cards. Default is <see langword="true"/>.</para>
  /// </summary>
  /// <param name="enabled"><see langword="true"/> to accept Visa/Master Card payments, <see langword="false"/> to not.</param>
  /// <returns>Reference to the current widget.</returns>
  IYandexMoneyPaymentFormWidget Cards(bool enabled);

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
  ///   <para>Monetary sum to transfer to Yandex.Money account.</para>
  /// </summary>
  /// <param name="sum">Payment sum.</param>
  /// <returns>Reference to the current widget.</returns>
  IYandexMoneyPaymentFormWidget Sum(decimal sum);

  /// <summary>
  ///   <para>Text to display on button. Default is 1 ("Pay").</para>
  /// </summary>
  /// <param name="text">Numeric code of text to display.</param>
  /// <returns>Reference to the current widget.</returns>
  IYandexMoneyPaymentFormWidget Text(byte text);
}