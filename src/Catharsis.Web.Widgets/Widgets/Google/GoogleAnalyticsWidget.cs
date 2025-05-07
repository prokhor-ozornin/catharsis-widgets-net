using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IGoogleAnalyticsWidget"/>
public class GoogleAnalyticsWidget : WebWidget, IGoogleAnalyticsWidget
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string AccountValue { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string DomainValue { get; set; }

  /// <inheritdoc cref="IGoogleAnalyticsWidget.Account(string)"/>
  public virtual IGoogleAnalyticsWidget Account(string account)
  {
    if (account is null) throw new ArgumentNullException(nameof(account));
    if (account.IsEmpty()) throw new ArgumentException(nameof(account));

    AccountValue = account;
    return this;
  }

  /// <inheritdoc cref="IGoogleAnalyticsWidget.Domain(string)"/>
  public virtual IGoogleAnalyticsWidget Domain(string domain)
  {
    if (domain is null) throw new ArgumentNullException(nameof(domain));
    if (domain.IsEmpty()) throw new ArgumentException(nameof(domain));

    DomainValue = domain;
    return this;
  }

  /// <inheritdoc cref="ICloneable.Clone()"/>
  public override object Clone() => new GoogleAnalyticsWidget
  {
    AccountValue = AccountValue,
    DomainValue = DomainValue
  };

  /// <inheritdoc cref="IWebWidget.ToHtml()"/>
  public override string ToHtml() => AccountValue.IsUnset() || DomainValue.IsUnset() ? string.Empty : string.Format(resources.google_analytics_js, AccountValue, DomainValue);
}