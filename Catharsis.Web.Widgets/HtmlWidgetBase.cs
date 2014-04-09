using System.Collections.Generic;
using System.IO;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  public abstract class HtmlWidgetBase : IHtmlWidget
  {
    private readonly IDictionary<string, object> htmlAttributes = new Dictionary<string, object>();

    public IDictionary<string, object> HtmlAttributes
    {
      get { return this.htmlAttributes; }
    }

    public string HtmlBody { get; set; }

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

    /// <summary>
    ///   <para>Generates and writes HTML markup of widget, using specified text writer.</para>
    /// </summary>
    /// <param name="writer">Text writer to use as output destination.</param>
    public abstract void Write(TextWriter writer);
  }
}