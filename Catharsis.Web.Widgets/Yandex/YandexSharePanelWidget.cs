using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Web;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Renders Yandex social "Share" button.</para>
  /// </summary>
  public sealed class YandexSharePanelWidget : HtmlWidgetBase, IYandexSharePanelWidget
  {
    private string language;
    private string layout = YandexSharePanelLayout.Button.ToString().ToLowerInvariant();
    private IEnumerable<string> services = new [] { "yaru", "vkontakte", "facebook", "twitter", "odnoklassniki", "moimir", "lj", "friendfeed", "moikrug", "gplus", "pinterest", "surfingbird" };

    /// <summary>
    ///   <para>Button's interface language.</para>
    /// </summary>
    /// <param name="language">Interface language.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="language"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="language"/> is <see cref="string.Empty"/> string.</exception>
    public IYandexSharePanelWidget Language(string language)
    {
      Assertion.NotEmpty(language);

      this.language = language;
      return this;
    }

    /// <summary>
    ///   <para>Visual layout/appearance of the button.</para>
    /// </summary>
    /// <param name="layout">Layout of button.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="layout"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="layout"/> is <see cref="string.Empty"/> string.</exception>
    public IYandexSharePanelWidget Layout(string layout)
    {
      Assertion.NotEmpty(layout);
      
      this.layout = layout;
      return this;
    }

    /// <summary>
    ///   <para>List of included social services. Valid names include : [yaru, vkontakte, facebook, twitter, odnoklassniki ,moimir, lj, friendfeed, moikrug, gplus, pinterest, surfingbird].</para>
    /// </summary>
    /// <param name="services">List of social services for which to render buttons.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="services"/> is a <c>null</c> reference.</exception>
    public IYandexSharePanelWidget Services(IEnumerable<string> services)
    {
      Assertion.NotNull(services);

      this.services = services;
      return this;
    }

    /// <summary>
    ///   <para>Generates and writes HTML markup of widget, using specified text writer.</para>
    /// </summary>
    /// <param name="writer">Text writer to use as output destination.</param>
    public override void Write(TextWriter writer)
    {
      Assertion.NotNull(writer);

      writer.Write(this.ToTag("div", tag => tag
        .Attribute("data-yashareL10n", this.language ?? (HttpContext.Current != null ? HttpContext.Current.Request.Language() : Thread.CurrentThread.CurrentCulture.TwoLetterISOLanguageName))
        .Attribute("data-yashareType", this.layout)
        .Attribute("data-yashareQuickServices", this.services.Join(","))
        .AddCssClass("yashare-auto-init")));
    }
  }
}