using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IGoogleAnalyticsWidget"/>
public class GoogleAnalyticsWidget : WebWidget, IGoogleAnalyticsWidget
{
  private string AccountProperty { get; set; }
  private string DomainProperty { get; set; }

  /// <inheritdoc cref="IGoogleAnalyticsWidget.Account(string)"/>
  public IGoogleAnalyticsWidget Account(string account)
  {
    if (account is null) throw new ArgumentNullException(nameof(account));
    if (account.IsEmpty()) throw new ArgumentException(nameof(account));

    AccountProperty = account;
    return this;
  }

  /// <inheritdoc cref="IGoogleAnalyticsWidget.Account()"/>
  public string Account() => AccountProperty;

  /// <inheritdoc cref="IGoogleAnalyticsWidget.Domain(string)"/>
  public IGoogleAnalyticsWidget Domain(string domain)
  {
    if (domain is null) throw new ArgumentNullException(nameof(domain));
    if (domain.IsEmpty()) throw new ArgumentException(nameof(domain));

    DomainProperty = domain;
    return this;
  }

  /// <inheritdoc cref="IGoogleAnalyticsWidget.Domain()"/>
  public string Domain() => DomainProperty;

  /// <inheritdoc cref="IHtmlContent.ToHtml()"/>
  public override string ToHtml()
  {
    if (Account().IsEmpty() || Domain().IsEmpty())
    {
      return string.Empty;
    }

    return string.Format(resources.google_analytics_js, Account(), Domain());
  }
}