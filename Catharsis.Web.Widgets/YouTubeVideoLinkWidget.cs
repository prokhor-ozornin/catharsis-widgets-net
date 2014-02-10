using System.IO;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  public sealed class YouTubeVideoLinkWidget : HtmlWidgetBase<IYouTubeVideoLinkWidget>, IYouTubeVideoLinkWidget
  {
    private string id;
    private bool embedded;
    private bool @private;
    private bool secure;

    public IYouTubeVideoLinkWidget Id(string id)
    {
      Assertion.NotEmpty(id);

      this.id = id;
      return this;
    }

    public IYouTubeVideoLinkWidget Embedded(bool embedded = true)
    {
      this.embedded = embedded;
      return this;
    }

    public IYouTubeVideoLinkWidget Private(bool @private = true)
    {
      this.@private = @private;
      return this;
    }

    public IYouTubeVideoLinkWidget Secure(bool secure = true)
    {
      this.secure = secure;
      return this;
    }

    public override void Write(TextWriter writer)
    {
      Assertion.NotNull(writer);

      if (this.id.IsEmpty())
      {
        return;
      }

      writer.Write(this.ToTag("a", tag => tag
        .Attribute("href", "{2}://{1}/{0}".FormatValue((this.embedded ? "embed/{0}" : "watch?v={0}").FormatValue(this.id), this.@private ? "www.youtube-nocookie.com" : "www.youtube.com", this.secure ? "https" : "http"))
        .InnerHtml(this.HtmlBody)));
    }
  }
}