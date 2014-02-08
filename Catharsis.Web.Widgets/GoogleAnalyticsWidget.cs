using System.IO;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  public sealed class GoogleAnalyticsWidget : HtmlWidgetBase<IGoogleAnalyticsWidget>, IGoogleAnalyticsWidget
  {
    private string account;
    private string domain;

    public IGoogleAnalyticsWidget Account(string account)
    {
      Assertion.NotEmpty(account);

      this.account = account;
      return this;
    }

    public IGoogleAnalyticsWidget Domain(string domain)
    {
      Assertion.NotEmpty(domain);

      this.domain = domain;
      return this;
    }

    public override void Write(TextWriter writer)
    {
      Assertion.NotNull(writer);

      if (this.account.IsEmpty() || this.domain.IsEmpty())
      {
        return;
      }

      writer.Write(resources.google_analytics.FormatValue(this.account, this.domain));
    }
  }
}