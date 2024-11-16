using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IYandexMoneyPaymentFormWidget"/>
public class YandexMoneyPaymentFormWidget : WebWidget, IYandexMoneyPaymentFormWidget
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

  /// <inheritdoc cref="IYandexMoneyPaymentFormWidget.Account(string)"/>
  public IYandexMoneyPaymentFormWidget Account(string account)
  {
    if (account is null) throw new ArgumentNullException(nameof(account));
    if (account.IsEmpty()) throw new ArgumentException(nameof(account));

    this.account = account;

    return this;
  }

  /// <inheritdoc cref="IYandexMoneyPaymentFormWidget.Account()"/>
  public string Account() => account;

  /// <inheritdoc cref="IYandexMoneyPaymentFormWidget.Cards(bool)"/>
  public IYandexMoneyPaymentFormWidget Cards(bool accept)
  {
    cards = accept;
    return this;
  }

  /// <inheritdoc cref="IYandexMoneyPaymentFormWidget.Cards()"/>
  public bool Cards() => cards;

  /// <inheritdoc cref="IYandexMoneyPaymentFormWidget.Description(string)"/>
  public IYandexMoneyPaymentFormWidget Description(string description)
  {
    if (description is null) throw new ArgumentNullException(nameof(description));
    if (description.IsEmpty()) throw new ArgumentException(nameof(description));

    this.description = description;

    return this;
  }

  /// <inheritdoc cref="IYandexMoneyPaymentFormWidget.Description()"/>
  public string Description() => description;

  /// <inheritdoc cref="IYandexMoneyPaymentFormWidget.AskPayerAddress(bool)"/>
  public IYandexMoneyPaymentFormWidget AskPayerAddress(bool ask)
  {
    askPayerAddress = ask;
    return this;
  }

  /// <inheritdoc cref="IYandexMoneyPaymentFormWidget.AskPayerAddress()"/>
  public bool AskPayerAddress() => askPayerAddress;

  /// <inheritdoc cref="IYandexMoneyPaymentFormWidget.AskPayerComment(bool)"/>
  public IYandexMoneyPaymentFormWidget AskPayerComment(bool ask)
  {
    askPayerComment = ask;
    return this;
  }

  /// <inheritdoc cref="IYandexMoneyPaymentFormWidget.AskPayerComment()"/>
  public bool AskPayerComment() => askPayerComment;

  /// <inheritdoc cref="IYandexMoneyPaymentFormWidget.AskPayerEmail(bool)"/>
  public IYandexMoneyPaymentFormWidget AskPayerEmail(bool ask)
  {
    askPayerEmail = ask;
    return this;
  }

  /// <inheritdoc cref="IYandexMoneyPaymentFormWidget.AskPayerEmail()"/>
  public bool AskPayerEmail() => askPayerEmail;

  /// <inheritdoc cref="IYandexMoneyPaymentFormWidget.AskPayerFullName(bool)"/>
  public IYandexMoneyPaymentFormWidget AskPayerFullName(bool ask)
  {
    askPayerFullName = ask;
    return this;
  }

  /// <inheritdoc cref="IYandexMoneyPaymentFormWidget.AskPayerFullName()"/>
  public bool AskPayerFullName() => askPayerFullName;

  /// <inheritdoc cref="IYandexMoneyPaymentFormWidget.AskPayerPhone(bool)"/>
  public IYandexMoneyPaymentFormWidget AskPayerPhone(bool ask)
  {
    askPayerPhone = ask;
    return this;
  }

  /// <inheritdoc cref="IYandexMoneyPaymentFormWidget.AskPayerPhone()"/>
  public bool AskPayerPhone() => askPayerPhone;

  /// <inheritdoc cref="IYandexMoneyPaymentFormWidget.AskPayerPurpose(bool)"/>
  public IYandexMoneyPaymentFormWidget AskPayerPurpose(bool ask)
  {
    askPayerPurpose = ask;
    return this;
  }

  /// <inheritdoc cref="IYandexMoneyPaymentFormWidget.AskPayerPurpose()"/>
  public bool AskPayerPurpose() => askPayerPurpose;

  /// <inheritdoc cref="IYandexMoneyPaymentFormWidget.Sum(decimal)"/>
  public IYandexMoneyPaymentFormWidget Sum(decimal sum)
  {
    this.sum = sum;
    return this;
  }

  /// <inheritdoc cref="IYandexMoneyPaymentFormWidget.Sum()"/>
  public decimal? Sum() => sum;

  /// <inheritdoc cref="IYandexMoneyPaymentFormWidget.Text(byte)"/>
  public IYandexMoneyPaymentFormWidget Text(byte text)
  {
    this.text = text;
    return this;
  }

  /// <inheritdoc cref="IYandexMoneyPaymentFormWidget.Text()"/>
  public byte Text() => text;

  /// <inheritdoc cref="IWebWidget.ToHtml()"/>
  public override string ToHtml()
  {
    if (Account().IsEmpty() || Description().IsEmpty())
    {
      return string.Empty;
    }

    return new TagBuilder("iframe")
      .Attribute("src", string.Format("https://money.yandex.ru/embed/shop.xml?account={0}&quickpay=shop{1}&writer={2}&{3}={4}&default-sum={5}&button-text=0{6}{7}{8}{9}{10}{11}",
        Account(),
        Cards() ? "&payment-type-choice=on" : string.Empty,
        AskPayerPurpose() ? "buyer" : "seller",
        AskPayerPurpose() ? "targets-hint" : "targets",
        Description(),
        Sum(),
        Text(), 
        AskPayerComment() ? "&comment=on" : string.Empty, 
        AskPayerFullName() ? "&fio=on" : string.Empty, 
        AskPayerEmail() ? "&mail=on" : string.Empty, 
        AskPayerPhone() ? "&phone=on" : string.Empty, 
        AskPayerAddress() ? "&address=on" : string.Empty)
      )
      .Attribute("frameborder", 0)
      .Attribute("allowtransparency", true)
      .Attribute("scrolling", "no")
      .Attribute("width", 450)
      .Attribute("height", AskPayerComment() ? 255 : 200)
      .ToString();
  }
}