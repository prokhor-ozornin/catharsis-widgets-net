namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IDoubleGisWidgetsCreator"/>
public class DoubleGisWidgetsCreator : IDoubleGisWidgetsCreator
{
  /// <inheritdoc cref="IDoubleGisWidgetsCreator.ContactsMap()"/>
  public virtual IDoubleGisContactsMapWidget ContactsMap() => new DoubleGisContactsMapWidget();

  /// <inheritdoc cref="IDoubleGisWidgetsCreator.Map()"/>
  public virtual IDoubleGisMapWidget Map() => new DoubleGisMapWidget();

  /// <inheritdoc cref="IDoubleGisWidgetsCreator.MiniMap()"/>
  public virtual IDoubleGisMiniMapWidget MiniMap() => new DoubleGisMiniMapWidget();
}