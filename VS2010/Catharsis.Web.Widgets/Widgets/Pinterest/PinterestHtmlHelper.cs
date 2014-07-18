namespace Catharsis.Web.Widgets
{
  internal sealed class PinterestHtmlHelper : IPinterestHtmlHelper
  {
    public IPinterestBoardWidget Board()
    {
      return new PinterestBoardWidget();
    }

    public IPinterestFollowButtonWidget FollowButton()
    {
      return new PinterestFollowButtonWidget();
    }

    public IPinterestPinItButtonWidget PinItButton()
    {
      return new PinterestPinItButtonWidget();
    }

    public IPinterestPinWidget Pin()
    {
      return new PinterestPinWidget();
    }

    public IPinterestProfileWidget Profile()
    {
      return new PinterestProfileWidget();
    }
  }
}