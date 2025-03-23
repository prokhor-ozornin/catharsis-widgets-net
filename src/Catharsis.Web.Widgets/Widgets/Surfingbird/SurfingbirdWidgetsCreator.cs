namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="ISurfingbirdWidgetsCreator"/>
public class SurfingbirdWidgetsCreator : ISurfingbirdWidgetsCreator
{
  /// <inheritdoc cref="ISurfingbirdWidgetsCreator.SurfButton()"/>
  public virtual ISurfingbirdSurfButtonWidget SurfButton() => new SurfingbirdSurfButtonWidget();
}