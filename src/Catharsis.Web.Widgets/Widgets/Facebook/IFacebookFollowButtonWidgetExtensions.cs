using System.Globalization;

namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Set of extension methods for interface <see cref="IFacebookFollowButtonWidget"/>.</para>
/// </summary>
/// <seealso cref="IFacebookFollowButtonWidget"/>
public static class IFacebookFollowButtonWidgetExtensions
{
  /// <summary>
  ///   <para>The width of the button. The layout you choose affects the minimum and default widths you can use.</para>
  /// </summary>
  /// <param name="widget">Widget to call method on.</param>
  /// <param name="width">Width of button.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
  /// <seealso cref="IFacebookFollowButtonWidget.Width(string)"/>
  public static IFacebookFollowButtonWidget Width(this IFacebookFollowButtonWidget widget, short width) => widget is not null ? widget.Width(width.ToString()) : throw new ArgumentNullException(nameof(widget));

  /// <summary>
  ///   <para>The height of the button.</para>
  /// </summary>
  /// <param name="widget">Widget to call method on.</param>
  /// <param name="height">Height of button.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
  /// <seealso cref="IFacebookFollowButtonWidget.Height(string)"/>
  public static IFacebookFollowButtonWidget Height(this IFacebookFollowButtonWidget widget, short height) => widget is not null ? widget.Height(height.ToString(CultureInfo.InvariantCulture)) : throw new ArgumentNullException(nameof(widget));

  /// <summary>
  ///   <para>The color scheme used by the button.</para>
  /// </summary>
  /// <param name="widget">Widget to call method on.</param>
  /// <param name="scheme">Color scheme of button.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
  /// <seealso cref="IFacebookFollowButtonWidget.ColorScheme(string)"/>
  public static IFacebookFollowButtonWidget ColorScheme(this IFacebookFollowButtonWidget widget, FacebookColorScheme scheme) => widget is not null ? widget.ColorScheme(scheme.ToString().ToLowerInvariant()) : throw new ArgumentNullException(nameof(widget));

  /// <summary>
  ///   <para>Selects one of the different layouts that are available for the button.</para>
  /// </summary>
  /// <param name="widget">Widget to call method on.</param>
  /// <param name="layout">Layout of button.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
  /// <seealso cref="IFacebookFollowButtonWidget.Layout(string)"/>
  public static IFacebookFollowButtonWidget Layout(this IFacebookFollowButtonWidget widget, FacebookButtonLayout layout)
  {
    if (widget is null) throw new ArgumentNullException(nameof(widget));

    return layout switch
    {
      FacebookButtonLayout.BoxCount => widget.Layout("box_count"),
      FacebookButtonLayout.ButtonCount => widget.Layout("button_count"),
      _ => widget.Layout("standard")
    };
  }
}