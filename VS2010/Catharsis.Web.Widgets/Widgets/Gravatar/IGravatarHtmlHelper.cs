namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Helper factory class for managing Gravatar widgets.</para>
  /// </summary>
  public interface IGravatarHtmlHelper
  {
    /// <summary>
    ///   <para>Creates new Gravatar's avatar URL widget.</para>
    /// </summary>
    /// <returns>Initialized widget with default options.</returns>
    IGravatarImageUrlWidget ImageUrl();

    /// <summary>
    ///   <para>Creates new Gravatar's user profile URL widget.</para>
    /// </summary>
    /// <returns>Initialized widget with default options.</returns>
    IGravatarProfileUrlWidget ProfileUrl();
  }
}