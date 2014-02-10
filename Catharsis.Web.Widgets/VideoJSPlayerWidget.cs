using System.Collections.Generic;
using System.IO;
using System.Linq;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  public sealed class VideoJSPlayerWidget : HtmlWidgetBase<IVideoJSPlayerWidget>, IVideoJSPlayerWidget
  {
    private string width;
    private string height;
    private IEnumerable<IMediaSource> videos = Enumerable.Empty<IMediaSource>();

    public IVideoJSPlayerWidget Width(string width)
    {
      Assertion.NotEmpty(width);

      this.width = width;
      return this;
    }

    public IVideoJSPlayerWidget Height(string height)
    {
      Assertion.NotEmpty(height);

      this.height = height;
      return this;
    }

    public IVideoJSPlayerWidget Videos(IEnumerable<IMediaSource> videos)
    {
      Assertion.NotNull(videos);

      this.videos = videos;
      return this;
    }

    public override void Write(TextWriter writer)
    {
      Assertion.NotNull(writer);

      if (!this.videos.Any() || this.width.IsEmpty() || this.height.IsEmpty())
      {
        return;
      }

      writer.Write(this.ToTag("video", tag => tag
        .Attribute("class", "video-js vjs-default-skin")
        .Attribute("controls", "controls")
        .Attribute("preload", "auto")
        .Attribute("data-setup", "{}")
        .Attribute("height", this.height)
        .Attribute("width", this.width)
        .InnerHtml(this.videos.Join(string.Empty) + this.HtmlBody)));
    }
  }
}