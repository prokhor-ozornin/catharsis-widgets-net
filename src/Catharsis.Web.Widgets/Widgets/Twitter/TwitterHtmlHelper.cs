namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="ITwitterHtmlHelper"/>
public class TwitterHtmlHelper : ITwitterHtmlHelper
{
  /// <inheritdoc cref="ITwitterHtmlHelper.FollowButton()"/>
  public ITwitterFollowButtonWidget FollowButton() => new TwitterFollowButtonWidget();

  /// <inheritdoc cref="ITwitterHtmlHelper.TweetButton()"/>
  public ITwitterTweetButtonWidget TweetButton() => new TwitterTweetButtonWidget();
}