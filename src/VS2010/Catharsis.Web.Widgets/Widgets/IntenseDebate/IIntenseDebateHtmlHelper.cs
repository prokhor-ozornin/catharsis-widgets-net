namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Helper factory class for managing IntenseDebate widgets.</para>
  /// </summary>
  public interface IIntenseDebateHtmlHelper
  {
    /// <summary>
    ///   <para>Creates new IntenseDebate comments widget.</para>
    /// </summary>
    /// <returns>Initialized widget with default options.</returns>
    IIntenseDebateCommentsWidget Comments();

    /// <summary>
    ///   <para>Creates new IntenseDebate link widget.</para>
    /// </summary>
    /// <returns>Initialized widget with default options.</returns>
    IIntenseDebateLinkWidget Link();
  }
}