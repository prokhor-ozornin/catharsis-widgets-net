using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Set of extension methods for interface <see cref="ITagBuilder"/>.</para>
/// </summary>
/// <seealso cref="ITagBuilder"/>
public static class ITagBuilderExtensions
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="builder"></param>
  /// <param name="name"></param>
  /// <param name="value"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  /// <exception cref="ArgumentException"></exception>
  public static ITagBuilder Attribute(this ITagBuilder builder, string name, object value)
  {
    if (builder is null) throw new ArgumentNullException(nameof(builder));
    if (name is null) throw new ArgumentNullException(nameof(name));
    if (name.IsEmpty()) throw new ArgumentException(nameof(name));

    return builder.Attribute(name, value?.ToInvariantString());
  }

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="builder"></param>
  /// <param name="attributes"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  /// <exception cref="ArgumentException"></exception>
  public static ITagBuilder Attributes(this ITagBuilder builder, IEnumerable<(string Name, object Value)> attributes)
  {
    if (builder is null) throw new ArgumentNullException(nameof(builder));
    if (attributes is null) throw new ArgumentNullException(nameof(attributes));

    attributes.ForEach(attribute => builder.Attribute(attribute.Name, attribute.Value));

    return builder;
  }

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="builder"></param>
  /// <param name="attributes"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  public static ITagBuilder Attributes(this ITagBuilder builder, object attributes)
  {
    if (builder is null) throw new ArgumentNullException(nameof(builder));
    if (attributes is null) throw new ArgumentNullException(nameof(attributes));

    return builder.Attributes(attributes.GetState());
  }

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="builder"></param>
  /// <param name="name"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  public static ITagBuilder CssClass(this ITagBuilder builder, string name) => builder.CssClasses(name);

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="builder"></param>
  /// <param name="names"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  /// <exception cref="ArgumentException"></exception>
  public static ITagBuilder CssClasses(this ITagBuilder builder, IEnumerable<string> names)
  {
    if (builder is null) throw new ArgumentNullException(nameof(builder));
    if (names is null) throw new ArgumentNullException(nameof(names));

    return builder.Attribute("class", names.AsNotNullable().Select(it => it.Trim()).Join(" "));
  }

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="builder"></param>
  /// <param name="names"></param>
  /// <exception cref="ArgumentNullException"></exception>
  /// <exception cref="ArgumentException"></exception>
  public static ITagBuilder CssClasses(this ITagBuilder builder, params string[] names) => builder.CssClasses(names as IEnumerable<string>);

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="builder"></param>
  /// <param name="style"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  public static ITagBuilder CssStyle(this ITagBuilder builder, string style)
  {
    if (builder is null) throw new ArgumentNullException(nameof(builder));

    return builder.Attribute("style", style);
  }

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="builder"></param>
  /// <param name="styles"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  /// <exception cref="ArgumentException"></exception>
  public static ITagBuilder CssStyles(this ITagBuilder builder, IEnumerable<(string Name, string Value)> styles)
  {
    if (builder is null) throw new ArgumentNullException(nameof(builder));
    if (styles is null) throw new ArgumentNullException(nameof(styles));

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="builder"></param>
  /// <param name="styles"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  /// <exception cref="ArgumentException"></exception>
  public static ITagBuilder CssStyles(this ITagBuilder builder, IEnumerable<(string Name, object Value)> styles) => builder.CssStyles(styles.Select(style => (style.Name, style.Value?.ToInvariantString())));
}