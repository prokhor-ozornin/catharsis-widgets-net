namespace Catharsis.Web.Widgets
{
  internal sealed class TumblrHtmlHelper : ITumblrHtmlHelper
  {
    public ITumblrFollowButtonWidget Follow()
    {
      return new TumblrFollowButtonWidget();
    }

    public ITumblrShareButtonWidget Share()
    {
      return new TumblrShareButtonWidget();
    }
  }
}