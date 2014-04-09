using System;
using System.IO;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Includes Google Analytics JavaScript code into web page.</para>
  /// </summary>
  /// <seealso cref="http://www.google.com/analytics"/>
  public sealed class GoogleAnalyticsWidget : HtmlWidgetBase, IGoogleAnalyticsWidget
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
    ///   <para>Generates and writes HTML markup of widget, using specified text writer.</para>
    /// </summary>
    /// <param name="writer">Text writer to use as output destination.</param>
    public override void Write(TextWriter writer)
    {
      Assertion.NotNull(writer);

      if (this.account.IsEmpty() || this.domain.IsEmpty())
      {
        return;
      }

      writer.Write(resources.google_analytics.FormatSelf(this.account, this.domain));
    }
  }
}