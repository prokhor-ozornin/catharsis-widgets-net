using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IYandexMoneyPaymentFormWidget"/>
public class YandexMoneyPaymentFormWidget : WebWidget, IYandexMoneyPaymentFormWidget
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string AccountProperty { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string DescriptionProperty { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual decimal? SumProperty { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual bool CardsProperty { get; set; } = true;

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual byte TextProperty { get; set; } = (byte) YandexMoneyPaymentFormText.Pay;

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual bool AskPayerPurposeProperty { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual bool AskPayerCommentProperty { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual bool AskPayerFullNameProperty { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual bool AskPayerEmailProperty { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual bool AskPayerPhoneProperty { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual bool AskPayerAddressProperty { get; set; }

  /// <inheritdoc cref="IYandexMoneyPaymentFormWidget.Account(string)"/>
  public virtual IYandexMoneyPaymentFormWidget Account(string account)
  {
    if (account is null) throw new ArgumentNullException(nameof(account));
    if (account.IsEmpty()) throw new ArgumentException(nameof(account));

    AccountProperty = account;

    return this;
  }

  /// <inheritdoc cref="IYandexMoneyPaymentFormWidget.Cards(bool)"/>
  public virtual IYandexMoneyPaymentFormWidget Cards(bool enabled)
  {
    CardsProperty = enabled;
    return this;
  }

  /// <inheritdoc cref="IYandexMoneyPaymentFormWidget.Description(string)"/>
  public virtual IYandexMoneyPaymentFormWidget Description(string description)
  {
    if (description is null) throw new ArgumentNullException(nameof(description));
    if (description.IsEmpty()) throw new ArgumentException(nameof(description));

    DescriptionProperty = description;

    return this;
  }

  /// <inheritdoc cref="IYandexMoneyPaymentFormWidget.AskPayerAddress(bool)"/>
  public virtual IYandexMoneyPaymentFormWidget AskPayerAddress(bool enabled)
  {
    AskPayerAddressProperty = enabled;
    return this;
  }

  /// <inheritdoc cref="IYandexMoneyPaymentFormWidget.AskPayerComment(bool)"/>
  public virtual IYandexMoneyPaymentFormWidget AskPayerComment(bool enabled)
  {
    AskPayerCommentProperty = enabled;
    return this;
  }

  /// <inheritdoc cref="IYandexMoneyPaymentFormWidget.AskPayerEmail(bool)"/>
  public virtual IYandexMoneyPaymentFormWidget AskPayerEmail(bool enabled)
  {
    AskPayerEmailProperty = enabled;
    return this;
  }

  /// <inheritdoc cref="IYandexMoneyPaymentFormWidget.AskPayerFullName(bool)"/>
  public virtual IYandexMoneyPaymentFormWidget AskPayerFullName(bool enabled)
  {
    AskPayerFullNameProperty = enabled;
    return this;
  }

  /// <inheritdoc cref="IYandexMoneyPaymentFormWidget.AskPayerPhone(bool)"/>
  public virtual IYandexMoneyPaymentFormWidget AskPayerPhone(bool enabled)
  {
    AskPayerPhoneProperty = enabled;
    return this;
  }

  /// <inheritdoc cref="IYandexMoneyPaymentFormWidget.AskPayerPurpose(bool)"/>
  public virtual IYandexMoneyPaymentFormWidget AskPayerPurpose(bool enabled)
  {
    AskPayerPurposeProperty = enabled;
    return this;
  }

  /// <inheritdoc cref="IYandexMoneyPaymentFormWidget.Sum(decimal)"/>
  public virtual IYandexMoneyPaymentFormWidget Sum(decimal sum)
  {
    SumProperty = sum;
    return this;
  }

  /// <inheritdoc cref="IYandexMoneyPaymentFormWidget.Text(byte)"/>
  public virtual IYandexMoneyPaymentFormWidget Text(byte text)
  {
    TextProperty = text;
    return this;
  }

  public override object Clone() => new YandexMoneyPaymentFormWidget { };

  /// <inheritdoc cref="IWebWidget.ToHtml()"/>
  public override string ToHtml() => AccountProperty.IsUnset() || DescriptionProperty.IsUnset() ? string.Empty : new TagBuilder("iframe")
      .Attribute("src", $"https://money.yandex.ru/embed/shop.xml?account={AccountProperty}&quickpay=shop{(CardsProperty ? "&payment-type-choice=on" : string.Empty)}&writer={(AskPayerPurposeProperty ? "buyer" : "seller")}&{(AskPayerPurposeProperty ? "targets-hint" : "targets")}={DescriptionProperty}&default-sum={SumProperty}&button-text=0{TextProperty}{(AskPayerCommentProperty ? "&comment=on" : string.Empty)}{(AskPayerFullNameProperty ? "&fio=on" : string.Empty)}{(AskPayerEmailProperty ? "&mail=on" : string.Empty)}{(AskPayerPhoneProperty ? "&phone=on" : string.Empty)}{(AskPayerAddressProperty ? "&address=on" : string.Empty)}")
      .Attribute("frameborder", 0)
      .Attribute("allowtransparency", true)
      .Attribute("scrolling", "no")
      .Attribute("width", 450)
      .Attribute("height", AskPayerCommentProperty ? 255 : 200)
      .ToString();
}