using System.Web.Mvc;
using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IYandexSharePanelWidget"/>
public class YandexSharePanelWidget : HtmlWidget, IYandexSharePanelWidget
{
  private string language;
  private string layout = YandexSharePanelLayout.Button.ToString().ToLowerInvariant();
  private IEnumerable<string> services = ["yaru", "vkontakte", "facebook", "twitter", "odnoklassniki", "moimir", "lj", "friendfeed", "moikrug", "gplus", "pinterest", "surfingbird"];

  /// <summary>
  ///   <para>Button's interface language.</para>
  /// </summary>
  /// <param name="language">Interface language.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="language"/> is a <c>null</c> reference.</exception>
  /// <exception cref="ArgumentException">If <paramref name="language"/> is <see cref="string.Empty"/> string.</exception>
  public IYandexSharePanelWidget Language(string language)
  {
    if (language is null) throw new ArgumentNullException(nameof(language));
    if (language.IsEmpty()) throw new ArgumentException(nameof(language));


    this.language = language;
    return this;
  }

  /// <summary>
  ///   <para>Button's interface language.</para>
  /// </summary>
  /// <returns>Interface language.</returns>
  public string Language() => language;

  /// <summary>
  ///   <para>Visual layout/appearance of the button.</para>
  /// </summary>
  /// <param name="layout">Layout of button.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="layout"/> is a <c>null</c> reference.</exception>
  /// <exception cref="ArgumentException">If <paramref name="layout"/> is <see cref="string.Empty"/> string.</exception>
  public IYandexSharePanelWidget Layout(string layout)
  {
    if (layout is null) throw new ArgumentNullException(nameof(layout));
    if (layout.IsEmpty()) throw new ArgumentException(nameof(layout));

      
    this.layout = layout;

    return this;
  }

  /// <summary>
  ///   <para>Visual layout/appearance of the button.</para>
  /// </summary>
  /// <returns>Layout of button.</returns>
  public string Layout() => layout;

  /// <summary>
  ///   <para>List of included social services. Valid names include : [yaru, vkontakte, facebook, twitter, odnoklassniki ,moimir, lj, friendfeed, moikrug, gplus, pinterest, surfingbird].</para>
  /// </summary>
  /// <param name="services">List of social services for which to render buttons.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="services"/> is a <c>null</c> reference.</exception>
  public IYandexSharePanelWidget Services(IEnumerable<string> services)
  {
    this.services = services ?? throw new ArgumentNullException(nameof(services));

    return this;
  }

  /// <summary>
  ///   <para>List of included social services. Valid names include : [yaru, vkontakte, facebook, twitter, odnoklassniki ,moimir, lj, friendfeed, moikrug, gplus, pinterest, surfingbird].</para>
  /// </summary>
  /// <returns>List of social services for which to render buttons.</returns>
  public IEnumerable<string> Services() => services;

  /// <inheritdoc cref="IHtmlWidget.ToHtmlString()"/>
  public override string ToHtmlString()
  {
    return new TagBuilder("div")
      .Attribute("data-yashareL10n", Language() ?? (HttpContext.Current is not null ? HttpContext.Current.Request.Language() : Thread.CurrentThread.CurrentCulture.TwoLetterISOLanguageName))
      .Attribute("data-yashareType", Layout())
      .Attribute("data-yashareQuickServices", Services().Join(","))
      .CssClass("yashare-auto-init")
      .ToString();
  }
}