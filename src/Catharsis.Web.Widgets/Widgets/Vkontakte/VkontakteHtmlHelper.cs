namespace Catharsis.Web.Widgets;

internal sealed class VkontakteHtmlHelper : IVkontakteHtmlHelper
{
  public IVkontakteAuthButtonWidget AuthButton() => new VkontakteAuthButtonWidget();

  public IVkontakteCommentsWidget Comments() => new VkontakteCommentsWidget();

  public IVkontakteCommunityWidget Community() => new VkontakteCommunityWidget();

  public IVkontakteInitializationWidget Initialize() => new VkontakteInitializationWidget();

  public IVkontakteLikeButtonWidget LikeButton() => new VkontakteLikeButtonWidget();

  public IVkontaktePollWidget Poll() => new VkontaktePollWidget();

  public IVkontaktePostWidget Post() => new VkontaktePostWidget();

  public IVkontakteRecommendationsWidget Recommendations() => new VkontakteRecommendationsWidget();

  //public IVkontakteShareButtonWidget ShareButton() => new VkontakteShareButtonWidget();

  public IVkontakteSubscriptionWidget Subscription() => new VkontakteSubscriptionWidget();

  public IVkontakteVideoWidget Video() => new VkontakteVideoWidget();
}