namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Helper factory class for managing RuTube widgets.</para>
/// </summary>
public interface IRuTubeWidgetsCreator
{
  /// <summary>
  ///   <para>Creates new RuTube embedded video widget.</para>
  /// </summary>
  /// <returns>Initialized widget with default options.</returns>
  IRuTubeVideoWidget Video();
}