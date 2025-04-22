using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IGoogleAnalyticsWidget"/>
public class GoogleAnalyticsWidget : WebWidget, IGoogleAnalyticsWidget
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string AccountProperty { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string DomainProperty { get; set; }

  /// <inheritdoc cref="IGoogleAnalyticsWidget.Account(string)"/>
  public virtual IGoogleAnalyticsWidget Account(string account)
  {
    if (account is null) throw new ArgumentNullException(nameof(account));
    if (account.IsEmpty()) throw new ArgumentException(nameof(account));

    AccountProperty = account;
    return this;
  }

  /// <inheritdoc cref="IGoogleAnalyticsWidget.Domain(string)"/>
  public virtual IGoogleAnalyticsWidget Domain(string domain)
  {
    if (domain is null) throw new ArgumentNullException(nameof(domain));
    if (domain.IsEmpty()) throw new ArgumentException(nameof(domain));

    DomainProperty = domain;
    return this;
  }

  /// <inheritdoc cref="IHtmlContent.ToHtml()"/>
  public override string ToHtml() => AccountProperty.IsUnset() || DomainProperty.IsUnset() ? string.Empty : string.Format(resources.google_analytics_js, AccountProperty, DomainProperty);
}