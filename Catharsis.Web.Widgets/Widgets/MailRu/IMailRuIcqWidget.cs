using System;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Adds "ICQ On-Site" widget to web page.</para>
  /// </summary>
  /// <seealso cref="http://api.mail.ru/sites/plugins/icq-on-site"/>
  public interface IMailRuIcqWidget : IHtmlWidget
  {
    /// <summary>
    ///   <para>ICQ UIN number of contact person. If specified, "Ask Me" option will be added to the widget.</para>
    /// </summary>
    /// <param name="account">ICQ UIN number.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="account"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="account"/> is <see cref="string.Empty"/> string.</exception>
    IMailRuIcqWidget Account(string account);

    /// <summary>
    ///   <para>ICQ UIN number of contact person. If specified, "Ask Me" option will be added to the widget.</para>
    /// </summary>
    /// <returns>ICQ UIN number.</returns>
    string Account();

    /// <summary>
    ///   <para>Two-letter ISO language code that determines the interface language. Default is "ru".</para>
    /// </summary>
    /// <param name="language">ISO language code for interface.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="language"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="language"/> is <see cref="string.Empty"/> string.</exception>
    IMailRuIcqWidget Language(string language);

    /// <summary>
    ///   <para>Two-letter ISO language code that determines the interface language. Default is "ru".</para>
    /// </summary>
    /// <returns>ISO language code for interface.</returns>
    string Language();
  }
}