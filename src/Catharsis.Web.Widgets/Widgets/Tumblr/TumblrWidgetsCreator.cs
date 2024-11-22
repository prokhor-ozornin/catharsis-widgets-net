namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="ITumblrWidgetsCreator"/>
public class TumblrWidgetsCreator : ITumblrWidgetsCreator
{
  /// <inheritdoc cref="ITumblrWidgetsCreator.FollowButton()"/>
  public ITumblrFollowButtonWidget FollowButton() => new TumblrFollowButtonWidget();

  /// <inheritdoc cref="ITumblrWidgetsCreator.ShareButton()"/>
  public ITumblrShareButtonWidget ShareButton() => new TumblrShareButtonWidget();
}