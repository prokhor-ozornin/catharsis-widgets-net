using Catharsis.Extensions;
using Catharsis.Web.Widgets.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IYandexAnalyticsWidget"/>
public class YandexAnalyticsWidget : WebWidget, IYandexAnalyticsWidget
{
  private string AccountProperty { get; set; }
  private bool WebVisorProperty { get; set; } = true;
  private bool ClickMapProperty { get; set; } = true;
  private bool TrackLinksProperty { get; set; } = true;
  private bool TrackHashProperty { get; set; } = true;
  private bool AccurateProperty { get; set; } = true;
  private bool NoIndexProperty { get; set; }
  private string LanguageProperty { get; set; }

  /// <inheritdoc cref="IYandexAnalyticsWidget.Account(string)"/>
  public IYandexAnalyticsWidget Account(string account)
  {
    if (account is null) throw new ArgumentNullException(nameof(account));
    if (account.IsEmpty()) throw new ArgumentException(nameof(account));

    AccountProperty = account;

    return this;
  }

  /// <inheritdoc cref="IYandexAnalyticsWidget.Account()"/>
  public string Account() => AccountProperty;

  /// <inheritdoc cref="IYandexAnalyticsWidget.Accurate(bool)"/>
  public IYandexAnalyticsWidget Accurate(bool enabled)
  {
    AccurateProperty = enabled;
    return this;
  }

  /// <inheritdoc cref="IYandexAnalyticsWidget.Accurate()"/>
  public bool Accurate() => AccurateProperty;

  /// <inheritdoc cref="IYandexAnalyticsWidget.ClickMap(bool)"/>
  public IYandexAnalyticsWidget ClickMap(bool enabled)
  {
    ClickMapProperty = enabled;
    return this;
  }

  /// <inheritdoc cref="IYandexAnalyticsWidget.ClickMap()"/>
  public bool ClickMap() => ClickMapProperty;

  /// <inheritdoc cref="IYandexAnalyticsWidget.Language(string)"/>
  public IYandexAnalyticsWidget Language(string language)
  {
    if (language is null) throw new ArgumentNullException(nameof(language));
    if (language.IsEmpty()) throw new ArgumentException(nameof(language));

    LanguageProperty = language;

    return this;
  }

  /// <inheritdoc cref="IYandexAnalyticsWidget.Language()"/>
  public string Language() => LanguageProperty;

  /// <inheritdoc cref="IYandexAnalyticsWidget.NoIndex(bool)"/>
  public IYandexAnalyticsWidget NoIndex(bool enabled)
  {
    NoIndexProperty = enabled;
    return this;
  }

  /// <inheritdoc cref="IYandexAnalyticsWidget.NoIndex()"/>
  public bool NoIndex() => NoIndexProperty;

  /// <inheritdoc cref="IYandexAnalyticsWidget.TrackHash(bool)"/>
  public IYandexAnalyticsWidget TrackHash(bool enabled)
  {
    TrackHashProperty = enabled;
    return this;
  }

  /// <inheritdoc cref="IYandexAnalyticsWidget.TrackHash()"/>
  public bool TrackHash() => TrackHashProperty;

  /// <inheritdoc cref="IYandexAnalyticsWidget.TrackLinks(bool)"/>
  public IYandexAnalyticsWidget TrackLinks(bool enabled)
  {
    TrackLinksProperty = enabled;
    return this;
  }

  /// <inheritdoc cref="IYandexAnalyticsWidget.TrackLinks()"/>
  public bool TrackLinks() => TrackLinksProperty;

  /// <inheritdoc cref="IYandexAnalyticsWidget.WebVisor(bool)"/>
  public IYandexAnalyticsWidget WebVisor(bool enabled)
  {
    WebVisorProperty = enabled;
    return this;
  }

  /// <inheritdoc cref="IYandexAnalyticsWidget.WebVisor()"/>
  public bool WebVisor() => WebVisorProperty;

  /// <inheritdoc cref="IHtmlContent.ToHtml()"/>
  public override string ToHtml()
  {
    if (Account().IsEmpty())
    {
      return string.Empty;
    }

    var config = new Dictionary<string, object>
    {
      { "id", Account() },
      { "webvisor", WebVisor() },
      { "clickmap", ClickMap() },
      { "trackLinks", TrackLinks() },
      { "accurateTrackBounce", Accurate() },
      { "trackHash", TrackHash() }
    };

    if (NoIndex())
    {
      config["ut"] = "noindex";
    }

    return string.Format(resources.yandex_analytics_html, Account(), Language() ?? Thread.CurrentThread.CurrentCulture.TwoLetterISOLanguageName, config.Json());
  }
}