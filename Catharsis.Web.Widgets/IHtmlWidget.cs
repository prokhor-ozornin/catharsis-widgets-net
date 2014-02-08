using System;
using System.Collections.Generic;
using System.IO;
using System.Web;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  public interface IHtmlWidget : IHtmlString
  {
    /// <summary>
    ///   <para></para>
    /// </summary>
    IDictionary<string, object> HtmlAttributes { get; }

    /// <summary>
    ///   <para></para>
    /// </summary>
    string HtmlBody { get; set; }

    /// <summary>
    ///   <para></para>
    /// </summary>
    /// <param name="writer"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentNullException">If <paramref name="writer"/> is a <c>null</c> reference.</exception>
    void Write(TextWriter writer);
  }
}