namespace Catharsis.Web.Widgets
{
  internal sealed class GoogleHtmlHelper : IGoogleHtmlHelper
  {
    public IGoogleAnalyticsWidget Analytics()
    {
      return new GoogleAnalyticsWidget();
    }

    /*public IGoogleMapWidget Map()
    {
      return new GoogleMapWidget();
    }*/

    public IGooglePlusOneButtonWidget PlusOneButton()
    {
      return new GooglePlusOneButtonWidget();
    }
  }
}