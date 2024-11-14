using System.Globalization;

namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Set of extension methods for interface <see cref="IFacebookSendButtonWidget"/>.</para>
/// </summary>
/// <seealso cref="IFacebookSendButtonWidget"/>
public static class IFacebookSendButtonWidgetExtensions
{
  /// <summary>
  ///   <para>The width of the button.</para>
  /// </summary>
  /// <param name="widget">Widget to call method on.</param>
  /// <param name="width">Width of button.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
  /// <seealso cref="IFacebookSendButtonWidget.Width(string)"/>
  public static IFacebookSendButtonWidget Width(this IFacebookSendButtonWidget widget, short width) => widget is not null ? widget.Width(width.ToString(CultureInfo.InvariantCulture)) : throw new ArgumentNullException(nameof(widget));

  /// <summary>
  ///   <para>The height of the button.</para>
  /// </summary>
  /// <param name="widget">Widget to call method on.</param>
  /// <param name="height">Height of button.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
  /// <seealso cref="IFacebookSendButtonWidget.Height(string)"/>
  public static IFacebookSendButtonWidget Height(this IFacebookSendButtonWidget widget, short height) => widget is not null ? widget.Height(height.ToString(CultureInfo.InvariantCulture)) : throw new ArgumentNullException(nameof(widget));

  /// <summary>
  ///   <para>The color scheme used by the button.</para>
  /// </summary>
  /// <param name="widget">Widget to call method on.</param>
  /// <param name="colorScheme">Color scheme of button.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
  /// <seealso cref="IFacebookSendButtonWidget.ColorScheme(string)"/>
  public static IFacebookSendButtonWidget ColorScheme(this IFacebookSendButtonWidget widget, FacebookColorScheme colorScheme) => widget is not null ? widget.ColorScheme(colorScheme.ToString().ToLowerInvariant()) : throw new ArgumentNullException(nameof(widget));
}