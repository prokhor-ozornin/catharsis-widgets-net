namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Helper factory class for managing Share42 widgets.</para>
  /// </summary>
  public interface IShare42HtmlHelper
  {
    /// <summary>
    ///   <para>Creates nwe Share42 Panel widget.</para>
    /// </summary>
    /// <returns>Initialized widget with default options.</returns>
    IShare42PanelWidget Panel();
  }
}