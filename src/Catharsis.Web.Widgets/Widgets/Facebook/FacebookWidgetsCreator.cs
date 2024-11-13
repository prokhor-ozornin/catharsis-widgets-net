namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IFacebookWidgetsCreator"/>
public class FacebookWidgetsCreator : IFacebookWidgetsCreator
{
  /// <inheritdoc cref="IFacebookWidgetsCreator.ActivityFeed()"/>
  public IFacebookActivityFeedWidget ActivityFeed() => new FacebookActivityFeedWidget();

  /// <inheritdoc cref="IFacebookWidgetsCreator.Comments()"/>
  public IFacebookCommentsWidget Comments() => new FacebookCommentsWidget();

  /// <inheritdoc cref="IFacebookWidgetsCreator.Facepile()"/>
  public IFacebookFacepileWidget Facepile() => new FacebookFacepileWidget();

  /// <inheritdoc cref="IFacebookWidgetsCreator.FollowButton()"/>
  public IFacebookFollowButtonWidget FollowButton() => new FacebookFollowButtonWidget();

  /// <inheritdoc cref="IFacebookWidgetsCreator.Initialize()"/>
  public IFacebookInitializationWidget Initialize() => new FacebookInitializationWidget();

  /// <inheritdoc cref="IFacebookWidgetsCreator.LikeButton()"/>
  public IFacebookLikeButtonWidget LikeButton() => new FacebookLikeButtonWidget();

  /// <inheritdoc cref="IFacebookWidgetsCreator.LikeBox()"/>
  public IFacebookLikeBoxWidget LikeBox() => new FacebookLikeBoxWidget();

  /// <inheritdoc cref="IFacebookWidgetsCreator.Post()"/>
  public IFacebookPostWidget Post() => new FacebookPostWidget();

  /// <inheritdoc cref="IFacebookWidgetsCreator.RecommendationsFeed()"/>
  public IFacebookRecommendationsFeedWidget RecommendationsFeed() => new FacebookRecommendationsFeedWidget();

  /// <inheritdoc cref="IFacebookWidgetsCreator.SendButton()"/>
  public IFacebookSendButtonWidget SendButton() => new FacebookSendButtonWidget();

  /// <inheritdoc cref="IFacebookWidgetsCreator.Video()"/>
  public IFacebookVideoWidget Video() => new FacebookVideoWidget();
}