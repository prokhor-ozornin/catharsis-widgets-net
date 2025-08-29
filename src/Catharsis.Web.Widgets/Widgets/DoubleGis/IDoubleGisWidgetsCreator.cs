namespace Catharsis.Web.Widgets;

/// <summary>
///   <para></para>
/// </summary>
public interface IDoubleGisWidgetsCreator
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <returns>Initialized widget with default options.</returns>
  IDoubleGisContactsMapWidget ContactsMap();

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <returns>Initialized widget with default options.</returns>
  IDoubleGisMapWidget Map();

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <returns>Initialized widget with default options.</returns>
  IDoubleGisMiniMapWidget MiniMap();
}