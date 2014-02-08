using System.IO;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  public sealed class VimeoVideoWidget : HtmlWidgetBase<IVimeoVideoWidget>, IVimeoVideoWidget
  {
    private string id;
    private string width;
    private string height;
    private bool autoPlay;
    private bool loop;

    public IVimeoVideoWidget Id(string id)
    {
      Assertion.NotEmpty(id);

      this.id = id;
      return this;
    }

    public IVimeoVideoWidget Width(string width)
    {
      Assertion.NotEmpty(width);

      this.width = width;
      return this;
    }

    public IVimeoVideoWidget Height(string height)
    {
      Assertion.NotEmpty(height);

      this.height = height;
      return this;
    }

    public IVimeoVideoWidget AutoPlay(bool autoPlay = true)
    {
      this.autoPlay = autoPlay;
      return this;
    }

    public IVimeoVideoWidget Loop(bool loop = true)
    {
      this.loop = loop;
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
        .Attribute("frameborder", 0)
        .Attribute("allowfullscreen", true)
        .Attribute("webkitallowfullscreen", true)
        .Attribute("mozallowfullscreen", true)
        .Attribute("height", this.height)
        .Attribute("width", this.width)
        .Attribute("src", "https://player.vimeo.com/video/{0}?badge=0{1}{2}".FormatValue(this.id, this.autoPlay ? "&autoplay=1" : string.Empty, this.loop ? "&loop=1" : string.Empty))));
    }
  }
}