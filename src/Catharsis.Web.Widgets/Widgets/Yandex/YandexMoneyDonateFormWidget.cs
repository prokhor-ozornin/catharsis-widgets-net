using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IYandexMoneyDonateFormWidget"/>
public class YandexMoneyDonateFormWidget : WebWidget, IYandexMoneyDonateFormWidget
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

  /// <inheritdoc cref="IYandexMoneyDonateFormWidget.Account(string)"/>
  public IYandexMoneyDonateFormWidget Account(string account)
  {
    if (account is null) throw new ArgumentNullException(nameof(account));
    if (account.IsEmpty()) throw new ArgumentException(nameof(account));

    this.account = account;
    return this;
  }

  /// <inheritdoc cref="IYandexMoneyDonateFormWidget.Account()"/>
  public string Account() => account;

  /// <inheritdoc cref="IYandexMoneyDonateFormWidget.Cards(bool)"/>
  public IYandexMoneyDonateFormWidget Cards(bool enabled)
  {
    cards = enabled;
    return this;
  }

  /// <inheritdoc cref="IYandexMoneyDonateFormWidget.Cards()"/>
  public bool Cards() => cards;

  /// <inheritdoc cref="IYandexMoneyDonateFormWidget.DescriptionText(string)"/>
  public IYandexMoneyDonateFormWidget DescriptionText(string description)
  {
    if (description is null) throw new ArgumentNullException(nameof(description));
    if (description.IsEmpty()) throw new ArgumentException(nameof(description));

    descriptionText = description;
    return this;
  }

  /// <inheritdoc cref="IYandexMoneyDonateFormWidget.DescriptionText()"/>
  public string DescriptionText() => descriptionText;

  /// <inheritdoc cref="IYandexMoneyDonateFormWidget.AskPayerComment(bool)"/>
  public IYandexMoneyDonateFormWidget AskPayerComment(bool enabled)
  {
    askPayerComment = enabled;
    return this;
  }

  /// <inheritdoc cref="IYandexMoneyDonateFormWidget.AskPayerComment()"/>
  public bool AskPayerComment() => askPayerComment;

  /// <inheritdoc cref="IYandexMoneyDonateFormWidget.CommentHint(string)"/>
  public IYandexMoneyDonateFormWidget CommentHint(string hint)
  {
    if (hint is null) throw new ArgumentNullException(nameof(hint));
    if (hint.IsEmpty()) throw new ArgumentException(nameof(hint));

    commentHint = hint;
    return this;
  }

  /// <inheritdoc cref="IYandexMoneyDonateFormWidget.CommentHint()"/>
  public string CommentHint() => commentHint;

  /// <inheritdoc cref="IYandexMoneyDonateFormWidget.AskPayerEmail(bool)"/>
  public IYandexMoneyDonateFormWidget AskPayerEmail(bool enabled)
  {
    askPayerEmail = enabled;
    return this;
  }

  /// <inheritdoc cref="IYandexMoneyDonateFormWidget.AskPayerEmail()"/>
  public bool AskPayerEmail() => askPayerEmail;

  /// <inheritdoc cref="IYandexMoneyDonateFormWidget.AskPayerFullName(bool)"/>
  public IYandexMoneyDonateFormWidget AskPayerFullName(bool enabled)
  {
    askPayerFullName = enabled;
    return this;
  }

  /// <inheritdoc cref="IYandexMoneyDonateFormWidget.AskPayerFullName()"/>
  public bool AskPayerFullName() => askPayerFullName;

  /// <inheritdoc cref="IYandexMoneyDonateFormWidget.AskPayerPhone(bool)"/>
  public IYandexMoneyDonateFormWidget AskPayerPhone(bool enabled)
  {
    askPayerPhone = enabled;
    return this;
  }

  /// <inheritdoc cref="IYandexMoneyDonateFormWidget.AskPayerPhone()"/>
  public bool AskPayerPhone() => askPayerPhone;

  /// <inheritdoc cref="IYandexMoneyDonateFormWidget.ProjectName(string)"/>
  public IYandexMoneyDonateFormWidget ProjectName(string name)
  {
    if (name is null) throw new ArgumentNullException(nameof(name));
    if (name.IsEmpty()) throw new ArgumentException(nameof(name));

    projectName = name;

    return this;
  }

  /// <inheritdoc cref="IYandexMoneyDonateFormWidget.ProjectName()"/>
  public string ProjectName() => projectName;

  /// <inheritdoc cref="IYandexMoneyDonateFormWidget.ProjectSite(string)"/>
  public IYandexMoneyDonateFormWidget ProjectSite(string url)
  {
    if (url is null) throw new ArgumentNullException(nameof(url));
    if (url.IsEmpty()) throw new ArgumentException(nameof(url));

    projectSite = url;

    return this;
  }

  /// <inheritdoc cref="IYandexMoneyDonateFormWidget.ProjectSite()"/>
  public string ProjectSite() => projectSite;

  /// <inheritdoc cref="IYandexMoneyDonateFormWidget.Description(bool)"/>
  public IYandexMoneyDonateFormWidget Description(bool enabled)
  {
    description = enabled;
    return this;
  }

  /// <inheritdoc cref="IYandexMoneyDonateFormWidget.Description()"/>
  public bool Description() => description;

  /// <inheritdoc cref="IYandexMoneyDonateFormWidget.Sum(decimal)"/>
  public IYandexMoneyDonateFormWidget Sum(decimal sum)
  {
    this.sum = sum;
    return this;
  }

  /// <inheritdoc cref="IYandexMoneyDonateFormWidget.Sum()"/>
  public decimal? Sum() => sum;

  /// <inheritdoc cref="IYandexMoneyDonateFormWidget.Text(byte)"/>
  public IYandexMoneyDonateFormWidget Text(byte text)
  {
    this.text = text;
    return this;
  }

  /// <inheritdoc cref="IYandexMoneyDonateFormWidget.Text()"/>
  public byte Text() => text;

  /// <inheritdoc cref="IWebWidget.ToHtml()"/>
  public override string ToHtml()
  {
    if (Account().IsEmpty() || DescriptionText().IsEmpty())
    {
      return string.Empty;
    }

    var width = (YandexMoneyDonateFormText)Text() switch
    {
      YandexMoneyDonateFormText.Donate => 523,
      YandexMoneyDonateFormText.Give => 487,
      YandexMoneyDonateFormText.Transfer => 495,
      YandexMoneyDonateFormText.Send => 494,
      YandexMoneyDonateFormText.Support => 507,
      _ => 523
    };

    if (!cards)
    {
      width -= 69;
    }

    return new TagBuilder("iframe")
      .Attribute("src", $"https://money.yandex.ru/embed/donate.xml?account={Account()}&quickpay=donate{(Cards() ? "&payment-type-choice=on" : string.Empty)}&default-sum={Sum()}&targets={DescriptionText()}{(Description() ? "&target-visibility=on" : string.Empty)}&project-name={ProjectName()}&project-site={ProjectSite()}&button-text=0{Text()}{(AskPayerComment() ? $"&comment=on&hint=${CommentHint()}" : string.Empty)}{(AskPayerFullName() ? "&fio=on" : string.Empty)}{(AskPayerEmail() ? "&mail=on" : string.Empty)}{(AskPayerPhone() ? "&phone=on" : string.Empty)}")
      .Attribute("frameborder", 0)
      .Attribute("allowtransparency", true)
      .Attribute("scrolling", "no")
      .Attribute("width", width)
      .Attribute("height", this.AskPayerComment() ? 210 : 133)
      .ToString();
  }
}