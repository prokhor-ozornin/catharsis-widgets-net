using System;
using System.Globalization;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Set of extension methods for interface <see cref="IPinterestBoardWidget"/>.</para>
  /// </summary>
  /// <seealso cref="IPinterestBoardWidget"/>
  public static class IPinterestBoardWidgetExtensions
  {
    /// <summary>
    ///   <para>Total height of board in pixels.</para>
    /// </summary>
    /// <param name="widget">Widget to call method on.</param>
    /// <param name="height">Board's height.</param>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="IPinterestBoardWidget.Height(string)"/>
    public static IPinterestBoardWidget Height(this IPinterestBoardWidget widget, short height) => widget is not null ? widget.Height(height.ToString(CultureInfo.InvariantCulture)) : throw new ArgumentNullException(nameof(widget));

    /// <summary>
    ///   <para>Total width of board in pixels.</para>
    /// </summary>
    /// <param name="widget">Widget to call method on.</param>
    /// <param name="width">Board's width.</param>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="IPinterestBoardWidget.Width(string)"/>
    public static IPinterestBoardWidget Width(this IPinterestBoardWidget widget, short width) => widget is not null ? widget.Width(width.ToString(CultureInfo.InvariantCulture)) : throw new ArgumentNullException(nameof(widget));

    /// <summary>
    ///   <para>Sets predefined dimensions of board and images to make board look like a site's header.</para>
    /// </summary>
    /// <param name="widget">Widget to call method on.</param>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="IPinterestBoardWidget.Image(string)"/>
    /// <seealso cref="IPinterestBoardWidget.Height(string)"/>
    /// <seealso cref="IPinterestBoardWidget.Width(string)"/>
    public static IPinterestBoardWidget Header(this IPinterestBoardWidget widget) => widget is not null ? widget.Image(115).Height(120).Width(900) : throw new ArgumentNullException(nameof(widget));

    /// <summary>
    ///   <para>Width of board's image in pixels.</para>
    /// </summary>
    /// <param name="widget">Widget to call method on.</param>
    /// <param name="width">Board's image width.</param>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="IPinterestBoardWidget.Image(string)"/>
    public static IPinterestBoardWidget Image(this IPinterestBoardWidget widget, short width) => widget is not null ? widget.Image(width.ToString(CultureInfo.InvariantCulture)) : throw new ArgumentNullException(nameof(widget));

    /// <summary>
    ///   <para>Sets predefined dimensions of board and images to make board look like a site's sidebar.</para>
    /// </summary>
    /// <param name="widget">Widget to call method on.</param>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="IPinterestBoardWidget.Image(string)"/>
    /// <seealso cref="IPinterestBoardWidget.Height(string)"/>
    /// <seealso cref="IPinterestBoardWidget.Width(string)"/>
    public static IPinterestBoardWidget Sidebar(this IPinterestBoardWidget widget) => widget is not null ? widget.Image(60).Height(800).Width(150) : throw new ArgumentNullException(nameof(widget));

    /// <summary>
    ///   <para>Sets predefined dimensions of board and images to make board look like a site's square.</para>
    /// </summary>
    /// <param name="widget">Widget to call method on.</param>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="IPinterestBoardWidget.Image(string)"/>
    /// <seealso cref="IPinterestBoardWidget.Height(string)"/>
    /// <seealso cref="IPinterestBoardWidget.Width(string)"/>
    public static IPinterestBoardWidget Square(this IPinterestBoardWidget widget) => widget is not null ? widget.Image(80).Height(320).Width(400) : throw new ArgumentNullException(nameof(widget));
  }
}