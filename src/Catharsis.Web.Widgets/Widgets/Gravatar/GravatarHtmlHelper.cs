namespace Catharsis.Web.Widgets
{
  internal sealed class GravatarHtmlHelper : IGravatarHtmlHelper
  {
    public IGravatarImageUrlWidget ImageUrl()
    {
      return new GravatarImageUrlWidget();
    }

    public IGravatarProfileUrlWidget ProfileUrl()
    {
      return new GravatarProfileUrlWidget();
    }
  }
}