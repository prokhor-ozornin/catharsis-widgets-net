using System;
using System.IO;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Adds "ICQ On-Site" widget to web page.</para>
  /// </summary>
  /// <seealso cref="http://api.mail.ru/sites/plugins/icq-on-site"/>
  public sealed class MailRuIcqWidget : HtmlWidgetBase, IMailRuIcqWidget
  {
    private string account;
    private string language;

    /// <summary>
    ///   <para>ICQ UIN number of contact person. If specified, "Ask Me" option will be added to the widget.</para>
    /// </summary>
    /// <param name="account">ICQ UIN number.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="account"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="account"/> is <see cref="string.Empty"/> string.</exception>
    public IMailRuIcqWidget Account(string account)
    {
      Assertion.NotEmpty(account);

      this.account = account;
      return this;
    }

    /// <summary>
    ///   <para>Two-letter ISO language code that determines the interface language. Default is "ru".</para>
    /// </summary>
    /// <param name="language">ISO language code for interface.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="language"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="language"/> is <see cref="string.Empty"/> string.</exception>
    public IMailRuIcqWidget Language(string language)
    {
      Assertion.NotEmpty(language);

      this.language = language;
      return this;
    }

    /// <summary>
    ///   <para>Generates and writes HTML markup of widget, using specified text writer.</para>
    /// </summary>
    /// <param name="writer">Text writer to use as output destination.</param>
    public override void Write(TextWriter writer)
    {
      Assertion.NotNull(writer);

      writer.Write(this.JavaScript("http://c.icq.com/siteim/icqbar/js/partners/initbar_{0}.js".FormatSelf(this.language ?? "ru") .ToUri()));
      if (!this.account.IsEmpty())
      {
        writer.Write(this.JavaScript("window.ICQ = {{siteOwner:'{0}'}};".FormatSelf(this.account)));
      }
    }
  }
}