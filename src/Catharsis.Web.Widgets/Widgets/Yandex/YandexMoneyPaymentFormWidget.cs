using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IYandexMoneyPaymentFormWidget"/>
public class YandexMoneyPaymentFormWidget : WebWidget, IYandexMoneyPaymentFormWidget
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string AccountValue { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string DescriptionValue { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual decimal? SumValue { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual bool CardsValue { get; set; } = true;

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual byte TextValue { get; set; } = (byte) YandexMoneyPaymentFormText.Pay;

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual bool AskPayerPurposeValue { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual bool AskPayerCommentValue { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual bool AskPayerFullNameValue { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual bool AskPayerEmailValue { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual bool AskPayerPhoneValue { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual bool AskPayerAddressValue { get; set; }

  /// <inheritdoc cref="IYandexMoneyPaymentFormWidget.Account(string)"/>
  public virtual IYandexMoneyPaymentFormWidget Account(string account)
  {
    if (account is null) throw new ArgumentNullException(nameof(account));
    if (account.IsEmpty()) throw new ArgumentException(nameof(account));

    AccountValue = account;

    return this;
  }

  /// <inheritdoc cref="IYandexMoneyPaymentFormWidget.Cards(bool)"/>
  public virtual IYandexMoneyPaymentFormWidget Cards(bool enabled)
  {
    CardsValue = enabled;
    return this;
  }

  /// <inheritdoc cref="IYandexMoneyPaymentFormWidget.Description(string)"/>
  public virtual IYandexMoneyPaymentFormWidget Description(string description)
  {
    if (description is null) throw new ArgumentNullException(nameof(description));
    if (description.IsEmpty()) throw new ArgumentException(nameof(description));

    DescriptionValue = description;

    return this;
  }

  /// <inheritdoc cref="IYandexMoneyPaymentFormWidget.AskPayerAddress(bool)"/>
  public virtual IYandexMoneyPaymentFormWidget AskPayerAddress(bool enabled)
  {
    AskPayerAddressValue = enabled;
    return this;
  }

  /// <inheritdoc cref="IYandexMoneyPaymentFormWidget.AskPayerComment(bool)"/>
  public virtual IYandexMoneyPaymentFormWidget AskPayerComment(bool enabled)
  {
    AskPayerCommentValue = enabled;
    return this;
  }

  /// <inheritdoc cref="IYandexMoneyPaymentFormWidget.AskPayerEmail(bool)"/>
  public virtual IYandexMoneyPaymentFormWidget AskPayerEmail(bool enabled)
  {
    AskPayerEmailValue = enabled;
    return this;
  }

  /// <inheritdoc cref="IYandexMoneyPaymentFormWidget.AskPayerFullName(bool)"/>
  public virtual IYandexMoneyPaymentFormWidget AskPayerFullName(bool enabled)
  {
    AskPayerFullNameValue = enabled;
    return this;
  }

  /// <inheritdoc cref="IYandexMoneyPaymentFormWidget.AskPayerPhone(bool)"/>
  public virtual IYandexMoneyPaymentFormWidget AskPayerPhone(bool enabled)
  {
    AskPayerPhoneValue = enabled;
    return this;
  }

  /// <inheritdoc cref="IYandexMoneyPaymentFormWidget.AskPayerPurpose(bool)"/>
  public virtual IYandexMoneyPaymentFormWidget AskPayerPurpose(bool enabled)
  {
    AskPayerPurposeValue = enabled;
    return this;
  }

  /// <inheritdoc cref="IYandexMoneyPaymentFormWidget.Sum(decimal)"/>
  public virtual IYandexMoneyPaymentFormWidget Sum(decimal sum)
  {
    SumValue = sum;
    return this;
  }

  /// <inheritdoc cref="IYandexMoneyPaymentFormWidget.Text(byte)"/>
  public virtual IYandexMoneyPaymentFormWidget Text(byte text)
  {
    TextValue = text;
    return this;
  }

  /// <inheritdoc cref="ICloneable.Clone()"/>
  public override object Clone() => new YandexMoneyPaymentFormWidget
  {
    AccountValue = AccountValue,
    DescriptionValue = DescriptionValue,
    SumValue = SumValue,
    CardsValue = CardsValue,
    TextValue = TextValue,
    AskPayerPurposeValue = AskPayerPurposeValue,
    AskPayerCommentValue = AskPayerCommentValue,
    AskPayerFullNameValue = AskPayerFullNameValue,
    AskPayerEmailValue = AskPayerEmailValue,
    AskPayerPhoneValue = AskPayerPhoneValue,
    AskPayerAddressValue = AskPayerAddressValue
  };

  /// <inheritdoc cref="IWebWidget.ToHtml()"/>
  public override string ToHtml() => AccountValue.IsUnset() || DescriptionValue.IsUnset() ? string.Empty : new TagBuilder("iframe")
      .Attribute("src", $"https://money.yandex.ru/embed/shop.xml?account={AccountValue}&quickpay=shop{(CardsValue ? "&payment-type-choice=on" : string.Empty)}&writer={(AskPayerPurposeValue ? "buyer" : "seller")}&{(AskPayerPurposeValue ? "targets-hint" : "targets")}={DescriptionValue}&default-sum={SumValue}&button-text=0{TextValue}{(AskPayerCommentValue ? "&comment=on" : string.Empty)}{(AskPayerFullNameValue ? "&fio=on" : string.Empty)}{(AskPayerEmailValue ? "&mail=on" : string.Empty)}{(AskPayerPhoneValue ? "&phone=on" : string.Empty)}{(AskPayerAddressValue ? "&address=on" : string.Empty)}")
      .Attribute("frameborder", 0)
      .Attribute("allowtransparency", true)
      .Attribute("scrolling", "no")
      .Attribute("width", 450)
      .Attribute("height", AskPayerCommentValue ? 255 : 200)
      .ToString();
}