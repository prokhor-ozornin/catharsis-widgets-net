using System;
using System.IO;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Renders payment form for Yandex.Money (http://money.yandex.ru) payment system that allows financial transactions to be performed.</para>
  /// </summary>
  /// <seealso cref="https://money.yandex.ru/embed/quickpay/shop.xml"/>
  public sealed class YandexMoneyPaymentFormWidget : HtmlWidgetBase<IYandexMoneyPaymentFormWidget>, IYandexMoneyPaymentFormWidget
  {
    private string account;
    private string description;
    private decimal? sum;
    private bool cards = true;
    private byte text = (byte) YandexMoneyPaymentFormText.Pay;
    private bool payerPurpose;
    private bool payerComment;
    private bool payerFullName;
    private bool payerEmail;
    private bool payerPhone;
    private bool payerAddress;

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
    ///   <para>Whether to allow payer specify custom payment purpose text (<c>true</c>) or use predefined purpose text (<c>false</c>). Default is <c>false</c>.</para>
    /// </summary>
    /// <param name="allow"><c>true</c> to allow payer specify payment purpose, <c>false</c> to not.</param>
    /// <returns>Reference to the current widget.</returns>
    public IYandexMoneyPaymentFormWidget PayerPurpose(bool allow = true)
    {
      this.payerPurpose = allow;
      return this;
    }

    /// <summary>
    ///   <para>Whether to allow payer add custom payment comment. Default is <c>false</c>.</para>
    /// </summary>
    /// <param name="require"><c>true</c> to allow payer to add a form's comment, <c>false</c> to not.</param>
    /// <returns>Reference to the current widget.</returns>
    public IYandexMoneyPaymentFormWidget PayerComment(bool require = true)
    {
      this.payerComment = require;
      return this;
    }

    /// <summary>
    ///   <para>Whether to ask for full name of payer during transaction. Default is <c>false</c>.</para>
    /// </summary>
    /// <param name="require"><c>true</c> to make payer's full name required, <c>false</c> to not.</param>
    /// <returns>Reference to the current widget.</returns>
    public IYandexMoneyPaymentFormWidget PayerFullName(bool require = true)
    {
      this.payerFullName = require;
      return this;
    }

    /// <summary>
    ///   <para>Whether to ask for email address of payer during transaction. Default is <c>false</c>.</para>
    /// </summary>
    /// <param name="require"><c>true</c> to make payer's email required, <c>false</c> to not.</param>
    /// <returns>Reference to the current widget.</returns>
    public IYandexMoneyPaymentFormWidget PayerEmail(bool require = true)
    {
      this.payerEmail = require;
      return this;
    }

    /// <summary>
    ///   <para>Whether to ask for payer phone number during transaction. Default is <c>false</c>.</para>
    /// </summary>
    /// <param name="require"><c>true</c> to make payer's phone required, <c>false</c> to not.</param>
    /// <returns>Reference to the current widget.</returns>
    public IYandexMoneyPaymentFormWidget PayerPhone(bool require = true)
    {
      this.payerPhone = require;
      return this;
    }

    /// <summary>
    ///   <para>Whether to ask for payer address during transaction. Default is <c>false</c>.</para>
    /// </summary>
    /// <param name="require"><c>true</c> to make payer's address required, <c>false</c> to not.</param>
    /// <returns>Reference to the current widget.</returns>
    public IYandexMoneyPaymentFormWidget PayerAddress(bool require = true)
    {
      this.payerAddress = require;
      return this;
    }

    /// <summary>
    ///   <para>Generates and writes HTML markup of widget, using specified text writer.</para>
    /// </summary>
    /// <param name="writer">Text writer to use as output destination.</param>
    public override void Write(TextWriter writer)
    {
      Assertion.NotNull(writer);

      if (this.account.IsEmpty() || this.description.IsEmpty())
      {
        return;
      }

      writer.Write(this.ToTag("iframe", tag => tag
        .Attribute("src", "https://money.yandex.ru/embed/shop.xml?account={0}&quickpay=shop{1}&writer={2}&{3}={4}&default-sum={5}&button-text={6}{7}{8}{9}{10}{11}".FormatSelf(this.account, this.cards ? "&payment-type-choice=on" : string.Empty, this.payerPurpose ? "buyer" : "seller", this.payerPurpose ? "targets-hint" : "targets", this.description, this.sum, "0{0}".FormatSelf(this.text), this.payerComment ? "&comment=on" : string.Empty, this.payerFullName ? "&fio=on" : string.Empty, this.payerEmail ? "&mail=on" : string.Empty, this.payerPhone ? "&phone=on" : string.Empty, this.payerAddress ? "&address=on" : string.Empty))
        .Attribute("frameborder", 0)
        .Attribute("allowtransparency", true)
        .Attribute("scrolling", "no")
        .Attribute("width", 450)
        .Attribute("height", this.payerComment ? 255 : 200)));
    }
  }
}