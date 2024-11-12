namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IAddThisHtmlHelper"/>
public class AddThisHtmlHelper : IAddThisHtmlHelper
{
  /// <inheritdoc cref="IAddThisHtmlHelper.SmartLayers()"/>
  public IAddThisSmartLayersWidget SmartLayers() => new AddThisSmartLayersWidget();

  /// <inheritdoc cref="IAddThisHtmlHelper.ShareButtons()"/>
  public IAddThisShareButtonsWidget ShareButtons() => new AddThisShareButtonsWidget();

  /// <inheritdoc cref="IAddThisHtmlHelper.FollowButtons()"/>
  public IAddThisFollowButtonsWidget FollowButtons() => new AddThisFollowButtonsWidget();

  /// <inheritdoc cref="IAddThisHtmlHelper.WelcomeBar()"/>
  public IAddThisWelcomeBarWidget WelcomeBar() => new AddThisWelcomeBarWidget();

  /// <inheritdoc cref="IAddThisHtmlHelper.TrendingContent()"/>
  public IAddThisTrendingContentWidget TrendingContent() => new AddThisTrendingContentWidget();
}