namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Helper factory class for managing SoundCloud widgets.</para>
  /// </summary>
  public interface ISoundCloudHtmlHelper
  {
    /// <summary>
    ///   <para>Creates new SoundCloud profile icon widget.</para>
    /// </summary>
    /// <returns>Initialized widget with default options.</returns>
    ISoundCloudProfileIconWidget ProfileIcon();
  }
}