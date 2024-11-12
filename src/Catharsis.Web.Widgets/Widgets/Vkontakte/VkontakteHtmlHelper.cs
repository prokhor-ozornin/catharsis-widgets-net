namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IVkontakteHtmlHelper"/>
public class VkontakteHtmlHelper : IVkontakteHtmlHelper
{
  /// <inheritdoc cref="IVkontakteHtmlHelper.AuthButton()"/>
  public IVkontakteAuthButtonWidget AuthButton() => new VkontakteAuthButtonWidget();

  /// <inheritdoc cref="IVkontakteHtmlHelper.Comments()"/>
  public IVkontakteCommentsWidget Comments() => new VkontakteCommentsWidget();

  /// <inheritdoc cref="IVkontakteHtmlHelper.Community()"/>
  public IVkontakteCommunityWidget Community() => new VkontakteCommunityWidget();

  /// <inheritdoc cref="IVkontakteHtmlHelper.Initialize()"/>
  public IVkontakteInitializationWidget Initialize() => new VkontakteInitializationWidget();

  /// <inheritdoc cref="IVkontakteHtmlHelper.LikeButton()"/>
  public IVkontakteLikeButtonWidget LikeButton() => new VkontakteLikeButtonWidget();

  /// <inheritdoc cref="IVkontakteHtmlHelper.Poll()"/>
  public IVkontaktePollWidget Poll() => new VkontaktePollWidget();

  /// <inheritdoc cref="IVkontakteHtmlHelper.Post()"/>
  public IVkontaktePostWidget Post() => new VkontaktePostWidget();

  /// <inheritdoc cref="IVkontakteHtmlHelper.Recommendations()"/>
  public IVkontakteRecommendationsWidget Recommendations() => new VkontakteRecommendationsWidget();

  /// <inheritdoc cref="IVkontakteHtmlHelper.ShareButton()"/>
  //public IVkontakteShareButtonWidget ShareButton() => new VkontakteShareButtonWidget();

  /// <inheritdoc cref="IVkontakteHtmlHelper.Subscription()"/>
  public IVkontakteSubscriptionWidget Subscription() => new VkontakteSubscriptionWidget();

  /// <inheritdoc cref="IVkontakteHtmlHelper.Video()"/>
  public IVkontakteVideoWidget Video() => new VkontakteVideoWidget();
}