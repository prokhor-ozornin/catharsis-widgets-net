using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IVkontakteVideoWidget"/>
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

  /// <summary>
  ///   <para>Identifier Yandex.Metrica site.</para>
  /// </summary>
  /// <param name="account">Yandex.Metrika identifier.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="account"/> is a <c>null</c> reference.</exception>
  /// <exception cref="ArgumentException">If <paramref name="account"/> is <see cref="string.Empty"/> string.</exception>
  /// <remarks>This attribute is required.</remarks>
  public IYandexAnalyticsWidget Account(string account)
  {
    if (account is null) throw new ArgumentNullException(nameof(account));
    if (account.IsEmpty()) throw new ArgumentException(nameof(account));

    this.account = account;

    return this;
  }

  /// <summary>
  ///   <para>Identifier Yandex.Metrica site.</para>
  /// </summary>
  /// <returns>Yandex.Metrika identifier.</returns>
  public string Account() => account;

  /// <summary>
  ///   <para>Whether to use accurate track bounce. Default is <c>true</c>.</para>
  /// </summary>
  /// <param name="enabled"><c>true</c> to enable accurate track bounce functionality, <c>false</c> to disable it.</param>
  /// <returns>Reference to the current widget.</returns>
  public IYandexAnalyticsWidget Accurate(bool enabled)
  {
    accurate = enabled;
    return this;
  }

  /// <summary>
  ///   <para>Whether to use accurate track bounce. Default is <c>true</c>.</para>
  /// </summary>
  /// <returns><c>true</c> to enable accurate track bounce functionality, <c>false</c> to disable it.</returns>
  public bool Accurate() => accurate;

  /// <summary>
  ///   <para>Whether to use click map (gathering statistics for "click map" report). Default is <c>true</c>.</para>
  /// </summary>
  /// <param name="enabled"><c>true</c> to enable click map functionality, <c>false</c> to disable it.</param>
  /// <returns>Reference to the current widget.</returns>
  public IYandexAnalyticsWidget ClickMap(bool enabled)
  {
    clickMap = enabled;
    return this;
  }

  /// <summary>
  ///   <para>Whether to use click map (gathering statistics for "click map" report). Default is <c>true</c>.</para>
  /// </summary>
  /// <returns><c>true</c> to enable click map functionality, <c>false</c> to disable it.</returns>
  public bool ClickMap() => clickMap;

  /// <summary>
  ///   <para>Language of visual counter's interface to use. Default is current locale's language/language of the current thread.</para>
  /// </summary>
  /// <param name="language">Interface language to use.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="language"/> is a <c>null</c> reference.</exception>
  /// <exception cref="ArgumentException">If <paramref name="language"/> is <see cref="string.Empty"/> string.</exception>
  public IYandexAnalyticsWidget Language(string language)
  {
    if (language is null) throw new ArgumentNullException(nameof(language));
    if (language.IsEmpty()) throw new ArgumentException(nameof(language));

    this.language = language;

    return this;
  }

  /// <summary>
  ///   <para>Language of visual counter's interface to use. Default is current locale's language/language of the current thread.</para>
  /// </summary>
  /// <returns>Interface language to use.</returns>
  public string Language() => language;

  /// <summary>
  ///   <para>Whether to disable indexing of site's pages. Default is <c>false</c>.</para>
  /// </summary>
  /// <param name="enabled"><c>true</c> to disable indexing, <c>false</c> to enable it.</param>
  /// <returns>Reference to the current widget.</returns>
  public IYandexAnalyticsWidget NoIndex(bool enabled)
  {
    noIndex = enabled;
    return this;
  }

  /// <summary>
  ///   <para>Whether to disable indexing of site's pages. Default is <c>false</c>.</para>
  /// </summary>
  /// <returns><c>true</c> to disable indexing, <c>false</c> to enable it.</returns>
  public bool NoIndex() => noIndex;

  /// <summary>
  ///   <para>Whether to track address hash in URL query string. Default is <c>true</c>.</para>
  /// </summary>
  /// <param name="enabled"><c>true</c> to enable track hash functionality, <c>false</c> to disable.</param>
  /// <returns>Reference to the current widget.</returns>
  public IYandexAnalyticsWidget TrackHash(bool enabled)
  {
    trackHash = enabled;
    return this;
  }

  /// <summary>
  ///   <para>Whether to track address hash in URL query string. Default is <c>true</c>.</para>
  /// </summary>
  /// <returns><c>true</c> to enable track hash functionality, <c>false</c> to disable.</returns>
  public bool TrackHash() => trackHash;

  /// <summary>
  ///   <para>Whether to track links (gathering statistics for external links, file uploads and "Share" button). Default is <c>true</c>.</para>
  /// </summary>
  /// <param name="enabled"><c>true</c> to enable track links functionality, <c>false</c> to disable it.</param>
  /// <returns>Reference to the current widget.</returns>
  public IYandexAnalyticsWidget TrackLinks(bool enabled)
  {
    trackLinks = enabled;
    return this;
  }

  /// <summary>
  ///   <para>Whether to track links (gathering statistics for external links, file uploads and "Share" button). Default is <c>true</c>.</para>
  /// </summary>
  /// <returns><c>true</c> to enable track links functionality, <c>false</c> to disable it.</returns>
  public bool TrackLinks() => trackLinks;

  /// <summary>
  ///   <para>Whether to use webvisor (recording and analysis of site's visitors behaviour). Default is <c>true</c>.</para>
  /// </summary>
  /// <param name="enabled"><c>true</c> to enable webvisor functionality, <c>false</c> to disable it.</param>
  /// <returns>Reference to the current widget.</returns>
  public IYandexAnalyticsWidget WebVisor(bool enabled)
  {
    webVisor = enabled;
    return this;
  }

  /// <summary>
  ///   <para>Whether to use webvisor (recording and analysis of site's visitors behaviour). Default is <c>true</c>.</para>
  /// </summary>
  /// <returns><c>true</c> to enable webvisor functionality, <c>false</c> to disable it.</returns>
  public bool WebVisor() => webVisor;

  /// <inheritdoc cref="IWebWidget.ToHtml()"/>
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

    return string.Format(resources.yandex_analytics, Account(), Language() ?? (HttpContext.Current is not null ? HttpContext.Current.Request.Language() : Thread.CurrentThread.CurrentCulture.TwoLetterISOLanguageName), config.Json());
  }
}