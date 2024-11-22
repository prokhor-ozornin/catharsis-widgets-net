namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="ITwitterWidgetsCreator"/>
public class TwitterWidgetsCreator : ITwitterWidgetsCreator
{
  /// <inheritdoc cref="ITwitterWidgetsCreator.FollowButton()"/>
  public ITwitterFollowButtonWidget FollowButton() => new TwitterFollowButtonWidget();

  /// <inheritdoc cref="ITwitterWidgetsCreator.TweetButton()"/>
  public ITwitterTweetButtonWidget TweetButton() => new TwitterTweetButtonWidget();
}