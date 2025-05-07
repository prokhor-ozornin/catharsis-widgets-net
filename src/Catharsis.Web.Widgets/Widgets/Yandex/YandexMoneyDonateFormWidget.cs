using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IYandexMoneyDonateFormWidget"/>
public class YandexMoneyDonateFormWidget : WebWidget, IYandexMoneyDonateFormWidget
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string AccountValue { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual bool DescriptionValue { get; set; }

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
  protected virtual byte TextValue { get; set; } = (byte) YandexMoneyDonateFormText.Donate;

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string ProjectNameValue { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string ProjectSiteValue { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual bool AskPayerCommentValue { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string CommentHintValue { get; set; }

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
  protected virtual string DescriptionTextValue { get; set; }

  /// <inheritdoc cref="IYandexMoneyDonateFormWidget.Account(string)"/>
  public virtual IYandexMoneyDonateFormWidget Account(string account)
  {
    if (account is null) throw new ArgumentNullException(nameof(account));
    if (account.IsEmpty()) throw new ArgumentException(nameof(account));

    AccountValue = account;
    return this;
  }

  /// <inheritdoc cref="IYandexMoneyDonateFormWidget.Cards(bool)"/>
  public virtual IYandexMoneyDonateFormWidget Cards(bool enabled)
  {
    CardsValue = enabled;
    return this;
  }

  /// <inheritdoc cref="IYandexMoneyDonateFormWidget.DescriptionText(string)"/>
  public virtual IYandexMoneyDonateFormWidget DescriptionText(string description)
  {
    if (description is null) throw new ArgumentNullException(nameof(description));
    if (description.IsEmpty()) throw new ArgumentException(nameof(description));

    DescriptionTextValue = description;
    return this;
  }

  /// <inheritdoc cref="IYandexMoneyDonateFormWidget.AskPayerComment(bool)"/>
  public virtual IYandexMoneyDonateFormWidget AskPayerComment(bool enabled)
  {
    AskPayerCommentValue = enabled;
    return this;
  }

  /// <inheritdoc cref="IYandexMoneyDonateFormWidget.CommentHint(string)"/>
  public virtual IYandexMoneyDonateFormWidget CommentHint(string hint)
  {
    if (hint is null) throw new ArgumentNullException(nameof(hint));
    if (hint.IsEmpty()) throw new ArgumentException(nameof(hint));

    CommentHintValue = hint;
    return this;
  }

  /// <inheritdoc cref="IYandexMoneyDonateFormWidget.AskPayerEmail(bool)"/>
  public virtual IYandexMoneyDonateFormWidget AskPayerEmail(bool enabled)
  {
    AskPayerEmailValue = enabled;
    return this;
  }

  /// <inheritdoc cref="IYandexMoneyDonateFormWidget.AskPayerFullName(bool)"/>
  public virtual IYandexMoneyDonateFormWidget AskPayerFullName(bool enabled)
  {
    AskPayerFullNameValue = enabled;
    return this;
  }

  /// <inheritdoc cref="IYandexMoneyDonateFormWidget.AskPayerPhone(bool)"/>
  public virtual IYandexMoneyDonateFormWidget AskPayerPhone(bool enabled)
  {
    AskPayerPhoneValue = enabled;
    return this;
  }

  /// <inheritdoc cref="IYandexMoneyDonateFormWidget.ProjectName(string)"/>
  public virtual IYandexMoneyDonateFormWidget ProjectName(string name)
  {
    if (name is null) throw new ArgumentNullException(nameof(name));
    if (name.IsEmpty()) throw new ArgumentException(nameof(name));

    ProjectNameValue = name;

    return this;
  }

  /// <inheritdoc cref="IYandexMoneyDonateFormWidget.ProjectSite(string)"/>
  public virtual IYandexMoneyDonateFormWidget ProjectSite(string url)
  {
    if (url is null) throw new ArgumentNullException(nameof(url));
    if (url.IsEmpty()) throw new ArgumentException(nameof(url));

    ProjectSiteValue = url;

    return this;
  }

  /// <inheritdoc cref="IYandexMoneyDonateFormWidget.Description(bool)"/>
  public virtual IYandexMoneyDonateFormWidget Description(bool enabled)
  {
    DescriptionValue = enabled;
    return this;
  }

  /// <inheritdoc cref="IYandexMoneyDonateFormWidget.Sum(decimal)"/>
  public virtual IYandexMoneyDonateFormWidget Sum(decimal sum)
  {
    SumValue = sum;
    return this;
  }

  /// <inheritdoc cref="IYandexMoneyDonateFormWidget.Text(byte)"/>
  public virtual IYandexMoneyDonateFormWidget Text(byte text)
  {
    TextValue = text;
    return this;
  }

  /// <inheritdoc cref="ICloneable.Clone()"/>
  public override object Clone() => new YandexMoneyDonateFormWidget
  {
    AccountValue = AccountValue,
    DescriptionValue = DescriptionValue,
    SumValue = SumValue,
    CardsValue = CardsValue,
    TextValue = TextValue,
    ProjectNameValue = ProjectNameValue,
    ProjectSiteValue = ProjectSiteValue,
    AskPayerCommentValue = AskPayerCommentValue,
    CommentHintValue = CommentHintValue,
    AskPayerFullNameValue = AskPayerFullNameValue,
    AskPayerEmailValue = AskPayerEmailValue,
    AskPayerPhoneValue = AskPayerPhoneValue,
    DescriptionTextValue = DescriptionTextValue
  };

  /// <inheritdoc cref="IWebWidget.ToHtml()"/>
  public override string ToHtml()
  {
    if (AccountValue.IsUnset() || DescriptionTextValue.IsUnset())
    {
      return string.Empty;
    }

    var width = (YandexMoneyDonateFormText) TextValue switch
    {
      YandexMoneyDonateFormText.Donate => 523,
      YandexMoneyDonateFormText.Give => 487,
      YandexMoneyDonateFormText.Transfer => 495,
      YandexMoneyDonateFormText.Send => 494,
      YandexMoneyDonateFormText.Support => 507,
      _ => 523
    };

    if (!CardsValue)
    {
      width -= 69;
    }

    return new TagBuilder("iframe")
      .Attribute("src", $"https://money.yandex.ru/embed/donate.xml?account={AccountValue}&quickpay=donate{(CardsValue ? "&payment-type-choice=on" : string.Empty)}&default-sum={SumValue}&targets={DescriptionTextValue}{(DescriptionValue ? "&target-visibility=on" : string.Empty)}&project-name={ProjectNameValue}&project-site={ProjectSiteValue}&button-text=0{TextValue}{(AskPayerCommentValue ? $"&comment=on&hint=${CommentHintValue}" : string.Empty)}{(AskPayerFullNameValue ? "&fio=on" : string.Empty)}{(AskPayerEmailValue ? "&mail=on" : string.Empty)}{(AskPayerPhoneValue ? "&phone=on" : string.Empty)}")
      .Attribute("frameborder", 0)
      .Attribute("allowtransparency", true)
      .Attribute("scrolling", "no")
      .Attribute("width", width)
      .Attribute("height", AskPayerCommentValue ? 210 : 133)
      .ToString();
  }
}