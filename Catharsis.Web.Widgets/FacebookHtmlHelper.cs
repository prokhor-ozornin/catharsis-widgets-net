namespace Catharsis.Web.Widgets
{
  internal sealed class FacebookHtmlHelper : IFacebookHtmlHelper
  {
    public IFacebookInitWidget Initialize()
    {
      return new FacebookInitWidget();
    }

    public IFacebookActivityFeedWidget ActivityFeed()
    {
      return new FacebookActivityFeedWidget();
    }

    public IFacebookRecommendationsFeedWidget RecommendationsFeed()
    {
      return new FacebookRecommendationsFeedWidget();
    }

    public IFacebookCommentsWidget Comments()
    {
      return new FacebookCommentsWidget();
    }

    public IFacebookFacepileWidget Facepile()
    {
      return new FacebookFacepileWidget();
    }

    public IFacebookFollowButtonWidget Follow()
    {
      return new FacebookFollowButtonWidget();
    }

    public IFacebookLikeButtonWidget Like()
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

    public IFacebookSendButtonWidget Send()
    {
      return new FacebookSendButtonWidget();
    }

    public IFacebookVideoWidget Video()
    {
      return new FacebookVideoWidget();
    }

    public IFacebookVideoLinkWidget VideoLink()
    {
      return new FacebookVideoLinkWidget();
    }
  }
}