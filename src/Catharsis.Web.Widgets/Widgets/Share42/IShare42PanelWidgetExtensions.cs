namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Set of extension methods for interface <see cref="IShare42PanelWidget"/>.</para>
///   <seealso cref="IShare42PanelWidget"/>
/// </summary>
public static class IShare42PanelWidgetExtensions
{
  /// <param name="widget">Widget to call method on.</param>
  extension(IShare42PanelWidget widget)
  {
    /// <summary>
    ///   <para>Specifies static horizontal direction of panel.</para>
    /// </summary>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="IShare42PanelWidget.Direction(Share42PanelDirection)"/>
    public IShare42PanelWidget Horizontal() => widget?.Direction(Share42PanelDirection.Horizontal) ?? throw new ArgumentNullException(nameof(widget));

    /// <summary>
    ///   <para>Specifies size of social icons.</para>
    /// </summary>
    /// <param name="size">Size of icons (both height and width).</param>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="IShare42PanelWidget.Size(byte)"/>
    public IShare42PanelWidget Size(Share42PanelSize size) => widget?.Size((byte) size) ?? throw new ArgumentNullException(nameof(widget));

    /// <summary>
    ///   <para>Specifies floating vertical direction of panel.</para>
    /// </summary>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="IShare42PanelWidget.Direction(Share42PanelDirection)"/>
    public IShare42PanelWidget Vertical() => widget?.Direction(Share42PanelDirection.Vertical) ?? throw new ArgumentNullException(nameof(widget));
  }
}