namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IShare42WidgetsCreator"/>
public class Share42WidgetsCreator : IShare42WidgetsCreator
{
  /// <inheritdoc cref="IShare42WidgetsCreator.Panel()"/>
  public IShare42PanelWidget Panel() => new Share42PanelWidget();
}