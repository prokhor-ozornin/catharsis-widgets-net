using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IGoogleAnalyticsWidget"/>
public class GoogleAnalyticsWidget : WebWidget, IGoogleAnalyticsWidget
{
  private string account;
  private string domain;

  /// <inheritdoc cref="IGoogleAnalyticsWidget.Account(string)"/>
  public IGoogleAnalyticsWidget Account(string account)
  {
    if (account is null) throw new ArgumentNullException(nameof(account));
    if (account.IsEmpty()) throw new ArgumentException(nameof(account));

    this.account = account;
    return this;
  }

  /// <inheritdoc cref="IGoogleAnalyticsWidget.Account()"/>
  public string Account() => account;

  /// <inheritdoc cref="IGoogleAnalyticsWidget.Domain(string)"/>
  public IGoogleAnalyticsWidget Domain(string domain)
  {
    if (domain is null) throw new ArgumentNullException(nameof(domain));
    if (domain.IsEmpty()) throw new ArgumentException(nameof(domain));

    this.domain = domain;
    return this;
  }

  /// <inheritdoc cref="IGoogleAnalyticsWidget.Domain()"/>
  public string Domain() => domain;

  /// <inheritdoc cref="IWebWidget.ToHtml()"/>
  public override string ToHtml()
  {
    if (Account().IsEmpty() || Domain().IsEmpty())
    {
      return string.Empty;
    }

    return string.Format(resources.google_analytics, Account(), Domain());
  }
}