using System.Globalization;

namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Set of extension methods for interface <see cref="IPinterestPinItButtonWidget"/>.</para>
/// </summary>
/// <seealso cref="IPinterestPinItButtonWidget"/>
public static class IPinterestPinItButtonWidgetExtensions
{
  /// <param name="widget">Widget to call method on.</param>
  extension(IPinterestPinItButtonWidget widget)
  {
    /// <summary>
    ///   <para>Sets color of the button to gray.</para>
    /// </summary>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="IPinterestPinItButtonWidget.Color(string)"/>
    public IPinterestPinItButtonWidget Gray() => widget?.Color("gray") ?? throw new ArgumentNullException(nameof(widget));

    /// <summary>
    ///   <para>Language of button's label.</para>
    /// </summary>
    /// <param name="culture">Button's text culture.</param>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If either <paramref name="widget"/> or <paramref name="culture"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="IPinterestPinItButtonWidget.Language(string)"/>
    public IPinterestPinItButtonWidget Language(CultureInfo culture)
    {
      if (widget is null) throw new ArgumentNullException(nameof(widget));
      if (culture is null) throw new ArgumentNullException(nameof(culture));

      return widget.Language(culture.TwoLetterISOLanguageName);
    }

    /// <summary>
    ///   <para>Sets color of the button to red.</para>
    /// </summary>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="IPinterestPinItButtonWidget.Color(string)"/>
    public IPinterestPinItButtonWidget Red() => widget?.Color("red") ?? throw new ArgumentNullException(nameof(widget));

    /// <summary>
    ///   <para>Sets color of the button to white.</para>
    /// </summary>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="IPinterestPinItButtonWidget.Color(string)"/>
    public IPinterestPinItButtonWidget White() => widget?.Color("white") ?? throw new ArgumentNullException(nameof(widget));
  }
}