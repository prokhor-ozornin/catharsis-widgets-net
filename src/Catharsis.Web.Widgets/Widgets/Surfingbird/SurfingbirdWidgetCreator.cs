namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="ISurfingbirdWidgetCreator"/>
public class SurfingbirdWidgetCreator : ISurfingbirdWidgetCreator
{
  /// <inheritdoc cref="ISurfingbirdWidgetCreator.SurfButton()"/>
  public ISurfingbirdSurfButtonWidget SurfButton() => new SurfingbirdSurfButtonWidget();
}