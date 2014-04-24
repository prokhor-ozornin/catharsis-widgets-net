using System;
using System.Globalization;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Set of extension methods for interface <see cref="IPinterestProfileWidget"/>.</para>
  /// </summary>
  /// <seealso cref="IPinterestProfileWidget"/>
  public static class IPinterestProfileWidgetExtensions
  {
    /// <summary>
    ///   <para>Total height of profile area in pixels.</para>
    /// </summary>
    /// <param name="widget">Widget to call method on.</param>
    /// <param name="height">Areas's height.</param>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="IPinterestProfileWidget.Height(string)"/>
    public static IPinterestProfileWidget Height(this IPinterestProfileWidget widget, short height)
    {
      Assertion.NotNull(widget);

      return widget.Height(height.ToString(CultureInfo.InvariantCulture));
    }

    /// <summary>
    ///   <para>Total width of profile area in pixels.</para>
    /// </summary>
    /// <param name="widget">Widget to call method on.</param>
    /// <param name="width">Area's width.</param>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="IPinterestProfileWidget.Width(string)"/>
    public static IPinterestProfileWidget Width(this IPinterestProfileWidget widget, short width)
    {
      Assertion.NotNull(widget);

      return widget.Width(width.ToString(CultureInfo.InvariantCulture));
    }

    /// <summary>
    ///   <para>Sets predefined dimensions of area and images to make it look like a site's header.</para>
    /// </summary>
    /// <param name="widget">Widget to call method on.</param>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="IPinterestProfileWidget.Image(string)"/>
    /// <seealso cref="IPinterestProfileWidget.Height(string)"/>
    /// <seealso cref="IPinterestProfileWidget.Width(string)"/>
    public static IPinterestProfileWidget Header(this IPinterestProfileWidget widget)
    {
      Assertion.NotNull(widget);

      return widget.Image(115).Height(120).Width(900);
    }

    /// <summary>
    ///   <para>Width of profile area's image in pixels.</para>
    /// </summary>
    /// <param name="widget">Widget to call method on.</param>
    /// <param name="width">Area's image width.</param>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="IPinterestProfileWidget.Image(string)"/>
    public static IPinterestProfileWidget Image(this IPinterestProfileWidget widget, short width)
    {
      Assertion.NotNull(widget);

      return widget.Image(width.ToString(CultureInfo.InvariantCulture));
    }

    /// <summary>
    ///   <para>Sets predefined dimensions of area and images to make it look like a site's sidebar.</para>
    /// </summary>
    /// <param name="widget">Widget to call method on.</param>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="IPinterestProfileWidget.Image(string)"/>
    /// <seealso cref="IPinterestProfileWidget.Height(string)"/>
    /// <seealso cref="IPinterestProfileWidget.Width(string)"/>
    public static IPinterestProfileWidget Sidebar(this IPinterestProfileWidget widget)
    {
      Assertion.NotNull(widget);

      return widget.Image(60).Height(800).Width(150);
    }

    /// <summary>
    ///   <para>Sets predefined dimensions of area and images to make it look like a site's square.</para>
    /// </summary>
    /// <param name="widget">Widget to call method on.</param>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="IPinterestProfileWidget.Image(string)"/>
    /// <seealso cref="IPinterestProfileWidget.Height(string)"/>
    /// <seealso cref="IPinterestProfileWidget.Width(string)"/>
    public static IPinterestProfileWidget Square(this IPinterestProfileWidget widget)
    {
      Assertion.NotNull(widget);

      return widget.Image(80).Height(320).Width(400);
    }
  }
}