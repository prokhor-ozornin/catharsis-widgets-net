using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Set of extension methods for interface <see cref="IFacebookSendButtonWidget"/>.</para>
/// </summary>
/// <seealso cref="IFacebookSendButtonWidget"/>
public static class IFacebookSendButtonWidgetExtensions
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="widget"></param>
  /// <param name="url"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException">Если параметр <paramref name="widget"/> является <see langword="null"/> ссылкой.</exception>
  public static IFacebookSendButtonWidget Url(this IFacebookSendButtonWidget widget, Uri url) => widget?.Url(url?.ToString()) ?? throw new ArgumentNullException(nameof(widget));

  /// <summary>
  ///   <para>The width of the button.</para>
  /// </summary>
  /// <param name="widget">Widget to call method on.</param>
  /// <param name="width">Width of button.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
  /// <seealso cref="IFacebookSendButtonWidget.Width(string)"/>
  public static IFacebookSendButtonWidget Width(this IFacebookSendButtonWidget widget, short width) => widget?.Width(width.ToInvariantString()) ?? throw new ArgumentNullException(nameof(widget));

  /// <summary>
  ///   <para>The height of the button.</para>
  /// </summary>
  /// <param name="widget">Widget to call method on.</param>
  /// <param name="height">Height of button.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
  /// <seealso cref="IFacebookSendButtonWidget.Height(string)"/>
  public static IFacebookSendButtonWidget Height(this IFacebookSendButtonWidget widget, short height) => widget?.Height(height.ToInvariantString()) ?? throw new ArgumentNullException(nameof(widget));

  /// <summary>
  ///   <para>The color scheme used by the button.</para>
  /// </summary>
  /// <param name="widget">Widget to call method on.</param>
  /// <param name="scheme">Color scheme of button.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
  /// <seealso cref="IFacebookSendButtonWidget.ColorScheme(string)"/>
  public static IFacebookSendButtonWidget ColorScheme(this IFacebookSendButtonWidget widget, FacebookColorScheme scheme) => widget?.ColorScheme(scheme.ToString().ToLowerInvariant()) ?? throw new ArgumentNullException(nameof(widget));
}