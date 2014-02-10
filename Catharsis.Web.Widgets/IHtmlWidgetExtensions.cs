using System;
using System.IO;
using System.Text;
using System.Web;
using System.Web.Mvc;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Set of extension methods for interface <see cref="IHtmlWidget"/>.</para>
  ///   <seealso cref="IHtmlWidget"/>
  /// </summary>
  public static class IHtmlWidgetExtensions
  {
    /// <summary>
    ///   <para></para>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="widget"></param>
    /// <param name="attributes"></param>
    /// <exception cref="ArgumentNullException">If either <paramref name="widget"/> or <paramref name="attributes"/> is a <c>null</c> reference.</exception>
    public static T HtmlAttributes<T>(this T widget, object attributes) where T : IHtmlWidget
    {
      Assertion.NotNull(widget);
      Assertion.NotNull(attributes);

      attributes.GetType().GetProperties().Each(property => widget.HtmlAttributes.Add(property.Name, property.GetValue(attributes, null)));
      return widget;
    }

    /// <summary>
    ///   <para></para>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="widget"></param>
    /// <param name="html"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    public static T HtmlBody<T>(this T widget, string html) where T : IHtmlWidget
    {
      Assertion.NotNull(widget);

      widget.HtmlBody = html;
      return widget;
    }

    /// <summary>
    ///   <para></para>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="widget"></param>
    /// <param name="stream"></param>
    /// <param name="encoding"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentNullException">If either <paramref name="widget"/> or <paramref name="stream"/> is a <c>null</c> reference.</exception>
    public static T Write<T>(this T widget, Stream stream, Encoding encoding = null) where T : IHtmlWidget
    {
      Assertion.NotNull(widget);
      Assertion.NotNull(stream);

      var writer = stream.TextWriter(encoding);
      widget.Write(writer);
      writer.Flush();
      return widget;
    }

    /// <summary>
    ///   <para></para>
    /// </summary>
    /// <param name="widget"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    public static T WriteHttp<T>(this T widget) where T : IHtmlWidget
    {
      Assertion.NotNull(widget);

      if (HttpContext.Current != null)
      {
        widget.Write(HttpContext.Current.Response.Output);
      }

      return widget;
    }

    /// <summary>
    ///   <para></para>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="widget"></param>
    /// <param name="tag"></param>
    /// <param name="builder"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentNullException">If either <paramref name="widget"/> or <paramref name="tag"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="tag"/> is <see cref="string.Empty"/> string.</exception>
    public static string ToTag<T>(this T widget, string tag, Action<TagBuilder> builder = null) where T : IHtmlWidget
    {
      Assertion.NotNull(widget);
      Assertion.NotEmpty(tag);

      var tagBuilder = new TagBuilder(tag);
      if (builder != null) 
      {
        builder(tagBuilder);
      }
      widget.HtmlAttributes.Each(attribute => tagBuilder.Attributes.Add(attribute.Key, attribute.Value.ToString()));
      return tagBuilder.ToString();
    }

    /// <summary>
    ///   <para></para>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="widget"></param>
    /// <param name="code"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentNullException">If either <paramref name="widget"/> or <paramref name="code"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="code"/> is <see cref="string.Empty"/> string.</exception>
    public static string JavaScript<T>(this T widget, string code) where T : IHtmlWidget
    {
      Assertion.NotNull(widget);
      Assertion.NotEmpty(code);

      return widget.ToTag("script", tag => tag.Attribute("type", "text/javascript").InnerHtml(code));
    }

    /// <summary>
    ///   <para></para>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="widget"></param>
    /// <param name="url"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentNullException">If either <paramref name="widget"/> or <paramref name="url"/> is a <c>null</c> reference.</exception>
    public static string JavaScript<T>(this T widget, Uri url) where T : IHtmlWidget
    {
      Assertion.NotNull(widget);
      Assertion.NotNull(url);

      return widget.ToTag("script", tag => tag.Attribute("type", "text/javascript").Attribute("src", url));
    }
  }
}