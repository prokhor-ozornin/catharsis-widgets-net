namespace Catharsis.Web.Widgets
{
  internal sealed class GoogleHtmlHelper : IGoogleHtmlHelper
  {
    public IGoogleAnalyticsWidget Analytics()
    {
      return new GoogleAnalyticsWidget();
    }

    public IGooglePlusOneButtonWidget PlusOne()
    {
      return new GooglePlusOneButtonWidget();
    }
  }
}