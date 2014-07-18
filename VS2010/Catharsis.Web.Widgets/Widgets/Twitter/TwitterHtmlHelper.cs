namespace Catharsis.Web.Widgets
{
  internal sealed class TwitterHtmlHelper : ITwitterHtmlHelper
  {
    public ITwitterFollowButtonWidget FollowButton()
    {
      return new TwitterFollowButtonWidget();
    }

    public ITwitterTweetButtonWidget TweetButton()
    {
      return new TwitterTweetButtonWidget();
    }
  }
}