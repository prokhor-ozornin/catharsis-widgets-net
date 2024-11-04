using System;
using System.Web.Mvc;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Renders button for Yandex.Money (http://money.yandex.ru) payment system that allows financial transactions to be performed.</para>
  /// </summary>
  /// <seealso cref="https://money.yandex.ru/embed/quickpay/small.xml"/>
  public class YandexMoneyButtonWidget : HtmlWidget, IYandexMoneyButtonWidget
  {
    private string account;
    private string color = YandexMoneyButtonColor.Orange.ToString().ToLowerInvariant();
    private string description;
    private bool askPayerFullName;
    private bool askPayerEmail;
    private bool askPayerPhone;
    private bool askPayerAddress;
    private string size = "l";
    private decimal? sum;
    private byte text = (byte) YandexMoneyButtonText.Pay;
    private string type = "yamoney-payment-type";

    /// <summary>
    ///   <para>Identifier of account in the Yandex.Money payment system which is to receive money.</para>
    /// </summary>
    /// <param name="account">Identifier of account.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="account"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="account"/> is <see cref="string.Empty"/> string.</exception>
    /// <remarks>This attribute is required.</remarks>
    public IYandexMoneyButtonWidget Account(string account)
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
    ///   <para>Color of button. Default is "orange".</para>
    /// </summary>
    /// <param name="color">Button's color.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="color"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="color"/> is <see cref="string.Empty"/> string.</exception>
    public IYandexMoneyButtonWidget Color(string color)
    {
      Assertion.NotEmpty(color);

      this.color = color;
      return this;
    }

    /// <summary>
    ///   <para>Color of button. Default is "orange".</para>
    /// </summary>
    /// <returns>Button's color.</returns>
    public string Color()
    {
      return this.color;
    }

    /// <summary>
    ///   <para>Description of payment goal/purpose.</para>
    /// </summary>
    /// <param name="description">Description of purpose.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="description"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="description"/> is <see cref="string.Empty"/> string.</exception>
    /// <remarks>This attribute is required.</remarks>
    public IYandexMoneyButtonWidget Description(string description)
    {
      Assertion.NotEmpty(description);

      this.description = description;
      return this;
    }

    /// <summary>
    ///   <para>Description of payment goal/purpose.</para>
    /// </summary>
    /// <returns>Description of purpose.</returns>
    public string Description()
    {
      return this.description;
    }

    /// <summary>
    ///   <para>Whether to ask for full name of payer during transaction. Default is <c>false</c>.</para>
    /// </summary>
    /// <param name="ask"><c>true</c> to make payer's full name required, <c>false</c> to not.</param>
    /// <returns>Reference to the current widget.</returns>
    public IYandexMoneyButtonWidget AskPayerFullName(bool ask)
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
    ///   <para>Whether to ask for email address of payer during transaction. Default is <c>false</c>.</para>
    /// </summary>
    /// <param name="ask"><c>true</c> to make payer's email required, <c>false</c> to not.</param>
    /// <returns>Reference to the current widget.</returns>
    public IYandexMoneyButtonWidget AskPayerEmail(bool ask)
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
    ///   <para>Whether to ask for payer phone number during transaction. Default is <c>false</c>.</para>
    /// </summary>
    /// <param name="ask"><c>true</c> to make payer's phone required, <c>false</c> to not.</param>
    /// <returns>Reference to the current widget.</returns>
    public IYandexMoneyButtonWidget AskPayerPhone(bool ask)
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
    ///   <para>Whether to ask for payer address during transaction. Default is <c>false</c>.</para>
    /// </summary>
    /// <param name="ask"><c>true</c> to make payer's address required, <c>false</c> to not.</param>
    /// <returns>Reference to the current widget.</returns>
    public IYandexMoneyButtonWidget AskPayerAddress(bool ask)
    {
      this.askPayerAddress = ask;
      return this;
    }

    /// <summary>
    ///   <para>Whether to ask for payer address during transaction. Default is <c>false</c>.</para>
    /// </summary>
    /// <returns><c>true</c> to make payer's address required, <c>false</c> to not.</returns>
    public bool AskPayerAddress()
    {
      return this.askPayerAddress;
    }

    /// <summary>
    ///   <para>Size of button. Default is "l" (large).</para>
    /// </summary>
    /// <param name="size">Button's size.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="size"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="size"/> is <see cref="string.Empty"/> string.</exception>
    public IYandexMoneyButtonWidget Size(string size)
    {
      Assertion.NotEmpty(size);

      this.size = size;
      return this;
    }

    /// <summary>
    ///   <para>Size of button. Default is "l" (large).</para>
    /// </summary>
    /// <returns>Button's size.</returns>
    public string Size()
    {
      return this.size;
    }

    /// <summary>
    ///   <para>Monetary sum to transfer to Yandex.Money account.</para>
    /// </summary>
    /// <param name="sum">Payment sum.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <remarks>This attribute is required.</remarks>
    public IYandexMoneyButtonWidget Sum(decimal sum)
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
    ///   <para>Text to display on button. Default is 1 ("pay").</para>
    /// </summary>
    /// <param name="text">Numeric text type to display.</param>
    /// <returns>Reference to the current widget.</returns>
    public IYandexMoneyButtonWidget Text(byte text)
    {
      this.text = text;
      return this;
    }

    /// <summary>
    ///   <para>Text to display on button. Default is 1 ("pay").</para>
    /// </summary>
    /// <returns>Numeric text type to display.</returns>
    public byte Text()
    {
      return this.text;
    }

    /// <summary>
    ///   <para>Type of payment option. Default is "yamoney-payment-type" (pay from Yandex.Money wallet balance).</para>
    /// </summary>
    /// <param name="type">Payment source.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="type"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="type"/> is <see cref="string.Empty"/> string.</exception>
    public IYandexMoneyButtonWidget Type(string type)
    {
      Assertion.NotEmpty(type);

      this.type = type;
      return this;
    }

    /// <summary>
    ///   <para>Type of payment option. Default is "yamoney-payment-type" (pay from Yandex.Money wallet balance).</para>
    /// </summary>
    /// <returns>Payment source.</returns>
    public string Type()
    {
      return this.type;
    }

    /// <summary>
    ///   <para>Returns HTML markup text of widget.</para>
    /// </summary>
    /// <returns>Widget's HTML markup.</returns>
    public override string ToHtmlString()
    {
      if (this.Account().IsEmpty() || this.Sum() == null || this.Description().IsEmpty())
      {
        return string.Empty;
      }

      int width;
      switch ((YandexMoneyButtonText)this.Text())
      {
        case YandexMoneyButtonText.Pay:
          width = 229;
          break;

        case YandexMoneyButtonText.Buy:
          width = 197;
          break;

        case YandexMoneyButtonText.Transfer:
          width = 242;
          break;

        case YandexMoneyButtonText.Donate:
          width = 283;
          break;

        case YandexMoneyButtonText.Give:
          width = 231;
          break;

        case YandexMoneyButtonText.Support:
          width = 262;
          break;

        default:
          width = 283;
          break;
      }

      return new TagBuilder("iframe")
        .Attribute("src", "https://money.yandex.ru/embed/small.xml?account={0}&quickpay=small&{1}=on&button-text=0{2}&button-size={3}&button-color={4}&targets={5}&default-sum={6}{7}{8}{9}{10}".FormatSelf(this.Account(), this.Type(), this.Text(), this.Size(), this.Color(), this.Description(), this.Sum(), this.AskPayerFullName() ? "&fio=on" : string.Empty, this.AskPayerEmail() ? "&mail=on" : string.Empty, this.AskPayerPhone() ? "&phone=on" : string.Empty, this.AskPayerAddress() ? "&address=on" : string.Empty))
        .Attribute("frameborder", 0)
        .Attribute("allowtransparency", true)
        .Attribute("scrolling", "no")
        .Attribute("width", width)
        .Attribute("height", 54)
        .ToString();
    }
  }
}