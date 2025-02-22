using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IYandexMoneyDonateFormWidget"/>
public class YandexMoneyDonateFormWidget : WebWidget, IYandexMoneyDonateFormWidget
{
  private string AccountProperty { get; set; }
  private bool DescriptionProperty { get; set; }
  private decimal? SumProperty { get; set; }
  private bool CardsProperty { get; set; } = true;
  private byte TextProperty { get; set; } = (byte) YandexMoneyDonateFormText.Donate;
  private string ProjectNameProperty { get; set; }
  private string ProjectSiteProperty { get; set; }
  private bool AskPayerCommentProperty { get; set; }
  private string CommentHintProperty { get; set; }
  private bool AskPayerFullNameProperty { get; set; }
  private bool AskPayerEmailProperty { get; set; }
  private bool AskPayerPhoneProperty { get; set; }
  private string DescriptionTextProperty { get; set; }

  /// <inheritdoc cref="IYandexMoneyDonateFormWidget.Account(string)"/>
  public IYandexMoneyDonateFormWidget Account(string account)
  {
    if (account is null) throw new ArgumentNullException(nameof(account));
    if (account.IsEmpty()) throw new ArgumentException(nameof(account));

    AccountProperty = account;
    return this;
  }

  /// <inheritdoc cref="IYandexMoneyDonateFormWidget.Account()"/>
  public string Account() => AccountProperty;

  /// <inheritdoc cref="IYandexMoneyDonateFormWidget.Cards(bool)"/>
  public IYandexMoneyDonateFormWidget Cards(bool enabled)
  {
    CardsProperty = enabled;
    return this;
  }

  /// <inheritdoc cref="IYandexMoneyDonateFormWidget.Cards()"/>
  public bool Cards() => CardsProperty;

  /// <inheritdoc cref="IYandexMoneyDonateFormWidget.DescriptionText(string)"/>
  public IYandexMoneyDonateFormWidget DescriptionText(string description)
  {
    if (description is null) throw new ArgumentNullException(nameof(description));
    if (description.IsEmpty()) throw new ArgumentException(nameof(description));

    DescriptionTextProperty = description;
    return this;
  }

  /// <inheritdoc cref="IYandexMoneyDonateFormWidget.DescriptionText()"/>
  public string DescriptionText() => DescriptionTextProperty;

  /// <inheritdoc cref="IYandexMoneyDonateFormWidget.AskPayerComment(bool)"/>
  public IYandexMoneyDonateFormWidget AskPayerComment(bool enabled)
  {
    AskPayerCommentProperty = enabled;
    return this;
  }

  /// <inheritdoc cref="IYandexMoneyDonateFormWidget.AskPayerComment()"/>
  public bool AskPayerComment() => AskPayerCommentProperty;

  /// <inheritdoc cref="IYandexMoneyDonateFormWidget.CommentHint(string)"/>
  public IYandexMoneyDonateFormWidget CommentHint(string hint)
  {
    if (hint is null) throw new ArgumentNullException(nameof(hint));
    if (hint.IsEmpty()) throw new ArgumentException(nameof(hint));

    CommentHintProperty = hint;
    return this;
  }

  /// <inheritdoc cref="IYandexMoneyDonateFormWidget.CommentHint()"/>
  public string CommentHint() => CommentHintProperty;

  /// <inheritdoc cref="IYandexMoneyDonateFormWidget.AskPayerEmail(bool)"/>
  public IYandexMoneyDonateFormWidget AskPayerEmail(bool enabled)
  {
    AskPayerEmailProperty = enabled;
    return this;
  }

  /// <inheritdoc cref="IYandexMoneyDonateFormWidget.AskPayerEmail()"/>
  public bool AskPayerEmail() => AskPayerEmailProperty;

  /// <inheritdoc cref="IYandexMoneyDonateFormWidget.AskPayerFullName(bool)"/>
  public IYandexMoneyDonateFormWidget AskPayerFullName(bool enabled)
  {
    AskPayerFullNameProperty = enabled;
    return this;
  }

