using System;
using System.Collections.Generic;
using System.Globalization;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Set of extension methods for interface <see cref="IFacebookActivityFeedWidget"/>.</para>
  /// </summary>
  /// <seealso cref="IFacebookActivityFeedWidget"/>
  public static class IFacebookActivityFeedWidgetExtensions
  {
    /// <summary>
    ///   <para>Collection of Open Graph action types to show in the feed.</para>
    /// </summary>
    /// <param name="widget">Widget to call method on.</param>
    /// <param name="actions">Collection of Facebook action types.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="IFacebookActivityFeedWidget.Actions(IEnumerable{string})"/>
    public static IFacebookActivityFeedWidget Actions(this IFacebookActivityFeedWidget widget, params string[] actions)
    {
      Assertion.NotNull(widget);

      return widget.Actions(actions);
    }

    /// <summary>
    ///   <para>The width of the widget in pixels.</para>
    /// </summary>
    /// <param name="widget">Widget to call method on.</param>
    /// <param name="width">Width of widget.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="IFacebookActivityFeedWidget.Width(string)"/>
    public static IFacebookActivityFeedWidget Width(this IFacebookActivityFeedWidget widget, short width)
    {
      Assertion.NotNull(widget);

      return widget.Width(width.ToString(CultureInfo.InvariantCulture));
    }

    /// <summary>
    ///   <para>The height of the widget in pixels.</para>
    /// </summary>
    /// <param name="widget">Widget to call method on.</param>
    /// <param name="height">Height of widget.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    /// <exception cref="IFacebookActivityFeedWidget.Height(string)"/>
    public static IFacebookActivityFeedWidget Height(this IFacebookActivityFeedWidget widget, short height)
    {
      Assertion.NotNull(widget);

      return widget.Height(height.ToString(CultureInfo.InvariantCulture));
    }

    /// <summary>
    ///   <para>The color scheme used by the widget.</para>
    /// </summary>
    /// <param name="widget">Widget to call method on.</param>
    /// <param name="colorScheme">Color scheme of widget.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="IFacebookActivityFeedWidget.ColorScheme(string)"/>
    public static IFacebookActivityFeedWidget ColorScheme(this IFacebookActivityFeedWidget widget, FacebookColorScheme colorScheme)
    {
      Assertion.NotNull(widget);

      return widget.ColorScheme(colorScheme.ToString().ToLowerInvariant());
    }
  }
}