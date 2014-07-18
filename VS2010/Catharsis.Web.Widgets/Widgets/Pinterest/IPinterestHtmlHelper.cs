namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  public interface IPinterestHtmlHelper
  {
    /// <summary>
    ///   <para>Creates new Pinterest Board widget.</para>
    /// </summary>
    /// <returns>Initialized widget with default options.</returns>
    IPinterestBoardWidget Board();

    /// <summary>
    ///   <para>Creates new Pinterest "Follow Me" button widget.</para>
    /// </summary>
    /// <returns>Initialized widget with default options.</returns>
    IPinterestFollowButtonWidget FollowButton();

    /// <summary>
    ///   <para>Creates new Pinterest "Pin It" button widget.</para>
    /// </summary>
    /// <returns>Initialized widget with default options.</returns>
    IPinterestPinItButtonWidget PinItButton();

    /// <summary>
    ///   <para>Creates new Pinterest embedded pin widget.</para>
    /// </summary>
    /// <returns>Initialized widget with default options.</returns>
    IPinterestPinWidget Pin();

    /// <summary>
    ///   <para>Creates new Pinterest Profile widget.</para>
    /// </summary>
    /// <returns>Initialized widget with default options.</returns>
    IPinterestProfileWidget Profile();
  }
}