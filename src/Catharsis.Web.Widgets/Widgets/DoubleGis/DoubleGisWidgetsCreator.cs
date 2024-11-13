namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IDoubleGisWidgetsCreator"/>
public class DoubleGisWidgetsCreator : IDoubleGisWidgetsCreator
{
  /// <inheritdoc cref="IDoubleGisWidgetsCreator.ContactsMap()"/>
  public IDoubleGisContactsMapWidget ContactsMap() => new DoubleGisContactsMapWidget();

  /// <inheritdoc cref="IDoubleGisWidgetsCreator.Map()"/>
  public IDoubleGisMapWidget Map() => new DoubleGisMapWidget();

  /// <inheritdoc cref="IDoubleGisWidgetsCreator.MiniMap()"/>
  public IDoubleGisMiniMapWidget MiniMap() => new DoubleGisMiniMapWidget();
}