using System.IO;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  public sealed class VkontakteVideoLinkWidget : HtmlWidgetBase<IVkontakteVideoLinkWidget>, IVkontakteVideoLinkWidget
  {
    private string id;
    private string user;

    public IVkontakteVideoLinkWidget Id(string id)
    {
      Assertion.NotEmpty(id);

      this.id = id;
      return this;
    }

    public IVkontakteVideoLinkWidget User(string user)
    {
      Assertion.NotEmpty(user);

      this.user = user;
      return this;
    }

    public override void Write(TextWriter writer)
    {
      Assertion.NotNull(writer);

      if (this.id.IsEmpty() || this.user.IsEmpty())
      {
        return;
      }

      writer.Write(this.ToTag("a", tag => tag
        .Attribute("href", "http://vk.com/video{0}_{1}".FormatValue(this.user, this.id))
        .InnerHtml(this.HtmlBody)));
    }
  }
}