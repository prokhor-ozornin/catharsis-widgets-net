using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

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
    if (builder is null) throw new ArgumentNullException(nameof(builder));
    if (name is null) throw new ArgumentNullException(nameof(name));
    if (name.IsEmpty()) throw new ArgumentException(nameof(name));

    if (value is not null)
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
    if (builder is null) throw new ArgumentNullException(nameof(builder));
    if (attributes is null) throw new ArgumentNullException(nameof(attributes));

    attributes.GetType().GetProperties().ForEach(property => builder.Attributes.Add(property.Name, property.GetValue(attributes, null).ToString()));

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
    if (builder is null) throw new ArgumentNullException(nameof(builder));
    if (css is null) throw new ArgumentNullException(nameof(css));
    if (css.IsEmpty()) throw new ArgumentException(nameof(css));

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
    if (builder is null) throw new ArgumentNullException(nameof(builder));
    if (css is null) throw new ArgumentNullException(nameof(css));
    if (css.IsEmpty()) throw new ArgumentException(nameof(css));

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
    if (builder is null) throw new ArgumentNullException(nameof(builder));

    if (html.IsEmpty())
    {
      return builder;
    }

    builder.InnerHtml = html;

    return builder;
  }
}