namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Helper factory class for managing Disqus widgets.</para>
  /// </summary>
  public interface IDisqusHtmlHelper
  {
    /// <summary>
    ///   <para>Creates new Disqus comments widget.</para>
    /// </summary>
    /// <returns>Initialized widget with default options.</returns>
    IDisqusCommentsWidget Comments();
  }
}