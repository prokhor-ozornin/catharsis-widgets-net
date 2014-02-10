using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Web;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  public sealed class YandexSharePanelWidget : HtmlWidgetBase<IYandexSharePanelWidget>, IYandexSharePanelWidget
  {
    private string language;
    private string layout = YandexSharePanelLayout.Button.ToString().ToLowerInvariant();
    private IEnumerable<string> services = new [] { "yaru", "vkontakte", "facebook", "twitter", "odnoklassniki", "moimir", "lj", "friendfeed", "moikrug", "gplus", "pinterest", "surfingbird" };

    public IYandexSharePanelWidget Services(IEnumerable<string> services)
    {
      Assertion.NotNull(services);

      this.services = services;
      return this;
    }

    public IYandexSharePanelWidget Language(string language)
    {
      Assertion.NotEmpty(language);

      this.language = language;
      return this;
    }

    public IYandexSharePanelWidget Layout(string layout)
    {
      Assertion.NotEmpty(layout);
      
      this.layout = layout;
      return this;
    }

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