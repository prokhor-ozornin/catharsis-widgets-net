using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Web;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  public sealed class YandexAnalyticsWidget : HtmlWidgetBase<IYandexAnalyticsWidget>, IYandexAnalyticsWidget
  {
    private string account;
    private bool webvisor = true;
    private bool clickmap = true;
    private bool tracklinks = true;
    private bool trackhash = true;
    private bool accurate = true;
    private bool noindex;
    private string language;

    public IYandexAnalyticsWidget Account(string account)
    {
      Assertion.NotEmpty(account);

      this.account = account;
      return this;
    }

    public IYandexAnalyticsWidget WebVisor(bool webvisor = true)
    {
      this.webvisor = webvisor;
      return this;
    }

    public IYandexAnalyticsWidget ClickMap(bool clickmap = true)
    {
      this.clickmap = clickmap;
      return this;
    }

    public IYandexAnalyticsWidget TrackLinks(bool tracklinks = true)
    {
      this.tracklinks = tracklinks;
      return this;
    }

    public IYandexAnalyticsWidget TrackHash(bool trackhash = true)
    {
      this.trackhash = trackhash;
      return this;
    }

    public IYandexAnalyticsWidget Accurate(bool accurate = true)
    {
      this.accurate = accurate;
      return this;
    }

    public IYandexAnalyticsWidget NoIndex(bool noindex = true)
    {
      this.noindex = noindex;
      return this;
    }

    public IYandexAnalyticsWidget Language(string language)
    {
      Assertion.NotEmpty(language);

      this.language = language;
      return this;
    }

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

      writer.Write(resources.yandex_analytics.FormatValue(this.account, this.language ?? (HttpContext.Current != null ? HttpContext.Current.Request.Language() : Thread.CurrentThread.CurrentCulture.TwoLetterISOLanguageName), config.Json()));
    }
  }
}