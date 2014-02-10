using System.IO;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  public sealed class GooglePlusOneButtonWidget : HtmlWidgetBase<IGooglePlusOneButtonWidget>, IGooglePlusOneButtonWidget
  {
    private string url;
    private string width;
    private string size;
    private string alignment;
    private string annotation;
    private string callback;
    private bool? recommendations; 

    public IGooglePlusOneButtonWidget Url(string url)
    {
      Assertion.NotEmpty(url);

      this.url = url;
      return this;
    }

    public IGooglePlusOneButtonWidget Width(string width)
    {
      Assertion.NotEmpty(width);

      this.width = width;
      return this;
    }

    public IGooglePlusOneButtonWidget Size(string size)
    {
      Assertion.NotEmpty(size);

      this.size = size;
      return this;
    }

    public IGooglePlusOneButtonWidget Alignment(string alignment)
    {
      Assertion.NotEmpty(alignment);

      this.alignment = alignment;
      return this;
    }

    public IGooglePlusOneButtonWidget Annotation(string annotation)
    {
      Assertion.NotEmpty(annotation);

      this.annotation = annotation;
      return this;
    }

    public IGooglePlusOneButtonWidget Callback(string callback)
    {
      Assertion.NotEmpty(callback);

      this.callback = callback;
      return this;
    }

    public IGooglePlusOneButtonWidget Recommendations(bool recommendations = true)
    {
      this.recommendations = recommendations;
      return this;
    }

    public override void Write(TextWriter writer)
    {
      Assertion.NotNull(writer);

      writer.Write(this.ToTag("g:plusone", tag => tag
        .Attribute("href", this.url)
        .Attribute("size", this.size)
        .Attribute("annotation", this.annotation)
        .Attribute("width", this.width)
        .Attribute("align", this.alignment)
        .Attribute("data-callback", this.callback)
        .Attribute("data-recommendations", this.recommendations)));
    }
  }
}