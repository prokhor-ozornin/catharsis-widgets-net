namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Helper factory class for managing Google widgets.</para>
  /// </summary>
  public interface IGoogleHtmlHelper
  {
    /// <summary>
    ///   <para>Creates new Google Analytics widget.</para>
    /// </summary>
    /// <returns>Initialized widget with default options.</returns>
    IGoogleAnalyticsWidget Analytics();

    /// <summary>
    ///   <para>Creates new Google "+1" button widget.</para>
    /// </summary>
    /// <returns>Initialized widget with default options.</returns>
    IGooglePlusOneButtonWidget PlusOne();
  }
}