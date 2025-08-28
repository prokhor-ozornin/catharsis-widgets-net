using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Set of extension methods for interface <see cref="IFacebookLikeButtonWidget"/>.</para>
/// </summary>
/// <seealso cref="IFacebookLikeButtonWidget"/>
public static class IFacebookLikeButtonWidgetExtensions
{
  /// <summary>
  ///   <para>Selects one of the different layouts that are available for the button.</para>
  /// </summary>
  /// <param name="widget">Widget to call method on.</param>
  /// <param name="layout">Button layout.</param>
  /// <returns>Reference to provided <paramref name="widget"/>.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
  /// <seealso cref="IFacebookLikeButtonWidget.Layout(string)"/>
  public static IFacebookLikeButtonWidget Layout(this IFacebookLikeButtonWidget widget, FacebookButtonLayout layout)
  {
    if (widget is null) throw new ArgumentNullException(nameof(widget));

    return layout switch
    {
      FacebookButtonLayout.BoxCount => widget.Layout("box_count"),
      FacebookButtonLayout.ButtonCount => widget.Layout("button_count"),
      _ => widget.Layout("standard")
    };
  }

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="widget"></param>
  /// <param name="url"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException">Если параметр <paramref name="widget"/> является <see langword="null"/> ссылкой.</exception>
  public static IFacebookLikeButtonWidget Url(this IFacebookLikeButtonWidget widget, Uri url) => widget is not null ? widget.Url(url?.ToString()) : throw new ArgumentNullException(nameof(widget));

  /// <summary>
  ///   <para>The width of the button. The layout you choose affects the minimum and default widths you can use.</para>
  /// </summary>
  /// <param name="widget">Widget to call method on.</param>
  /// <param name="width">Width of button.</param>
  /// <returns>Reference to provided <paramref name="widget"/>.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
  /// <seealso cref="IFacebookLikeButtonWidget.Width(string)"/>
  public static IFacebookLikeButtonWidget Width(this IFacebookLikeButtonWidget widget, short width) => widget is not null ? widget.Width(width.ToInvariantString()) : throw new ArgumentNullException(nameof(widget));

  /// <summary>
  ///   <para>The verb to display on the button.</para>
  /// </summary>
  /// <param name="widget">Widget to call method on.</param>
  /// <param name="verb">Verb on the button.</param>
  /// <returns>Reference to provided <paramref name="widget"/>.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
  /// <seealso cref="IFacebookLikeButtonWidget.Verb(string)"/>
  public static IFacebookLikeButtonWidget Verb(this IFacebookLikeButtonWidget widget, FacebookLikeButtonVerb verb) => widget is not null ? widget.Verb(verb.ToString().ToLowerInvariant()) : throw new ArgumentNullException(nameof(widget));

  /// <summary>
  ///   <para>Color scheme used by the button.</para>
  /// </summary>
  /// <param name="widget">Widget to call method on.</param>
  /// <param name="scheme">The color scheme for the button.</param>
  /// <returns>Reference to provided <paramref name="widget"/>.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
  /// <seealso cref="IFacebookLikeButtonWidget.ColorScheme(string)"/>
  public static IFacebookLikeButtonWidget ColorScheme(this IFacebookLikeButtonWidget widget, FacebookColorScheme scheme) => widget is not null ? widget.ColorScheme(scheme.ToString().ToLowerInvariant()) : throw new ArgumentNullException(nameof(widget));
}