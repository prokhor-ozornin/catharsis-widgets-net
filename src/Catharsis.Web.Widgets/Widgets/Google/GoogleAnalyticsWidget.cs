using System;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Includes Google Analytics JavaScript code into web page.</para>
  /// </summary>
  /// <seealso cref="http://www.google.com/analytics"/>
  public class GoogleAnalyticsWidget : HtmlWidget, IGoogleAnalyticsWidget
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
      Assertion.NotEmpty(account);

      this.account = account;
      return this;
    }

    /// <summary>
    ///   <para>Google Analytics site identifier (UA-*).</para>
    /// </summary>
    /// <returns>Site identifier.</returns>
    public string Account()
    {
      return this.account;
    }

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
      Assertion.NotEmpty(domain);

      this.domain = domain;
      return this;
    }

    /// <summary>
    ///   <para>Google Analytics site domain name.</para>
    /// </summary>
    /// <returns>Site domain name.</returns>
    public string Domain()
    {
      return this.domain;
    }

    /// <summary>
    ///   <para>Returns HTML markup text of widget.</para>
    /// </summary>
    /// <returns>Widget's HTML markup.</returns>
    public override string ToHtmlString()
    {
      if (this.Account().IsEmpty() || this.Domain().IsEmpty())
      {
        return string.Empty;
      }

      return resources.google_analytics.FormatSelf(this.Account(), this.Domain());
    }
  }
}