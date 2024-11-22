namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IPinterestWidgetsCreator"/>
public class PinterestWidgetsCreator : IPinterestWidgetsCreator
{
  /// <inheritdoc cref="IPinterestWidgetsCreator.Board()"/>
  public IPinterestBoardWidget Board() => new PinterestBoardWidget();

  /// <inheritdoc cref="IPinterestWidgetsCreator.FollowButton()"/>
  public IPinterestFollowButtonWidget FollowButton() => new PinterestFollowButtonWidget();

  /// <inheritdoc cref="IPinterestWidgetsCreator.PinItButton()"/>
  public IPinterestPinItButtonWidget PinItButton() => new PinterestPinItButtonWidget();

  /// <inheritdoc cref="IPinterestWidgetsCreator.Pin()"/>
  public IPinterestPinWidget Pin() => new PinterestPinWidget();

  /// <inheritdoc cref="IPinterestWidgetsCreator.Profile()"/>
  public IPinterestProfileWidget Profile() => new PinterestProfileWidget();
}