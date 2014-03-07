using System.Collections.Generic;
using System.IO;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  public sealed class VkontakteLikeButtonWidget : HtmlWidgetBase<IVkontakteLikeButtonWidget>, IVkontakteLikeButtonWidget
  {
    private string text;
    private byte? verb;
    private string layout;
    private string width;
    private string height;
    private string pageTitle;
    private string pageUrl;
    private string pageDescription;
    private string pageImageUrl;

    public IVkontakteLikeButtonWidget Text(string text)
    {
      Assertion.NotEmpty(text);

      this.text = text;
      return this;
    }

    public IVkontakteLikeButtonWidget Verb(byte verb)
    {
      this.verb = verb;
      return this;
    }

    public IVkontakteLikeButtonWidget Layout(string layout)
    {
      Assertion.NotEmpty(layout);

      this.layout = layout;
      return this;
    }

    public IVkontakteLikeButtonWidget Width(string width)
    {
      Assertion.NotEmpty(width);

      this.width = width;
      return this;
    }

    public IVkontakteLikeButtonWidget Height(string height)
    {
      Assertion.NotEmpty(height);

      this.height = height;
      return this;
    }

    public IVkontakteLikeButtonWidget PageTitle(string title)
    {
      Assertion.NotEmpty(title);

      this.pageTitle = title;
      return this;
    }

    public IVkontakteLikeButtonWidget PageUrl(string url)
    {
      Assertion.NotEmpty(url);

      this.pageUrl = url;
      return this;
    }

    public IVkontakteLikeButtonWidget PageDescription(string description)
    {
      Assertion.NotEmpty(description);

      this.pageDescription = description;
      return this;
    }

    public IVkontakteLikeButtonWidget PageImageUrl(string url)
    {
      Assertion.NotEmpty(url);

      this.pageImageUrl = url;
      return this;
    }

    public override void Write(TextWriter writer)
    {
      Assertion.NotNull(writer);

      var config = new Dictionary<string, object>();
      if (!this.layout.IsEmpty())
      {
        config["type"] = this.layout;
      }
      if (!this.width.IsEmpty())
      {
        config["width"] = this.width;
      }
      if (!this.pageTitle.IsEmpty())
      {
        config["pageTitle"] = this.pageTitle;
      }
      if (!this.pageDescription.IsEmpty())
      {
        config["pageDescription"] = this.pageDescription;
      }
      if (!this.pageUrl.IsEmpty())
      {
        config["pageUrl"] = this.pageUrl;
      }
      if (!this.pageImageUrl.IsEmpty())
      {
        config["pageImage"] = this.pageImageUrl;
      }
      if (!this.text.IsEmpty())
      {
        config["text"] = this.text;
      }
      if (!this.height.IsEmpty())
      {
        config["height"] = this.height;
      }
      if (this.verb != null)
      {
        config["verb"] = this.verb;
      }

      writer.Write(this.ToTag("div", tag => tag.Attribute("id", "vk_like")));
      writer.Write(this.JavaScript(@"VK.Widgets.Like(""vk_like"", {0});".FormatSelf(config.Json())));
    }
  }
}