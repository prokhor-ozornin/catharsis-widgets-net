namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IAddThisWidgetsCreator"/>
public class AddThisWidgetsCreator : IAddThisWidgetsCreator
{
  /// <inheritdoc cref="IAddThisWidgetsCreator.SmartLayers()"/>
  public IAddThisSmartLayersWidget SmartLayers() => new AddThisSmartLayersWidget();

  /// <inheritdoc cref="IAddThisWidgetsCreator.ShareButtons()"/>
  public IAddThisShareButtonsWidget ShareButtons() => new AddThisShareButtonsWidget();

  /// <inheritdoc cref="IAddThisWidgetsCreator.FollowButtons()"/>
  public IAddThisFollowButtonsWidget FollowButtons() => new AddThisFollowButtonsWidget();

  /// <inheritdoc cref="IAddThisWidgetsCreator.WelcomeBar()"/>
  public IAddThisWelcomeBarWidget WelcomeBar() => new AddThisWelcomeBarWidget();

  /// <inheritdoc cref="IAddThisWidgetsCreator.TrendingContent()"/>
  public IAddThisTrendingContentWidget TrendingContent() => new AddThisTrendingContentWidget();
}