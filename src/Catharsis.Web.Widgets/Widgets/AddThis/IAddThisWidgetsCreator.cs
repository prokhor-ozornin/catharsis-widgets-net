namespace Catharsis.Web.Widgets;

/// <summary>
///   <para></para>
/// </summary>
public interface IAddThisWidgetsCreator
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <returns></returns>
  IAddThisSmartLayersWidget SmartLayers();

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <returns>Initialized widget with default options.</returns>
  IAddThisShareButtonsWidget ShareButtons();

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <returns>Initialized widget with default options.</returns>
  IAddThisFollowButtonsWidget FollowButtons();

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <returns>Initialized widget with default options.</returns>
  IAddThisWelcomeBarWidget WelcomeBar();

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <returns>Initialized widget with default options.</returns>
  IAddThisTrendingContentWidget TrendingContent();
}