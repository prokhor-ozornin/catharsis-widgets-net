namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Helper factory class for managing YouTube widgets.</para>
  /// </summary>
  public interface IYouTubeHtmlHelper
  {
    /// <summary>
    ///   <para>Creates new YouTube embedded video widget.</para>
    /// </summary>
    /// <returns>Initialized widget with default options.</returns>
    IYouTubeVideoWidget Video();
  }
}