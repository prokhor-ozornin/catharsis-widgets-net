using System.Globalization;

namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Set of extension methods for interface <see cref="ISurfingbirdSurfButtonWidget"/>.</para>
/// </summary>
/// <seealso cref="ISurfingbirdSurfButtonWidget"/>
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
    if (widget is null) throw new ArgumentNullException(nameof(widget));

    return layout switch
    {
      SurfingbirdSurfButtonLayout.Micro => widget.Layout("micro"),
      SurfingbirdSurfButtonLayout.Vertical => widget.Layout("vert"),
      SurfingbirdSurfButtonLayout.Common => widget.Layout("common"),
      _ => widget.Layout("common")
    };
  }

  /// <summary>
  ///   <para>Horizontal width of the button.</para>
  /// </summary>
  /// <param name="widget">Widget to call method on.</param>
  /// <param name="width">Width of button.</param>
  /// <returns>Reference to provided <paramref name="widget"/>.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
  /// <seealso cref="ISurfingbirdSurfButtonWidget.Width(string)"/>
  public static ISurfingbirdSurfButtonWidget Width(this ISurfingbirdSurfButtonWidget widget, short width) => widget is not null ? widget.Width(width.ToString(CultureInfo.InvariantCulture)) : throw new ArgumentNullException(nameof(widget));

  /// <summary>
  ///   <para>Vertical height of the button.</para>
  /// </summary>
  /// <param name="widget">Widget to call method on.</param>
  /// <param name="height">Height of button.</param>
  /// <returns>Reference to provided <paramref name="widget"/>.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
  /// <seealso cref="ISurfingbirdSurfButtonWidget.Height(string)"/>
  public static ISurfingbirdSurfButtonWidget Height(this ISurfingbirdSurfButtonWidget widget, short height) => widget is not null ? widget.Height(height.ToString(CultureInfo.InvariantCulture)) : throw new ArgumentNullException(nameof(widget));

  /// <summary>
  ///   <para>Text label's color.</para>
  /// </summary>
  /// <param name="widget">Widget to call method on.</param>
  /// <param name="color">Label's color.</param>
  /// <returns>Reference to provided <paramref name="widget"/>.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
  /// <seealso cref="ISurfingbirdSurfButtonWidget.Color(string)"/>
  public static ISurfingbirdSurfButtonWidget Color(this ISurfingbirdSurfButtonWidget widget, SurfingbirdSurfButtonColor color) => widget is not null ? widget.Color(color.ToString().ToLowerInvariant()) : throw new ArgumentNullException(nameof(widget));
}