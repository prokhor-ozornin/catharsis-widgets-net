namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IPinterestWidgetCreator"/>
public class PinterestWidgetCreator : IPinterestWidgetCreator
{
  /// <inheritdoc cref="IPinterestWidgetCreator.Board()"/>
  public IPinterestBoardWidget Board() => new PinterestBoardWidget();

  /// <inheritdoc cref="IPinterestWidgetCreator.FollowButton()"/>
  public IPinterestFollowButtonWidget FollowButton() => new PinterestFollowButtonWidget();

  /// <inheritdoc cref="IPinterestWidgetCreator.PinItButton()"/>
  public IPinterestPinItButtonWidget PinItButton() => new PinterestPinItButtonWidget();

  /// <inheritdoc cref="IPinterestWidgetCreator.Pin()"/>
  public IPinterestPinWidget Pin() => new PinterestPinWidget();

  /// <inheritdoc cref="IPinterestWidgetCreator.Profile()"/>
  public IPinterestProfileWidget Profile() => new PinterestProfileWidget();
}