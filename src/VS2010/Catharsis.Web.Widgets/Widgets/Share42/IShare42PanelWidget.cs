namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Renders Share42 panel.</para>
  /// </summary>
  public interface IShare42PanelWidget : IHtmlWidget
  {
    /// <summary>
    ///   <para>Specifies direction on panel (static horizontal or floating vertical).</para>
    /// </summary>
    /// <param name="direction">Direction of panel.</param>
    /// <returns>Reference to the current widget.</returns>
    IShare42PanelWidget Direction(Share42PanelDirection direction);

    /// <summary>
    ///   <para>Specifies size of social icons.</para>
    /// </summary>
    /// <param name="size">Size of icons (both height and width).</param>
    /// <returns>Reference to the current widget.</returns>
    IShare42PanelWidget Size(byte size);
  }
}