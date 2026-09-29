namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Renders embedded Vimeo video on web page.</para>
/// </summary>
public interface IVimeoVideoWidget : IVideoWidget<IVimeoVideoWidget>
{
  /// <summary>
  ///   <para>Whether to start playing video automatically. Default is <see langword="false"/>.</para>
  /// </summary>
  /// <param name="enabled"><see langword="true"/> to enable autoplay, <see langword="false"/> to disable.</param>
  /// <returns>Reference to the current widget.</returns>
  IVimeoVideoWidget AutoPlay(bool enabled);

  /// <summary>
  ///   <para>Whether to replay video when it finishes. Default is <see langword="false"/>.</para>
  /// </summary>
  /// <param name="enabled"><see langword="true"/> to enable looping, <see langword="false"/> to disable.</param>
  /// <returns>Reference to the current widget.</returns>
  IVimeoVideoWidget Loop(bool enabled);
}