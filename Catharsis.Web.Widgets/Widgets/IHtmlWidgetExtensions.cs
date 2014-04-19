using System;
using System.Web;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Set of extension methods for interface <see cref="IHtmlWidget"/>.</para>
  /// </summary>
  /// <seealso cref="IHtmlWidget"/>
  public static class IHtmlWidgetExtensions
  {
    /// <summary>
    ///   <para></para>
    /// </summary>
    /// <param name="widget"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    public static T Render<T>(this T widget) where T : IHtmlWidget
    {
      Assertion.NotNull(widget);

      if (HttpContext.Current != null)
      {
        HttpContext.Current.Response.Output.Write(widget.ToHtmlString());
      }

      return widget;
    }
  }
}