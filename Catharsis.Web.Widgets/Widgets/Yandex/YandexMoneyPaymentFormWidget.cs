using System;
using System.Web.Mvc;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Renders payment form for Yandex.Money (http://money.yandex.ru) payment system that allows financial transactions to be performed.</para>
  /// </summary>
  /// <seealso cref="https://money.yandex.ru/embed/quickpay/shop.xml"/>
  public class YandexMoneyPaymentFormWidget : HtmlWidget, IYandexMoneyPaymentFormWidget
  {
    private string account;
    private string description;
    private decimal? sum;
    private bool cards = true;
    private byte text = (byte) YandexMoneyPaymentFormText.Pay;
    private bool askPayerPurpose;
    private bool askPayerComment;
    private bool askPayerFullName;
    private bool askPayerEmail;
    private bool askPayerPhone;
    private bool askPayerAddress;

    /// <summary>
    ///   <para>Identifier of account in the Yandex.Money payment system which is to receive money.</para>
    /// </summary>
    /// <param name="account">Identifier of account.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="account"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="account"/> is <see cref="string.Empty"/> string.</exception>
    /// <remarks>This attribute is required.</remarks>
    public IYandexMoneyPaymentFormWidget Account(string account)
    {
      Assertion.NotEmpty(account);

      this.account = account;
      return this;
    }

    /// <summary>
    ///   <para>Whether to accept payment from Visa/Master Card cards. Default is <c>true</c>.</para>
    /// </summary>
    /// <param name="accept"><c>true</c> to accept Visa/Master Card payments, <c>false</c> to not.</param>
    /// <returns>Reference to the current widget.</returns>
    public IYandexMoneyPaymentFormWidget Cards(bool accept = true)
    {
      this.cards = accept;
      return this;
    }

    /// <summary>
    ///   <para>Description of payment goal/purpose (for predefined purpose) or purpose hint (for custom purpose).</para>
    /// </summary>
    /// <param name="description">Description of purpose/purpose hint.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="description"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="description"/> is <see cref="string.Empty"/> string.</exception>
    public IYandexMoneyPaymentFormWidget Description(string description)
    {
      Assertion.NotEmpty(description);

      this.description = description;
      return this;
    }

    /// <summary>
    ///   <para>Whether to ask for payer address during transaction. Default is <c>false</c>.</para>
    /// </summary>
    /// <param name="ask"><c>true</c> to make payer's address required, <c>false</c> to not.</param>
    /// <returns>Reference to the current widget.</returns>
    public IYandexMoneyPaymentFormWidget AskPayerAddress(bool ask = true)
    {
      this.askPayerAddress = ask;
      return this;
    }

    /// <summary>
    ///   <para>Whether to allow payer add custom payment comment. Default is <c>false</c>.</para>
    /// </summary>
    /// <param name="ask"><c>true</c> to allow payer to add a form's comment, <c>false</c> to not.</param>
    /// <returns>Reference to the current widget.</returns>
    public IYandexMoneyPaymentFormWidget AskPayerComment(bool ask = true)
    {
      this.askPayerComment = ask;
      return this;
    }

    /// <summary>
    ///   <para>Whether to ask for email address of payer during transaction. Default is <c>false</c>.</para>
    /// </summary>
    /// <param name="ask"><c>true</c> to make payer's email required, <c>false</c> to not.</param>
    /// <returns>Reference to the current widget.</returns>
    public IYandexMoneyPaymentFormWidget AskPayerEmail(bool ask = true)
    {
      this.askPayerEmail = ask;
      return this;
    }

    /// <summary>
    ///   <para>Whether to ask for full name of payer during transaction. Default is <c>false</c>.</para>
    /// </summary>
    /// <param name="ask"><c>true</c> to make payer's full name required, <c>false</c> to not.</param>
    /// <returns>Reference to the current widget.</returns>
    public IYandexMoneyPaymentFormWidget AskPayerFullName(bool ask = true)
    {
      this.askPayerFullName = ask;
      return this;
    }

    /// <summary>
    ///   <para>Whether to ask for payer phone number during transaction. Default is <c>false</c>.</para>
    /// </summary>
    /// <param name="ask"><c>true</c> to make payer's phone required, <c>false</c> to not.</param>
    /// <returns>Reference to the current widget.</returns>
    public IYandexMoneyPaymentFormWidget AskPayerPhone(bool ask = true)
    {
      this.askPayerPhone = ask;
      return this;
    }

    /// <summary>
    ///   <para>Whether to allow payer specify custom payment purpose text (<c>true</c>) or use predefined purpose text (<c>false</c>). Default is <c>false</c>.</para>
    /// </summary>
    /// <param name="ask"><c>true</c> to allow payer specify payment purpose, <c>false</c> to not.</param>
    /// <returns>Reference to the current widget.</returns>
    public IYandexMoneyPaymentFormWidget AskPayerPurpose(bool ask = true)
    {
      this.askPayerPurpose = ask;
      return this;
    }

    /// <summary>
    ///   <para>Monetary sum to transfer to Yandex.Money account.</para>
    /// </summary>
    /// <param name="sum">Payment sum.</param>
    /// <returns>Reference to the current widget.</returns>
    public IYandexMoneyPaymentFormWidget Sum(decimal sum)
    {
      this.sum = sum;
      return this;
    }

    /// <summary>
    ///   <para>Text to display on button. Default is 1 ("Pay").</para>
    /// </summary>
    /// <param name="text">Numeric code of text to display.</param>
    /// <returns>Reference to the current widget.</returns>
    public IYandexMoneyPaymentFormWidget Text(byte text)
    {
      this.text = text;
      return this;
    }

    /// <summary>
    ///   <para>Returns HTML markup text of widget.</para>
    /// </summary>
    /// <returns>Widget's HTML markup.</returns>
    public override string ToHtmlString()
    {
      if (this.account.IsEmpty() || this.description.IsEmpty())
      {
        return string.Empty;
      }

      return new TagBuilder("iframe")
        .Attribute("src", "https://money.yandex.ru/embed/shop.xml?account={0}&quickpay=shop{1}&writer={2}&{3}={4}&default-sum={5}&button-text=0{6}{7}{8}{9}{10}{11}".FormatSelf(this.account, this.cards ? "&payment-type-choice=on" : string.Empty, this.askPayerPurpose ? "buyer" : "seller", this.askPayerPurpose ? "targets-hint" : "targets", this.description, this.sum, this.text, this.askPayerComment ? "&comment=on" : string.Empty, this.askPayerFullName ? "&fio=on" : string.Empty, this.askPayerEmail ? "&mail=on" : string.Empty, this.askPayerPhone ? "&phone=on" : string.Empty, this.askPayerAddress ? "&address=on" : string.Empty))
        .Attribute("frameborder", 0)
        .Attribute("allowtransparency", true)
        .Attribute("scrolling", "no")
        .Attribute("width", 450)
        .Attribute("height", this.askPayerComment ? 255 : 200)
        .ToString();
    }
  }
}