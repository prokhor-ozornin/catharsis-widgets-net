using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IYandexMoneyPaymentFormWidget"/>
public class YandexMoneyPaymentFormWidget : WebWidget, IYandexMoneyPaymentFormWidget
{
  private string AccountProperty { get; set; }
  private string DescriptionProperty { get; set; }
  private decimal? SumProperty { get; set; }
  private bool CardsProperty { get; set; } = true;
  private byte TextProperty { get; set; } = (byte) YandexMoneyPaymentFormText.Pay;
  private bool AskPayerPurposeProperty { get; set; }
  private bool AskPayerCommentProperty { get; set; }
  private bool AskPayerFullNameProperty { get; set; }
  private bool AskPayerEmailProperty { get; set; }
  private bool AskPayerPhoneProperty { get; set; }
  private bool AskPayerAddressProperty { get; set; }

  /// <inheritdoc cref="IYandexMoneyPaymentFormWidget.Account(string)"/>
  public IYandexMoneyPaymentFormWidget Account(string account)
  {
    if (account is null) throw new ArgumentNullException(nameof(account));
    if (account.IsEmpty()) throw new ArgumentException(nameof(account));

    AccountProperty = account;

    return this;
  }

  /// <inheritdoc cref="IYandexMoneyPaymentFormWidget.Account()"/>
  public string Account() => AccountProperty;

  /// <inheritdoc cref="IYandexMoneyPaymentFormWidget.Cards(bool)"/>
  public IYandexMoneyPaymentFormWidget Cards(bool enabled)
  {
    CardsProperty = enabled;
    return this;
  }

  /// <inheritdoc cref="IYandexMoneyPaymentFormWidget.Cards()"/>
  public bool Cards() => CardsProperty;

  /// <inheritdoc cref="IYandexMoneyPaymentFormWidget.Description(string)"/>
  public IYandexMoneyPaymentFormWidget Description(string description)
  {
    if (description is null) throw new ArgumentNullException(nameof(description));
    if (description.IsEmpty()) throw new ArgumentException(nameof(description));

    DescriptionProperty = description;

    return this;
  }

  /// <inheritdoc cref="IYandexMoneyPaymentFormWidget.Description()"/>
  public string Description() => DescriptionProperty;

  /// <inheritdoc cref="IYandexMoneyPaymentFormWidget.AskPayerAddress(bool)"/>
  public IYandexMoneyPaymentFormWidget AskPayerAddress(bool enabled)
  {
    AskPayerAddressProperty = enabled;
    return this;
  }

  /// <inheritdoc cref="IYandexMoneyPaymentFormWidget.AskPayerAddress()"/>
  public bool AskPayerAddress() => AskPayerAddressProperty;

  /// <inheritdoc cref="IYandexMoneyPaymentFormWidget.AskPayerComment(bool)"/>
  public IYandexMoneyPaymentFormWidget AskPayerComment(bool enabled)
  {
    AskPayerCommentProperty = enabled;
    return this;
  }

  /// <inheritdoc cref="IYandexMoneyPaymentFormWidget.AskPayerComment()"/>
  public bool AskPayerComment() => AskPayerCommentProperty;

  /// <inheritdoc cref="IYandexMoneyPaymentFormWidget.AskPayerEmail(bool)"/>
  public IYandexMoneyPaymentFormWidget AskPayerEmail(bool enabled)
  {
    AskPayerEmailProperty = enabled;
    return this;
  }

  /// <inheritdoc cref="IYandexMoneyPaymentFormWidget.AskPayerEmail()"/>
  public bool AskPayerEmail() => AskPayerEmailProperty;

  /// <inheritdoc cref="IYandexMoneyPaymentFormWidget.AskPayerFullName(bool)"/>
  public IYandexMoneyPaymentFormWidget AskPayerFullName(bool enabled)
  {
    AskPayerFullNameProperty = enabled;
    return this;
  }

  /// <inheritdoc cref="IYandexMoneyPaymentFormWidget.AskPayerFullName()"/>
  public bool AskPayerFullName() => AskPayerFullNameProperty;

  /// <inheritdoc cref="IYandexMoneyPaymentFormWidget.AskPayerPhone(bool)"/>
  public IYandexMoneyPaymentFormWidget AskPayerPhone(bool enabled)
  {
    AskPayerPhoneProperty = enabled;
    return this;
  }

  /// <inheritdoc cref="IYandexMoneyPaymentFormWidget.AskPayerPhone()"/>
  public bool AskPayerPhone() => AskPayerPhoneProperty;

  /// <inheritdoc cref="IYandexMoneyPaymentFormWidget.AskPayerPurpose(bool)"/>
  public IYandexMoneyPaymentFormWidget AskPayerPurpose(bool enabled)
  {
    AskPayerPurposeProperty = enabled;
    return this;
  }

  /// <inheritdoc cref="IYandexMoneyPaymentFormWidget.AskPayerPurpose()"/>
  public bool AskPayerPurpose() => AskPayerPurposeProperty;

  /// <inheritdoc cref="IYandexMoneyPaymentFormWidget.Sum(decimal)"/>
  public IYandexMoneyPaymentFormWidget Sum(decimal sum)
  {
    SumProperty = sum;
    return this;
  }

  /// <inheritdoc cref="IYandexMoneyPaymentFormWidget.Sum()"/>
  public decimal? Sum() => SumProperty;

  /// <inheritdoc cref="IYandexMoneyPaymentFormWidget.Text(byte)"/>
  public IYandexMoneyPaymentFormWidget Text(byte text)
  {
    TextProperty = text;
    return this;
  }

  /// <inheritdoc cref="IYandexMoneyPaymentFormWidget.Text()"/>
  public byte Text() => TextProperty;

  /// <inheritdoc cref="IHtmlContent.ToHtml()"/>
  public override string ToHtml()
  {
    if (Account().IsEmpty() || Description().IsEmpty())
    {
      return string.Empty;
    }

    return new TagBuilder("iframe")
      .Attribute("src", $"https://money.yandex.ru/embed/shop.xml?account={Account()}&quickpay=shop{(Cards() ? "&payment-type-choice=on" : string.Empty)}&writer={(AskPayerPurpose() ? "buyer" : "seller")}&{(AskPayerPurpose() ? "targets-hint" : "targets")}={Description()}&default-sum={Sum()}&button-text=0{Text()}{(AskPayerComment() ? "&comment=on" : string.Empty)}{(AskPayerFullName() ? "&fio=on" : string.Empty)}{(AskPayerEmail() ? "&mail=on" : string.Empty)}{(AskPayerPhone() ? "&phone=on" : string.Empty)}{(AskPayerAddress() ? "&address=on" : string.Empty)}")
      .Attribute("frameborder", 0)
      .Attribute("allowtransparency", true)
      .Attribute("scrolling", "no")
      .Attribute("width", 450)
      .Attribute("height", AskPayerComment() ? 255 : 200)
      .ToString();
  }
}