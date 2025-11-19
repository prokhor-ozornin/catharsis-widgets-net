using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Set of extension methods for interface <see cref="IPinterestProfileWidget"/>.</para>
/// </summary>
/// <seealso cref="IPinterestProfileWidget"/>
public static class IPinterestProfileWidgetExtensions
{
  /// <param name="widget">Widget to call method on.</param>
  extension(IPinterestProfileWidget widget)
  {
    /// <summary>
    ///   <para>Total height of profile area in pixels.</para>
    /// </summary>
    /// <param name="height">Areas's height.</param>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="IPinterestProfileWidget.Height(string)"/>
    public IPinterestProfileWidget Height(short height) => widget?.Height(height.ToInvariantString()) ?? throw new ArgumentNullException(nameof(widget));

    /// <summary>
    ///   <para>Total width of profile area in pixels.</para>
    /// </summary>
    /// <param name="width">Area's width.</param>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="IPinterestProfileWidget.Width(string)"/>
    public IPinterestProfileWidget Width(short width) => widget?.Width(width.ToInvariantString()) ?? throw new ArgumentNullException(nameof(widget));

    /// <summary>
    ///   <para>Sets predefined dimensions of area and images to make it look like a site's header.</para>
    /// </summary>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="IPinterestProfileWidget.Image(string)"/>
    /// <seealso cref="IPinterestProfileWidget.Height(string)"/>
    /// <seealso cref="IPinterestProfileWidget.Width(string)"/>
    public IPinterestProfileWidget Header() => widget?.Image(115).Height(120).Width(900) ?? throw new ArgumentNullException(nameof(widget));

    /// <summary>
    ///   <para>Width of profile area's image in pixels.</para>
    /// </summary>
    /// <param name="width">Area's image width.</param>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="IPinterestProfileWidget.Image(string)"/>
    public IPinterestProfileWidget Image(short width) => widget?.Image(width.ToInvariantString()) ?? throw new ArgumentNullException(nameof(widget));

    /// <summary>
    ///   <para>Sets predefined dimensions of area and images to make it look like a site's sidebar.</para>
    /// </summary>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="IPinterestProfileWidget.Image(string)"/>
    /// <seealso cref="IPinterestProfileWidget.Height(string)"/>
    /// <seealso cref="IPinterestProfileWidget.Width(string)"/>
    public IPinterestProfileWidget Sidebar() => widget?.Image(60).Height(800).Width(150) ?? throw new ArgumentNullException(nameof(widget));

    /// <summary>
    ///   <para>Sets predefined dimensions of area and images to make it look like a site's square.</para>
    /// </summary>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="IPinterestProfileWidget.Image(string)"/>
    /// <seealso cref="IPinterestProfileWidget.Height(string)"/>
    /// <seealso cref="IPinterestProfileWidget.Width(string)"/>
    public IPinterestProfileWidget Square() => widget?.Image(80).Height(320).Width(400) ?? throw new ArgumentNullException(nameof(widget));
  }
}