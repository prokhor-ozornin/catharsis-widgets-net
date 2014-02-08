namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Helper factory class for managing Facebook widgets.</para>
  /// </summary>
  public interface IFacebookHtmlHelper
  {
    /// <summary>
    ///   <para>Creates new Facebook JavaScript API initialization widget.</para>
    /// </summary>
    /// <returns>Initialized widget with default options.</returns>
    IFacebookInitWidget Initialize();

    /// <summary>
    ///   <para>Creates new Facebook embedded post widget.</para>
    /// </summary>
    /// <returns>Initialized widget with default options.</returns>
    IFacebookPostWidget Post();

    /// <summary>
    ///   <para>Creates new Facebook "Like" button widget.</para>
    /// </summary>
    /// <returns>Initialized widget with default options.</returns>
    IFacebookLikeButtonWidget Like();

    /// <summary>
    ///   <para>Creates new Facebook embedded video widget.</para>
    /// </summary>
    /// <returns>Initialized widget with default options.</returns>
    IFacebookVideoWidget Video();

    /// <summary>
    ///   <para>Creates new Facebook video hyperlink widget.</para>
    /// </summary>
    /// <returns>Initialized widget with default options.</returns>
    IFacebookVideoLinkWidget VideoLink();
  }
}