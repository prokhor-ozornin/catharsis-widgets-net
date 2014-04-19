using System;
using System.Globalization;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Set of extension methods for interface <see cref="ISurfingbirdSurfButtonWidget"/>.</para>
  ///   <seealso cref="ISurfingbirdSurfButtonWidget"/>
  /// </summary>
  public static class ISurfingbirdSurfButtonWidgetExtensions
  {
    /// <summary>
    ///   <para>Layout/appearance of the button.</para>
    /// </summary>
    /// <param name="widget">Widget to call method on.</param>
    /// <param name="layout">Layout of button.</param>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="ISurfingbirdSurfButtonWidget.Layout(string)"/>
    public static ISurfingbirdSurfButtonWidget Layout(this ISurfingbirdSurfButtonWidget widget, SurfingbirdSurfButtonLayout layout)
    {
      Assertion.NotNull(widget);

      switch (layout)
      {
        case SurfingbirdSurfButtonLayout.Micro :
          return widget.Layout("micro");

        case SurfingbirdSurfButtonLayout.Vertical :
          return widget.Layout("vert");

        default:
          return widget.Layout("common");
      }
    }

    /// <summary>
    ///   <para>Horizontal width of the button.</para>
    /// </summary>
    /// <param name="widget">Widget to call method on.</param>
    /// <param name="width">Width of button.</param>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="ISurfingbirdSurfButtonWidget.Width(string)"/>
    public static ISurfingbirdSurfButtonWidget Width(this ISurfingbirdSurfButtonWidget widget, short width)
    {
      Assertion.NotNull(widget);

      return widget.Width(width.ToString(CultureInfo.InvariantCulture));
    }

    /// <summary>
    ///   <para>Vertical height of the button.</para>
    /// </summary>
    /// <param name="widget">Widget to call method on.</param>
    /// <param name="height">Height of button.</param>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="ISurfingbirdSurfButtonWidget.Height(string)"/>
    public static ISurfingbirdSurfButtonWidget Height(this ISurfingbirdSurfButtonWidget widget, short height)
    {
      Assertion.NotNull(widget);

      return widget.Height(height.ToString(CultureInfo.InvariantCulture));
    }

    /// <summary>
    ///   <para>Text label's color.</para>
    /// </summary>
    /// <param name="widget">Widget to call method on.</param>
    /// <param name="color">Label's color.</param>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="ISurfingbirdSurfButtonWidget.Color(string)"/>
    public static ISurfingbirdSurfButtonWidget Color(this ISurfingbirdSurfButtonWidget widget, SurfingbirdSurfButtonColor color)
    {
      Assertion.NotNull(widget);

      return widget.Color(color.ToString().ToLowerInvariant());
    }
  }
}