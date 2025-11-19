using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Set of extension methods for interface <see cref="IFacebookFollowButtonWidget"/>.</para>
/// </summary>
/// <seealso cref="IFacebookFollowButtonWidget"/>
public static class IFacebookFollowButtonWidgetExtensions
{
  /// <param name="widget">Widget to call method on.</param>
  extension(IFacebookFollowButtonWidget widget)
  {
    /// <summary>
    ///   <para>The width of the button. The layout you choose affects the minimum and default widths you can use.</para>
    /// </summary>
    /// <param name="width">Width of button.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="IFacebookFollowButtonWidget.Width(string)"/>
    public IFacebookFollowButtonWidget Width(short width) => widget?.Width(width.ToString()) ?? throw new ArgumentNullException(nameof(widget));

    /// <summary>
    ///   <para>The height of the button.</para>
    /// </summary>
    /// <param name="height">Height of button.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="IFacebookFollowButtonWidget.Height(string)"/>
    public IFacebookFollowButtonWidget Height(short height) => widget?.Height(height.ToInvariantString()) ?? throw new ArgumentNullException(nameof(widget));

    /// <summary>
    ///   <para>The color scheme used by the button.</para>
    /// </summary>
    /// <param name="scheme">Color scheme of button.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="IFacebookFollowButtonWidget.ColorScheme(string)"/>
    public IFacebookFollowButtonWidget ColorScheme(FacebookColorScheme scheme) => widget?.ColorScheme(scheme.ToString().ToLowerInvariant()) ?? throw new ArgumentNullException(nameof(widget));

    /// <summary>
    ///   <para>Selects one of the different layouts that are available for the button.</para>
    /// </summary>
    /// <param name="layout">Layout of button.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="IFacebookFollowButtonWidget.Layout(string)"/>
    public IFacebookFollowButtonWidget Layout(FacebookButtonLayout layout)
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
    public IFacebookFollowButtonWidget Url(Uri url) => widget?.Url(url?.ToString()) ?? throw new ArgumentNullException(nameof(widget));
  }
}