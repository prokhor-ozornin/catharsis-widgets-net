namespace Catharsis.Web.Widgets
{
  internal sealed class MailRuHtmlHelper : IMailRuHtmlHelper
  {
    public IMailRuIcqWidget Icq()
    {
      return new MailRuIcqWidget();
    }

    public IMailRuLikeButtonWidget Like()
    {
      return new MailRuLikeButtonWidget();
    }

    public IMailRuVideoWidget Video()
    {
      return new MailRuVideoWidget();
    }

    public IMailRuVideoLinkWidget VideoLink()
    {
      return new MailRuVideoLinkWidget();
    }
  }
}