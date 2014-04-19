namespace Catharsis.Web.Widgets
{
  internal sealed class TwitterHtmlHelper : ITwitterHtmlHelper
  {
    public ITwitterFollowButtonWidget Follow()
    {
      return new TwitterFollowButtonWidget();
    }

    public ITwitterTweetButtonWidget Tweet()
    {
      return new TwitterTweetButtonWidget();
    }
  }
}