using System.IO;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  public sealed class RuTubeVideoWidget : HtmlWidgetBase<IRuTubeVideoWidget>, IRuTubeVideoWidget
  {
    private string id;
    private string height;
    private string width;

    public IRuTubeVideoWidget Id(string id)
    {
      Assertion.NotEmpty(id);

      this.id = id;
      return this;
    }

    public IRuTubeVideoWidget Width(string width)
    {
      Assertion.NotEmpty(width);

      this.width = width;
      return this;
    }

    public IRuTubeVideoWidget Height(string height)
    {
      Assertion.NotEmpty(height);

      this.height = height;
      return this;
    }

    public override void Write(TextWriter writer)
    {
      Assertion.NotNull(writer);

      if (this.id.IsEmpty() || this.height.IsEmpty() || this.width.IsEmpty())
      {
        return;
      }

      writer.Write(this.ToTag("iframe", tag => tag
        .Attribute("frameborder", 0)
        .Attribute("allowfullscreen", true)
        .Attribute("webkitallowfullscreen", true)
        .Attribute("mozallowfullscreen", true)
        .Attribute("scrolling", "no")
        .Attribute("height", this.height)
        .Attribute("width", this.width)
        .Attribute("src", "http://rutube.ru/embed/{0}".FormatValue(id))));
    }
  }
}