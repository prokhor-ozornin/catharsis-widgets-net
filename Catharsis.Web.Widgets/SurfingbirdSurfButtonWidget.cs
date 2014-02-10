using System.Collections.Generic;
using System.IO;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  public sealed class SurfingbirdSurfButtonWidget : HtmlWidgetBase<ISurfingbirdSurfButtonWidget>, ISurfingbirdSurfButtonWidget
  {
    private string url;
    private string layout = SurfingbirdSurfButtonLayout.Common.ToString().ToLowerInvariant();
    private string width;
    private string height;
    private bool hasCounter;
    private string label = "Surf";
    private string color;
    
    public ISurfingbirdSurfButtonWidget Url(string url)
    {
      Assertion.NotEmpty(url);

      this.url = url;
      return this;
    }

    public ISurfingbirdSurfButtonWidget Layout(string layout)
    {
      Assertion.NotEmpty(layout);

      this.layout = layout;
      return this;
    }

    public ISurfingbirdSurfButtonWidget Width(string width)
    {
      Assertion.NotEmpty(width);

      this.width = width;
      return this;
    }

    public ISurfingbirdSurfButtonWidget Height(string height)
    {
      Assertion.NotEmpty(height);

      this.height = height;
      return this;
    }

    public ISurfingbirdSurfButtonWidget HasCounter(bool has = true)
    {
      this.hasCounter = has;
      return this;
    }

    public ISurfingbirdSurfButtonWidget Label(string label)
    {
      Assertion.NotEmpty(label);

      this.label = label;
      return this;
    }

    public ISurfingbirdSurfButtonWidget Color(string color)
    {
      Assertion.NotEmpty(color);

      this.color = color;
      return this;
    }

    public override void Write(TextWriter writer)
    {
      Assertion.NotNull(writer);

      var config = new Dictionary<string, object> { { "layout", "{0}{1}{2}".FormatValue(this.layout, this.hasCounter ? string.Empty : "-nocount", this.color.IsEmpty() ? string.Empty : "-" + this.color) } };
      if (!this.url.IsEmpty())
      {
        config["url"] = this.url;
      }
      if (!this.width.IsEmpty())
      {
        config["width"] = this.width;
      }
      if (!this.height.IsEmpty())
      {
        config["height"] = this.height;
      }

      writer.Write(this.ToTag("a", tag => tag
        .Attribute("target", "_blank")
        .Attribute("href", "http://surfingbird.ru/share")
        .Attribute("data-surf-config", config.Json())
        .InnerHtml(this.label)
        .AddCssClass("surfinbird__like_button")));
    }
  }
}