namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Renders embedded Vimeo video on web page.</para>
  /// </summary>
  public interface IVimeoVideoWidget : IVideoWidget<IVimeoVideoWidget>
  {
    /// <summary>
    ///   <para>Whether to start playing video automatically. Default is <c>false</c>.</para>
    /// </summary>
    /// <param name="enabled"><c>true</c> to enable autoplay, <c>false</c> to disable.</param>
    /// <returns>Reference to the current widget.</returns>
    IVimeoVideoWidget AutoPlay(bool enabled = true);

    /// <summary>
    ///   <para>Whether to replay video when it finishes. Default is <c>false</c>.</para>
    /// </summary>
    /// <param name="enabled"><c>true</c> to enable looping, <c>false</c> to disable.</param>
    /// <returns>Reference to the current widget.</returns>
    IVimeoVideoWidget Loop(bool enabled = true);
  }
}