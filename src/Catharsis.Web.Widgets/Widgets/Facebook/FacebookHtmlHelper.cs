namespace Catharsis.Web.Widgets
{
  internal sealed class FacebookHtmlHelper : IFacebookHtmlHelper
  {
    public IFacebookActivityFeedWidget ActivityFeed()
    {
      return new FacebookActivityFeedWidget();
    }

    public IFacebookCommentsWidget Comments()
    {
      return new FacebookCommentsWidget();
    }

    public IFacebookFacepileWidget Facepile()
    {
      return new FacebookFacepileWidget();
    }

    public IFacebookFollowButtonWidget FollowButton()
    {
      return new FacebookFollowButtonWidget();
    }

    public IFacebookInitializationWidget Initialize()
    {
      return new FacebookInitializationWidget();
    }

    public IFacebookLikeButtonWidget LikeButton()
    {
      return new FacebookLikeButtonWidget();
    }

    public IFacebookLikeBoxWidget LikeBox()
    {
      return new FacebookLikeBoxWidget();
    }

    public IFacebookPostWidget Post()
    {
      return new FacebookPostWidget();
    }

    public IFacebookRecommendationsFeedWidget RecommendationsFeed()
    {
      return new FacebookRecommendationsFeedWidget();
    }

    public IFacebookSendButtonWidget SendButton()
    {
      return new FacebookSendButtonWidget();
    }

    public IFacebookVideoWidget Video()
    {
      return new FacebookVideoWidget();
    }
  }
}