using Catharsis.Extensions;
using Catharsis.Web.Widgets.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IYandexAnalyticsWidget"/>
public class YandexAnalyticsWidget : WebWidget, IYandexAnalyticsWidget
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string AccountValue { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual bool WebVisorValue { get; set; } = true;

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual bool ClickMapValue { get; set; } = true;

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual bool TrackLinksValue { get; set; } = true;

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual bool TrackHashValue { get; set; } = true;

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual bool AccurateValue { get; set; } = true;

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual bool NoIndexValue { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string LanguageValue { get; set; }

  /// <inheritdoc cref="IYandexAnalyticsWidget.Account(string)"/>
  public virtual IYandexAnalyticsWidget Account(string account)
  {
    if (account is null) throw new ArgumentNullException(nameof(account));
    if (account.IsEmpty()) throw new ArgumentException(nameof(account));

    AccountValue = account;

    return this;
  }

  /// <inheritdoc cref="IYandexAnalyticsWidget.Accurate(bool)"/>
  public virtual IYandexAnalyticsWidget Accurate(bool enabled)
  {
    AccurateValue = enabled;
    return this;
  }

  /// <inheritdoc cref="IYandexAnalyticsWidget.ClickMap(bool)"/>
  public virtual IYandexAnalyticsWidget ClickMap(bool enabled)
  {
    ClickMapValue = enabled;
    return this;
  }

  /// <inheritdoc cref="IYandexAnalyticsWidget.Language(string)"/>
  public virtual IYandexAnalyticsWidget Language(string language)
  {
    if (language is null) throw new ArgumentNullException(nameof(language));
    if (language.IsEmpty()) throw new ArgumentException(nameof(language));

    LanguageValue = language;

    return this;
  }

  /// <inheritdoc cref="IYandexAnalyticsWidget.NoIndex(bool)"/>
  public virtual IYandexAnalyticsWidget NoIndex(bool enabled)
  {
    NoIndexValue = enabled;
    return this;
  }

  /// <inheritdoc cref="IYandexAnalyticsWidget.TrackHash(bool)"/>
  public virtual IYandexAnalyticsWidget TrackHash(bool enabled)
  {
    TrackHashValue = enabled;
    return this;
  }

  /// <inheritdoc cref="IYandexAnalyticsWidget.TrackLinks(bool)"/>
  public virtual IYandexAnalyticsWidget TrackLinks(bool enabled)
  {
    TrackLinksValue = enabled;
    return this;
  }

  /// <inheritdoc cref="IYandexAnalyticsWidget.WebVisor(bool)"/>
  public virtual IYandexAnalyticsWidget WebVisor(bool enabled)
  {
    WebVisorValue = enabled;
    return this;
  }

  /// <inheritdoc cref="ICloneable.Clone()"/>
  public override object Clone() => new YandexAnalyticsWidget
  {
    AccountValue = AccountValue,
    WebVisorValue = WebVisorValue,
    ClickMapValue = ClickMapValue,
    TrackLinksValue = TrackLinksValue,
    TrackHashValue = TrackHashValue,
    AccurateValue = AccurateValue,
    NoIndexValue = NoIndexValue,
    LanguageValue = LanguageValue
  };

  /// <inheritdoc cref="IWebWidget.ToHtml()"/>
  public override string ToHtml()
  {
    if (AccountValue.IsUnset())
    {
      return string.Empty;
    }

    var config = new Dictionary<string, object>
    {
      { "id", AccountValue },
      { "webvisor", WebVisorValue },
      { "clickmap", ClickMapValue },
      { "trackLinks", TrackLinksValue },
      { "accurateTrackBounce", AccurateValue },
      { "trackHash", TrackHashValue }
    };

    if (NoIndexValue)
    {
      config["ut"] = "noindex";
    }

    return string.Format(resources.yandex_analytics_html, AccountValue, LanguageValue ?? Thread.CurrentThread.CurrentCulture.TwoLetterISOLanguageName, config.Json());
  }
}