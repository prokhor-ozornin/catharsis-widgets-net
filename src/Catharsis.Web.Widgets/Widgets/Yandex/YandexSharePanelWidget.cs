using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IYandexSharePanelWidget"/>
public class YandexSharePanelWidget : WebWidget, IYandexSharePanelWidget
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string LanguageValue { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string LayoutValue { get; set; } = nameof(YandexSharePanelLayout.Button).ToLowerInvariant();

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual IEnumerable<string> ServicesValue { get; set; } = ["yaru", "vkontakte", "facebook", "twitter", "odnoklassniki", "moimir", "lj", "friendfeed", "moikrug", "gplus", "pinterest", "surfingbird"];

  /// <inheritdoc cref="IYandexSharePanelWidget.Language(string)"/>
  public virtual IYandexSharePanelWidget Language(string language)
  {
    if (language is null) throw new ArgumentNullException(nameof(language));
    if (language.IsEmpty()) throw new ArgumentException(nameof(language));

    LanguageValue = language;
    return this;
  }

  /// <inheritdoc cref="IYandexSharePanelWidget.Layout(string)"/>
  public virtual IYandexSharePanelWidget Layout(string layout)
  {
    if (layout is null) throw new ArgumentNullException(nameof(layout));
    if (layout.IsEmpty()) throw new ArgumentException(nameof(layout));
          
    LayoutValue = layout;

    return this;
  }

  /// <inheritdoc cref="IYandexSharePanelWidget.Services(IEnumerable{string})"/>
  public virtual IYandexSharePanelWidget Services(IEnumerable<string> services)
  {
    ServicesValue = services ?? throw new ArgumentNullException(nameof(services));

    return this;
  }

  /// <inheritdoc cref="ICloneable.Clone()"/>
  public override object Clone() => new YandexSharePanelWidget
  {
    LanguageValue = LanguageValue,
    LayoutValue = LayoutValue
  };

  /// <inheritdoc cref="IWebWidget.ToHtml()"/>
  public override string ToHtml() =>
    new TagBuilder("div")
      .Attribute("data-yashareL10n", LanguageValue ?? Thread.CurrentThread.CurrentCulture.TwoLetterISOLanguageName)
      .Attribute("data-yashareType", LayoutValue)
      .Attribute("data-yashareQuickServices", ServicesValue.Join(","))
      .CssClass("yashare-auto-init")
      .ToString();
}