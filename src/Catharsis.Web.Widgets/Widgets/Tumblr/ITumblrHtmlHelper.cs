namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Helper factory class for managing Tumblr widgets.</para>
  /// </summary>
  public interface ITumblrHtmlHelper
  {
    /// <summary>
    ///   <para>Creates new Tumblr "Follow" button widget.</para>
    /// </summary>
    /// <returns>Initialized widget with default options.</returns>
    ITumblrFollowButtonWidget FollowButton();

    /// <summary>
    ///   <para>Creates new Tumblr "Share" button widget.</para>
    /// </summary>
    /// <returns>Initialized widget with default options.</returns>
    ITumblrShareButtonWidget ShareButton();
  }
}