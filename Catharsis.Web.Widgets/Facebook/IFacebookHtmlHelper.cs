namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Helper factory class for managing Facebook widgets.</para>
  /// </summary>
  public interface IFacebookHtmlHelper
  {
    /// <summary>
    ///   <para>Creates new Facebook Activity Feed widget.</para>
    /// </summary>
    /// <returns>Initialized widget with default options.</returns>
    IFacebookActivityFeedWidget ActivityFeed();

    /// <summary>
    ///   <para>Creates new Facebook comments widget.</para>
    /// </summary>
    /// <returns>Initialized widget with default options.</returns>
    IFacebookCommentsWidget Comments();

    /// <summary>
    ///   <para>Creates new Facebook Facepile widget.</para>
    /// </summary>
    /// <returns>Initialized widget with default options.</returns>
    IFacebookFacepileWidget Facepile();

    /// <summary>
    ///   <para>Creates new Facebook "Follow" button widget.</para>
    /// </summary>
    /// <returns>Initialized widget with default options.</returns>
    IFacebookFollowButtonWidget Follow();

    /// <summary>
    ///   <para>Creates new Facebook JavaScript API initialization widget.</para>
    /// </summary>
    /// <returns>Initialized widget with default options.</returns>
    IFacebookInitWidget Initialize();

    /// <summary>
    ///   <para>Creates new Facebook "Like" button widget.</para>
    /// </summary>
    /// <returns>Initialized widget with default options.</returns>
    IFacebookLikeButtonWidget Like();

    /// <summary>
    ///   <para>Creates new Facebook Likebox widget.</para>
    /// </summary>
    /// <returns>Initialized widget with default options.</returns>
    IFacebookLikeBoxWidget LikeBox();

    /// <summary>
    ///   <para>Creates new Facebook embedded post widget.</para>
    /// </summary>
    /// <returns>Initialized widget with default options.</returns>
    IFacebookPostWidget Post();

    /// <summary>
    ///   <para>Creates new Facebook Recommendations Feed widget.</para>
    /// </summary>
    /// <returns>Initialized widget with default options.</returns>
    IFacebookRecommendationsFeedWidget RecommendationsFeed();

    /// <summary>
    ///   <para>Creates new Facebook "Send" button widget.</para>
    /// </summary>
    /// <returns>Initialized widget with default options.</returns>
    IFacebookSendButtonWidget Send();

    /// <summary>
    ///   <para>Creates new Facebook embedded video widget.</para>
    /// </summary>
    /// <returns>Initialized widget with default options.</returns>
    IFacebookVideoWidget Video();
  }
}