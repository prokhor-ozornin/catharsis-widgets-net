namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Helper factory class for managing VKontakte widgets.</para>
  /// </summary>
  public interface IVkontakteHtmlHelper
  {
    /// <summary>
    ///   <para>Renders VKontakte OAuth button widget.</para>
    /// </summary>
    /// <returns>Initialized widget with default options.</returns>
    IVkontakteAuthButtonWidget AuthButton();

    /// <summary>
    ///   <para>Creates new VKontakte comments widget.</para>
    /// </summary>
    /// <returns>Initialized widget with default options.</returns>
    IVkontakteCommentsWidget Comments();

    /// <summary>
    ///   <para>Creates new VKontakte community widget.</para>
    /// </summary>
    /// <returns>Initialized widget with default options.</returns>
    IVkontakteCommunityWidget Community();

    /// <summary>
    ///   <para>Creates new VKontakte JavaScript API initialization widget.</para>
    /// </summary>
    /// <returns>Initialized widget with default options.</returns>
    IVkontakteInitializationWidget Initialize();

    /// <summary>
    ///   <para>Creates new VKontakte "Like" button widget.</para>
    /// </summary>
    /// <returns>Initialized widget with default options.</returns>
    IVkontakteLikeButtonWidget LikeButton();

    /// <summary>
    ///   <para>Renders Vkontakte Poll widget.</para>
    /// </summary>
    /// <returns>Initialized widget with default options.</returns>
    IVkontaktePollWidget Poll();

    /// <summary>
    ///   <para>Renders VKontakte Wall Post widget.</para>
    /// </summary>
    /// <returns>Initialized widget with default options.</returns>
    IVkontaktePostWidget Post();

    /// <summary>
    ///   <para>Renders VKontakte Recommendations widget.</para>
    /// </summary>
    /// <returns>Initialized widget with default options.</returns>
    IVkontakteRecommendationsWidget Recommendations();

    /// <summary>
    ///   <para>Creates new VKontakte subscription widget.</para>
    /// </summary>
    /// <returns>Initialized widget with default options.</returns>
    IVkontakteSubscriptionWidget Subscription();

    /// <summary>
    ///   <para>Creates new VKontakte embedded video widget.</para>
    /// </summary>
    /// <returns>Initialized widget with default options.</returns>
    IVkontakteVideoWidget Video();
  }
}