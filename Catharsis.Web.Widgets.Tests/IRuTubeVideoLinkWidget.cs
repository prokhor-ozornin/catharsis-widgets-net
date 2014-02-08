namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  public interface IRuTubeVideoLinkWidget : IVideoLinkWidget<IRuTubeVideoLinkWidget>
  {
    /// <summary>
    ///   <para></para>
    /// </summary>
    /// <param name="embedded"></param>
    /// <returns></returns>
    IRuTubeVideoLinkWidget Embedded(bool embedded = true);
  }
}