namespace Catharsis.Web.Widgets
{
  internal sealed class VkontakteHtmlHelper : IVkontakteHtmlHelper
  {
    public IVkontakteAuthButtonWidget AuthButton()
    {
      return new VkontakteAuthButtonWidget();
    }

    public IVkontakteCommentsWidget Comments()
    {
      return new VkontakteCommentsWidget();
    }

    public IVkontakteCommunityWidget Community()
    {
      return new VkontakteCommunityWidget();
    }

    public IVkontakteInitializationWidget Initialize()
    {
      return new VkontakteInitializationWidget();
    }

    public IVkontakteLikeButtonWidget LikeButton()
    {
      return new VkontakteLikeButtonWidget();
    }

    public IVkontaktePollWidget Poll()
    {
      return new VkontaktePollWidget();
    }

    public IVkontaktePostWidget Post()
    {
      return new VkontaktePostWidget();
    }

    public IVkontakteRecommendationsWidget Recommendations()
    {
      return new VkontakteRecommendationsWidget();
    }

    /*public IVkontakteShareButtonWidget ShareButton()
    {
      return new VkontakteShareButtonWidget();
    }*/

    public IVkontakteSubscriptionWidget Subscription()
    {
      return new VkontakteSubscriptionWidget();
    }

    public IVkontakteVideoWidget Video()
    {
      return new VkontakteVideoWidget();
    }
  }
}