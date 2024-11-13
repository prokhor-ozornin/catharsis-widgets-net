namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="ITumblrWidgetCreator"/>
public class TumblrWidgetCreator : ITumblrWidgetCreator
{
  /// <inheritdoc cref="ITumblrWidgetCreator.FollowButton()"/>
  public ITumblrFollowButtonWidget FollowButton() => new TumblrFollowButtonWidget();

  /// <inheritdoc cref="ITumblrWidgetCreator.ShareButton()"/>
  public ITumblrShareButtonWidget ShareButton() => new TumblrShareButtonWidget();
}