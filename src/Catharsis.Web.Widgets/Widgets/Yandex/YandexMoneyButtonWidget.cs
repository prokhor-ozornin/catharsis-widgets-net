using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IYandexMoneyButtonWidget"/>
public class YandexMoneyButtonWidget : WebWidget, IYandexMoneyButtonWidget
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

  /// <inheritdoc cref="IYandexMoneyButtonWidget.Account(string)"/>
  public IYandexMoneyButtonWidget Account(string account)
  {
    if (account is null) throw new ArgumentNullException(nameof(account));
    if (account.IsEmpty()) throw new ArgumentException(nameof(account));

    this.account = account;

    return this;
  }

  /// <inheritdoc cref="IYandexMoneyButtonWidget.Account()"/>
  public string Account() => account;

  /// <inheritdoc cref="IYandexMoneyButtonWidget.Color(string)"/>
  public IYandexMoneyButtonWidget Color(string color)
  {
    if (color is null) throw new ArgumentNullException(nameof(color));
    if (color.IsEmpty()) throw new ArgumentException(nameof(color));

    this.color = color;

    return this;
  }

  /// <inheritdoc cref="IYandexMoneyButtonWidget.Color()"/>
  public string Color() => color;

  /// <inheritdoc cref="IYandexMoneyButtonWidget.Description(string)"/>
  public IYandexMoneyButtonWidget Description(string description)
  {
    if (description is null) throw new ArgumentNullException(nameof(description));
    if (description.IsEmpty()) throw new ArgumentException(nameof(description));

    this.description = description;
    return this;
  }

  /// <inheritdoc cref="IYandexMoneyButtonWidget.Description()"/>
  public string Description() => description;

  /// <inheritdoc cref="IYandexMoneyButtonWidget.AskPayerFullName(bool)"/>
  public IYandexMoneyButtonWidget AskPayerFullName(bool enabled)
  {
    askPayerFullName = enabled;
    return this;
  }

  /// <inheritdoc cref="IYandexMoneyButtonWidget.AskPayerFullName()"/>
  public bool AskPayerFullName() => askPayerFullName;

  /// <inheritdoc cref="IYandexMoneyButtonWidget.AskPayerEmail(bool)"/>
  public IYandexMoneyButtonWidget AskPayerEmail(bool enabled)
  {
    askPayerEmail = enabled;
    return this;
  }

  /// <inheritdoc cref="IYandexMoneyButtonWidget.AskPayerEmail()"/>
  public bool AskPayerEmail() => askPayerEmail;

  /// <inheritdoc cref="IYandexMoneyButtonWidget.AskPayerPhone(bool)"/>
  public IYandexMoneyButtonWidget AskPayerPhone(bool enabled)
  {
    askPayerPhone = enabled;
    return this;
  }

  /// <inheritdoc cref="IYandexMoneyButtonWidget.AskPayerPhone()"/>
  public bool AskPayerPhone() => askPayerPhone;

  /// <inheritdoc cref="IYandexMoneyButtonWidget.AskPayerAddress(bool)"/>
  public IYandexMoneyButtonWidget AskPayerAddress(bool enabled)
  {
    askPayerAddress = enabled;
    return this;
  }

  /// <inheritdoc cref="IYandexMoneyButtonWidget.AskPayerAddress()"/>
  public bool AskPayerAddress() => askPayerAddress;

  /// <inheritdoc cref="IYandexMoneyButtonWidget.Size(string)"/>
  public IYandexMoneyButtonWidget Size(string size)
  {
    if (size is null) throw new ArgumentNullException(nameof(size));
    if (size.IsEmpty()) throw new ArgumentException(nameof(size));

    this.size = size;

    return this;
  }

  /// <inheritdoc cref="IYandexMoneyButtonWidget.Size()"/>
  public string Size() => size;

  /// <inheritdoc cref="IYandexMoneyButtonWidget.Sum(decimal)"/>
  public IYandexMoneyButtonWidget Sum(decimal sum)
  {
    this.sum = sum;
    return this;
  }

  /// <inheritdoc cref="IYandexMoneyButtonWidget.Sum()"/>
  public decimal? Sum() => sum;

  /// <inheritdoc cref="IYandexMoneyButtonWidget.Text(byte)"/>
  public IYandexMoneyButtonWidget Text(byte text)
  {
    this.text = text;
    return this;
  }

  /// <inheritdoc cref="IYandexMoneyButtonWidget.Text()"/>
  public byte Text() => text;

  /// <inheritdoc cref="IYandexMoneyButtonWidget.Type(string)"/>
  public IYandexMoneyButtonWidget Type(string type)
  {
    if (type is null) throw new ArgumentNullException(nameof(type));
    if (type.IsEmpty()) throw new ArgumentException(nameof(type));

    this.type = type;
    return this;
  }

  /// <inheritdoc cref="IYandexMoneyButtonWidget.Type()"/>
  public string Type() => type;

  /// <inheritdoc cref="IWebWidget.ToHtml()"/>
  public override string ToHtml()
  {
    if (Account().IsEmpty() || Sum() is null || Description().IsEmpty())
    {
      return string.Empty;
    }

    int width = (YandexMoneyButtonText)Text() switch
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
      .Attribute("src", string.Format("https://money.yandex.ru/embed/small.xml?account={0}&quickpay=small&{1}=on&button-text=0{2}&button-size={3}&button-color={4}&targets={5}&default-sum={6}{7}{8}{9}{10}", Account(), Type(), Text(), Size(), Color(), Description(), Sum(), AskPayerFullName() ? "&fio=on" : string.Empty, AskPayerEmail() ? "&mail=on" : string.Empty, AskPayerPhone() ? "&phone=on" : string.Empty, AskPayerAddress() ? "&address=on" : string.Empty))
      .Attribute("frameborder", 0)
      .Attribute("allowtransparency", true)
      .Attribute("scrolling", "no")
      .Attribute("width", width)
      .Attribute("height", 54)
      .ToString();
  }
}