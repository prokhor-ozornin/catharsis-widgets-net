using System.IO;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  public sealed class FacebookInitWidget : HtmlWidgetBase<IFacebookInitWidget>, IFacebookInitWidget
  {
    private string appId;

    public IFacebookInitWidget AppId(string id)
    {
      Assertion.NotEmpty(id);

      this.appId = id;
      return this;
    }

    public override void Write(TextWriter writer)
    {
      Assertion.NotNull(writer);

      if (this.appId.IsEmpty())
      {
        return;
      }

      writer.Write(this.ToTag("div", tag => tag.Attribute("id", "fb-root")));
      writer.Write(resources.facebook_initialize.FormatSelf(this.appId));
    }
  }
}