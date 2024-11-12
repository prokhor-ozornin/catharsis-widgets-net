namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IDoubleGisHtmlHelper"/>
public class DoubleGisHtmlHelper : IDoubleGisHtmlHelper
{
  /// <inheritdoc cref="IDoubleGisHtmlHelper.ContactsMap()"/>
  public IDoubleGisContactsMapWidget ContactsMap() => new DoubleGisContactsMapWidget();

  /// <inheritdoc cref="IDoubleGisHtmlHelper.Map()"/>
  public IDoubleGisMapWidget Map() => new DoubleGisMapWidget();

  /// <inheritdoc cref="IDoubleGisHtmlHelper.MiniMap()"/>
  public IDoubleGisMiniMapWidget MiniMap() => new DoubleGisMiniMapWidget();
}