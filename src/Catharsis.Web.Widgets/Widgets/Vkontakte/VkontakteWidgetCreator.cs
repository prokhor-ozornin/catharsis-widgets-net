namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IVkontakteWidgetCreator"/>
public class VkontakteWidgetCreator : IVkontakteWidgetCreator
{
  /// <inheritdoc cref="IVkontakteWidgetCreator.AuthButton()"/>
  public IVkontakteAuthButtonWidget AuthButton() => new VkontakteAuthButtonWidget();

  /// <inheritdoc cref="IVkontakteWidgetCreator.Comments()"/>
  public IVkontakteCommentsWidget Comments() => new VkontakteCommentsWidget();

  /// <inheritdoc cref="IVkontakteWidgetCreator.Community()"/>
  public IVkontakteCommunityWidget Community() => new VkontakteCommunityWidget();

  /// <inheritdoc cref="IVkontakteWidgetCreator.Initialize()"/>
  public IVkontakteInitializationWidget Initialize() => new VkontakteInitializationWidget();

  /// <inheritdoc cref="IVkontakteWidgetCreator.LikeButton()"/>
  public IVkontakteLikeButtonWidget LikeButton() => new VkontakteLikeButtonWidget();

  /// <inheritdoc cref="IVkontakteWidgetCreator.Poll()"/>
  public IVkontaktePollWidget Poll() => new VkontaktePollWidget();

  /// <inheritdoc cref="IVkontakteWidgetCreator.Post()"/>
  public IVkontaktePostWidget Post() => new VkontaktePostWidget();

  /// <inheritdoc cref="IVkontakteWidgetCreator.Recommendations()"/>
  public IVkontakteRecommendationsWidget Recommendations() => new VkontakteRecommendationsWidget();

  /// <inheritdoc cref="IVkontakteWidgetCreator.ShareButton()"/>
  //public IVkontakteShareButtonWidget ShareButton() => new VkontakteShareButtonWidget();

  /// <inheritdoc cref="IVkontakteWidgetCreator.Subscription()"/>
  public IVkontakteSubscriptionWidget Subscription() => new VkontakteSubscriptionWidget();

  /// <inheritdoc cref="IVkontakteWidgetCreator.Video()"/>
  public IVkontakteVideoWidget Video() => new VkontakteVideoWidget();
}