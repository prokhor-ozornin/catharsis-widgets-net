using System.Collections.Generic;
using System.IO;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  public abstract class HtmlWidgetBase<T> : IHtmlWidget where T : IHtmlWidget
  {
    private readonly IDictionary<string, object> htmlAttributes = new Dictionary<string, object>();

    public string ToHtmlString()
    {
      return new StringWriter().With(writer =>
      {
        this.Write(writer);
        return writer.ToString();
      });
    }

    public override string ToString()
    {
      return this.ToHtmlString();
    }

    public IDictionary<string, object> HtmlAttributes
    {
      get { return this.htmlAttributes; }
    }

    public string HtmlBody { get; set; }

    public abstract void Write(TextWriter writer);
  }
}