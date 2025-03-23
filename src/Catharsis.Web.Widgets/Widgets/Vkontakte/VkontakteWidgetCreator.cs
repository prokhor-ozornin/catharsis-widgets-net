namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IVkontakteWidgetsCreator"/>
public class VkontakteWidgetsCreator : IVkontakteWidgetsCreator
{
  /// <inheritdoc cref="IVkontakteWidgetsCreator.AuthButton()"/>
  public virtual IVkontakteAuthButtonWidget AuthButton() => new VkontakteAuthButtonWidget();

  /// <inheritdoc cref="IVkontakteWidgetsCreator.Comments()"/>
  public virtual IVkontakteCommentsWidget Comments() => new VkontakteCommentsWidget();

  /// <inheritdoc cref="IVkontakteWidgetsCreator.Community()"/>
  public virtual IVkontakteCommunityWidget Community() => new VkontakteCommunityWidget();

  /// <inheritdoc cref="IVkontakteWidgetsCreator.Initialize()"/>
  public virtual IVkontakteInitializationWidget Initialize() => new VkontakteInitializationWidget();

  /// <inheritdoc cref="IVkontakteWidgetsCreator.LikeButton()"/>
  public virtual IVkontakteLikeButtonWidget LikeButton() => new VkontakteLikeButtonWidget();

  /// <inheritdoc cref="IVkontakteWidgetsCreator.Poll()"/>
  public virtual IVkontaktePollWidget Poll() => new VkontaktePollWidget();

  /// <inheritdoc cref="IVkontakteWidgetsCreator.Post()"/>
  public virtual IVkontaktePostWidget Post() => new VkontaktePostWidget();

  /// <inheritdoc cref="IVkontakteWidgetsCreator.Recommendations()"/>
  public virtual IVkontakteRecommendationsWidget Recommendations() => new VkontakteRecommendationsWidget();

  /// <inheritdoc cref="IVkontakteWidgetCreator.ShareButton()"/>
  //public virtual IVkontakteShareButtonWidget ShareButton() => new VkontakteShareButtonWidget();

  /// <inheritdoc cref="IVkontakteWidgetsCreator.Subscription()"/>
  public virtual IVkontakteSubscriptionWidget Subscription() => new VkontakteSubscriptionWidget();

  /// <inheritdoc cref="IVkontakteWidgetsCreator.Video()"/>
  public virtual IVkontakteVideoWidget Video() => new VkontakteVideoWidget();
}