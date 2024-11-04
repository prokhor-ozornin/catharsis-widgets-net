using System;
using System.Collections.Generic;
using System.Globalization;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Set of extension methods for interface <see cref="IYandexSharePanelWidget"/>.</para>
  /// </summary>
  /// <seealso cref="IYandexSharePanelWidget"/>
  public static class IYandexSharePanelWidgetExtensions
  {
    /// <summary>
    ///   <para>List of included social services.</para>
    /// </summary>
    /// <param name="widget">Widget to call method on.</param>
    /// <param name="services">List of social services for which to render buttons.</param>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="IYandexSharePanelWidget.Services(IEnumerable{string})"/>
    public static IYandexSharePanelWidget Services(this IYandexSharePanelWidget widget, params string[] services)
    {
      Assertion.NotNull(widget);

      return widget.Services(services);
    }

    /// <summary>
    ///   <para>Button's interface language.</para>
    /// </summary>
    /// <param name="widget">Widget to call method on.</param>
    /// <param name="language">Interface language.</param>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If either <paramref name="widget"/> or <paramref name="language"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="IYandexSharePanelWidget.Language(string)"/>
    public static IYandexSharePanelWidget Language(this IYandexSharePanelWidget widget, CultureInfo language)
    {
      Assertion.NotNull(widget);
      Assertion.NotNull(language);

      return widget.Language(language.TwoLetterISOLanguageName);
    }

    /// <summary>
    ///   <para>Visual layout/appearance of the button.</para>
    /// </summary>
    /// <param name="widget">Widget to call method on.</param>
    /// <param name="layout">Layout of button.</param>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="IYandexSharePanelWidget.Layout(string)"/>
    public static IYandexSharePanelWidget Layout(this IYandexSharePanelWidget widget, YandexSharePanelLayout layout)
    {
      Assertion.NotNull(widget);

      return widget.Layout(layout.ToString().ToLowerInvariant());
    }
  }
}