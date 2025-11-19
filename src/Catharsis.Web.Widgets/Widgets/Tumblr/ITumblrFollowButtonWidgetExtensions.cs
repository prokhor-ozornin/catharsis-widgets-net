namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Set of extension methods for interface <see cref="ITumblrFollowButtonWidget"/>.</para>
/// </summary>
/// <seealso cref="ITumblrFollowButtonWidget"/>
public static class ITumblrFollowButtonWidgetExtensions
{
  /// <param name="widget">Widget to call method on.</param>
  extension(ITumblrFollowButtonWidget widget)
  {
    /// <summary>
    ///   <para>Visual layout/appearance of button.</para>
    /// </summary>
    /// <param name="type">Layout of button.</param>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="ITumblrFollowButtonWidget.Type(byte)"/>
    public ITumblrFollowButtonWidget Type(TumblrFollowButtonType type) => widget?.Type((byte)type) ?? throw new ArgumentNullException(nameof(widget));

    /// <summary>
    ///   <para>Visual color scheme of button.</para>
    /// </summary>
    /// <param name="scheme">Color scheme for button.</param>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="ITumblrFollowButtonWidget.ColorScheme(string)"/>
    public ITumblrFollowButtonWidget ColorScheme(TumblrFollowButtonColorScheme scheme) => widget?.ColorScheme(scheme.ToString().ToLowerInvariant()) ?? throw new ArgumentNullException(nameof(widget));
  }
}