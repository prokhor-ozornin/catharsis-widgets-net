namespace Catharsis.Web.Widgets
{
  internal sealed class TumblrHtmlHelper : ITumblrHtmlHelper
  {
    public ITumblrFollowButtonWidget FollowButton() => new TumblrFollowButtonWidget();

    public ITumblrShareButtonWidget ShareButton() => new TumblrShareButtonWidget();
  }
}