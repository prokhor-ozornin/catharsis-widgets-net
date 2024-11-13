using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IGoogleAnalyticsWidget"/>
public class GoogleAnalyticsWidget : WebWidget, IGoogleAnalyticsWidget
{
  private string account;
  private string domain;

  /// <summary>
  ///   <para>Google Analytics site identifier (UA-*).</para>
  /// </summary>
  /// <param name="account">Site identifier.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="account"/> is a <c>null</c> reference.</exception>
  /// <exception cref="ArgumentException">If <paramref name="account"/> is <see cref="string.Empty"/> string.</exception>
  /// <remarks>This attribute is required.</remarks>
  public IGoogleAnalyticsWidget Account(string account)
  {
    if (account is null) throw new ArgumentNullException(nameof(account));
    if (account.IsEmpty()) throw new ArgumentException(nameof(account));

    this.account = account;
    return this;
  }

  /// <summary>
  ///   <para>Google Analytics site identifier (UA-*).</para>
  /// </summary>
  /// <returns>Site identifier.</returns>
  public string Account() => account;
  
  /// <summary>
  ///   <para>Google Analytics site domain name.</para>
  /// </summary>
  /// <param name="domain">Site domain name.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="domain"/> is a <c>null</c> reference.</exception>
  /// <exception cref="ArgumentException">If <paramref name="domain"/> is <see cref="string.Empty"/> string.</exception>
  /// <remarks>This attribute is required.</remarks>
  public IGoogleAnalyticsWidget Domain(string domain)
  {
    if (domain is null) throw new ArgumentNullException(nameof(domain));
    if (domain.IsEmpty()) throw new ArgumentException(nameof(domain));

    this.domain = domain;
    return this;
  }

  /// <summary>
  ///   <para>Google Analytics site domain name.</para>
  /// </summary>
  /// <returns>Site domain name.</returns>
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