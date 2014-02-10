using System.IO;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  public sealed class RuTubeVideoLinkWidget : HtmlWidgetBase<IRuTubeVideoLinkWidget>, IRuTubeVideoLinkWidget
  {
    private bool embedded;
    private string id;

    public IRuTubeVideoLinkWidget Id(string id)
    {
      Assertion.NotEmpty(id);

      this.id = id;
      return this;
    }

    public IRuTubeVideoLinkWidget Embedded(bool embedded = true)
    {
      this.embedded = embedded;
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
        .Attribute("href", "http://rutube.ru/{1}/{0}".FormatValue(id, this.embedded ? "embed" : "video"))
        .InnerHtml(this.HtmlBody)));
    }
  }
}