using System.IO;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  public sealed class VimeoVideoLinkWidget : HtmlWidgetBase<IVimeoVideoLinkWidget>, IVimeoVideoLinkWidget
  {
    private string id;

    public IVimeoVideoLinkWidget Id(string id)
    {
      Assertion.NotEmpty(id);

      this.id = id;
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
        .Attribute("href", "https://vimeo.com/{0}".FormatValue(this.id))
        .InnerHtml(this.HtmlBody)));
    }
  }
}