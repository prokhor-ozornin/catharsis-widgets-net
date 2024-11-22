namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IVkontakteWidgetsCreator"/>
public class VkontakteWidgetsCreator : IVkontakteWidgetsCreator
{
  /// <inheritdoc cref="IVkontakteWidgetsCreator.AuthButton()"/>
  public IVkontakteAuthButtonWidget AuthButton() => new VkontakteAuthButtonWidget();

  /// <inheritdoc cref="IVkontakteWidgetsCreator.Comments()"/>
  public IVkontakteCommentsWidget Comments() => new VkontakteCommentsWidget();

  /// <inheritdoc cref="IVkontakteWidgetsCreator.Community()"/>
  public IVkontakteCommunityWidget Community() => new VkontakteCommunityWidget();

  /// <inheritdoc cref="IVkontakteWidgetsCreator.Initialize()"/>
  public IVkontakteInitializationWidget Initialize() => new VkontakteInitializationWidget();

  /// <inheritdoc cref="IVkontakteWidgetsCreator.LikeButton()"/>
  public IVkontakteLikeButtonWidget LikeButton() => new VkontakteLikeButtonWidget();

  /// <inheritdoc cref="IVkontakteWidgetsCreator.Poll()"/>
  public IVkontaktePollWidget Poll() => new VkontaktePollWidget();

  /// <inheritdoc cref="IVkontakteWidgetsCreator.Post()"/>
  public IVkontaktePostWidget Post() => new VkontaktePostWidget();

  /// <inheritdoc cref="IVkontakteWidgetsCreator.Recommendations()"/>
  public IVkontakteRecommendationsWidget Recommendations() => new VkontakteRecommendationsWidget();

  /// <inheritdoc cref="IVkontakteWidgetCreator.ShareButton()"/>
  //public IVkontakteShareButtonWidget ShareButton() => new VkontakteShareButtonWidget();

  /// <inheritdoc cref="IVkontakteWidgetsCreator.Subscription()"/>
  public IVkontakteSubscriptionWidget Subscription() => new VkontakteSubscriptionWidget();

  /// <inheritdoc cref="IVkontakteWidgetsCreator.Video()"/>
  public IVkontakteVideoWidget Video() => new VkontakteVideoWidget();
}