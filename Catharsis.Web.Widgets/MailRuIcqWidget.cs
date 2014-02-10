using System.IO;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  public sealed class MailRuIcqWidget : HtmlWidgetBase<IMailRuIcqWidget>, IMailRuIcqWidget
  {
    private string account;
    private string language;

    public IMailRuIcqWidget Account(string account)
    {
      Assertion.NotEmpty(account);

      this.account = account;
      return this;
    }

    public IMailRuIcqWidget Language(string language)
    {
      Assertion.NotEmpty(language);

      this.language = language;
      return this;
    }

    public override void Write(TextWriter writer)
    {
      Assertion.NotNull(writer);

      writer.Write(this.JavaScript("http://c.icq.com/siteim/icqbar/js/partners/initbar_{0}.js".FormatValue(this.language ?? "ru") .ToUri()));
      if (!this.account.IsEmpty())
      {
        writer.Write(this.JavaScript("window.ICQ = {{siteOwner:'{0}'}};".FormatValue(this.account)));
      }
    }
  }
}