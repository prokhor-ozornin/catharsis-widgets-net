namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="ISurfingbirdHtmlHelper"/>
public class SurfingbirdHtmlHelper : ISurfingbirdHtmlHelper
{
  /// <inheritdoc cref="ISurfingbirdHtmlHelper.SurfButton()"/>
  public ISurfingbirdSurfButtonWidget SurfButton() => new SurfingbirdSurfButtonWidget();
}