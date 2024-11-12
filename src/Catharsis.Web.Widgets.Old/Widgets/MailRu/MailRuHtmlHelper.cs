namespace Catharsis.Web.Widgets
{
  internal sealed class MailRuHtmlHelper : IMailRuHtmlHelper
  {
    public IMailRuFacesWidget Faces() => new MailRuFacesWidget();

    public IMailRuGroupsWidget Groups() => new MailRuGroupsWidget();

    public IMailRuIcqWidget Icq() => new MailRuIcqWidget();

    public IMailRuLikeButtonWidget LikeButton() => new MailRuLikeButtonWidget();

    public IMailRuVideoWidget Video() => new MailRuVideoWidget();
  }
}