using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IYandexMoneyButtonWidget"/>
public class YandexMoneyButtonWidget : WebWidget, IYandexMoneyButtonWidget
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string AccountValue { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string ColorValue { get; set; } = nameof(YandexMoneyButtonColor.Orange).ToLowerInvariant();

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string DescriptionValue { get; set; }

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

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string SizeValue { get; set; } = "l";

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual decimal? SumValue { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual byte TextValue { get; set; } = (byte) YandexMoneyButtonText.Pay;

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string TypeValue { get; set; } = "yamoney-payment-type";

  /// <inheritdoc cref="IYandexMoneyButtonWidget.Account(string)"/>
  public virtual IYandexMoneyButtonWidget Account(string account)
  {
    if (account is null) throw new ArgumentNullException(nameof(account));
    if (account.IsEmpty()) throw new ArgumentException(nameof(account));

    AccountValue = account;

    return this;
  }

  /// <inheritdoc cref="IYandexMoneyButtonWidget.Color(string)"/>
  public virtual IYandexMoneyButtonWidget Color(string color)
  {
    if (color is null) throw new ArgumentNullException(nameof(color));
    if (color.IsEmpty()) throw new ArgumentException(nameof(color));

    ColorValue = color;

    return this;
  }

  /// <inheritdoc cref="IYandexMoneyButtonWidget.Description(string)"/>
  public virtual IYandexMoneyButtonWidget Description(string description)
  {
    if (description is null) throw new ArgumentNullException(nameof(description));
    if (description.IsEmpty()) throw new ArgumentException(nameof(description));

    DescriptionValue = description;
    return this;
  }

  /// <inheritdoc cref="IYandexMoneyButtonWidget.AskPayerFullName(bool)"/>
  public virtual IYandexMoneyButtonWidget AskPayerFullName(bool enabled)
  {
    AskPayerFullNameValue = enabled;
    return this;
  }

  /// <inheritdoc cref="IYandexMoneyButtonWidget.AskPayerEmail(bool)"/>
  public virtual IYandexMoneyButtonWidget AskPayerEmail(bool enabled)
  {
    AskPayerEmailValue = enabled;
    return this;
  }

  /// <inheritdoc cref="IYandexMoneyButtonWidget.AskPayerPhone(bool)"/>
  public virtual IYandexMoneyButtonWidget AskPayerPhone(bool enabled)
  {
    AskPayerPhoneValue = enabled;
    return this;
  }

  /// <inheritdoc cref="IYandexMoneyButtonWidget.AskPayerAddress(bool)"/>
  public virtual IYandexMoneyButtonWidget AskPayerAddress(bool enabled)
  {
    AskPayerAddressValue = enabled;
    return this;
  }

  /// <inheritdoc cref="IYandexMoneyButtonWidget.Size(string)"/>
  public virtual IYandexMoneyButtonWidget Size(string size)
  {
    if (size is null) throw new ArgumentNullException(nameof(size));
    if (size.IsEmpty()) throw new ArgumentException(nameof(size));

    SizeValue = size;

    return this;
  }

  /// <inheritdoc cref="IYandexMoneyButtonWidget.Sum(decimal)"/>
  public virtual IYandexMoneyButtonWidget Sum(decimal sum)
  {
    SumValue = sum;
    return this;
  }

  /// <inheritdoc cref="IYandexMoneyButtonWidget.Text(byte)"/>
  public virtual IYandexMoneyButtonWidget Text(byte text)
  {
    TextValue = text;
    return this;
  }

  /// <inheritdoc cref="IYandexMoneyButtonWidget.Type(string)"/>
  public virtual IYandexMoneyButtonWidget Type(string type)
  {
    if (type is null) throw new ArgumentNullException(nameof(type));
    if (type.IsEmpty()) throw new ArgumentException(nameof(type));

    TypeValue = type;
    return this;
  }

  /// <inheritdoc cref="ICloneable.Clone()"/>
  public override object Clone() => new YandexMoneyButtonWidget
  {
    AccountValue = AccountValue,
    ColorValue = ColorValue,
    DescriptionValue = DescriptionValue,
    AskPayerFullNameValue = AskPayerFullNameValue,
    AskPayerEmailValue = AskPayerEmailValue,
    AskPayerPhoneValue = AskPayerPhoneValue,
    AskPayerAddressValue = AskPayerAddressValue,
    SizeValue = SizeValue,
    SumValue = SumValue,
    TextValue = TextValue,
    TypeValue = TypeValue
  };

  /// <inheritdoc cref="IWebWidget.ToHtml()"/>
  public override string ToHtml()
  {
    if (AccountValue.IsUnset() || SumValue is null || DescriptionValue.IsUnset())
    {
      return string.Empty;
    }

    var width = (YandexMoneyButtonText) TextValue switch
    {
      YandexMoneyButtonText.Pay => 229,
      YandexMoneyButtonText.Buy => 197,
      YandexMoneyButtonText.Transfer => 242,
      YandexMoneyButtonText.Donate => 283,
      YandexMoneyButtonText.Give => 231,
      YandexMoneyButtonText.Support => 262,
      _ => 283
    };

    return new TagBuilder("iframe")
      .Attribute("src", $"https://money.yandex.ru/embed/small.xml?account={AccountValue}&quickpay=small&{TypeValue}=on&button-text=0{TextValue}&button-size={SizeValue}&button-color={ColorValue}&targets={DescriptionValue}&default-sum={SumValue}{(AskPayerFullNameValue ? "&fio=on" : string.Empty)}{(AskPayerEmailValue ? "&mail=on" : string.Empty)}{(AskPayerPhoneValue ? "&phone=on" : string.Empty)}{(AskPayerAddressValue ? "&address=on" : string.Empty)}")
      .Attribute("frameborder", 0)
      .Attribute("allowtransparency", true)
      .Attribute("scrolling", "no")
      .Attribute("width", width)
      .Attribute("height", 54)
      .ToString();
  }
}