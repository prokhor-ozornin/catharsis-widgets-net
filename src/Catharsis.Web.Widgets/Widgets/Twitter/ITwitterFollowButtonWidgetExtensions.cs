using System.Globalization;

namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Set of extension methods for interface <see cref="ITwitterFollowButtonWidget"/>.</para>
/// </summary>
/// <seealso cref="ITwitterFollowButtonWidget"/>
public static class ITwitterFollowButtonWidgetExtensions
{
  /// <summary>
  ///   <para>Language for the "Follow" button.</para>
  /// </summary>
  /// <param name="widget">Widget to call method on.</param>
  /// <param name="culture">Interface language for button.</param>
  /// <returns>Reference to provided <paramref name="widget"/>.</returns>
  /// <exception cref="ArgumentNullException">If either <paramref name="widget"/> or <paramref name="culture"/> is a <c>null</c> reference.</exception>
  /// <seealso cref="ITwitterFollowButtonWidget.Language(string)"/>
  public static ITwitterFollowButtonWidget Language(this ITwitterFollowButtonWidget widget, CultureInfo culture)
  {
    if (widget is null) throw new ArgumentNullException(nameof(widget));
    if (culture is null) throw new ArgumentNullException(nameof(culture));

    return widget.Language(culture.TwoLetterISOLanguageName);
  }

  /// <summary>
  ///   <para>The size of the rendered button.</para>
  /// </summary>
  /// <param name="widget">Widget to call method on.</param>
  /// <param name="size">Size of button.</param>
  /// <returns>Reference to provided <paramref name="widget"/>.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
  /// <seealso cref="ITwitterFollowButtonWidget.Size(string)"/>
  public static ITwitterFollowButtonWidget Size(this ITwitterFollowButtonWidget widget, TwitterFollowButtonSize size) => widget?.Size(size.ToString().ToLowerInvariant()) ?? throw new ArgumentNullException(nameof(widget));

  /// <summary>
  ///   <para>Horizontal alignment of the button.</para>
  /// </summary>
  /// <param name="widget">Widget to call method on.</param>
  /// <param name="alignment">Horizontal alignment of button.</param>
  /// <returns>Reference to provided <paramref name="widget"/>.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
  /// <seealso cref="ITwitterFollowButtonWidget.Alignment(string)"/>
  public static ITwitterFollowButtonWidget Alignment(this ITwitterFollowButtonWidget widget, TwitterFollowButtonAlignment alignment) => widget?.Alignment(alignment.ToString().ToLowerInvariant()) ?? throw new ArgumentNullException(nameof(widget));
}