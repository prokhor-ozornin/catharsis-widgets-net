using System.IO;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  public sealed class YouTubeVideoWidget : HtmlWidgetBase<IYouTubeVideoWidget>, IYouTubeVideoWidget
  {
    private string id;
    private string width;
    private string height;
    private bool @private;
    private bool secure;

    public IYouTubeVideoWidget Id(string id)
    {
      Assertion.NotEmpty(id);

      this.id = id;
      return this;
    }

    public IYouTubeVideoWidget Width(string width)
    {
      Assertion.NotEmpty(width);

      this.width = width;
      return this;
    }

    public IYouTubeVideoWidget Height(string height)
    {
      Assertion.NotEmpty(height);

      this.height = height;
      return this;
    }

    public IYouTubeVideoWidget Private(bool isPrivate = true)
    {
      this.@private = isPrivate;
      return this;
    }

    public IYouTubeVideoWidget Secure(bool isSecure = true)
    {
      this.secure = isSecure;
      return this;
    }

    public override void Write(TextWriter writer)
    {
      Assertion.NotNull(writer);

      if (this.id.IsEmpty() || this.width.IsEmpty() || this.height.IsEmpty())
      {
        return;
      }

      writer.Write(this.ToTag("iframe", tag => tag
        .Attribute("src", "{2}://{1}/embed/{0}".FormatValue(this.id, this.@private ? "www.youtube-nocookie.com" : "www.youtube.com", this.secure ? "https" : "http"))
        .Attribute("width", this.width)
        .Attribute("height", this.height)
        .Attribute("frameborder", 0)
        .Attribute("allowfullscreen", true)
        .Attribute("webkitallowfullscreen", true)
        .Attribute("mozallowfullscreen", true)));
    }
  }
}