namespace Catharsis.Web.Widgets
{
  internal sealed class VkontakteHtmlHelper : IVkontakteHtmlHelper
  {
    public IVkontakteVideoWidget Video()
    {
      return new VkontakteVideoWidget();
    }

    public IVkontakteInitWidget Initialize()
    {
      return new VkontakteInitWidget();
    }

    public IVkontakteCommentsWidget Comments()
    {
      return new VkontakteCommentsWidget();
    }

    public IVkontakteCommunityWidget Community()
    {
      return new VkontakteCommunityWidget();
    }

    public IVkontakteLikeButtonWidget Like()
    {
      return new VkontakteLikeButtonWidget();
    }

    public IVkontakteSubscriptionWidget Subscribe()
    {
      return new VkontakteSubscriptionWidget();
    }
  }
}