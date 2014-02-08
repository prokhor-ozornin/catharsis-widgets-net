namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Helper factory class for managing RuTube widgets.</para>
  /// </summary>
  public interface IRuTubeHtmlHelper
  {
    /// <summary>
    ///   <para>Creates new RuTube embedded video widget.</para>
    /// </summary>
    /// <returns>Initialized widget with default options.</returns>
    IRuTubeVideoWidget Video();

    /// <summary>
    ///   <para>Creates new RuTube video hyperlink widget.</para>
    /// </summary>
    /// <returns>Initialized widget with default options.</returns>
    IRuTubeVideoLinkWidget VideoLink();
  }
}