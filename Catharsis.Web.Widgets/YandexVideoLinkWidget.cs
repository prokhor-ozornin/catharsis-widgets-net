using System.IO;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  public sealed class YandexVideoLinkWidget : HtmlWidgetBase<IYandexVideoLinkWidget>, IYandexVideoLinkWidget
  {
    private string id;
    private bool highQuality;
    private string user;

    public IYandexVideoLinkWidget Id(string id)
    {
      Assertion.NotEmpty(id);

      this.id = id;
      return this;
    }

    public IYandexVideoLinkWidget HighQuality(bool highQuality = true)
    {
      this.highQuality = highQuality;
      return this;
    }

    public IYandexVideoLinkWidget User(string user)
    {
      Assertion.NotEmpty(user);

      this.user = user;
      return this;
    }

    public override void Write(TextWriter writer)
    {
      Assertion.NotNull(writer);

      if (this.id.IsEmpty() || this.user.IsEmpty())
      {
        return;
      }

      writer.Write(this.ToTag("a", tag => tag
        .Attribute("href", "http://video.yandex.ru/users/{1}/view/{0}/#{2}".FormatSelf(this.id, this.user, this.highQuality ? "hq" : string.Empty))
        .InnerHtml(this.HtmlBody)));
    }
  }
}