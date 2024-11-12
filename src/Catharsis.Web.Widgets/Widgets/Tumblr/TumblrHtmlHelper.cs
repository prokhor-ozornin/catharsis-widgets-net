namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="ITumblrHtmlHelper"/>
public class TumblrHtmlHelper : ITumblrHtmlHelper
{
  /// <inheritdoc cref="ITumblrHtmlHelper.FollowButton()"/>
  public ITumblrFollowButtonWidget FollowButton() => new TumblrFollowButtonWidget();

  /// <inheritdoc cref="ITumblrHtmlHelper.ShareButton()"/>
  public ITumblrShareButtonWidget ShareButton() => new TumblrShareButtonWidget();
}