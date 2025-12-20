using System.Globalization;

namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Set of extension methods for interface <see cref="IYandexAnalyticsWidget"/>.</para>
/// </summary>
public static class IYandexAnalyticsWidgetExtensions
{
  /// <param name="widget">Widget to call method on.</param>
  extension(IYandexAnalyticsWidget widget)
  {
    /// <summary>
    ///   <para>Language of visual counter's interface to use. Default is current locale's language/language of the current thread.</para>
    /// </summary>
    /// <param name="culture">Interface language to use.</param>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If either <paramref name="widget"/> or <paramref name="culture"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="IYandexAnalyticsWidget.Language(string)"/>
    public IYandexAnalyticsWidget Language(CultureInfo culture)
    {
      if (widget is null) throw new ArgumentNullException(nameof(widget));
      if (culture is null) throw new ArgumentNullException(nameof(culture));

      return widget.Language(culture.TwoLetterISOLanguageName);
    }
  }
}