namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="ISurfingbirdWidgetsCreator"/>
public class SurfingbirdWidgetsCreator : ISurfingbirdWidgetsCreator
{
  /// <inheritdoc cref="ISurfingbirdWidgetsCreator.SurfButton()"/>
  public ISurfingbirdSurfButtonWidget SurfButton() => new SurfingbirdSurfButtonWidget();
}