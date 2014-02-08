using System;
using System.Collections.Generic;
using System.Globalization;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Set of extension methods for interface <see cref="IYandexSharePanelWidget"/>.</para>
  ///   <seealso cref="IYandexSharePanelWidget"/>
  /// </summary>
  public static class IYandexSharePanelWidgetExtensions
  {
    /// <summary>
    ///   <para></para>
    /// </summary>
    /// <param name="widget">Widget to call method on.</param>
    /// <param name="services"></param>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="IYandexSharePanelWidget.Services(IEnumerable{string})"/>
    public static IYandexSharePanelWidget Services(this IYandexSharePanelWidget widget, params string[] services)
    {
      Assertion.NotNull(widget);

      return widget.Services(services);
    }

    /// <summary>
    ///   <para></para>
    /// </summary>
    /// <param name="widget">Widget to call method on.</param>
    /// <param name="language"></param>
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
    ///   <para></para>
    /// </summary>
    /// <param name="widget">Widget to call method on.</param>
    /// <param name="layout"></param>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="IYandexSharePanelWidget.Layout(string)"/>
    public static IYandexSharePanelWidget Layout(this IYandexSharePanelWidget widget, YandexSharePanelLayout layout)
    {
      Assertion.NotNull(widget);

      return widget.Layout(Enum.GetName(typeof(YandexSharePanelLayout), layout).ToLowerInvariant());
    }
  }
}