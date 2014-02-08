using System.Collections.Generic;
using System.IO;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para></para>
  /// </summary>
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

    /// <summary>
    ///   <para></para>
    /// </summary>
    /// <returns></returns>
    public override string ToString()
    {
      return this.ToHtmlString();
    }

    public IDictionary<string, object> HtmlAttributes
    {
      get { return this.htmlAttributes; }
    }

    public string HtmlBody { get; set; }

    /// <summary>
    ///   <para>Abstract declaration of <see cref="IHtmlWidget.Write(TextWriter)"/> method.</para>
    /// </summary>
    public abstract void Write(TextWriter writer);
  }
}