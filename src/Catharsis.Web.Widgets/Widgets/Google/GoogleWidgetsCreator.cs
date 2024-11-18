namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IGoogleWidgetsCreator"/>
public class GoogleWidgetsCreator : IGoogleWidgetsCreator
{
  /// <inheritdoc cref="IGoogleWidgetsCreator.Analytics()"/>
  public IGoogleAnalyticsWidget Analytics() => new GoogleAnalyticsWidget();

  /// <inheritdoc cref="IGoogleWidgetsCreator.Map()"/>
  //public IGoogleMapWidget Map() => new GoogleMapWidget();

  /// <inheritdoc cref="IGoogleWidgetsCreator.PlusOneButton()"/>
  public IGooglePlusOneButtonWidget PlusOneButton() => new GooglePlusOneButtonWidget();
}