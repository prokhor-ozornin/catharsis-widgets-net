namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IShare42WidgetsCreator"/>
public class Share42WidgetsCreator : IShare42WidgetsCreator
{
  /// <inheritdoc cref="IShare42WidgetsCreator.Panel()"/>
  public virtual IShare42PanelWidget Panel() => new Share42PanelWidget();
}