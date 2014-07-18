namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Renders embedded YouTube video on web page.</para>
  /// </summary>
  public interface IYouTubeVideoWidget : IVideoWidget<IYouTubeVideoWidget>
  {
    /// <summary>
    ///   <para>Specifies whether to keep track of user cookies or not (default is <c>false)</c>.</para>
    /// </summary>
    /// <param name="enabled"><c>true</c> to set cookies, <c>false</c> to not.</param>
    /// <returns>Reference to the current widget.</returns>
    IYouTubeVideoWidget PrivateMode(bool enabled);

    /// <summary>
    ///   <para>Specifies whether to keep track of user cookies or not (default is <c>false)</c>.</para>
    /// </summary>
    /// <returns><c>true</c> to set cookies, <c>false</c> to not.</returns>
    bool PrivateMode();

    /// <summary>
    ///   <para>Specifies whether to access video through secure HTTPS protocol or unsecure HTTP (default is <c>false</c>).</para>
    /// </summary>
    /// <param name="enabled"><c>true</c> to use HTTPS protocol, <c>false</c> to use HTTP.</param>
    /// <returns>Reference to the current widget.</returns>
    IYouTubeVideoWidget SecureMode(bool enabled);

    /// <summary>
    ///   <para>Specifies whether to access video through secure HTTPS protocol or unsecure HTTP (default is <c>false</c>).</para>
    /// </summary>
    /// <returns><c>true</c> to use HTTPS protocol, <c>false</c> to use HTTP.</returns>
    bool SecureMode();
  }
}