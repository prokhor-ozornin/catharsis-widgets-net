namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Renders hyperlink to RuTube video.</para>
  /// </summary>
  public interface IRuTubeVideoLinkWidget : IVideoLinkWidget<IRuTubeVideoLinkWidget>
  {
    /// <summary>
    ///   <para>Specifies Whether to create link for embedded video type (default is <c>false</c>).</para>
    /// </summary>
    /// <param name="embedded"><c>true</c> to use embedded video style, <c>false</c> to use normal link.</param>
    /// <returns>Reference to the current widget.</returns>
    IRuTubeVideoLinkWidget Embedded(bool embedded = true);
  }
}