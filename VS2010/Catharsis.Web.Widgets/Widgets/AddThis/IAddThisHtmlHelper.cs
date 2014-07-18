namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  public interface IAddThisHtmlHelper
  {
    /// <summary>
    ///   <para></para>
    /// </summary>
    /// <returns></returns>
    IAddThisSmartLayersWidget SmartLayers();

    /// <summary>
    ///   <para></para>
    /// </summary>
    /// <returns></returns>
    IAddThisShareButtonsWidget ShareButtons();

    /// <summary>
    ///   <para></para>
    /// </summary>
    /// <returns></returns>
    IAddThisFollowButtonsWidget FollowButtons();

    /// <summary>
    ///   <para></para>
    /// </summary>
    /// <returns></returns>
    IAddThisWelcomeBarWidget WelcomeBar();

    /// <summary>
    ///   <para></para>
    /// </summary>
    /// <returns></returns>
    IAddThisTrendingContentWidget TrendingContent();
  }
}