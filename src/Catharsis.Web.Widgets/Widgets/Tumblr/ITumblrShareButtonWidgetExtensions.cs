namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Set of extension methods for interface <see cref="ITumblrShareButtonWidget"/>.</para>
/// </summary>
/// <seealso cref="ITumblrShareButtonWidget"/>
public static class ITumblrShareButtonWidgetExtensions
{
  /// <param name="widget">Widget to call method on.</param>
  extension(ITumblrShareButtonWidget widget)
  {
    /// <summary>
    ///   <para>Specifies visual layout/appearance of button.</para>
    /// </summary>
    /// <param name="type">Layout of button.</param>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="ITumblrShareButtonWidget.Type(byte)"/>
    public ITumblrShareButtonWidget Type(TumblrShareButtonType type) => widget?.Type((byte)type) ?? throw new ArgumentNullException(nameof(widget));

    /// <summary>
    ///   <para>Specifies visual color scheme of button.</para>
    /// </summary>
    /// <param name="scheme">Color scheme for button.</param>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="ITumblrShareButtonWidget.ColorScheme(string)"/>
    public ITumblrShareButtonWidget ColorScheme(TumblrShareButtonColorScheme scheme) => widget?.ColorScheme(scheme.ToString().ToLowerInvariant()) ?? throw new ArgumentNullException(nameof(widget));
  }
}