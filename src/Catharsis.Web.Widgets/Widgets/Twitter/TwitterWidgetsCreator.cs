namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="ITwitterWidgetsCreator"/>
public class TwitterWidgetsCreator : ITwitterWidgetsCreator
{
  /// <inheritdoc cref="ITwitterWidgetsCreator.FollowButton()"/>
  public virtual ITwitterFollowButtonWidget FollowButton() => new TwitterFollowButtonWidget();

  /// <inheritdoc cref="ITwitterWidgetsCreator.TweetButton()"/>
  public virtual ITwitterTweetButtonWidget TweetButton() => new TwitterTweetButtonWidget();
}