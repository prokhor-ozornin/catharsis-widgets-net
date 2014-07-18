namespace Catharsis.Web.Widgets
{
  internal sealed class AddThisHtmlHelper : IAddThisHtmlHelper
  {
    public IAddThisSmartLayersWidget SmartLayers()
    {
      return new AddThisSmartLayersWidget();
    }

    public IAddThisShareButtonsWidget ShareButtons()
    {
      return new AddThisShareButtonsWidget();
    }

    public IAddThisFollowButtonsWidget FollowButtons()
    {
      return new AddThisFollowButtonsWidget();
    }

    public IAddThisWelcomeBarWidget WelcomeBar()
    {
      return new AddThisWelcomeBarWidget();
    }

    public IAddThisTrendingContentWidget TrendingContent()
    {
      return new AddThisTrendingContentWidget();
    }
  }
}