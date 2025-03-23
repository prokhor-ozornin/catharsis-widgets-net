namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IAddThisWidgetsCreator"/>
public class AddThisWidgetsCreator : IAddThisWidgetsCreator
{
  /// <inheritdoc cref="IAddThisWidgetsCreator.SmartLayers()"/>
  public virtual IAddThisSmartLayersWidget SmartLayers() => new AddThisSmartLayersWidget();

  /// <inheritdoc cref="IAddThisWidgetsCreator.ShareButtons()"/>
  public virtual IAddThisShareButtonsWidget ShareButtons() => new AddThisShareButtonsWidget();

  /// <inheritdoc cref="IAddThisWidgetsCreator.FollowButtons()"/>
  public virtual IAddThisFollowButtonsWidget FollowButtons() => new AddThisFollowButtonsWidget();

  /// <inheritdoc cref="IAddThisWidgetsCreator.WelcomeBar()"/>
  public virtual IAddThisWelcomeBarWidget WelcomeBar() => new AddThisWelcomeBarWidget();

  /// <inheritdoc cref="IAddThisWidgetsCreator.TrendingContent()"/>
  public virtual IAddThisTrendingContentWidget TrendingContent() => new AddThisTrendingContentWidget();
}