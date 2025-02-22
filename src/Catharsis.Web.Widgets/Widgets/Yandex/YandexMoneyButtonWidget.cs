using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IYandexMoneyButtonWidget"/>
public class YandexMoneyButtonWidget : WebWidget, IYandexMoneyButtonWidget
{
  private string AccountProperty { get; set; }
  private string ColorProperty { get; set; } = YandexMoneyButtonColor.Orange.ToString().ToLowerInvariant();
  private string DescriptionProperty { get; set; }
  private bool AskPayerFullNameProperty { get; set; }
  private bool AskPayerEmailProperty { get; set; }
  private bool AskPayerPhoneProperty { get; set; }
  private bool AskPayerAddressProperty { get; set; }
  private string SizeProperty { get; set; } = "l";
  private decimal? SumProperty { get; set; }
  private byte TextProperty { get; set; } = (byte) YandexMoneyButtonText.Pay;
  private string TypeProperty { get; set; } = "yamoney-payment-type";

  /// <inheritdoc cref="IYandexMoneyButtonWidget.Account(string)"/>
  public IYandexMoneyButtonWidget Account(string account)
  {
    if (account is null) throw new ArgumentNullException(nameof(account));
    if (account.IsEmpty()) throw new ArgumentException(nameof(account));

    AccountProperty = account;

    return this;
  }

  /// <inheritdoc cref="IYandexMoneyButtonWidget.Account()"/>
  public string Account() => AccountProperty;

  /// <inheritdoc cref="IYandexMoneyButtonWidget.Color(string)"/>
  public IYandexMoneyButtonWidget Color(string color)
  {
    if (color is null) throw new ArgumentNullException(nameof(color));
    if (color.IsEmpty()) throw new ArgumentException(nameof(color));

    ColorProperty = color;

    return this;
  }

  /// <inheritdoc cref="IYandexMoneyButtonWidget.Color()"/>
  public string Color() => ColorProperty;

  /// <inheritdoc cref="IYandexMoneyButtonWidget.Description(string)"/>
  public IYandexMoneyButtonWidget Description(string description)
  {
    if (description is null) throw new ArgumentNullException(nameof(description));
    if (description.IsEmpty()) throw new ArgumentException(nameof(description));

    DescriptionProperty = description;
    return this;
  }

  /// <inheritdoc cref="IYandexMoneyButtonWidget.Description()"/>
  public string Description() => DescriptionProperty;

  /// <inheritdoc cref="IYandexMoneyButtonWidget.AskPayerFullName(bool)"/>
  public IYandexMoneyButtonWidget AskPayerFullName(bool enabled)
  {
    AskPayerFullNameProperty = enabled;
    return this;
  }

  /// <inheritdoc cref="IYandexMoneyButtonWidget.AskPayerFullName()"/>
  public bool AskPayerFullName() => AskPayerFullNameProperty;

  /// <inheritdoc cref="IYandexMoneyButtonWidget.AskPayerEmail(bool)"/>
  public IYandexMoneyButtonWidget AskPayerEmail(bool enabled)
  {
    AskPayerEmailProperty = enabled;
    return this;
  }

  /// <inheritdoc cref="IYandexMoneyButtonWidget.AskPayerEmail()"/>
  public bool AskPayerEmail() => AskPayerEmailProperty;

  /// <inheritdoc cref="IYandexMoneyButtonWidget.AskPayerPhone(bool)"/>
  public IYandexMoneyButtonWidget AskPayerPhone(bool enabled)
  {
    AskPayerPhoneProperty = enabled;
    return this;
  }

  /// <inheritdoc cref="IYandexMoneyButtonWidget.AskPayerPhone()"/>
  public bool AskPayerPhone() => AskPayerPhoneProperty;

  /// <inheritdoc cref="IYandexMoneyButtonWidget.AskPayerAddress(bool)"/>
  public IYandexMoneyButtonWidget AskPayerAddress(bool enabled)
  {
    AskPayerAddressProperty = enabled;
    return this;
  }

  /// <inheritdoc cref="IYandexMoneyButtonWidget.AskPayerAddress()"/>
  public bool AskPayerAddress() => AskPayerAddressProperty;

  /// <inheritdoc cref="IYandexMoneyButtonWidget.Size(string)"/>
  public IYandexMoneyButtonWidget Size(string size)
  {
    if (size is null) throw new ArgumentNullException(nameof(size));
    if (size.IsEmpty()) throw new ArgumentException(nameof(size));

    SizeProperty = size;

    return this;
  }

  /// <inheritdoc cref="IYandexMoneyButtonWidget.Size()"/>
  public string Size() => SizeProperty;

  /// <inheritdoc cref="IYandexMoneyButtonWidget.Sum(decimal)"/>
  public IYandexMoneyButtonWidget Sum(decimal sum)
  {
    SumProperty = sum;
    return this;
  }

  /// <inheritdoc cref="IYandexMoneyButtonWidget.Sum()"/>
  public decimal? Sum() => SumProperty;

  /// <inheritdoc cref="IYandexMoneyButtonWidget.Text(byte)"/>
  public IYandexMoneyButtonWidget Text(byte text)
  {
    TextProperty = text;
    return this;
  }

  /// <inheritdoc cref="IYandexMoneyButtonWidget.Text()"/>
  public byte Text() => TextProperty;

  /// <inheritdoc cref="IYandexMoneyButtonWidget.Type(string)"/>
  public IYandexMoneyButtonWidget Type(string type)
  {
    if (type is null) throw new ArgumentNullException(nameof(type));
    if (type.IsEmpty()) throw new ArgumentException(nameof(type));

    TypeProperty = type;
    return this;
  }

  /// <inheritdoc cref="IYandexMoneyButtonWidget.Type()"/>
  public string Type() => TypeProperty;

  /// <inheritdoc cref="IHtmlContent.ToHtml()"/>
  public override string ToHtml()
  {
    if (Account().IsEmpty() || Sum() is null || Description().IsEmpty())
    {
      return string.Empty;
    }

    var width = (YandexMoneyButtonText)Text() switch
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
      .Attribute("src", $"https://money.yandex.ru/embed/small.xml?account={Account()}&quickpay=small&{Type()}=on&button-text=0{Text()}&button-size={Size()}&button-color={Color()}&targets={Description()}&default-sum={Sum()}{(AskPayerFullName() ? "&fio=on" : string.Empty)}{(AskPayerEmail() ? "&mail=on" : string.Empty)}{(AskPayerPhone() ? "&phone=on" : string.Empty)}{(AskPayerAddress() ? "&address=on" : string.Empty)}")
      .Attribute("frameborder", 0)
      .Attribute("allowtransparency", true)
      .Attribute("scrolling", "no")
      .Attribute("width", width)
      .Attribute("height", 54)
      .ToString();
  }
}