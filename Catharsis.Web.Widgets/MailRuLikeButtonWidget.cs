using System.Collections.Generic;
using System.IO;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  public sealed class MailRuLikeButtonWidget : HtmlWidgetBase<IMailRuLikeButtonWidget>, IMailRuLikeButtonWidget
  {
    private string type = "combo";
    private string size = "20";
    private byte layout = (byte) MailRuLikeButtonLayout.First;
    private bool text = true;
    private byte textType = (byte) MailRuLikeButtonTextType.First;
    private bool counter = true;
    private string counterPosition = MailRuLikeButtonCounterPosition.Right.ToString().ToLowerInvariant();

    public IMailRuLikeButtonWidget Type(string type)
    {
      Assertion.NotEmpty(type);

      this.type = type;
      return this;
    }

    public IMailRuLikeButtonWidget Size(string size)
    {
      this.size = size;
      return this;
    }

    public IMailRuLikeButtonWidget Layout(byte layout)
    {
      this.layout = layout;
      return this;
    }

    public IMailRuLikeButtonWidget Text(bool text = true)
    {
      this.text = text;
      return this;
    }

    public IMailRuLikeButtonWidget TextType(byte type)
    {
      this.textType = type;
      return this;
    }

    public IMailRuLikeButtonWidget Counter(bool counter = true)
    {
      this.counter = counter;
      return this;
    }

    public IMailRuLikeButtonWidget CounterPosition(string position)
    {
      Assertion.NotEmpty(position);

      this.counterPosition = position;
      return this;
    }

    public override void Write(TextWriter writer)
    {
      Assertion.NotNull(writer);

      var config = new Dictionary<string, object> { { "sz", this.size }, { "st", this.layout }, { "tp", this.type } };
      
      if (!this.counter)
      {
        config["nc"] = 1;
      }
      else if (this.counterPosition != null && this.counterPosition.ToLowerInvariant() == MailRuLikeButtonCounterPosition.Upper.ToString().ToLowerInvariant())
      {
        config["vt"] = 1;
      }

      if (!this.text)
      {
        config["nt"] = 1;
      }
      else
      {
        config["cm"] = this.textType;
        config["ck"] = this.textType;
      }

      writer.Write(this.ToTag("a", tag => tag
        .Attribute("target", "_blank")
        .Attribute("href", "http://connect.mail.ru/share")
        .Attribute("data-mrc-config", config.Json())
        .InnerHtml("Нравится")
        .AddCssClass("mrc__plugin_uber_like_button")));

    }
  }
}