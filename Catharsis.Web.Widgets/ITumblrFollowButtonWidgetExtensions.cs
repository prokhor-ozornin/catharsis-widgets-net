using System;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Set of extension methods for interface <see cref="ITumblrFollowButtonWidget"/>.</para>
  ///   <seealso cref="ITumblrFollowButtonWidget"/>
  /// </summary>
  public static class ITumblrFollowButtonWidgetExtensions
  {
    /// <summary>
    ///   <para>Visual layout/appearance of button.</para>
    /// </summary>
    /// <param name="widget">Widget to call method on.</param>
    /// <param name="type">Layout of button.</param>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="ITumblrFollowButtonWidget.Type(byte)"/>
    public static ITumblrFollowButtonWidget Type(this ITumblrFollowButtonWidget widget, TumblrFollowButtonType type)
    {
      Assertion.NotNull(widget);

      return widget.Type((byte)type);
    }

    /// <summary>
    ///   <para>Visual color scheme of button.</para>
    /// </summary>
    /// <param name="widget">Widget to call method on.</param>
    /// <param name="scheme">Color scheme for button.</param>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="ITumblrFollowButtonWidget.ColorScheme(string)"/>
    public static ITumblrFollowButtonWidget ColorScheme(this ITumblrFollowButtonWidget widget, TumblrFollowButtonColorScheme scheme)
    {
      Assertion.NotNull(widget);

      return widget.ColorScheme(scheme.ToString().ToLowerInvariant());
    }
  }
}