namespace Catharsis.Web.Widgets;

internal sealed class PinterestHtmlHelper : IPinterestHtmlHelper
{
  public IPinterestBoardWidget Board() => new PinterestBoardWidget();

  public IPinterestFollowButtonWidget FollowButton() => new PinterestFollowButtonWidget();

  public IPinterestPinItButtonWidget PinItButton() => new PinterestPinItButtonWidget();

  public IPinterestPinWidget Pin() => new PinterestPinWidget();

  public IPinterestProfileWidget Profile() => new PinterestProfileWidget();
}