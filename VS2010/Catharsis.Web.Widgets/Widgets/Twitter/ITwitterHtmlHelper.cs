namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Helper factory class for managing Twitter widgets.</para>
  /// </summary>
  public interface ITwitterHtmlHelper
  {
    /// <summary>
    ///   <para>Creates new Twitter "Follow" button widget.</para>
    /// </summary>
    /// <returns>Initialized widget with default options.</returns>
    ITwitterFollowButtonWidget FollowButton();

    /// <summary>
    ///   <para>Creates new Twitter "Tweet" button widget.</para>
    /// </summary>
    /// <returns>Initialized widget with default options.</returns>
    ITwitterTweetButtonWidget TweetButton();
  }
}