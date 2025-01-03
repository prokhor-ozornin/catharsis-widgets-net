using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IYandexAnalyticsWidget"/>
public class YandexAnalyticsWidget : WebWidget, IYandexAnalyticsWidget
{
  private string account;
  private bool webVisor = true;
  private bool clickMap = true;
  private bool trackLinks = true;
  private bool trackHash = true;
  private bool accurate = true;
  private bool noIndex;
  private string language;

  /// <inheritdoc cref="IYandexAnalyticsWidget.Account(string)"/>
  public IYandexAnalyticsWidget Account(string account)
  {
    if (account is null) throw new ArgumentNullException(nameof(account));
    if (account.IsEmpty()) throw new ArgumentException(nameof(account));

    this.account = account;

    return this;
  }

  /// <inheritdoc cref="IYandexAnalyticsWidget.Account()"/>
  public string Account() => account;

  /// <inheritdoc cref="IYandexAnalyticsWidget.Accurate(bool)"/>
  public IYandexAnalyticsWidget Accurate(bool enabled)
  {
    accurate = enabled;
    return this;
  }

  /// <inheritdoc cref="IYandexAnalyticsWidget.Accurate()"/>
  public bool Accurate() => accurate;

  /// <inheritdoc cref="IYandexAnalyticsWidget.ClickMap(bool)"/>
  public IYandexAnalyticsWidget ClickMap(bool enabled)
  {
    clickMap = enabled;
    return this;
  }

  /// <inheritdoc cref="IYandexAnalyticsWidget.ClickMap()"/>
  public bool ClickMap() => clickMap;

  /// <inheritdoc cref="IYandexAnalyticsWidget.Language(string)"/>
  public IYandexAnalyticsWidget Language(string language)
  {
    if (language is null) throw new ArgumentNullException(nameof(language));
    if (language.IsEmpty()) throw new ArgumentException(nameof(language));

    this.language = language;

    return this;
  }

  /// <inheritdoc cref="IYandexAnalyticsWidget.Language()"/>
  public string Language() => language;

  /// <inheritdoc cref="IYandexAnalyticsWidget.NoIndex(bool)"/>
  public IYandexAnalyticsWidget NoIndex(bool enabled)
  {
    noIndex = enabled;
    return this;
  }

  /// <inheritdoc cref="IYandexAnalyticsWidget.NoIndex()"/>
  public bool NoIndex() => noIndex;

  /// <inheritdoc cref="IYandexAnalyticsWidget.TrackHash(bool)"/>
  public IYandexAnalyticsWidget TrackHash(bool enabled)
  {
    trackHash = enabled;
    return this;
  }

  /// <inheritdoc cref="IYandexAnalyticsWidget.TrackHash()"/>
  public bool TrackHash() => trackHash;

  /// <inheritdoc cref="IYandexAnalyticsWidget.TrackLinks(bool)"/>
  public IYandexAnalyticsWidget TrackLinks(bool enabled)
  {
    trackLinks = enabled;
    return this;
  }

  /// <inheritdoc cref="IYandexAnalyticsWidget.TrackLinks()"/>
  public bool TrackLinks() => trackLinks;

  /// <inheritdoc cref="IYandexAnalyticsWidget.WebVisor(bool)"/>
  public IYandexAnalyticsWidget WebVisor(bool enabled)
  {
    webVisor = enabled;
    return this;
  }

  /// <inheritdoc cref="IYandexAnalyticsWidget.WebVisor()"/>
  public bool WebVisor() => webVisor;

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

    return string.Format(resources.yandex_analytics, Account(), Language() ?? Thread.CurrentThread.CurrentCulture.TwoLetterISOLanguageName, config.Json());
  }
}