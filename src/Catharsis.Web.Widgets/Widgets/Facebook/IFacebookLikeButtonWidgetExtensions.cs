using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Set of extension methods for interface <see cref="IFacebookLikeButtonWidget"/>.</para>
/// </summary>
/// <seealso cref="IFacebookLikeButtonWidget"/>
public static class IFacebookLikeButtonWidgetExtensions
{
  /// <param name="widget">Widget to call method on.</param>
  extension(IFacebookLikeButtonWidget widget)
  {
    /// <summary>
    ///   <para>Selects one of the different layouts that are available for the button.</para>
    /// </summary>
    /// <param name="layout">Button layout.</param>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="IFacebookLikeButtonWidget.Layout(string)"/>
    public IFacebookLikeButtonWidget Layout(FacebookButtonLayout layout)
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
    /// <param name="url"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentNullException">Если параметр <paramref name="widget"/> является <see langword="null"/> ссылкой.</exception>
    public IFacebookLikeButtonWidget Url(Uri url) => widget?.Url(url?.ToString()) ?? throw new ArgumentNullException(nameof(widget));

    /// <summary>
    ///   <para>The width of the button. The layout you choose affects the minimum and default widths you can use.</para>
    /// </summary>
    /// <param name="width">Width of button.</param>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="IFacebookLikeButtonWidget.Width(string)"/>
    public IFacebookLikeButtonWidget Width(short width) => widget?.Width(width.ToInvariantString()) ?? throw new ArgumentNullException(nameof(widget));

    /// <summary>
    ///   <para>The verb to display on the button.</para>
    /// </summary>
    /// <param name="verb">Verb on the button.</param>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="IFacebookLikeButtonWidget.Verb(string)"/>
    public IFacebookLikeButtonWidget Verb(FacebookLikeButtonVerb verb) => widget?.Verb(verb.ToString().ToLowerInvariant()) ?? throw new ArgumentNullException(nameof(widget));

    /// <summary>
    ///   <para>Color scheme used by the button.</para>
    /// </summary>
    /// <param name="scheme">The color scheme for the button.</param>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="IFacebookLikeButtonWidget.ColorScheme(string)"/>
    public IFacebookLikeButtonWidget ColorScheme(FacebookColorScheme scheme) => widget?.ColorScheme(scheme.ToString().ToLowerInvariant()) ?? throw new ArgumentNullException(nameof(widget));
  }
}