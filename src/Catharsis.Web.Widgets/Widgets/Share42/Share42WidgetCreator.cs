namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IShare42WidgetCreator"/>
public class Share42WidgetCreator : IShare42WidgetCreator
{
  /// <inheritdoc cref="IShare42WidgetCreator.Panel()"/>
  public IShare42PanelWidget Panel() => new Share42PanelWidget();
}