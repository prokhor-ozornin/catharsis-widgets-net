using System;
using System.Globalization;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Set of extension methods for interface <see cref="ITwitterFollowButtonWidget"/>.</para>
  ///   <seealso cref="ITwitterFollowButtonWidget"/>
  /// </summary>
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
      Assertion.NotNull(widget);
      Assertion.NotNull(culture);

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
    public static ITwitterFollowButtonWidget Size(this ITwitterFollowButtonWidget widget, TwitterFollowButtonSize size)
    {
      Assertion.NotNull(widget);

      return widget.Size(Enum.GetName(typeof(TwitterFollowButtonSize), size).ToLowerInvariant());
    }

    /// <summary>
    ///   <para>Horizontal alignment of the button.</para>
    /// </summary>
    /// <param name="widget">Widget to call method on.</param>
    /// <param name="alignment">Horizontal alignment of button.</param>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="ITwitterFollowButtonWidget.Alignment(string)"/>
    public static ITwitterFollowButtonWidget Alignment(this ITwitterFollowButtonWidget widget, TwitterFollowButtonAlignment alignment)
    {
      Assertion.NotNull(widget);

      return widget.Alignment(Enum.GetName(typeof(TwitterFollowButtonAlignment), alignment).ToLowerInvariant());
    }
  }
}