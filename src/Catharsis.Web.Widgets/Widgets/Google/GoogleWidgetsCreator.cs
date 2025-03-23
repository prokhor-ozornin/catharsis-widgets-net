namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IGoogleWidgetsCreator"/>
public class GoogleWidgetsCreator : IGoogleWidgetsCreator
{
  /// <inheritdoc cref="IGoogleWidgetsCreator.Analytics()"/>
  public virtual IGoogleAnalyticsWidget Analytics() => new GoogleAnalyticsWidget();

  /// <inheritdoc cref="IGoogleWidgetsCreator.Map()"/>
  //public virtual IGoogleMapWidget Map() => new GoogleMapWidget();

  /// <inheritdoc cref="IGoogleWidgetsCreator.PlusOneButton()"/>
  public virtual IGooglePlusOneButtonWidget PlusOneButton() => new GooglePlusOneButtonWidget();
}