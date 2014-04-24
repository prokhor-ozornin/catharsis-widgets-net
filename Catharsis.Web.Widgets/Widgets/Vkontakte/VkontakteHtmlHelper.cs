namespace Catharsis.Web.Widgets
{
  internal sealed class VkontakteHtmlHelper : IVkontakteHtmlHelper
  {
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