using System.IO;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  public sealed class FacebookVideoLinkWidget : HtmlWidgetBase<IFacebookVideoLinkWidget>, IFacebookVideoLinkWidget
  {
    private string id;

    public IFacebookVideoLinkWidget Id(string id)
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
        .Attribute("href", "https://www.facebook.com/photo.php?v={0}".FormatValue(id))
        .InnerHtml(this.HtmlBody)));
    }
  }
}