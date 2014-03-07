namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Renders hyperlink to YouTube video.</para>
  /// </summary>
  public interface IYouTubeVideoLinkWidget : IVideoLinkWidget<IYouTubeVideoLinkWidget>
  {
    /// <summary>
    ///   <para>Whether to create link for embedded video type (default is <c>false</c>).</para>
    /// </summary>
    /// <param name="embedded"><c>true</c> to use embedded video style, <c>false</c> to use normal link.</param>
    /// <returns>Reference to the current widget.</returns>
    IYouTubeVideoLinkWidget Embedded(bool embedded = true);

    /// <summary>
    ///   <para>Whether to create link that keeps track of user cookies or not (default is <c>false</c>).</para>
    /// </summary>
    /// <param name="isPrivate"><c>true</c> to create "cookie-aware" hyperlink, <c>false</c> to not.</param>
    /// <returns>Reference to the current widget.</returns>
    IYouTubeVideoLinkWidget Private(bool @isPrivate = true);

    /// <summary>
    ///   <para>Whether to create link to access video through secure HTTPS protocol or unsecure HTTP (default is <c>false</c>).</para>
    /// </summary>
    /// <param name="secure"><c>true</c> to create link with HTTPS protocol, <c>false</c> to use HTTP.</param>
    /// <returns>Reference to the current widget.</returns>
    IYouTubeVideoLinkWidget Secure(bool secure = true);
  }
}