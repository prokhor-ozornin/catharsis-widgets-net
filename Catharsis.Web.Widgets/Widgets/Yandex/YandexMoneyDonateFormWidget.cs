using System;
using System.Web.Mvc;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Renders donation form for Yandex.Money (http://money.yandex.ru) payment system that allows financial transactions to be performed.</para>
  /// </summary>
  /// <seealso cref="https://money.yandex.ru/embed/quickpay/donate.xml"/>
  public class YandexMoneyDonateFormWidget : HtmlWidget, IYandexMoneyDonateFormWidget
  {
    private string account;
    private bool description;
    private decimal? sum;
    private bool cards = true;
    private byte text = (byte) YandexMoneyDonateFormText.Donate;
    private string projectName;
    private string projectSite;
    private bool askPayerComment;
    private string commentHint;
    private bool askPayerFullName;
    private bool askPayerEmail;
    private bool askPayerPhone;
    private string descriptionText;

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
    ///   <para>Identifier of account in the Yandex.Money payment system which is to receive money.</para>
    /// </summary>
    /// <returns>Identifier of account.</returns>
    public string Account()
    {
      return this.account;
    }

    /// <summary>
    ///   <para>Whether to accept payment from Visa/Master Card cards. Default is <c>true</c>.</para>
    /// </summary>
    /// <param name="accept"><c>true</c> to accept Visa/Master Card payments, <c>false</c> to not.</param>
    /// <returns>Reference to the current widget.</returns>
    public IYandexMoneyDonateFormWidget Cards(bool accept)
    {
      this.cards = accept;
      return this;
    }

    /// <summary>
    ///   <para>Whether to accept payment from Visa/Master Card cards. Default is <c>true</c>.</para>
    /// </summary>
    /// <returns><c>true</c> to accept Visa/Master Card payments, <c>false</c> to not.</returns>
    public bool Cards()
    {
      return this.cards;
    }

    /// <summary>
    ///   <para>Description of payment goal/purpose.</para>
    /// </summary>
    /// <param name="description">Description of payment purpose.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="description"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="description"/> is <see cref="string.Empty"/> string.</exception>
    /// <remarks>This attribute is required.</remarks>
    public IYandexMoneyDonateFormWidget DescriptionText(string description)
    {
      Assertion.NotEmpty(description);

      this.descriptionText = description;
      return this;
    }

    /// <summary>
    ///   <para>Description of payment goal/purpose.</para>
    /// </summary>
    /// <returns>Description of payment purpose.</returns>
    public string DescriptionText()
    {
      return this.descriptionText;
    }

    /// <summary>
    ///   <para>Whether to allow payer add custom payment comment. Default is <c>false</c>.</para>
    /// </summary>
    /// <param name="ask"><c>true</c> to allow payer to add a form's comment, <c>false</c> to not.</param>
    /// <returns>Reference to the current widget.</returns>
    public IYandexMoneyDonateFormWidget AskPayerComment(bool ask)
    {
      this.askPayerComment = ask;
      return this;
    }

    /// <summary>
    ///   <para>Whether to allow payer add custom payment comment. Default is <c>false</c>.</para>
    /// </summary>
    /// <returns><c>true</c> to allow payer to add a form's comment, <c>false</c> to not.</returns>
    public bool AskPayerComment()
    {
      return this.askPayerComment;
    }

    /// <summary>
    ///   <para>Hint text for comment field.</para>
    /// </summary>
    /// <param name="hint">Comment's hint.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="hint"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="hint"/> is <see cref="string.Empty"/> string.</exception>
    public IYandexMoneyDonateFormWidget CommentHint(string hint)
    {
      Assertion.NotEmpty(hint);

      this.commentHint = hint;
      return this;
    }

    /// <summary>
    ///   <para>Hint text for comment field.</para>
    /// </summary>
    /// <returns>Comment's hint.</returns>
    public string CommentHint()
    {
      return this.commentHint;
    }

    /// <summary>
    ///   <para>Whether to ask for email address of payer during transaction. Default is <c>false</c>.</para>
    /// </summary>
    /// <param name="ask"><c>true</c> to make payer's email required, <c>false</c> to not.</param>
    /// <returns>Reference to the current widget.</returns>
    public IYandexMoneyDonateFormWidget AskPayerEmail(bool ask)
    {
      this.askPayerEmail = ask;
      return this;
    }

    /// <summary>
    ///   <para>Whether to ask for email address of payer during transaction. Default is <c>false</c>.</para>
    /// </summary>
    /// <returns><c>true</c> to make payer's email required, <c>false</c> to not.</returns>
    public bool AskPayerEmail()
    {
      return this.askPayerEmail;
    }

    /// <summary>
    ///   <para>Whether to ask for full name of payer during transaction. Default is <c>false</c>.</para>
    /// </summary>
    /// <param name="ask"><c>true</c> to make payer's full name required, <c>false</c> to not.</param>
    /// <returns>Reference to the current widget.</returns>
    public IYandexMoneyDonateFormWidget AskPayerFullName(bool ask)
    {
      this.askPayerFullName = ask;
      return this;
    }

    /// <summary>
    ///   <para>Whether to ask for full name of payer during transaction. Default is <c>false</c>.</para>
    /// </summary>
    /// <returns><c>true</c> to make payer's full name required, <c>false</c> to not.</returns>
    public bool AskPayerFullName()
    {
      return this.askPayerFullName;
    }

    /// <summary>
    ///   <para>Whether to ask for payer phone number during transaction. Default is <c>false</c>.</para>
    /// </summary>
    /// <param name="ask"><c>true</c> to make payer's phone required, <c>false</c> to not.</param>
    /// <returns>Reference to the current widget.</returns>
    public IYandexMoneyDonateFormWidget AskPayerPhone(bool ask)
    {
      this.askPayerPhone = ask;
      return this;
    }

    /// <summary>
    ///   <para>Whether to ask for payer phone number during transaction. Default is <c>false</c>.</para>
    /// </summary>
    /// <returns><c>true</c> to make payer's phone required, <c>false</c> to not.</returns>
    public bool AskPayerPhone()
    {
      return this.askPayerPhone;
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
    ///   <para>Name of charitable project or program.</para>
    /// </summary>
    /// <returns>Name of project.</returns>
    public string ProjectName()
    {
      return this.projectName;
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
    ///   <para>URL address of charitable project or program website.</para>
    /// </summary>
    /// <returns>Website of project.</returns>
    public string ProjectSite()
    {
      return this.projectSite;
    }

    /// <summary>
    ///   <para>Whether to show description of payment goal/purpose in the form. Default is <c>false</c>.</para>
    /// </summary>
    /// <param name="show"><c>true</c> to show payment purpose text on the form, <c>false</c> to hide it.</param>
    /// <returns>Reference to the current widget.</returns>
    public IYandexMoneyDonateFormWidget Description(bool show)
    {
      this.description = show;
      return this;
    }

    /// <summary>
    ///   <para>Whether to show description of payment goal/purpose in the form. Default is <c>false</c>.</para>
    /// </summary>
    /// <returns><c>true</c> to show payment purpose text on the form, <c>false</c> to hide it.</returns>
    public bool Description()
    {
      return this.description;
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
    ///   <para>Monetary sum to transfer to Yandex.Money account.</para>
    /// </summary>
    /// <returns>Payment sum.</returns>
    public decimal? Sum()
    {
      return this.sum;
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
    ///   <para>Text to display on button. Default is 1 ("Donate").</para>
    /// </summary>
    /// <returns>Numeric code of text to display.</returns>
    public byte Text()
    {
      return this.text;
    }

    /// <summary>
    ///   <para>Returns HTML markup text of widget.</para>
    /// </summary>
    /// <returns>Widget's HTML markup.</returns>
    public override string ToHtmlString()
    {
      if (this.Account().IsEmpty() || this.DescriptionText().IsEmpty())
      {
        return string.Empty;
      }

      int width;
      switch ((YandexMoneyDonateFormText)this.Text())
      {
        case YandexMoneyDonateFormText.Donate:
          width = 523;
          break;

        case YandexMoneyDonateFormText.Give:
          width = 487;
          break;

        case YandexMoneyDonateFormText.Transfer:
          width = 495;
          break;

        case YandexMoneyDonateFormText.Send:
          width = 494;
          break;

        case YandexMoneyDonateFormText.Support:
          width = 507;
          break;

        default:
          width = 523;
          break;
      }
      if (!this.cards)
      {
        width -= 69;
      }

      return new TagBuilder("iframe")
        .Attribute("src", "https://money.yandex.ru/embed/donate.xml?account={0}&quickpay=donate{1}&default-sum={2}&targets={3}{4}&project-name={5}&project-site={6}&button-text=0{7}{8}{9}{10}{11}".FormatSelf(this.Account(), this.Cards() ? "&payment-type-choice=on" : string.Empty, this.Sum(), this.DescriptionText(), this.Description() ? "&target-visibility=on" : string.Empty, this.ProjectName(), this.ProjectSite(), this.Text(), this.AskPayerComment() ? "&comment=on&hint={0}".FormatSelf(this.CommentHint()) : string.Empty, this.AskPayerFullName() ? "&fio=on" : string.Empty, this.AskPayerEmail() ? "&mail=on" : string.Empty, this.AskPayerPhone() ? "&phone=on" : string.Empty))
        .Attribute("frameborder", 0)
        .Attribute("allowtransparency", true)
        .Attribute("scrolling", "no")
        .Attribute("width", width)
        .Attribute("height", this.AskPayerComment() ? 210 : 133)
        .ToString();
    }
  }
}