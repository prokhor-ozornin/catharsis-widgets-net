namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Helper factory class for managing VKontakte widgets.</para>
  /// </summary>
  public interface IVkontakteHtmlHelper
  {
    /// <summary>
    ///   <para>Creates new VKontakte JavaScript API initialization widget.</para>
    /// </summary>
    /// <returns>Initialized widget with default options.</returns>
    IVkontakteInitWidget Initialize();

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
    ///   <para>Creates new VKontakte "Like" button widget.</para>
    /// </summary>
    /// <returns>Initialized widget with default options.</returns>
    IVkontakteLikeButtonWidget Like();

    /// <summary>
    ///   <para>Creates new VKontakte subscription widget.</para>
    /// </summary>
    /// <returns>Initialized widget with default options.</returns>
    IVkontakteSubscriptionWidget Subscribe();

    /// <summary>
    ///   <para>Creates new VKontakte embedded video widget.</para>
    /// </summary>
    /// <returns>Initialized widget with default options.</returns>
    IVkontakteVideoWidget Video();
  }
}