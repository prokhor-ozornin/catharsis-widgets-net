using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IYandexMoneyDonateFormWidget"/>
public class YandexMoneyDonateFormWidget : WebWidget, IYandexMoneyDonateFormWidget
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string AccountProperty { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual bool DescriptionProperty { get; set; }

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
  protected virtual byte TextProperty { get; set; } = (byte) YandexMoneyDonateFormText.Donate;

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string ProjectNameProperty { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string ProjectSiteProperty { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual bool AskPayerCommentProperty { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string CommentHintProperty { get; set; }

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
  protected virtual string DescriptionTextProperty { get; set; }

  /// <inheritdoc cref="IYandexMoneyDonateFormWidget.Account(string)"/>
  public virtual IYandexMoneyDonateFormWidget Account(string account)
  {
    if (account is null) throw new ArgumentNullException(nameof(account));
    if (account.IsEmpty()) throw new ArgumentException(nameof(account));

    AccountProperty = account;
    return this;
  }

  /// <inheritdoc cref="IYandexMoneyDonateFormWidget.Cards(bool)"/>
  public virtual IYandexMoneyDonateFormWidget Cards(bool enabled)
  {
    CardsProperty = enabled;
    return this;
  }

  /// <inheritdoc cref="IYandexMoneyDonateFormWidget.DescriptionText(string)"/>
  public virtual IYandexMoneyDonateFormWidget DescriptionText(string description)
  {
    if (description is null) throw new ArgumentNullException(nameof(description));
    if (description.IsEmpty()) throw new ArgumentException(nameof(description));

    DescriptionTextProperty = description;
    return this;
  }

  /// <inheritdoc cref="IYandexMoneyDonateFormWidget.AskPayerComment(bool)"/>
  public virtual IYandexMoneyDonateFormWidget AskPayerComment(bool enabled)
  {
    AskPayerCommentProperty = enabled;
    return this;
  }

  /// <inheritdoc cref="IYandexMoneyDonateFormWidget.CommentHint(string)"/>
  public virtual IYandexMoneyDonateFormWidget CommentHint(string hint)
  {
    if (hint is null) throw new ArgumentNullException(nameof(hint));
    if (hint.IsEmpty()) throw new ArgumentException(nameof(hint));

    CommentHintProperty = hint;
    return this;
  }

  /// <inheritdoc cref="IYandexMoneyDonateFormWidget.AskPayerEmail(bool)"/>
  public virtual IYandexMoneyDonateFormWidget AskPayerEmail(bool enabled)
  {
    AskPayerEmailProperty = enabled;
    return this;
  }

  /// <inheritdoc cref="IYandexMoneyDonateFormWidget.AskPayerFullName(bool)"/>
  public virtual IYandexMoneyDonateFormWidget AskPayerFullName(bool enabled)
  {
    AskPayerFullNameProperty = enabled;
    return this;
  }

  /// <inheritdoc cref="IYandexMoneyDonateFormWidget.AskPayerPhone(bool)"/>
  public virtual IYandexMoneyDonateFormWidget AskPayerPhone(bool enabled)
  {
    AskPayerPhoneProperty = enabled;
    return this;
  }

  /// <inheritdoc cref="IYandexMoneyDonateFormWidget.ProjectName(string)"/>
  public virtual IYandexMoneyDonateFormWidget ProjectName(string name)
  {
    if (name is null) throw new ArgumentNullException(nameof(name));
    if (name.IsEmpty()) throw new ArgumentException(nameof(name));

    ProjectNameProperty = name;

    return this;
  }

  /// <inheritdoc cref="IYandexMoneyDonateFormWidget.ProjectSite(string)"/>
  public virtual IYandexMoneyDonateFormWidget ProjectSite(string url)
  {
    if (url is null) throw new ArgumentNullException(nameof(url));
    if (url.IsEmpty()) throw new ArgumentException(nameof(url));

    ProjectSiteProperty = url;

    return this;
  }

  /// <inheritdoc cref="IYandexMoneyDonateFormWidget.Description(bool)"/>
  public virtual IYandexMoneyDonateFormWidget Description(bool enabled)
  {
    DescriptionProperty = enabled;
    return this;
  }

  /// <inheritdoc cref="IYandexMoneyDonateFormWidget.Sum(decimal)"/>
  public virtual IYandexMoneyDonateFormWidget Sum(decimal sum)
  {
    SumProperty = sum;
    return this;
  }

  /// <inheritdoc cref="IYandexMoneyDonateFormWidget.Text(byte)"/>
  public virtual IYandexMoneyDonateFormWidget Text(byte text)
  {
    TextProperty = text;
    return this;
  }

  public override object Clone() => new YandexMoneyDonateFormWidget { };

  /// <inheritdoc cref="IWebWidget.ToHtml()"/>
  public override string ToHtml()
  {
    if (AccountProperty.IsUnset() || DescriptionTextProperty.IsUnset())
    {
      return string.Empty;
    }

    var width = (YandexMoneyDonateFormText) TextProperty switch
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
      .Attribute("src", $"https://money.yandex.ru/embed/donate.xml?account={AccountProperty}&quickpay=donate{(CardsProperty ? "&payment-type-choice=on" : string.Empty)}&default-sum={SumProperty}&targets={DescriptionTextProperty}{(DescriptionProperty ? "&target-visibility=on" : string.Empty)}&project-name={ProjectNameProperty}&project-site={ProjectSiteProperty}&button-text=0{TextProperty}{(AskPayerCommentProperty ? $"&comment=on&hint=${CommentHintProperty}" : string.Empty)}{(AskPayerFullNameProperty ? "&fio=on" : string.Empty)}{(AskPayerEmailProperty ? "&mail=on" : string.Empty)}{(AskPayerPhoneProperty ? "&phone=on" : string.Empty)}")
      .Attribute("frameborder", 0)
      .Attribute("allowtransparency", true)
      .Attribute("scrolling", "no")
      .Attribute("width", width)
      .Attribute("height", AskPayerCommentProperty ? 210 : 133)
      .ToString();
  }
}