using Catharsis.Extensions;
using Catharsis.Web.Widgets.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IYandexAnalyticsWidget"/>
public class YandexAnalyticsWidget : WebWidget, IYandexAnalyticsWidget
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string AccountProperty { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual bool WebVisorProperty { get; set; } = true;

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual bool ClickMapProperty { get; set; } = true;

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual bool TrackLinksProperty { get; set; } = true;

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual bool TrackHashProperty { get; set; } = true;

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual bool AccurateProperty { get; set; } = true;

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual bool NoIndexProperty { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string LanguageProperty { get; set; }

  /// <inheritdoc cref="IYandexAnalyticsWidget.Account(string)"/>
  public virtual IYandexAnalyticsWidget Account(string account)
  {
    if (account is null) throw new ArgumentNullException(nameof(account));
    if (account.IsEmpty()) throw new ArgumentException(nameof(account));

    AccountProperty = account;

    return this;
  }

  /// <inheritdoc cref="IYandexAnalyticsWidget.Accurate(bool)"/>
  public virtual IYandexAnalyticsWidget Accurate(bool enabled)
  {
    AccurateProperty = enabled;
    return this;
  }

  /// <inheritdoc cref="IYandexAnalyticsWidget.ClickMap(bool)"/>
  public virtual IYandexAnalyticsWidget ClickMap(bool enabled)
  {
    ClickMapProperty = enabled;
    return this;
  }

  /// <inheritdoc cref="IYandexAnalyticsWidget.Language(string)"/>
  public virtual IYandexAnalyticsWidget Language(string language)
  {
    if (language is null) throw new ArgumentNullException(nameof(language));
    if (language.IsEmpty()) throw new ArgumentException(nameof(language));

    LanguageProperty = language;

    return this;
  }

  /// <inheritdoc cref="IYandexAnalyticsWidget.NoIndex(bool)"/>
  public virtual IYandexAnalyticsWidget NoIndex(bool enabled)
  {
    NoIndexProperty = enabled;
    return this;
  }

  /// <inheritdoc cref="IYandexAnalyticsWidget.TrackHash(bool)"/>
  public virtual IYandexAnalyticsWidget TrackHash(bool enabled)
  {
    TrackHashProperty = enabled;
    return this;
  }

  /// <inheritdoc cref="IYandexAnalyticsWidget.TrackLinks(bool)"/>
  public virtual IYandexAnalyticsWidget TrackLinks(bool enabled)
  {
    TrackLinksProperty = enabled;
    return this;
  }

  /// <inheritdoc cref="IYandexAnalyticsWidget.WebVisor(bool)"/>
  public virtual IYandexAnalyticsWidget WebVisor(bool enabled)
  {
    WebVisorProperty = enabled;
    return this;
  }

  public override object Clone() => new YandexAnalyticsWidget { };

  /// <inheritdoc cref="IWebWidget.ToHtml()"/>
  public override string ToHtml()
  {
    if (AccountProperty.IsUnset())
    {
      return string.Empty;
    }

    var config = new Dictionary<string, object>
    {
      { "id", AccountProperty },
      { "webvisor", WebVisorProperty },
      { "clickmap", ClickMapProperty },
      { "trackLinks", TrackLinksProperty },
      { "accurateTrackBounce", AccurateProperty },
      { "trackHash", TrackHashProperty }
    };

    if (NoIndexProperty)
    {
      config["ut"] = "noindex";
    }

    return string.Format(resources.yandex_analytics_html, AccountProperty, LanguageProperty ?? Thread.CurrentThread.CurrentCulture.TwoLetterISOLanguageName, config.Json());
  }
}