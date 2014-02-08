namespace Catharsis.Web.Widgets
{
  internal sealed class FacebookHtmlHelper : IFacebookHtmlHelper
  {
    public IFacebookInitWidget Initialize()
    {
      return new FacebookInitWidget();
    }

    public IFacebookLikeButtonWidget Like()
    {
      return new FacebookLikeButtonWidget();
    }

    public IFacebookPostWidget Post()
    {
      return new FacebookPostWidget();
    }

    public IFacebookVideoWidget Video()
    {
      return new FacebookVideoWidget();
    }

    public IFacebookVideoLinkWidget VideoLink()
    {
      return new FacebookVideoLinkWidget();
    }
  }
}