  /// <inheritdoc cref="IYandexMoneyDonateFormWidget.AskPayerFullName()"/>
  public bool AskPayerFullName() => AskPayerFullNameProperty;

  /// <inheritdoc cref="IYandexMoneyDonateFormWidget.AskPayerPhone(bool)"/>
  public IYandexMoneyDonateFormWidget AskPayerPhone(bool enabled)
  {
    AskPayerPhoneProperty = enabled;
    return this;
  }

  /// <inheritdoc cref="IYandexMoneyDonateFormWidget.AskPayerPhone()"/>
  public bool AskPayerPhone() => AskPayerPhoneProperty;

  /// <inheritdoc cref="IYandexMoneyDonateFormWidget.ProjectName(string)"/>
  public IYandexMoneyDonateFormWidget ProjectName(string name)
  {
    if (name is null) throw new ArgumentNullException(nameof(name));
    if (name.IsEmpty()) throw new ArgumentException(nameof(name));

    ProjectNameProperty = name;

    return this;
  }

  /// <inheritdoc cref="IYandexMoneyDonateFormWidget.ProjectName()"/>
  public string ProjectName() => ProjectNameProperty;

  /// <inheritdoc cref="IYandexMoneyDonateFormWidget.ProjectSite(string)"/>
  public IYandexMoneyDonateFormWidget ProjectSite(string url)
  {
    if (url is null) throw new ArgumentNullException(nameof(url));
    if (url.IsEmpty()) throw new ArgumentException(nameof(url));

    ProjectSiteProperty = url;

    return this;
  }

  /// <inheritdoc cref="IYandexMoneyDonateFormWidget.ProjectSite()"/>
  public string ProjectSite() => ProjectSiteProperty;

  /// <inheritdoc cref="IYandexMoneyDonateFormWidget.Description(bool)"/>
  public IYandexMoneyDonateFormWidget Description(bool enabled)
  {
    DescriptionProperty = enabled;
    return this;
  }

  /// <inheritdoc cref="IYandexMoneyDonateFormWidget.Description()"/>
  public bool Description() => DescriptionProperty;

  /// <inheritdoc cref="IYandexMoneyDonateFormWidget.Sum(decimal)"/>
  public IYandexMoneyDonateFormWidget Sum(decimal sum)
  {
    SumProperty = sum;
    return this;
  }

  /// <inheritdoc cref="IYandexMoneyDonateFormWidget.Sum()"/>
  public decimal? Sum() => SumProperty;

  /// <inheritdoc cref="IYandexMoneyDonateFormWidget.Text(byte)"/>
  public IYandexMoneyDonateFormWidget Text(byte text)
  {
    TextProperty = text;
    return this;
  }

  /// <inheritdoc cref="IYandexMoneyDonateFormWidget.Text()"/>
  public byte Text() => TextProperty;

  /// <inheritdoc cref="IHtmlContent.ToHtml()"/>
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

    if (!CardsProperty)
    {
      width -= 69;
    }

    return new TagBuilder("iframe")
      .Attribute("src", $"https://money.yandex.ru/embed/donate.xml?account={Account()}&quickpay=donate{(Cards() ? "&payment-type-choice=on" : string.Empty)}&default-sum={Sum()}&targets={DescriptionText()}{(Description() ? "&target-visibility=on" : string.Empty)}&project-name={ProjectName()}&project-site={ProjectSite()}&button-text=0{Text()}{(AskPayerComment() ? $"&comment=on&hint=${CommentHint()}" : string.Empty)}{(AskPayerFullName() ? "&fio=on" : string.Empty)}{(AskPayerEmail() ? "&mail=on" : string.Empty)}{(AskPayerPhone() ? "&phone=on" : string.Empty)}")
      .Attribute("frameborder", 0)
      .Attribute("allowtransparency", true)
      .Attribute("scrolling", "no")
      .Attribute("width", width)
      .Attribute("height", AskPayerComment() ? 210 : 133)
      .ToString();
  }
}