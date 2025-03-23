namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="ITumblrWidgetsCreator"/>
public class TumblrWidgetsCreator : ITumblrWidgetsCreator
{
  /// <inheritdoc cref="ITumblrWidgetsCreator.FollowButton()"/>
  public virtual ITumblrFollowButtonWidget FollowButton() => new TumblrFollowButtonWidget();

  /// <inheritdoc cref="ITumblrWidgetsCreator.ShareButton()"/>
  public virtual ITumblrShareButtonWidget ShareButton() => new TumblrShareButtonWidget();
}