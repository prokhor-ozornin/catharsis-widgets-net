namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Helper factory class for managing Cackle widgets.</para>
/// </summary>
public interface ICackleWidgetsCreator
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <returns></returns>
  ICackleCommentsWidget Comments();

  /// <summary>
  ///   <para>Creates new Cackle comments count widget.</para>
  /// </summary>
  /// <returns>Initialized widget with default options.</returns>
  ICackleCommentsCountWidget CommentsCount();

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <returns>Initialized widget with default options.</returns>
  ICackleLatestCommentsWidget LatestComments();

  /// <summary>
  ///   <para>Creates new Cackle OAuth login widget.</para>
  /// </summary>
  /// <returns>Initialized widget with default options.</returns>
  ICackleLoginWidget Login();
}