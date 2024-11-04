namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  public interface IDoubleGisHtmlHelper
  {
    /// <summary>
    ///   <para></para>
    /// </summary>
    /// <returns></returns>
    IDoubleGisContactsMapWidget ContactsMap();

    /// <summary>
    ///   <para></para>
    /// </summary>
    /// <returns></returns>
    IDoubleGisMapWidget Map();

    /// <summary>
    ///   <para></para>
    /// </summary>
    /// <returns></returns>
    IDoubleGisMiniMapWidget MiniMap();
  }
}