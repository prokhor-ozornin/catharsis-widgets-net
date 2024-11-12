namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IFacebookHtmlHelper"/>
public class FacebookHtmlHelper : IFacebookHtmlHelper
{
  /// <inheritdoc cref="IFacebookHtmlHelper.ActivityFeed()"/>
  public IFacebookActivityFeedWidget ActivityFeed() => new FacebookActivityFeedWidget();

  /// <inheritdoc cref="IFacebookHtmlHelper.Comments()"/>
  public IFacebookCommentsWidget Comments() => new FacebookCommentsWidget();

  /// <inheritdoc cref="IFacebookHtmlHelper.Facepile()"/>
  public IFacebookFacepileWidget Facepile() => new FacebookFacepileWidget();

  /// <inheritdoc cref="IFacebookHtmlHelper.FollowButton()"/>
  public IFacebookFollowButtonWidget FollowButton() => new FacebookFollowButtonWidget();

  /// <inheritdoc cref="IFacebookHtmlHelper.Initialize()"/>
  public IFacebookInitializationWidget Initialize() => new FacebookInitializationWidget();

  /// <inheritdoc cref="IFacebookHtmlHelper.LikeButton()"/>
  public IFacebookLikeButtonWidget LikeButton() => new FacebookLikeButtonWidget();

  /// <inheritdoc cref="IFacebookHtmlHelper.LikeBox()"/>
  public IFacebookLikeBoxWidget LikeBox() => new FacebookLikeBoxWidget();

  /// <inheritdoc cref="IFacebookHtmlHelper.Post()"/>
  public IFacebookPostWidget Post() => new FacebookPostWidget();

  /// <inheritdoc cref="IFacebookHtmlHelper.RecommendationsFeed()"/>
  public IFacebookRecommendationsFeedWidget RecommendationsFeed() => new FacebookRecommendationsFeedWidget();

  /// <inheritdoc cref="IFacebookHtmlHelper.SendButton()"/>
  public IFacebookSendButtonWidget SendButton() => new FacebookSendButtonWidget();

  /// <inheritdoc cref="IFacebookHtmlHelper.Video()"/>
  public IFacebookVideoWidget Video() => new FacebookVideoWidget();
}