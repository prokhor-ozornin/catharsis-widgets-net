namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Helper factory class for managing Vimeo widgets.</para>
/// </summary>
public interface IVimeoWidgetsCreator
{
  /// <summary>
  ///   <para>Creates new Vimeo embedded video widget.</para>
  /// </summary>
  /// <returns>Initialized widget with default options.</returns>
  IVimeoVideoWidget Video();
}