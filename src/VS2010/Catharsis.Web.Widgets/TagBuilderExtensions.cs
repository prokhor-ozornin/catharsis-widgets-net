using System;
using System.Web.Mvc;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Set of extension methods for class <see cref="TagBuilder"/>.</para>
  /// </summary>
  /// <seealso cref="TagBuilder"/>
  public static class TagBuilderExtensions
  {
    /// <summary>
    ///   <para></para>
    /// </summary>
    /// <param name="builder"></param>
    /// <param name="name"></param>
    /// <param name="value"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentNullException">If either <paramref name="builder"/> or <paramref name="name"/> is a <c>null</c> reference.</exception>
    public static TagBuilder Attribute(this TagBuilder builder, string name, object value)
    {
      Assertion.NotNull(builder);
      Assertion.NotEmpty(name);

      if (value != null)
      {
        var attribute = value.ToString();
        if (value.GetType().IsPrimitive)
        {
          attribute = attribute.ToLowerInvariant();
        }
        builder.MergeAttribute(name, attribute);
      }
      return builder;
    }

    /// <summary>
    ///   <para></para>
    /// </summary>
    /// <param name="builder"></param>
    /// <param name="attributes"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentNullException">If either <paramref name="builder"/> or <paramref name="attributes"/> is a <c>null</c> reference.</exception>
    public static TagBuilder Attributes(this TagBuilder builder, object attributes)
    {
      Assertion.NotNull(builder);
      Assertion.NotNull(attributes);

      attributes.GetType().GetProperties().Each(property => builder.Attributes.Add(property.Name, property.GetValue(attributes, null).ToString()));
      return builder;
    }

    /// <summary>
    ///   <para></para>
    /// </summary>
    /// <param name="builder"></param>
    /// <param name="css"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentNullException">If either <paramref name="builder"/> or <paramref name="css"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="css"/> is <see cref="string.Empty"/> string.</exception>
    public static TagBuilder CssClass(this TagBuilder builder, string css)
    {
      Assertion.NotNull(builder);
      Assertion.NotEmpty(css);

      builder.AddCssClass(css);
      return builder;
    }

    /// <summary>
    ///   <para></para>
    /// </summary>
    /// <param name="builder"></param>
    /// <param name="css"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentNullException">If either <paramref name="builder"/> or <paramref name="css"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="css"/> is <see cref="string.Empty"/> string.</exception>
    public static TagBuilder CssStyle(this TagBuilder builder, string css)
    {
      Assertion.NotNull(builder);
      Assertion.NotEmpty(css);

      return builder.Attribute("style", css);
    }

    /// <summary>
    ///   <para></para>
    /// </summary>
    /// <param name="builder"></param>
    /// <param name="html"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentNullException">If <paramref name="builder"/> is a <c>null</c> reference.</exception>
    public static TagBuilder InnerHtml(this TagBuilder builder, string html)
    {
      Assertion.NotNull(builder);

      if (html.IsEmpty())
      {
        return builder;
      }

      builder.InnerHtml = html;
      return builder;
    }
  }
}