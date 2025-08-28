namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Set of extension methods for interface <see cref="IShare42PanelWidget"/>.</para>
///   <seealso cref="IShare42PanelWidget"/>
/// </summary>
public static class IShare42PanelWidgetExtensions
{
  /// <summary>
  ///   <para>Specifies static horizontal direction of panel.</para>
  /// </summary>
  /// <param name="widget">Widget to call method on.</param>
  /// <returns>Reference to provided <paramref name="widget"/>.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
  /// <seealso cref="IShare42PanelWidget.Direction(Share42PanelDirection)"/>
  public static IShare42PanelWidget Horizontal(this IShare42PanelWidget widget) => widget?.Direction(Share42PanelDirection.Horizontal) ?? throw new ArgumentNullException(nameof(widget));

  /// <summary>
  ///   <para>Specifies size of social icons.</para>
  /// </summary>
  /// <param name="widget">Widget to call method on.</param>
  /// <param name="size">Size of icons (both height and width).</param>
  /// <returns>Reference to provided <paramref name="widget"/>.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
  /// <seealso cref="IShare42PanelWidget.Size(byte)"/>
  public static IShare42PanelWidget Size(this IShare42PanelWidget widget, Share42PanelSize size) => widget?.Size((byte) size) ?? throw new ArgumentNullException(nameof(widget));

  /// <summary>
  ///   <para>Specifies floating vertical direction of panel.</para>
  /// </summary>
  /// <param name="widget">Widget to call method on.</param>
  /// <returns>Reference to provided <paramref name="widget"/>.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
  /// <seealso cref="IShare42PanelWidget.Direction(Share42PanelDirection)"/>
  public static IShare42PanelWidget Vertical(this IShare42PanelWidget widget) => widget?.Direction(Share42PanelDirection.Vertical) ?? throw new ArgumentNullException(nameof(widget));
}