namespace Catharsis.Web.Widgets
{
  internal sealed class TwitterHtmlHelper : ITwitterHtmlHelper
  {
    public ITwitterFollowButtonWidget FollowButton() => new TwitterFollowButtonWidget();

    public ITwitterTweetButtonWidget TweetButton() => new TwitterTweetButtonWidget();
  }
}