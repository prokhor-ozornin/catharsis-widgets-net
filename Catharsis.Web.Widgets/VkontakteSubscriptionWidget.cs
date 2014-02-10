using System.Collections.Generic;
using System.IO;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  public sealed class VkontakteSubscriptionWidget : HtmlWidgetBase<IVkontakteSubscriptionWidget>, IVkontakteSubscriptionWidget
  {
    private string account;
    private byte layout = (byte) VkontakteSubscribeButtonLayout.First;
    private bool onlyButton;

    public IVkontakteSubscriptionWidget Account(string account)
    {
      Assertion.NotEmpty(account);

      this.account = account;
      return this;
    }

    public IVkontakteSubscriptionWidget Layout(byte layout)
    {
      this.layout = layout;
      return this;
    }

    public IVkontakteSubscriptionWidget OnlyButton(bool onlyButton = true)
    {
      this.onlyButton = onlyButton;
      return this;
    }

    public override void Write(TextWriter writer)
    {
      Assertion.NotNull(writer);

      if (this.account.IsEmpty())
      {
        return;
      }

      var config = new Dictionary<string, object> { { "mode", this.layout } };
      if (this.onlyButton)
      {
        config["soft"] = 1;
      }

      writer.Write(this.ToTag("div", tag => tag.Attribute("id", "vk_subscribe")));
      writer.Write(this.JavaScript(@"VK.Widgets.Subscribe(""vk_subscribe"", {0}, ""{1}"");".FormatValue(config.Json(), this.account)));
    }
  }
}