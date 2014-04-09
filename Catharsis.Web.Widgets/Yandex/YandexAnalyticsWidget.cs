using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Web;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Renders Yandex.Metrika web counter's JavaScript code.</para>
  /// </summary>
  /// <seealso cref="https://metrika.yandex.ru"/>
  public sealed class YandexAnalyticsWidget : HtmlWidgetBase, IYandexAnalyticsWidget
  {
    private string account;
    private bool webvisor = true;
    private bool clickmap = true;
    private bool tracklinks = true;
    private bool trackhash = true;
    private bool accurate = true;
    private bool noindex;
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
      Assertion.NotEmpty(account);

      this.account = account;
      return this;
    }

    /// <summary>
    ///   <para>Whether to use accurate track bounce. Default is <c>true</c>.</para>
    /// </summary>
    /// <param name="accurate"><c>true</c> to enable accurate track bounce functionality, <c>false</c> to disable it.</param>
    /// <returns>Reference to the current widget.</returns>
    public IYandexAnalyticsWidget Accurate(bool accurate = true)
    {
      this.accurate = accurate;
      return this;
    }

    /// <summary>
    ///   <para>Whether to use click map (gathering statistics for "click map" report). Default is <c>true</c>.</para>
    /// </summary>
    /// <param name="clickmap"><c>true</c> to enable click map functionality, <c>false</c> to disable it.</param>
    /// <returns>Reference to the current widget.</returns>
    public IYandexAnalyticsWidget ClickMap(bool clickmap = true)
    {
      this.clickmap = clickmap;
      return this;
    }

    /// <summary>
    ///   <para>Language of visual counter's interface to use. Default is current locale's language/language of the current thread.</para>
    /// </summary>
    /// <param name="language">Interface language to use.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="language"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="language"/> is <see cref="string.Empty"/> string.</exception>
    public IYandexAnalyticsWidget Language(string language)
    {
      Assertion.NotEmpty(language);

      this.language = language;
      return this;
    }

    /// <summary>
    ///   <para>Whether to disable indexing of site's pages. Default is <c>false</c>.</para>
    /// </summary>
    /// <param name="noindex"><c>true</c> to disable indexing, <c>false</c> to enable it.</param>
    /// <returns>Reference to the current widget.</returns>
    public IYandexAnalyticsWidget NoIndex(bool noindex = true)
    {
      this.noindex = noindex;
      return this;
    }

    /// <summary>
    ///   <para>Whether to track address hash in URL query string. Default is <c>true</c>.</para>
    /// </summary>
    /// <param name="trackhash"><c>true</c> to enable track hash functionality, <c>false</c> to disable.</param>
    /// <returns>Reference to the current widget.</returns>
    public IYandexAnalyticsWidget TrackHash(bool trackhash = true)
    {
      this.trackhash = trackhash;
      return this;
    }

    /// <summary>
    ///   <para>Whether to track links (gathering statistics for external links, file uploads and "Share" button). Default is <c>true</c>.</para>
    /// </summary>
    /// <param name="tracklinks"><c>true</c> to enable track links functionality, <c>false</c> to disable it.</param>
    /// <returns>Reference to the current widget.</returns>
    public IYandexAnalyticsWidget TrackLinks(bool tracklinks = true)
    {
      this.tracklinks = tracklinks;
      return this;
    }

    /// <summary>
    ///   <para>Whether to use webvisor (recording and analysis of site's visitors behaviour). Default is <c>true</c>.</para>
    /// </summary>
    /// <param name="webvisor"><c>true</c> to enable webvisor functionality, <c>false</c> to disable it.</param>
    /// <returns>Reference to the current widget.</returns>
    public IYandexAnalyticsWidget WebVisor(bool webvisor = true)
    {
      this.webvisor = webvisor;
      return this;
    }

    /// <summary>
    ///   <para>Generates and writes HTML markup of widget, using specified text writer.</para>
    /// </summary>
    /// <param name="writer">Text writer to use as output destination.</param>
    public override void Write(TextWriter writer)
    {
      Assertion.NotNull(writer);

      if (this.account.IsEmpty())
      {
        return;
      }

      var config = new Dictionary<string, object>
      {
        { "id", this.account },
        { "webvisor", this.webvisor },
        { "clickmap", this.clickmap },
        { "trackLinks", this.tracklinks },
        { "accurateTrackBounce", this.accurate },
        { "trackHash",  this.trackhash }
      };
      if (this.noindex)
      {
        config["ut"] = "noindex";
      }

      writer.Write(resources.yandex_analytics.FormatSelf(this.account, this.language ?? (HttpContext.Current != null ? HttpContext.Current.Request.Language() : Thread.CurrentThread.CurrentCulture.TwoLetterISOLanguageName), config.Json()));
    }
  }
}