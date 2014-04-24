using System;
using System.Collections.Generic;
using System.Globalization;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Set of extension methods for interface <see cref="IFacebookFacepileWidget"/>.</para>
  /// </summary>
  /// <seealso cref="IFacebookFacepileWidget"/>
  public static class IFacebookFacepileWidgetExtensions
  {
    /// <summary>
    ///   <para>Collection of Open Graph action types.</para>
    /// </summary>
    /// <param name="widget">Widget to call method on.</param>
    /// <param name="actions">Collection of Facebook action types.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="IFacebookFacepileWidget.Actions(IEnumerable{string})"/>
    public static IFacebookFacepileWidget Actions(this IFacebookFacepileWidget widget, params string[] actions)
    {
      Assertion.NotNull(widget);

      return widget.Actions(actions);
    }

    /// <summary>
    ///   <para>Controls the size of the photos shown in the widget.</para>
    /// </summary>
    /// <param name="widget">Widget to call method on.</param>
    /// <param name="size">Size of photos.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="IFacebookFacepileWidget.PhotoSize(string)"/>
    public static IFacebookFacepileWidget PhotoSize(this IFacebookFacepileWidget widget, FacebookFacepilePhotoSize size)
    {
      Assertion.NotNull(widget);

      return widget.PhotoSize(size.ToString().ToLowerInvariant());
    }

    /// <summary>
    ///   <para>The width of the widget in pixels.</para>
    /// </summary>
    /// <param name="widget">Widget to call method on.</param>
    /// <param name="width">Width of widget.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="IFacebookFacepileWidget.Width(string)"/>
    public static IFacebookFacepileWidget Width(this IFacebookFacepileWidget widget, short width)
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
    /// <seealso cref="IFacebookFacepileWidget.Height(string)"/>
    public static IFacebookFacepileWidget Height(this IFacebookFacepileWidget widget, short height)
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
    /// <seealso cref="IFacebookFacepileWidget.ColorScheme(string)"/>
    public static IFacebookFacepileWidget ColorScheme(this IFacebookFacepileWidget widget, FacebookColorScheme colorScheme)
    {
      Assertion.NotNull(widget);

      return widget.ColorScheme(colorScheme.ToString().ToLowerInvariant());
    }
  }
}