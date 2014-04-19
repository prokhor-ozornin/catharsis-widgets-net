using System;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Includes Google Analytics JavaScript code into web page.</para>
  /// </summary>
  /// <seealso cref="http://www.google.com/analytics"/>
  public interface IGoogleAnalyticsWidget : IHtmlWidget
  {
    /// <summary>
    ///   <para>Google Analytics site identifier (UA-*).</para>
    /// </summary>
    /// <param name="account">Site identifier.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="account"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="account"/> is <see cref="string.Empty"/> string.</exception>
    /// <remarks>This attribute is required.</remarks>
    IGoogleAnalyticsWidget Account(string account);

    /// <summary>
    ///   <para>Google Analytics site domain name.</para>
    /// </summary>
    /// <param name="domain">Site domain name.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="domain"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="domain"/> is <see cref="string.Empty"/> string.</exception>
    /// <remarks>This attribute is required.</remarks>
    IGoogleAnalyticsWidget Domain(string domain);
  }
}