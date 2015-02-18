using System;
using System.Globalization;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Set of extension methods for interface <see cref="IPinterestPinItButtonWidget"/>.</para>
  /// </summary>
  /// <seealso cref="IPinterestPinItButtonWidget"/>
  public static class IPinterestPinItButtonWidgetExtensions
  {
    /// <summary>
    ///   <para>Sets color of the button to gray.</para>
    /// </summary>
    /// <param name="widget">Widget to call method on.</param>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="IPinterestPinItButtonWidget.Color(string)"/>
    public static IPinterestPinItButtonWidget Gray(this IPinterestPinItButtonWidget widget)
    {
      Assertion.NotNull(widget);

      return widget.Color("gray");
    }

    /// <summary>
    ///   <para>Language of button's label.</para>
    /// </summary>
    /// <param name="widget">Widget to call method on.</param>
    /// <param name="culture">Button's text culture.</param>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If either <paramref name="widget"/> or <paramref name="culture"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="IPinterestPinItButtonWidget.Language(string)"/>
    public static IPinterestPinItButtonWidget Language(this IPinterestPinItButtonWidget widget, CultureInfo culture)
    {
      Assertion.NotNull(widget);
      Assertion.NotNull(culture);

      return widget.Language(culture.TwoLetterISOLanguageName);
    }

    /// <summary>
    ///   <para>Sets color of the button to red.</para>
    /// </summary>
    /// <param name="widget">Widget to call method on.</param>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="IPinterestPinItButtonWidget.Color(string)"/>
    public static IPinterestPinItButtonWidget Red(this IPinterestPinItButtonWidget widget)
    {
      Assertion.NotNull(widget);

      return widget.Color("red");
    }

    /// <summary>
    ///   <para>Sets color of the button to white.</para>
    /// </summary>
    /// <param name="widget">Widget to call method on.</param>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="IPinterestPinItButtonWidget.Color(string)"/>
    public static IPinterestPinItButtonWidget White(this IPinterestPinItButtonWidget widget)
    {
      Assertion.NotNull(widget);

      return widget.Color("white");
    }
  }
}