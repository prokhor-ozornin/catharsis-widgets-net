namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IFacebookWidgetsCreator"/>
public class FacebookWidgetsCreator : IFacebookWidgetsCreator
{
  /// <inheritdoc cref="IFacebookWidgetsCreator.ActivityFeed()"/>
  public virtual IFacebookActivityFeedWidget ActivityFeed() => new FacebookActivityFeedWidget();

  /// <inheritdoc cref="IFacebookWidgetsCreator.Comments()"/>
  public virtual IFacebookCommentsWidget Comments() => new FacebookCommentsWidget();

  /// <inheritdoc cref="IFacebookWidgetsCreator.FacePile"/>
  public virtual IFacebookFacePileWidget FacePile() => new FacebookFacePileWidget();

  /// <inheritdoc cref="IFacebookWidgetsCreator.FollowButton()"/>
  public virtual IFacebookFollowButtonWidget FollowButton() => new FacebookFollowButtonWidget();

  /// <inheritdoc cref="IFacebookWidgetsCreator.Initialize()"/>
  public virtual IFacebookInitializationWidget Initialize() => new FacebookInitializationWidget();

  /// <inheritdoc cref="IFacebookWidgetsCreator.LikeButton()"/>
  public virtual IFacebookLikeButtonWidget LikeButton() => new FacebookLikeButtonWidget();

  /// <inheritdoc cref="IFacebookWidgetsCreator.LikeBox()"/>
  public virtual IFacebookLikeBoxWidget LikeBox() => new FacebookLikeBoxWidget();

  /// <inheritdoc cref="IFacebookWidgetsCreator.Post()"/>
  public virtual IFacebookPostWidget Post() => new FacebookPostWidget();

  /// <inheritdoc cref="IFacebookWidgetsCreator.RecommendationsFeed()"/>
  public virtual IFacebookRecommendationsFeedWidget RecommendationsFeed() => new FacebookRecommendationsFeedWidget();

  /// <inheritdoc cref="IFacebookWidgetsCreator.SendButton()"/>
  public virtual IFacebookSendButtonWidget SendButton() => new FacebookSendButtonWidget();

  /// <inheritdoc cref="IFacebookWidgetsCreator.Video()"/>
  public virtual IFacebookVideoWidget Video() => new FacebookVideoWidget();
}