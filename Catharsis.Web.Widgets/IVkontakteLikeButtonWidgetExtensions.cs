using System;
using System.Globalization;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Set of extension methods for interface <see cref="IVkontakteLikeButtonWidget"/>.</para>
  ///   <seealso cref="IVkontakteLikeButtonWidget"/>
  /// </summary>
  public static class IVkontakteLikeButtonWidgetExtensions
  {
    /// <summary>
    ///   <para>Specifies type of text to display on the button.</para>
    /// </summary>
    /// <param name="widget">Widget to call method on.</param>
    /// <param name="verb">Displayed button's verb.</param>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="IVkontakteLikeButtonWidget.Verb(byte)"/>
    public static IVkontakteLikeButtonWidget Verb(this IVkontakteLikeButtonWidget widget, VkontakteLikeButtonVerb verb)
    {
      Assertion.NotNull(widget);

      return widget.Verb((byte)verb);
    }

    /// <summary>
    ///   <para>Specifies visual layout/appearance of the button.</para>
    /// </summary>
    /// <param name="widget">Widget to call method on.</param>
    /// <param name="layout">Layout of button.</param>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="IVkontakteLikeButtonWidget.Layout(string)"/>
    public static IVkontakteLikeButtonWidget Layout(this IVkontakteLikeButtonWidget widget, VkontakteLikeButtonLayout layout)
    {
      Assertion.NotNull(widget);

      return widget.Layout(Enum.GetName(typeof(VkontakteLikeButtonLayout), layout).ToLowerInvariant());
    }

    /// <summary>
    ///   <para>Specifies width of button in pixels.</para>
    /// </summary>
    /// <param name="widget">Widget to call method on.</param>
    /// <param name="width">Width of button.</param>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="IVkontakteLikeButtonWidget.Width(string)"/>
    public static IVkontakteLikeButtonWidget Width(this IVkontakteLikeButtonWidget widget, short width)
    {
      Assertion.NotNull(widget);

      return widget.Width(width.ToString(CultureInfo.InvariantCulture));
    }

    /// <summary>
    ///   <para>Specifies vertical height of the button in pixels.</para>
    /// </summary>
    /// <param name="widget">Widget to call method on.</param>
    /// <param name="height">Height of button.</param>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="IVkontakteLikeButtonWidget.Height(string)"/>
    public static IVkontakteLikeButtonWidget Height(this IVkontakteLikeButtonWidget widget, short height)
    {
      Assertion.NotNull(widget);

      return widget.Height(height.ToString(CultureInfo.InvariantCulture));
    }
  }
}