using System;
using System.Globalization;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Set of extension methods for interface <see cref="IYandexAnalyticsWidget"/>.</para>
  /// </summary>
  public static class IYandexAnalyticsWidgetExtensions
  {
    /// <summary>
    ///   <para>Specifies language of visual counter's interface to use. Default is current locale's language/language of the current thread.</para>
    /// </summary>
    /// <param name="widget">Widget to call method on.</param>
    /// <param name="culture">Interface language to use.</param>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If either <paramref name="widget"/> or <paramref name="culture"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="IYandexAnalyticsWidget.Language(string)"/>
    public static IYandexAnalyticsWidget Language(this IYandexAnalyticsWidget widget, CultureInfo culture)
    {
      Assertion.NotNull(widget);
      Assertion.NotNull(culture);

      return widget.Language(culture.TwoLetterISOLanguageName);
    }
  }
}