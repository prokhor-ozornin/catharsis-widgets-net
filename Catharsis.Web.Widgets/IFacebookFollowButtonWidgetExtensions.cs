using System;
using System.Globalization;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Set of extension methods for interface <see cref="IFacebookFollowButtonWidget"/>.</para>
  /// </summary>
  /// <seealso cref="IFacebookFollowButtonWidget"/>
  public static class IFacebookFollowButtonWidgetExtensions
  {
    /// <summary>
    ///   <para>The width of the button. The layout you choose affects the minimum and default widths you can use.</para>
    /// </summary>
    /// <param name="widget">Widget to call method on.</param>
    /// <param name="width">Width of button.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="IFacebookFollowButtonWidget.Width(string)"/>
    public static IFacebookFollowButtonWidget Width(this IFacebookFollowButtonWidget widget, short width)
    {
      Assertion.NotNull(widget);

      return widget.Width(width.ToString(CultureInfo.InvariantCulture));
    }

    /// <summary>
    ///   <para>The height of the button.</para>
    /// </summary>
    /// <param name="widget">Widget to call method on.</param>
    /// <param name="height">Height of button.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="IFacebookFollowButtonWidget.Height(string)"/>
    public static IFacebookFollowButtonWidget Height(this IFacebookFollowButtonWidget widget, short height)
    {
      Assertion.NotNull(widget);

      return widget.Height(height.ToString(CultureInfo.InvariantCulture));
    }

    /// <summary>
    ///   <para>The color scheme used by the button.</para>
    /// </summary>
    /// <param name="widget">Widget to call method on.</param>
    /// <param name="colorScheme">Color scheme of button.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="IFacebookFollowButtonWidget.ColorScheme(string)"/>
    public static IFacebookFollowButtonWidget ColorScheme(this IFacebookFollowButtonWidget widget, FacebookColorScheme colorScheme)
    {
      Assertion.NotNull(widget);

      return widget.ColorScheme(colorScheme.ToString().ToLowerInvariant());
    }

    /// <summary>
    ///   <para>Selects one of the different layouts that are available for the button.</para>
    /// </summary>
    /// <param name="widget">Widget to call method on.</param>
    /// <param name="layout">Layout of button.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="IFacebookFollowButtonWidget.Layout(string)"/>
    public static IFacebookFollowButtonWidget Layout(this IFacebookFollowButtonWidget widget, FacebookButtonLayout layout)
    {
      Assertion.NotNull(widget);

      var layoutType = "standard";
      switch (layout)
      {
        case FacebookButtonLayout.BoxCount :
          layoutType = "box_count";
        break;

        case FacebookButtonLayout.ButtonCount :
          layoutType = "button_count";
        break;

        case FacebookButtonLayout.Standard :
          layoutType = "standard";
        break;
      }

      return widget.Layout(layoutType);
    }
  }
}