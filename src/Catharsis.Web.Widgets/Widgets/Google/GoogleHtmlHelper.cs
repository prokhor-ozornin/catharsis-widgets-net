namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IGoogleHtmlHelper"/>
public class GoogleHtmlHelper : IGoogleHtmlHelper
{
  /// <inheritdoc cref="IGoogleHtmlHelper.Analytics()"/>
  public IGoogleAnalyticsWidget Analytics() => new GoogleAnalyticsWidget();

  /// <inheritdoc cref="IGoogleHtmlHelper.Map()"/>
  //public IGoogleMapWidget Map() => new GoogleMapWidget();

  /// <inheritdoc cref="IGoogleHtmlHelper.PlusOneButton()"/>
  public IGooglePlusOneButtonWidget PlusOneButton() => new GooglePlusOneButtonWidget();
}