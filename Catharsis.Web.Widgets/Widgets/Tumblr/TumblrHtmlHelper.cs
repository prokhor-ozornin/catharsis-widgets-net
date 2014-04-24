namespace Catharsis.Web.Widgets
{
  internal sealed class TumblrHtmlHelper : ITumblrHtmlHelper
  {
    public ITumblrFollowButtonWidget FollowButton()
    {
      return new TumblrFollowButtonWidget();
    }

    public ITumblrShareButtonWidget ShareButton()
    {
      return new TumblrShareButtonWidget();
    }
  }
}