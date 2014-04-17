namespace Catharsis.Web.Widgets
{
  internal sealed class MailRuHtmlHelper : IMailRuHtmlHelper
  {
    public IMailRuFacesWidget Faces()
    {
      return new MailRuFacesWidget();
    }

    public IMailRuGroupsWidget Groups()
    {
      return new MailRuGroupsWidget();
    }

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
  }
}