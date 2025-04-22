using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IYandexMoneyButtonWidget"/>
public class YandexMoneyButtonWidget : WebWidget, IYandexMoneyButtonWidget
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string AccountProperty { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string ColorProperty { get; set; } = YandexMoneyButtonColor.Orange.ToString().ToLowerInvariant();

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string DescriptionProperty { get; set; }

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

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string SizeProperty { get; set; } = "l";

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual decimal? SumProperty { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual byte TextProperty { get; set; } = (byte) YandexMoneyButtonText.Pay;

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string TypeProperty { get; set; } = "yamoney-payment-type";

  /// <inheritdoc cref="IYandexMoneyButtonWidget.Account(string)"/>
  public virtual IYandexMoneyButtonWidget Account(string account)
  {
    if (account is null) throw new ArgumentNullException(nameof(account));
    if (account.IsEmpty()) throw new ArgumentException(nameof(account));

    AccountProperty = account;

    return this;
  }

  /// <inheritdoc cref="IYandexMoneyButtonWidget.Color(string)"/>
  public virtual IYandexMoneyButtonWidget Color(string color)
  {
    if (color is null) throw new ArgumentNullException(nameof(color));
    if (color.IsEmpty()) throw new ArgumentException(nameof(color));

    ColorProperty = color;

    return this;
  }

  /// <inheritdoc cref="IYandexMoneyButtonWidget.Description(string)"/>
  public virtual IYandexMoneyButtonWidget Description(string description)
  {
    if (description is null) throw new ArgumentNullException(nameof(description));
    if (description.IsEmpty()) throw new ArgumentException(nameof(description));

    DescriptionProperty = description;
    return this;
  }

  /// <inheritdoc cref="IYandexMoneyButtonWidget.AskPayerFullName(bool)"/>
  public virtual IYandexMoneyButtonWidget AskPayerFullName(bool enabled)
  {
    AskPayerFullNameProperty = enabled;
    return this;
  }

  /// <inheritdoc cref="IYandexMoneyButtonWidget.AskPayerEmail(bool)"/>
  public virtual IYandexMoneyButtonWidget AskPayerEmail(bool enabled)
  {
    AskPayerEmailProperty = enabled;
    return this;
  }

  /// <inheritdoc cref="IYandexMoneyButtonWidget.AskPayerPhone(bool)"/>
  public virtual IYandexMoneyButtonWidget AskPayerPhone(bool enabled)
  {
    AskPayerPhoneProperty = enabled;
    return this;
  }

  /// <inheritdoc cref="IYandexMoneyButtonWidget.AskPayerAddress(bool)"/>
  public virtual IYandexMoneyButtonWidget AskPayerAddress(bool enabled)
  {
    AskPayerAddressProperty = enabled;
    return this;
  }

  /// <inheritdoc cref="IYandexMoneyButtonWidget.Size(string)"/>
  public virtual IYandexMoneyButtonWidget Size(string size)
  {
    if (size is null) throw new ArgumentNullException(nameof(size));
    if (size.IsEmpty()) throw new ArgumentException(nameof(size));

    SizeProperty = size;

    return this;
  }

  /// <inheritdoc cref="IYandexMoneyButtonWidget.Sum(decimal)"/>
  public virtual IYandexMoneyButtonWidget Sum(decimal sum)
  {
    SumProperty = sum;
    return this;
  }

  /// <inheritdoc cref="IYandexMoneyButtonWidget.Text(byte)"/>
  public virtual IYandexMoneyButtonWidget Text(byte text)
  {
    TextProperty = text;
    return this;
  }

  /// <inheritdoc cref="IYandexMoneyButtonWidget.Type(string)"/>
  public virtual IYandexMoneyButtonWidget Type(string type)
  {
    if (type is null) throw new ArgumentNullException(nameof(type));
    if (type.IsEmpty()) throw new ArgumentException(nameof(type));

    TypeProperty = type;
    return this;
  }

  /// <inheritdoc cref="IHtmlContent.ToHtml()"/>
  public override string ToHtml()
  {
    if (AccountProperty.IsUnset() || SumProperty is null || DescriptionProperty.IsUnset())
    {
      return string.Empty;
    }

    var width = (YandexMoneyButtonText) TextProperty switch
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
      .Attribute("src", $"https://money.yandex.ru/embed/small.xml?account={AccountProperty}&quickpay=small&{TypeProperty}=on&button-text=0{TextProperty}&button-size={SizeProperty}&button-color={ColorProperty}&targets={DescriptionProperty}&default-sum={SumProperty}{(AskPayerFullNameProperty ? "&fio=on" : string.Empty)}{(AskPayerEmailProperty ? "&mail=on" : string.Empty)}{(AskPayerPhoneProperty ? "&phone=on" : string.Empty)}{(AskPayerAddressProperty ? "&address=on" : string.Empty)}")
      .Attribute("frameborder", 0)
      .Attribute("allowtransparency", true)
      .Attribute("scrolling", "no")
      .Attribute("width", width)
      .Attribute("height", 54)
      .ToString();
  }
}