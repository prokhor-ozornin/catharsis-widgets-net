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

    public IVkontakteInitWidget Initialize()
    {
      return new VkontakteInitWidget();
    }

    public IVkontakteLikeButtonWidget Like()
    {
      return new VkontakteLikeButtonWidget();
    }

    public IVkontakteSubscriptionWidget Subscribe()
    {
      return new VkontakteSubscriptionWidget();
    }

    public IVkontakteVideoWidget Video()
    {
      return new VkontakteVideoWidget();
    }
  }
}