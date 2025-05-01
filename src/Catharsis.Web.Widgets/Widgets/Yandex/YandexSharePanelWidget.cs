using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IYandexSharePanelWidget"/>
public class YandexSharePanelWidget : WebWidget, IYandexSharePanelWidget
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string LanguageProperty { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string LayoutProperty { get; set; } = YandexSharePanelLayout.Button.ToString().ToLowerInvariant();

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual IEnumerable<string> ServicesProperty { get; set; } = ["yaru", "vkontakte", "facebook", "twitter", "odnoklassniki", "moimir", "lj", "friendfeed", "moikrug", "gplus", "pinterest", "surfingbird"];

  /// <inheritdoc cref="IYandexSharePanelWidget.Language(string)"/>
  public virtual IYandexSharePanelWidget Language(string language)
  {
    if (language is null) throw new ArgumentNullException(nameof(language));
    if (language.IsEmpty()) throw new ArgumentException(nameof(language));

    LanguageProperty = language;
    return this;
  }

  /// <inheritdoc cref="IYandexSharePanelWidget.Layout(string)"/>
  public virtual IYandexSharePanelWidget Layout(string layout)
  {
    if (layout is null) throw new ArgumentNullException(nameof(layout));
    if (layout.IsEmpty()) throw new ArgumentException(nameof(layout));
          
    LayoutProperty = layout;

    return this;
  }

  /// <inheritdoc cref="IYandexSharePanelWidget.Services(IEnumerable{string})"/>
  public virtual IYandexSharePanelWidget Services(IEnumerable<string> services)
  {
    ServicesProperty = services ?? throw new ArgumentNullException(nameof(services));

    return this;
  }

  public override object Clone() => new YandexSharePanelWidget { };

  /// <inheritdoc cref="IWebWidget.ToHtml()"/>
  public override string ToHtml() =>
    new TagBuilder("div")
      .Attribute("data-yashareL10n", LanguageProperty ?? Thread.CurrentThread.CurrentCulture.TwoLetterISOLanguageName)
      .Attribute("data-yashareType", LayoutProperty)
      .Attribute("data-yashareQuickServices", ServicesProperty.Join(","))
      .CssClass("yashare-auto-init")
      .ToString();
}