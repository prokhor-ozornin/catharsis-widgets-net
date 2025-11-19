using System.Globalization;

namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Set of extension methods for interface <see cref="IYandexSharePanelWidget"/>.</para>
/// </summary>
/// <seealso cref="IYandexSharePanelWidget"/>
public static class IYandexSharePanelWidgetExtensions
{
  /// <param name="widget">Widget to call method on.</param>
  extension(IYandexSharePanelWidget widget)
  {
    /// <summary>
    ///   <para>List of included social services.</para>
    /// </summary>
    /// <param name="services">List of social services for which to render buttons.</param>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="IYandexSharePanelWidget.Services(IEnumerable{string})"/>
    public IYandexSharePanelWidget Services(params string[] services) => widget?.Services(services) ?? throw new ArgumentNullException(nameof(widget));

    /// <summary>
    ///   <para>Button's interface language.</para>
    /// </summary>
    /// <param name="language">Interface language.</param>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If either <paramref name="widget"/> or <paramref name="language"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="IYandexSharePanelWidget.Language(string)"/>
    public IYandexSharePanelWidget Language(CultureInfo language)
    {
      if (widget is null) throw new ArgumentNullException(nameof(widget));
      if (language is null) throw new ArgumentNullException(nameof(language));

      return widget.Language(language.TwoLetterISOLanguageName);
    }

    /// <summary>
    ///   <para>Visual layout/appearance of the button.</para>
    /// </summary>
    /// <param name="layout">Layout of button.</param>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="IYandexSharePanelWidget.Layout(string)"/>
    public IYandexSharePanelWidget Layout(YandexSharePanelLayout layout) => widget?.Layout(layout.ToString().ToLowerInvariant()) ?? throw new ArgumentNullException(nameof(widget));
  }
}