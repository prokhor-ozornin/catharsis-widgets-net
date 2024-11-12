namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IPinterestHtmlHelper"/>
public class PinterestHtmlHelper : IPinterestHtmlHelper
{
  /// <inheritdoc cref="IPinterestHtmlHelper.Board()"/>
  public IPinterestBoardWidget Board() => new PinterestBoardWidget();

  /// <inheritdoc cref="IPinterestHtmlHelper.FollowButton()"/>
  public IPinterestFollowButtonWidget FollowButton() => new PinterestFollowButtonWidget();

  /// <inheritdoc cref="IPinterestHtmlHelper.PinItButton()"/>
  public IPinterestPinItButtonWidget PinItButton() => new PinterestPinItButtonWidget();

  /// <inheritdoc cref="IPinterestHtmlHelper.Pin()"/>
  public IPinterestPinWidget Pin() => new PinterestPinWidget();

  /// <inheritdoc cref="IPinterestHtmlHelper.Profile()"/>
  public IPinterestProfileWidget Profile() => new PinterestProfileWidget();
}