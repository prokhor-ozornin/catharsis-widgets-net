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
  /// <returns>Back self-reference to the given <paramref name="builder"/>.</returns>
  /// <exception cref="ArgumentNullException">If either <paramref name="builder"/> or <paramref name="name"/> is <see langword="null"/>.</exception>
  /// <exception cref="ArgumentException">If <paramref name="name"/> is invalid string.</exception>
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
  /// <returns>Back self-reference to the given <paramref name="builder"/>.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="builder"/> is <see langword="null"/>.</exception>
  public static ITagBuilder Attributes(this ITagBuilder builder, IEnumerable<(string Name, object Value)> attributes)
  {
    if (builder is null) throw new ArgumentNullException(nameof(builder));

    attributes?.ForEach(attribute => builder.Attribute(attribute.Name, attribute.Value));

    return builder;
  }

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="builder"></param>
  /// <param name="attributes"></param>
  /// <returns>Back self-reference to the given <paramref name="builder"/>.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="builder"/> is <see langword="null"/>.</exception>
  public static ITagBuilder Attributes(this ITagBuilder builder, object attributes) => builder?.Attributes(attributes?.GetState()) ?? throw new ArgumentNullException(nameof(builder));

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="builder"></param>
  /// <param name="name"></param>
  /// <returns>Back self-reference to the given <paramref name="builder"/>.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="builder"/> is <see langword="null"/>.</exception>
  public static ITagBuilder CssClass(this ITagBuilder builder, string name) => builder?.CssClasses(name) ?? throw new ArgumentNullException(nameof(builder));

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="builder"></param>
  /// <param name="names"></param>
  /// <returns>Back self-reference to the given <paramref name="builder"/>.</returns>
  /// <exception cref="ArgumentNullException">If either <paramref name="builder"/> or <paramref name="names"/> is <see langword="null"/>.</exception>
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
  /// <returns>Back self-reference to the given <paramref name="builder"/>.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="builder"/> is <see langword="null"/>.</exception>
  public static ITagBuilder CssClasses(this ITagBuilder builder, params string[] names) => builder?.CssClasses(names as IEnumerable<string>) ?? throw new ArgumentNullException(nameof(builder));

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="builder"></param>
  /// <param name="style"></param>
  /// <returns>Back self-reference to the given <paramref name="builder"/>.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="builder"/> is <see langword="null"/>.</exception>
  public static ITagBuilder CssStyle(this ITagBuilder builder, string style) => builder?.Attribute("style", style) ?? throw new ArgumentNullException(nameof(builder));

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="builder"></param>
  /// <param name="styles"></param>
  /// <returns>Back self-reference to the given <paramref name="builder"/>.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="builder"/> is <see langword="null"/>.</exception>
  public static ITagBuilder CssStyles(this ITagBuilder builder, IEnumerable<(string Name, string Value)> styles)
  {
    if (builder is null) throw new ArgumentNullException(nameof(builder));

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="builder"></param>
  /// <param name="styles"></param>
  /// <returns>Back self-reference to the given <paramref name="builder"/>.</returns>
  /// <exception cref="ArgumentNullException">If either <paramref name="builder"/> or <paramref name="styles"/> is <see langword="null"/>.</exception>
  public static ITagBuilder CssStyles(this ITagBuilder builder, IEnumerable<(string Name, object Value)> styles)
  {
    if (builder is null) throw new ArgumentNullException(nameof(builder));
    if (styles is null) throw new ArgumentNullException(nameof(styles));
    
    return builder.CssStyles(styles.Select(style => (style.Name, style.Value?.ToInvariantString()))); 
  }

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="builder"></param>
  /// <param name="key"></param>
  /// <returns>Back self-reference to the given <paramref name="builder"/>.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="builder"/> is <see langword="null"/>.</exception>
  public static ITagBuilder AccessKey(this ITagBuilder builder, string key) => builder?.Attribute("accesskey", key) ?? throw new ArgumentNullException(nameof(builder));

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="builder"></param>
  /// <param name="enabled"></param>
  /// <returns>Back self-reference to the given <paramref name="builder"/>.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="builder"/> is <see langword="null"/>.</exception>
  public static ITagBuilder ContentEditable(this ITagBuilder builder, bool? enabled) => builder?.Attribute("contenteditable", enabled) ?? throw new ArgumentNullException(nameof(builder));

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="builder"></param>
  /// <param name="id"></param>
  /// <returns>Back self-reference to the given <paramref name="builder"/>.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="builder"/> is <see langword="null"/>.</exception>
  public static ITagBuilder ContextMenu(this ITagBuilder builder, string id) => builder?.Attribute("contextmenu", id) ?? throw new ArgumentNullException(nameof(builder));

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="builder"></param>
  /// <param name="direction"></param>
  /// <returns>Back self-reference to the given <paramref name="builder"/>.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="builder"/> is <see langword="null"/>.</exception>
  public static ITagBuilder TextDirection(this ITagBuilder builder, string direction) => builder?.Attribute("dir", direction) ?? throw new ArgumentNullException(nameof(builder));

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="builder"></param>
  /// <param name="direction"></param>
  /// <returns>Back self-reference to the given <paramref name="builder"/>.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="builder"/> is <see langword="null"/>.</exception>
  public static ITagBuilder TextDirection(this ITagBuilder builder, TextDirection direction)
  {
    if (builder is null) throw new ArgumentNullException(nameof(builder));

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
  /// <returns>Back self-reference to the given <paramref name="builder"/>.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="builder"/> is <see langword="null"/>.</exception>
  public static ITagBuilder Hidden(this ITagBuilder builder, bool? enabled) => builder?.Attribute("hidden", enabled.GetValueOrDefault() ? "hidden" : null) ?? throw new ArgumentNullException(nameof(builder));

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="builder"></param>
  /// <param name="id"></param>
  /// <returns>Back self-reference to the given <paramref name="builder"/>.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="builder"/> is <see langword="null"/>.</exception>
  public static ITagBuilder Id(this ITagBuilder builder, string id) => builder?.Attribute("id", id) ?? throw new ArgumentNullException(nameof(builder));

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="builder"></param>
  /// <param name="code"></param>
  /// <returns>Back self-reference to the given <paramref name="builder"/>.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="builder"/> is <see langword="null"/>.</exception>
  public static ITagBuilder Language(this ITagBuilder builder, string code) => builder?.Attribute("lang", code) ?? throw new ArgumentNullException(nameof(builder));

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="builder"></param>
  /// <param name="culture"></param>
  /// <returns>Back self-reference to the given <paramref name="builder"/>.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="builder"/> is <see langword="null"/>.</exception>
  public static ITagBuilder Language(this ITagBuilder builder, CultureInfo culture) => builder?.Language(culture?.TwoLetterISOLanguageName) ?? throw new ArgumentNullException(nameof(builder));

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="builder"></param>
  /// <param name="enabled"></param>
  /// <returns>Back self-reference to the given <paramref name="builder"/>.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="builder"/> is <see langword="null"/>.</exception>
  public static ITagBuilder Spellcheck(this ITagBuilder builder, bool? enabled) => builder?.Attribute("spellcheck", enabled) ?? throw new ArgumentNullException(nameof(builder));

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="builder"></param>
  /// <param name="index"></param>
  /// <returns>Back self-reference to the given <paramref name="builder"/>.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="builder"/> is <see langword="null"/>.</exception>
  public static ITagBuilder TabIndex(this ITagBuilder builder, int? index) => builder?.Attribute("tabindex", index) ?? throw new ArgumentNullException(nameof(builder));

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="builder"></param>
  /// <param name="title"></param>
  /// <returns>Back self-reference to the given <paramref name="builder"/>.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="builder"/> is <see langword="null"/>.</exception>
  public static ITagBuilder Title(this ITagBuilder builder, string title) => builder?.Attribute("title", title) ?? throw new ArgumentNullException(nameof(builder));

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="builder"></param>
  /// <param name="script"></param>
  /// <returns>Back self-reference to the given <paramref name="builder"/>.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="builder"/> is <see langword="null"/>.</exception>
  public static ITagBuilder OnBlur(this ITagBuilder builder, string script) => builder?.Attribute("onblur", script) ?? throw new ArgumentNullException(nameof(builder));

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="builder"></param>
  /// <param name="script"></param>
  /// <returns>Back self-reference to the given <paramref name="builder"/>.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="builder"/> is <see langword="null"/>.</exception>
  public static ITagBuilder OnChange(this ITagBuilder builder, string script) => builder?.Attribute("onchange", script) ?? throw new ArgumentNullException(nameof(builder));

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="builder"></param>
  /// <param name="script"></param>
  /// <returns>Back self-reference to the given <paramref name="builder"/>.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="builder"/> is <see langword="null"/>.</exception>
  public static ITagBuilder OnClick(this ITagBuilder builder, string script) => builder?.Attribute("onclick", script) ?? throw new ArgumentNullException(nameof(builder));

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="builder"></param>
  /// <param name="script"></param>
  /// <returns>Back self-reference to the given <paramref name="builder"/>.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="builder"/> is <see langword="null"/>.</exception>
  public static ITagBuilder OnDoubleClick(this ITagBuilder builder, string script) => builder?.Attribute("ondblclick", script) ?? throw new ArgumentNullException(nameof(builder));

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="builder"></param>
  /// <param name="script"></param>
  /// <returns>Back self-reference to the given <paramref name="builder"/>.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="builder"/> is <see langword="null"/>.</exception>
  public static ITagBuilder OnFocus(this ITagBuilder builder, string script) => builder?.Attribute("onfocus", script) ?? throw new ArgumentNullException(nameof(builder));

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="builder"></param>
  /// <param name="script"></param>
  /// <returns>Back self-reference to the given <paramref name="builder"/>.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="builder"/> is <see langword="null"/>.</exception>
  public static ITagBuilder OnKeyDown(this ITagBuilder builder, string script) => builder?.Attribute("onkeydown", script) ?? throw new ArgumentNullException(nameof(builder));

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="builder"></param>
  /// <param name="script"></param>
  /// <returns>Back self-reference to the given <paramref name="builder"/>.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="builder"/> is <see langword="null"/>.</exception>
  public static ITagBuilder OnKeyPress(this ITagBuilder builder, string script) => builder?.Attribute("onkeypress", script) ?? throw new ArgumentNullException(nameof(builder));

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="builder"></param>
  /// <param name="script"></param>
  /// <returns>Back self-reference to the given <paramref name="builder"/>.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="builder"/> is <see langword="null"/>.</exception>
  public static ITagBuilder OnKeyUp(this ITagBuilder builder, string script) => builder?.Attribute("onkeyup", script) ?? throw new ArgumentNullException(nameof(builder));

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="builder"></param>
  /// <param name="script"></param>
  /// <returns>Back self-reference to the given <paramref name="builder"/>.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="builder"/> is <see langword="null"/>.</exception>
  public static ITagBuilder OnLoad(this ITagBuilder builder, string script) => builder?.Attribute("onload", script) ?? throw new ArgumentNullException(nameof(builder));

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="builder"></param>
  /// <param name="script"></param>
  /// <returns>Back self-reference to the given <paramref name="builder"/>.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="builder"/> is <see langword="null"/>.</exception>
  public static ITagBuilder OnMouseDown(this ITagBuilder builder, string script) => builder?.Attribute("onmousedown", script) ?? throw new ArgumentNullException(nameof(builder));

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="builder"></param>
  /// <param name="script"></param>
  /// <returns>Back self-reference to the given <paramref name="builder"/>.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="builder"/> is <see langword="null"/>.</exception>
  public static ITagBuilder OnMouseMove(this ITagBuilder builder, string script) => builder?.Attribute("onmousemove", script) ?? throw new ArgumentNullException(nameof(builder));

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="builder"></param>
  /// <param name="script"></param>
  /// <returns>Back self-reference to the given <paramref name="builder"/>.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="builder"/> is <see langword="null"/>.</exception>
  public static ITagBuilder OnMouseOut(this ITagBuilder builder, string script) => builder?.Attribute("onmouseout", script) ?? throw new ArgumentNullException(nameof(builder));

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="builder"></param>
  /// <param name="script"></param>
  /// <returns>Back self-reference to the given <paramref name="builder"/>.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="builder"/> is <see langword="null"/>.</exception>
  public static ITagBuilder OnMouseOver(this ITagBuilder builder, string script) => builder?.Attribute("onmouseover", script) ?? throw new ArgumentNullException(nameof(builder));

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="builder"></param>
  /// <param name="script"></param>
  /// <returns>Back self-reference to the given <paramref name="builder"/>.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="builder"/> is <see langword="null"/>.</exception>
  public static ITagBuilder OnMouseUp(this ITagBuilder builder, string script) => builder?.Attribute("onmouseup", script) ?? throw new ArgumentNullException(nameof(builder));

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="builder"></param>
  /// <param name="script"></param>
  /// <returns>Back self-reference to the given <paramref name="builder"/>.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="builder"/> is <see langword="null"/>.</exception>
  public static ITagBuilder OnReset(this ITagBuilder builder, string script) => builder?.Attribute("onreset", script) ?? builder;

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="builder"></param>
  /// <param name="script"></param>
  /// <returns>Back self-reference to the given <paramref name="builder"/>.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="builder"/> is <see langword="null"/>.</exception>
  public static ITagBuilder OnSelect(this ITagBuilder builder, string script) => builder?.Attribute("onselect", script) ?? throw new ArgumentNullException(nameof(builder));

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="builder"></param>
  /// <param name="script"></param>
  /// <returns>Back self-reference to the given <paramref name="builder"/>.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="builder"/> is <see langword="null"/>.</exception>
  public static ITagBuilder OnSubmit(this ITagBuilder builder, string script) => builder?.Attribute("onsubmit", script) ?? throw new ArgumentNullException(nameof(builder));

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="builder"></param>
  /// <param name="script"></param>
  /// <returns>Back self-reference to the given <paramref name="builder"/>.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="builder"/> is <see langword="null"/>.</exception>
  public static ITagBuilder OnUnload(this ITagBuilder builder, string script) => builder?.Attribute("onunload", script) ?? throw new ArgumentNullException(nameof(builder));
}