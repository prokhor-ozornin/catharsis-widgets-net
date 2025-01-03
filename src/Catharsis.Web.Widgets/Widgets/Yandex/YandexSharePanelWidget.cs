using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IYandexSharePanelWidget"/>
public class YandexSharePanelWidget : WebWidget, IYandexSharePanelWidget
{
  private string language;
  private string layout = YandexSharePanelLayout.Button.ToString().ToLowerInvariant();
  private IEnumerable<string> services = ["yaru", "vkontakte", "facebook", "twitter", "odnoklassniki", "moimir", "lj", "friendfeed", "moikrug", "gplus", "pinterest", "surfingbird"];

  /// <inheritdoc cref="IYandexSharePanelWidget.Language(string)"/>
  public IYandexSharePanelWidget Language(string language)
  {
    if (language is null) throw new ArgumentNullException(nameof(language));
    if (language.IsEmpty()) throw new ArgumentException(nameof(language));


    this.language = language;
    return this;
  }

  /// <inheritdoc cref="IYandexSharePanelWidget.Language()"/>
  public string Language() => language;

  /// <inheritdoc cref="IYandexSharePanelWidget.Layout(string)"/>
  public IYandexSharePanelWidget Layout(string layout)
  {
    if (layout is null) throw new ArgumentNullException(nameof(layout));
    if (layout.IsEmpty()) throw new ArgumentException(nameof(layout));
          
    this.layout = layout;

    return this;
  }

  /// <inheritdoc cref="IYandexSharePanelWidget.Layout()"/>
  public string Layout() => layout;

  /// <inheritdoc cref="IYandexSharePanelWidget.Services(IEnumerable{string})"/>
  public IYandexSharePanelWidget Services(IEnumerable<string> services)
  {
    this.services = services ?? throw new ArgumentNullException(nameof(services));

    return this;
  }

  /// <inheritdoc cref="IYandexSharePanelWidget.Services()"/>
  public IEnumerable<string> Services() => services;

  /// <inheritdoc cref="IHtmlContent.ToHtml()"/>
  public override string ToHtml() =>
    new TagBuilder("div")
      .Attribute("data-yashareL10n", Language() ?? Thread.CurrentThread.CurrentCulture.TwoLetterISOLanguageName)
      .Attribute("data-yashareType", Layout())
      .Attribute("data-yashareQuickServices", Services().Join(","))
      .CssClass("yashare-auto-init")
      .ToString();
}