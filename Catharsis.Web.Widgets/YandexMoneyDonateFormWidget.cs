using System;
using System.IO;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Renders donation form for Yandex.Money (http://money.yandex.ru) payment system that allows financial transactions to be performed.</para>
  /// </summary>
  /// <seealso cref="https://money.yandex.ru/embed/quickpay/donate.xml"/>
  public sealed class YandexMoneyDonateFormWidget : HtmlWidgetBase<IYandexMoneyDonateFormWidget>, IYandexMoneyDonateFormWidget
  {
    private string account;
    private string description;
    private decimal? sum;
    private bool cards = true;
    private byte text = (byte) YandexMoneyDonateFormText.Donate;
    private string projectName;
    private string projectSite;
    private bool payerComment;
    private string payerCommentHint;
    private bool payerFullName;
    private bool payerEmail;
    private bool payerPhone;
    private bool showDescription;

    /// <summary>
    ///   <para>Identifier of account in the Yandex.Money payment system which is to receive money.</para>
    /// </summary>
    /// <param name="account">Identifier of account.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="account"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="account"/> is <see cref="string.Empty"/> string.</exception>
    /// <remarks>This attribute is required.</remarks>
    public IYandexMoneyDonateFormWidget Account(string account)
    {
      Assertion.NotEmpty(account);

      this.account = account;
      return this;
    }

    /// <summary>
    ///   <para>Description of payment goal/purpose.</para>
    /// </summary>
    /// <param name="description">Description of payment purpose.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="description"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="description"/> is <see cref="string.Empty"/> string.</exception>
    /// <remarks>This attribute is required.</remarks>
    public IYandexMoneyDonateFormWidget Description(string description)
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
    public IYandexMoneyDonateFormWidget Sum(decimal sum)
    {
      this.sum = sum;
      return this;
    }

    /// <summary>
    ///   <para>Whether to accept payment from Visa/Master Card cards. Default is <c>true</c>.</para>
    /// </summary>
    /// <param name="accept"><c>true</c> to accept Visa/Master Card payments, <c>false</c> to not.</param>
    /// <returns>Reference to the current widget.</returns>
    public IYandexMoneyDonateFormWidget Cards(bool accept = true)
    {
      this.cards = accept;
      return this;
    }

    /// <summary>
    ///   <para>Text to display on button. Default is 1 ("Donate").</para>
    /// </summary>
    /// <param name="text">Numeric code of text to display.</param>
    /// <returns>Reference to the current widget.</returns>
    public IYandexMoneyDonateFormWidget Text(byte text)
    {
      this.text = text;
      return this;
    }

    /// <summary>
    ///   <para>Name of charitable project or program.</para>
    /// </summary>
    /// <param name="name">Name of project.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="name"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="name"/> is <see cref="string.Empty"/> string.</exception>
    public IYandexMoneyDonateFormWidget ProjectName(string name)
    {
      Assertion.NotEmpty(name);

      this.projectName = name;
      return this;
    }

    /// <summary>
    ///   <para>URL address of charitable project or program website.</para>
    /// </summary>
    /// <param name="url">Website of project.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="url"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="url"/> is <see cref="string.Empty"/> string.</exception>
    public IYandexMoneyDonateFormWidget ProjectSite(string url)
    {
      Assertion.NotEmpty(url);

      this.projectSite = url;
      return this;
    }

    /// <summary>
    ///   <para>Whether to allow payer add custom payment comment. Default is <c>false</c>.</para>
    /// </summary>
    /// <param name="require"><c>true</c> to allow payer to add a form's comment, <c>false</c> to not.</param>
    /// <returns>Reference to the current widget.</returns>
    public IYandexMoneyDonateFormWidget PayerComment(bool require = true)
    {
      this.payerComment = require;
      return this;
    }

    /// <summary>
    ///   <para>Hint text for comment field.</para>
    /// </summary>
    /// <param name="hint">Comment's hint.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="hint"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="hint"/> is <see cref="string.Empty"/> string.</exception>
    public IYandexMoneyDonateFormWidget PayerCommentHint(string hint)
    {
      Assertion.NotEmpty(hint);

      this.payerCommentHint = hint;
      return this;
    }

    /// <summary>
    ///   <para>Whether to ask for full name of payer during transaction. Default is <c>false</c>.</para>
    /// </summary>
    /// <param name="require"><c>true</c> to make payer's full name required, <c>false</c> to not.</param>
    /// <returns>Reference to the current widget.</returns>
    public IYandexMoneyDonateFormWidget PayerFullName(bool require = true)
    {
      this.payerFullName = require;
      return this;
    }

    /// <summary>
    ///   <para>Whether to ask for email address of payer during transaction. Default is <c>false</c>.</para>
    /// </summary>
    /// <param name="require"><c>true</c> to make payer's email required, <c>false</c> to not.</param>
    /// <returns>Reference to the current widget.</returns>
    public IYandexMoneyDonateFormWidget PayerEmail(bool require = true)
    {
      this.payerEmail = require;
      return this;
    }

    /// <summary>
    ///   <para>Whether to ask for payer phone number during transaction. Default is <c>false</c>.</para>
    /// </summary>
    /// <param name="require"><c>true</c> to make payer's phone required, <c>false</c> to not.</param>
    /// <returns>Reference to the current widget.</returns>
    public IYandexMoneyDonateFormWidget PayerPhone(bool require = true)
    {
      this.payerPhone = require;
      return this;
    }

    /// <summary>
    ///   <para>Whether to show description of payment goal/purpose in the form. Default is <c>false</c>.</para>
    /// </summary>
    /// <param name="show"><c>true</c> to show payment purpose text on the form, <c>false</c> to hide it.</param>
    /// <returns>Reference to the current widget.</returns>
    public IYandexMoneyDonateFormWidget ShowDescription(bool show = true)
    {
      this.showDescription = show;
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

      int width;
      switch ((YandexMoneyDonateFormText) this.text)
      {
        case YandexMoneyDonateFormText.Donate :
          width = 523;
        break;

        case YandexMoneyDonateFormText.Give :
          width = 487;
        break;

        case YandexMoneyDonateFormText.Transfer :
          width = 495;
        break;

        case YandexMoneyDonateFormText.Send :
          width = 494;
        break;

        case YandexMoneyDonateFormText.Support :
          width = 507;
        break;

        default :
          width = 523;
        break;
      }
      if (!this.cards)
      {
        width -= 69;
      }

      writer.Write(this.ToTag("iframe", tag => tag
        .Attribute("src", "https://money.yandex.ru/embed/donate.xml?account={0}&quickpay=donate{1}&default-sum={2}&targets={3}{4}&project-name={5}&project-site={6}&button-text={7}{8}{9}{10}{11}".FormatSelf(this.account, this.cards ? "&payment-type-choice=on" : string.Empty, this.sum, this.description, this.showDescription ? "&target-visibility=on" : string.Empty, this.projectName, this.projectSite, "0{0}".FormatSelf(this.text), this.payerComment ? "&comment=on&hint={0}".FormatSelf(this.payerCommentHint) : string.Empty, this.payerFullName ? "&fio=on" : string.Empty, this.payerEmail ? "&mail=on" : string.Empty, this.payerPhone ? "&phone=on" : string.Empty))
        .Attribute("frameborder", 0)
        .Attribute("allowtransparency", true)
        .Attribute("scrolling", "no")
        .Attribute("width", width)
        .Attribute("height", this.payerComment ? 210 : 133)));
    }
  }
}