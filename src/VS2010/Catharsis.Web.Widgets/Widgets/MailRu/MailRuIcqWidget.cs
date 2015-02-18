using System;
using System.Text;
using System.Web.Mvc;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Adds "ICQ On-Site" widget to web page.</para>
  /// </summary>
  /// <seealso cref="http://api.mail.ru/sites/plugins/icq-on-site"/>
  public class MailRuIcqWidget : HtmlWidget, IMailRuIcqWidget
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
    ///   <para>ICQ UIN number of contact person. If specified, "Ask Me" option will be added to the widget.</para>
    /// </summary>
    /// <returns>ICQ UIN number.</returns>
    public string Account()
    {
      return this.account;
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
    ///   <para>Two-letter ISO language code that determines the interface language. Default is "ru".</para>
    /// </summary>
    /// <returns>ISO language code for interface.</returns>
    public string Language()
    {
      return this.language;
    }

    /// <summary>
    ///   <para>Returns HTML markup text of widget.</para>
    /// </summary>
    /// <returns>Widget's HTML markup.</returns>
    public override string ToHtmlString()
    {
      var builder = new StringBuilder()
        .Append(new TagBuilder("script")
          .Attribute("type", "text/javascript")
          .Attribute("src", "http://c.icq.com/siteim/icqbar/js/partners/initbar_{0}.js".FormatSelf(this.Language() ?? "ru")));
      
      if (!this.Account().IsEmpty())
      {
        builder.Append(new TagBuilder("script").Attribute("type", "text/javascript").InnerHtml("window.ICQ = {{siteOwner:'{0}'}};".FormatSelf(this.Account())));
      }

      return builder.ToString();
    }
  }
}