using System.Collections.Generic;
using System.IO;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  public sealed class VkontakteCommunityWidget : HtmlWidgetBase<IVkontakteCommunityWidget>, IVkontakteCommunityWidget
  {
    private string account;
    private byte mode = (byte) VkontakteCommunityMode.Participants;
    private string width;
    private string height;

    public IVkontakteCommunityWidget Account(string account)
    {
      Assertion.NotEmpty(account);

      this.account = account;
      return this;
    }

    public IVkontakteCommunityWidget Mode(byte mode)
    {
      this.mode = mode;
      return this;
    }

    public IVkontakteCommunityWidget Width(string width)
    {
      Assertion.NotEmpty(width);

      this.width = width;
      return this;
    }

    public IVkontakteCommunityWidget Height(string height)
    {
      Assertion.NotEmpty(height);

      this.height = height;
      return this;
    }

    public override void Write(TextWriter writer)
    {
      Assertion.NotNull(writer);

      if (this.account.IsEmpty())
      {
        return;
      }

      var config = new Dictionary<string, object> { { "mode", this.mode } };
      if (this.mode == (byte) VkontakteCommunityMode.News)
      {
        config["wide"] = 1;
      }
      if (!this.width.IsEmpty())
      {
        config["width"] = this.width;
      }
      if (!this.height.IsEmpty())
      {
        config["height"] = this.height;
      }

      writer.Write(this.ToTag("div", tag => tag.Attribute("id", "vk_groups")));
      writer.Write(this.JavaScript(@"VK.Widgets.Group(""vk_groups"", {0}, ""{1}"");".FormatSelf(config.Json(), this.account)));
    }
  }
}