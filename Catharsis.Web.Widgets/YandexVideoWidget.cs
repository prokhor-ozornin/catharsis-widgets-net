using System.IO;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  public sealed class YandexVideoWidget : HtmlWidgetBase<IYandexVideoWidget>, IYandexVideoWidget
  {
    private string id;
    private string width;
    private string height;
    private string user;

    public IYandexVideoWidget Id(string id)
    {
      Assertion.NotEmpty(id);

      this.id = id;
      return this;
    }

    public IYandexVideoWidget Width(string width)
    {
      Assertion.NotEmpty(width);

      this.width = width;
      return this;
    }

    public IYandexVideoWidget Height(string height)
    {
      Assertion.NotEmpty(height);

      this.height = height;
      return this;
    }

    public IYandexVideoWidget User(string user)
    {
      Assertion.NotEmpty(user);

      this.user = user;
      return this;
    }

    public override void Write(TextWriter writer)
    {
      Assertion.NotNull(writer);

      if (this.id.IsEmpty() || this.user.IsEmpty() || this.height.IsEmpty() || this.width.IsEmpty())
      {
        return;
      }

      writer.Write(this.ToTag("iframe", tag => tag
        .Attribute("src", "http://video.yandex.ru/iframe/{1}/{0}".FormatValue(this.id, this.user))
        .Attribute("width", this.width)
        .Attribute("height", this.height)
        .Attribute("frameborder", 0)
        .Attribute("allowfullscreen", true)
        .Attribute("webkitallowfullscreen", true)
        .Attribute("mozallowfullscreen", true)));
    }
  }
}