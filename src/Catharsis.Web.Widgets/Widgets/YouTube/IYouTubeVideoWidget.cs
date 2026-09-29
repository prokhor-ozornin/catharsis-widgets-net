namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Renders embedded YouTube video on web page.</para>
/// </summary>
public interface IYouTubeVideoWidget : IVideoWidget<IYouTubeVideoWidget>
{
  /// <summary>
  ///   <para>Specifies whether to keep track of user cookies or not (default is <c>false)</c>.</para>
  /// </summary>
  /// <param name="enabled"><see langword="true"/> to set cookies, <see langword="false"/> to not.</param>
  /// <returns>Reference to the current widget.</returns>
  IYouTubeVideoWidget PrivateMode(bool enabled);

  /// <summary>
  ///   <para>Specifies whether to access video through secure HTTPS protocol or unsecure HTTP (default is <see langword="false"/>).</para>
  /// </summary>
  /// <param name="enabled"><see langword="true"/> to use HTTPS protocol, <see langword="false"/> to use HTTP.</param>
  /// <returns>Reference to the current widget.</returns>
  IYouTubeVideoWidget SecureMode(bool enabled);
}