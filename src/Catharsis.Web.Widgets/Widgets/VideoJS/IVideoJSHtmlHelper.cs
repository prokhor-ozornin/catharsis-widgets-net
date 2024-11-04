namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Helper factory class for managing VideoJS widgets.</para>
  /// </summary>
  public interface IVideoJSHtmlHelper
  {
    /// <summary>
    ///   <para>Creates new VideoJS player widget.</para>
    /// </summary>
    /// <returns>Initialized widget with default options.</returns>
    IVideoJSPlayerWidget Player();
  }
}