namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IPinterestWidgetsCreator"/>
public class PinterestWidgetsCreator : IPinterestWidgetsCreator
{
  /// <inheritdoc cref="IPinterestWidgetsCreator.Board()"/>
  public virtual IPinterestBoardWidget Board() => new PinterestBoardWidget();

  /// <inheritdoc cref="IPinterestWidgetsCreator.FollowButton()"/>
  public virtual IPinterestFollowButtonWidget FollowButton() => new PinterestFollowButtonWidget();

  /// <inheritdoc cref="IPinterestWidgetsCreator.PinItButton()"/>
  public virtual IPinterestPinItButtonWidget PinItButton() => new PinterestPinItButtonWidget();

  /// <inheritdoc cref="IPinterestWidgetsCreator.Pin()"/>
  public virtual IPinterestPinWidget Pin() => new PinterestPinWidget();

  /// <inheritdoc cref="IPinterestWidgetsCreator.Profile()"/>
  public virtual IPinterestProfileWidget Profile() => new PinterestProfileWidget();
}