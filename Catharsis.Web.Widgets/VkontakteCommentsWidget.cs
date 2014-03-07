using System.Collections.Generic;
using System.IO;
using System.Linq;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  public sealed class VkontakteCommentsWidget : HtmlWidgetBase<IVkontakteCommentsWidget>, IVkontakteCommentsWidget
  {
    private byte limit = (byte) VkontakteCommentsLimit.Limit5;
    private IEnumerable<string> attach = Enumerable.Empty<string>();
    private string width;

    public IVkontakteCommentsWidget Limit(byte limit)
    {
      this.limit = limit;
      return this;
    }

    public IVkontakteCommentsWidget Attach(params string[] attach)
    {
      Assertion.NotNull(attach);

      this.attach = attach;
      return this;
    }

    public IVkontakteCommentsWidget Width(string width)
    {
      Assertion.NotEmpty(width);

      this.width = width;
      return this;
    }

    public override void Write(TextWriter writer)
    {
      Assertion.NotNull(writer);

      var config = new Dictionary<string, object> { { "limit", this.limit }};
      if (this.attach.Any())
      {
        config["attach"] = this.attach.Join(",");
      }
      else
      {
        config["attach"] = false;
      }
      if (!this.width.IsEmpty())
      {
        config["width"] = this.width;
      }

      writer.Write(this.ToTag("div", tag => tag.Attribute("id", "vk_comments")));
      writer.Write(this.JavaScript(@"VK.Widgets.Comments(""vk_comments"", {0});".FormatSelf(config.Json())));
    }
  }
}