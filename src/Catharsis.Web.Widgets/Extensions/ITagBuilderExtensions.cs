using System.Globalization;
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
    if (builder is null)
      throw new ArgumentNullException(nameof(builder));
    if (attributes is null)
      throw new ArgumentNullException(nameof(attributes));

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
    if (builder is null)
      throw new ArgumentNullException(nameof(builder));
    if (attributes is null)
      throw new ArgumentNullException(nameof(attributes));

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
    if (builder is null)
      throw new ArgumentNullException(nameof(builder));
    if (names is null)
      throw new ArgumentNullException(nameof(names));

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
    if (builder is null)
      throw new ArgumentNullException(nameof(builder));

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
    if (builder is null)
      throw new ArgumentNullException(nameof(builder));
    if (styles is null)
      throw new ArgumentNullException(nameof(styles));

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

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="builder"></param>
  /// <param name="key"></param>
  /// <returns></returns>
  public static ITagBuilder AccessKey(this ITagBuilder builder, string key) => builder.Attribute("accesskey", key);

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="builder"></param>
  /// <param name="enabled"></param>
  /// <returns></returns>
  public static ITagBuilder ContentEditable(this ITagBuilder builder, bool? enabled) => builder.Attribute("contenteditable", enabled);

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="builder"></param>
  /// <param name="id"></param>
  /// <returns></returns>
  public static ITagBuilder ContextMenu(this ITagBuilder builder, string id) => builder.Attribute("contextmenu", id);

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="builder"></param>
  /// <param name="direction"></param>
  /// <returns></returns>
  public static ITagBuilder TextDirection(this ITagBuilder builder, string direction) => builder.Attribute("dir", direction);

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="builder"></param>
  /// <param name="direction"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  public static ITagBuilder TextDirection(this ITagBuilder builder, TextDirection direction)
  {
    if (builder is null)
      throw new ArgumentNullException(nameof(builder));

    var value = direction switch
    {
      Web.Widgets.TextDirection.LeftToRight => "ltr",
      Web.Widgets.TextDirection.RightToLeft => "rtl",
      _ => null
    };

    return builder.TextDirection(value);
  }

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="builder"></param>
  /// <param name="enabled"></param>
  /// <returns></returns>
  public static ITagBuilder Hidden(this ITagBuilder builder, bool? enabled) => builder.Attribute("hidden", enabled.GetValueOrDefault() ? "hidden" : null);

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="builder"></param>
  /// <param name="id"></param>
  /// <returns></returns>
  public static ITagBuilder Id(this ITagBuilder builder, string id) => builder.Attribute("id", id);

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="builder"></param>
  /// <param name="code"></param>
  /// <returns></returns>
  public static ITagBuilder Language(this ITagBuilder builder, string code) => builder.Attribute("lang", code);

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="builder"></param>
  /// <param name="culture"></param>
  /// <returns></returns>
  public static ITagBuilder Language(this ITagBuilder builder, CultureInfo culture) => builder.Language(culture?.TwoLetterISOLanguageName);

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="builder"></param>
  /// <param name="enabled"></param>
  /// <returns></returns>
  public static ITagBuilder Spellcheck(this ITagBuilder builder, bool? enabled) => builder.Attribute("spellcheck", enabled);

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="builder"></param>
  /// <param name="index"></param>
  /// <returns></returns>
  public static ITagBuilder TabIndex(this ITagBuilder builder, uint? index) => builder.Attribute("tabindex", index);

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="builder"></param>
  /// <param name="title"></param>
  /// <returns></returns>
  public static ITagBuilder Title(this ITagBuilder builder, string title) => builder.Attribute("title", title);

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="builder"></param>
  /// <param name="script"></param>
  /// <returns></returns>
  public static ITagBuilder OnBlur(this ITagBuilder builder, string script) => builder.Attribute("onblur", script);

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="builder"></param>
  /// <param name="script"></param>
  /// <returns></returns>
  public static ITagBuilder OnChange(this ITagBuilder builder, string script) => builder.Attribute("onchange", script);

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="builder"></param>
  /// <param name="script"></param>
  /// <returns></returns>
  public static ITagBuilder OnClick(this ITagBuilder builder, string script) => builder.Attribute("onclick", script);

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="builder"></param>
  /// <param name="script"></param>
  /// <returns></returns>
  public static ITagBuilder OnDoubleClick(this ITagBuilder builder, string script) => builder.Attribute("ondblclick", script);

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="builder"></param>
  /// <param name="script"></param>
  /// <returns></returns>
  public static ITagBuilder OnFocus(this ITagBuilder builder, string script) => builder.Attribute("onfocus", script);

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="builder"></param>
  /// <param name="script"></param>
  /// <returns></returns>
  public static ITagBuilder OnKeyDown(this ITagBuilder builder, string script) => builder.Attribute("onkeydown", script);

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="builder"></param>
  /// <param name="script"></param>
  /// <returns></returns>
  public static ITagBuilder OnKeyPress(this ITagBuilder builder, string script) => builder.Attribute("onkeypress", script);

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="builder"></param>
  /// <param name="script"></param>
  /// <returns></returns>
  public static ITagBuilder OnKeyUp(this ITagBuilder builder, string script) => builder.Attribute("onkeyup", script);

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="builder"></param>
  /// <param name="script"></param>
  /// <returns></returns>
  public static ITagBuilder OnLoad(this ITagBuilder builder, string script) => builder.Attribute("onload", script);

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="builder"></param>
  /// <param name="script"></param>
  /// <returns></returns>
  public static ITagBuilder OnMouseDown(this ITagBuilder builder, string script) => builder.Attribute("onmousedown", script);

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="builder"></param>
  /// <param name="script"></param>
  /// <returns></returns>
  public static ITagBuilder OnMouseMove(this ITagBuilder builder, string script) => builder.Attribute("onmousemove", script);

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="builder"></param>
  /// <param name="script"></param>
  /// <returns></returns>
  public static ITagBuilder OnMouseOut(this ITagBuilder builder, string script) => builder.Attribute("onmouseout", script);

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="builder"></param>
  /// <param name="script"></param>
  /// <returns></returns>
  public static ITagBuilder OnMouseOver(this ITagBuilder builder, string script) => builder.Attribute("onmouseover", script);

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="builder"></param>
  /// <param name="script"></param>
  /// <returns></returns>
  public static ITagBuilder OnMouseUp(this ITagBuilder builder, string script) => builder.Attribute("onmouseup", script);

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="builder"></param>
  /// <param name="script"></param>
  /// <returns></returns>
  public static ITagBuilder OnReset(this ITagBuilder builder, string script) => builder.Attribute("onreset", script);

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="builder"></param>
  /// <param name="script"></param>
  /// <returns></returns>
  public static ITagBuilder OnSelect(this ITagBuilder builder, string script) => builder.Attribute("onselect", script);

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="builder"></param>
  /// <param name="script"></param>
  /// <returns></returns>
  public static ITagBuilder OnSubmit(this ITagBuilder builder, string script) => builder.Attribute("onsubmit", script);

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="builder"></param>
  /// <param name="script"></param>
  /// <returns></returns>
  public static ITagBuilder OnUnload(this ITagBuilder builder, string script) => builder.Attribute("onunload", script);
}