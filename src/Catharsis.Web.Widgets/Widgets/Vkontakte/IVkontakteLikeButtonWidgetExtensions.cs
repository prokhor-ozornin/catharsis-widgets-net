using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Set of extension methods for interface <see cref="IVkontakteLikeButtonWidget"/>.</para>
/// </summary>
/// <seealso cref="IVkontakteLikeButtonWidget"/>
public static class IVkontakteLikeButtonWidgetExtensions
{
  /// <summary>
  ///   <para>Type of text to display on the button.</para>
  /// </summary>
  /// <param name="widget">Widget to call method on.</param>
  /// <param name="verb">Displayed button's verb.</param>
  /// <returns>Reference to provided <paramref name="widget"/>.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
  /// <seealso cref="IVkontakteLikeButtonWidget.Verb(byte)"/>
  public static IVkontakteLikeButtonWidget Verb(this IVkontakteLikeButtonWidget widget, VkontakteLikeButtonVerb verb) => widget?.Verb((byte) verb) ?? throw new ArgumentNullException(nameof(widget));

  /// <summary>
  ///   <para>Visual layout/appearance of the button.</para>
  /// </summary>
  /// <param name="widget">Widget to call method on.</param>
  /// <param name="layout">Layout of button.</param>
  /// <returns>Reference to provided <paramref name="widget"/>.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
  /// <seealso cref="IVkontakteLikeButtonWidget.Layout(string)"/>
  public static IVkontakteLikeButtonWidget Layout(this IVkontakteLikeButtonWidget widget, VkontakteLikeButtonLayout layout) => widget?.Layout(layout.ToString().ToLowerInvariant()) ?? throw new ArgumentNullException(nameof(widget));

  /// <summary>
  ///   <para>Width of button in pixels.</para>
  /// </summary>
  /// <param name="widget">Widget to call method on.</param>
  /// <param name="width">Width of button.</param>
  /// <returns>Reference to provided <paramref name="widget"/>.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
  /// <seealso cref="IVkontakteLikeButtonWidget.Width(string)"/>
  public static IVkontakteLikeButtonWidget Width(this IVkontakteLikeButtonWidget widget, short width) => widget?.Width(width.ToInvariantString()) ?? throw new ArgumentNullException(nameof(widget));

  /// <summary>
  ///   <para>Vertical height of the button in pixels.</para>
  /// </summary>
  /// <param name="widget">Widget to call method on.</param>
  /// <param name="height">Height of button.</param>
  /// <returns>Reference to provided <paramref name="widget"/>.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
  /// <seealso cref="IVkontakteLikeButtonWidget.Height(string)"/>
  public static IVkontakteLikeButtonWidget Height(this IVkontakteLikeButtonWidget widget, short height) => widget?.Height(height.ToInvariantString()) ?? throw new ArgumentNullException(nameof(widget));
}