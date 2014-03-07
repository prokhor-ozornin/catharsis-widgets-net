using System.IO;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  public sealed class MailRuVideoLinkWidget : HtmlWidgetBase<IMailRuVideoLinkWidget>, IMailRuVideoLinkWidget
  {
    private string id;

    public IMailRuVideoLinkWidget Id(string id)
    {
      Assertion.NotEmpty(id);

      this.id = id;
      return this;
    }

    public override void Write(TextWriter writer)
    {
      Assertion.NotNull(writer);

      if (this.id.IsEmpty())
      {
        return;
      }

      writer.Write(this.ToTag("a", tag => tag
        .Attribute("href","http://my.mail.ru/video/mail/{0}".FormatSelf(this.id))
        .InnerHtml(this.HtmlBody)));
    }
  }
}