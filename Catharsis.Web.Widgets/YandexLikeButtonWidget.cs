using System.IO;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  public sealed class YandexLikeButtonWidget : HtmlWidgetBase<IYandexLikeButtonWidget>, IYandexLikeButtonWidget
  {
    private string url;
    private string title;
    private string size = YandexLikeButtonSize.Large.ToString().ToLowerInvariant();
    private string layout = YandexLikeButtonLayout.Button.ToString().ToLowerInvariant();
    private string text;

    public IYandexLikeButtonWidget Url(string url)
    {
      Assertion.NotEmpty(url);

      this.url = url;
      return this;
    }

    public IYandexLikeButtonWidget Title(string title)
    {
      Assertion.NotEmpty(title);

      this.title = title;
      return this;
    }

    public IYandexLikeButtonWidget Size(string size)
    {
      Assertion.NotEmpty(size);

      this.size = size;
      return this;
    }

    public IYandexLikeButtonWidget Layout(string layout)
    {
      Assertion.NotEmpty(layout);

      this.layout = layout;
      return this;
    }

    public IYandexLikeButtonWidget Text(string text)
    {
      Assertion.NotEmpty(text);

      this.text = text;
      return this;
    }

    public override void Write(TextWriter writer)
    {
      Assertion.NotNull(writer);

      writer.Write(this.ToTag("a", tag => tag
        .Attribute("name", "ya-share")
        .Attribute("type", this.layout)
        .Attribute("size", this.size)
        .Attribute("share_text", this.text)
        .Attribute("share_url", this.url)
        .Attribute("share_title", this.title)));
      writer.Write(resources.yandex_like);
    }
  }
}