namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="ITwitterWidgetCreator"/>
public class TwitterWidgetCreator : ITwitterWidgetCreator
{
  /// <inheritdoc cref="ITwitterWidgetCreator.FollowButton()"/>
  public ITwitterFollowButtonWidget FollowButton() => new TwitterFollowButtonWidget();

  /// <inheritdoc cref="ITwitterWidgetCreator.TweetButton()"/>
  public ITwitterTweetButtonWidget TweetButton() => new TwitterTweetButtonWidget();
}