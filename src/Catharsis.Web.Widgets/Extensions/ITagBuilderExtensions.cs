using System.Globalization;
using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Set of extension methods for interface <see cref="ITagBuilder"/>.</para>
/// </summary>
/// <seealso cref="ITagBuilder"/>
public static class ITagBuilderExtensions
{
  /// <param name="builder"></param>
  extension(ITagBuilder builder)
  {
    /// <summary>
    ///   <para></para>
    /// </summary>
    /// <param name="name"></param>
    /// <param name="value"></param>
    /// <returns>Back self-reference to the given <paramref name="builder"/>.</returns>
    /// <exception cref="ArgumentNullException">If either <paramref name="builder"/> or <paramref name="name"/> is <see langword="null"/>.</exception>
    /// <exception cref="ArgumentException">If <paramref name="name"/> is invalid string.</exception>
    public ITagBuilder Attribute(string name, object value)
    {
      if (builder is null) throw new ArgumentNullException(nameof(builder));
      if (name is null) throw new ArgumentNullException(nameof(name));
      if (name.IsEmpty()) throw new ArgumentException(nameof(name));

      return builder.Attribute(name, value?.ToInvariantString());
    }

    /// <summary>
    ///   <para></para>
    /// </summary>
    /// <param name="attributes"></param>
    /// <returns>Back self-reference to the given <paramref name="builder"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="builder"/> is <see langword="null"/>.</exception>
    public ITagBuilder Attributes(IEnumerable<(string Name, object Value)> attributes)
    {
      if (builder is null) throw new ArgumentNullException(nameof(builder));

      attributes?.ForEach(attribute => builder.Attribute(attribute.Name, attribute.Value));

      return builder;
    }

    /// <summary>
    ///   <para></para>
    /// </summary>
    /// <param name="attributes"></param>
    /// <returns>Back self-reference to the given <paramref name="builder"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="builder"/> is <see langword="null"/>.</exception>
    public ITagBuilder Attributes(object attributes) => builder?.Attributes(attributes?.GetState()) ?? throw new ArgumentNullException(nameof(builder));

    /// <summary>
    ///   <para></para>
    /// </summary>
    /// <param name="name"></param>
    /// <returns>Back self-reference to the given <paramref name="builder"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="builder"/> is <see langword="null"/>.</exception>
    public ITagBuilder CssClass(string name) => builder?.CssClasses(name) ?? throw new ArgumentNullException(nameof(builder));

    /// <summary>
    ///   <para></para>
    /// </summary>
    /// <param name="names"></param>
    /// <returns>Back self-reference to the given <paramref name="builder"/>.</returns>
    /// <exception cref="ArgumentNullException">If either <paramref name="builder"/> or <paramref name="names"/> is <see langword="null"/>.</exception>
    public ITagBuilder CssClasses(IEnumerable<string> names)
    {
      if (builder is null) throw new ArgumentNullException(nameof(builder));
      if (names is null) throw new ArgumentNullException(nameof(names));

      return builder.Attribute("class", names.AsNotNullable().Select(it => it.Trim()).Join(" "));
    }

    /// <summary>
    ///   <para></para>
    /// </summary>
    /// <param name="names"></param>
    /// <returns>Back self-reference to the given <paramref name="builder"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="builder"/> is <see langword="null"/>.</exception>
    public ITagBuilder CssClasses(params string[] names) => builder?.CssClasses(names as IEnumerable<string>) ?? throw new ArgumentNullException(nameof(builder));

    /// <summary>
    ///   <para></para>
    /// </summary>
    /// <param name="style"></param>
    /// <returns>Back self-reference to the given <paramref name="builder"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="builder"/> is <see langword="null"/>.</exception>
    public ITagBuilder CssStyle(string style) => builder?.Attribute("style", style) ?? throw new ArgumentNullException(nameof(builder));

    /// <summary>
    ///   <para></para>
    /// </summary>
    /// <param name="styles"></param>
    /// <returns>Back self-reference to the given <paramref name="builder"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="builder"/> is <see langword="null"/>.</exception>
    public ITagBuilder CssStyles(IEnumerable<(string Name, string Value)> styles)
    {
      if (builder is null) throw new ArgumentNullException(nameof(builder));

      throw new NotImplementedException();
    }

    /// <summary>
    ///   <para></para>
    /// </summary>
    /// <param name="styles"></param>
    /// <returns>Back self-reference to the given <paramref name="builder"/>.</returns>
    /// <exception cref="ArgumentNullException">If either <paramref name="builder"/> or <paramref name="styles"/> is <see langword="null"/>.</exception>
    public ITagBuilder CssStyles(IEnumerable<(string Name, object Value)> styles)
    {
      if (builder is null) throw new ArgumentNullException(nameof(builder));
      if (styles is null) throw new ArgumentNullException(nameof(styles));
    
      return builder.CssStyles(styles.Select(style => (style.Name, style.Value?.ToInvariantString()))); 
    }

    /// <summary>
    ///   <para></para>
    /// </summary>
    /// <param name="key"></param>
    /// <returns>Back self-reference to the given <paramref name="builder"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="builder"/> is <see langword="null"/>.</exception>
    public ITagBuilder AccessKey(string key) => builder?.Attribute("accesskey", key) ?? throw new ArgumentNullException(nameof(builder));

    /// <summary>
    ///   <para></para>
    /// </summary>
    /// <param name="enabled"></param>
    /// <returns>Back self-reference to the given <paramref name="builder"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="builder"/> is <see langword="null"/>.</exception>
    public ITagBuilder ContentEditable(bool? enabled) => builder?.Attribute("contenteditable", enabled) ?? throw new ArgumentNullException(nameof(builder));

    /// <summary>
    ///   <para></para>
    /// </summary>
    /// <param name="id"></param>
    /// <returns>Back self-reference to the given <paramref name="builder"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="builder"/> is <see langword="null"/>.</exception>
    public ITagBuilder ContextMenu(string id) => builder?.Attribute("contextmenu", id) ?? throw new ArgumentNullException(nameof(builder));

    /// <summary>
    ///   <para></para>
    /// </summary>
    /// <param name="direction"></param>
    /// <returns>Back self-reference to the given <paramref name="builder"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="builder"/> is <see langword="null"/>.</exception>
    public ITagBuilder TextDirection(string direction) => builder?.Attribute("dir", direction) ?? throw new ArgumentNullException(nameof(builder));

    /// <summary>
    ///   <para></para>
    /// </summary>
    /// <param name="direction"></param>
    /// <returns>Back self-reference to the given <paramref name="builder"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="builder"/> is <see langword="null"/>.</exception>
    public ITagBuilder TextDirection(TextDirection direction)
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
    /// <param name="enabled"></param>
    /// <returns>Back self-reference to the given <paramref name="builder"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="builder"/> is <see langword="null"/>.</exception>
    public ITagBuilder Hidden(bool? enabled) => builder?.Attribute("hidden", enabled.GetValueOrDefault() ? "hidden" : null) ?? throw new ArgumentNullException(nameof(builder));

    /// <summary>
    ///   <para></para>
    /// </summary>
    /// <param name="id"></param>
    /// <returns>Back self-reference to the given <paramref name="builder"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="builder"/> is <see langword="null"/>.</exception>
    public ITagBuilder Id(string id) => builder?.Attribute("id", id) ?? throw new ArgumentNullException(nameof(builder));

    /// <summary>
    ///   <para></para>
    /// </summary>
    /// <param name="code"></param>
    /// <returns>Back self-reference to the given <paramref name="builder"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="builder"/> is <see langword="null"/>.</exception>
    public ITagBuilder Language(string code) => builder?.Attribute("lang", code) ?? throw new ArgumentNullException(nameof(builder));

    /// <summary>
    ///   <para></para>
    /// </summary>
    /// <param name="culture"></param>
    /// <returns>Back self-reference to the given <paramref name="builder"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="builder"/> is <see langword="null"/>.</exception>
    public ITagBuilder Language(CultureInfo culture) => builder?.Language(culture?.TwoLetterISOLanguageName) ?? throw new ArgumentNullException(nameof(builder));

    /// <summary>
    ///   <para></para>
    /// </summary>
    /// <param name="enabled"></param>
    /// <returns>Back self-reference to the given <paramref name="builder"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="builder"/> is <see langword="null"/>.</exception>
    public ITagBuilder Spellcheck(bool? enabled) => builder?.Attribute("spellcheck", enabled) ?? throw new ArgumentNullException(nameof(builder));

    /// <summary>
    ///   <para></para>
    /// </summary>
    /// <param name="index"></param>
    /// <returns>Back self-reference to the given <paramref name="builder"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="builder"/> is <see langword="null"/>.</exception>
    public ITagBuilder TabIndex(int? index) => builder?.Attribute("tabindex", index) ?? throw new ArgumentNullException(nameof(builder));

    /// <summary>
    ///   <para></para>
    /// </summary>
    /// <param name="title"></param>
    /// <returns>Back self-reference to the given <paramref name="builder"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="builder"/> is <see langword="null"/>.</exception>
    public ITagBuilder Title(string title) => builder?.Attribute("title", title) ?? throw new ArgumentNullException(nameof(builder));

    /// <summary>
    ///   <para></para>
    /// </summary>
    /// <param name="script"></param>
    /// <returns>Back self-reference to the given <paramref name="builder"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="builder"/> is <see langword="null"/>.</exception>
    public ITagBuilder OnBlur(string script) => builder?.Attribute("onblur", script) ?? throw new ArgumentNullException(nameof(builder));

    /// <summary>
    ///   <para></para>
    /// </summary>
    /// <param name="script"></param>
    /// <returns>Back self-reference to the given <paramref name="builder"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="builder"/> is <see langword="null"/>.</exception>
    public ITagBuilder OnChange(string script) => builder?.Attribute("onchange", script) ?? throw new ArgumentNullException(nameof(builder));

    /// <summary>
    ///   <para></para>
    /// </summary>
    /// <param name="script"></param>
    /// <returns>Back self-reference to the given <paramref name="builder"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="builder"/> is <see langword="null"/>.</exception>
    public ITagBuilder OnClick(string script) => builder?.Attribute("onclick", script) ?? throw new ArgumentNullException(nameof(builder));

    /// <summary>
    ///   <para></para>
    /// </summary>
    /// <param name="script"></param>
    /// <returns>Back self-reference to the given <paramref name="builder"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="builder"/> is <see langword="null"/>.</exception>
    public ITagBuilder OnDoubleClick(string script) => builder?.Attribute("ondblclick", script) ?? throw new ArgumentNullException(nameof(builder));

    /// <summary>
    ///   <para></para>
    /// </summary>
    /// <param name="script"></param>
    /// <returns>Back self-reference to the given <paramref name="builder"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="builder"/> is <see langword="null"/>.</exception>
    public ITagBuilder OnFocus(string script) => builder?.Attribute("onfocus", script) ?? throw new ArgumentNullException(nameof(builder));

    /// <summary>
    ///   <para></para>
    /// </summary>
    /// <param name="script"></param>
    /// <returns>Back self-reference to the given <paramref name="builder"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="builder"/> is <see langword="null"/>.</exception>
    public ITagBuilder OnKeyDown(string script) => builder?.Attribute("onkeydown", script) ?? throw new ArgumentNullException(nameof(builder));

    /// <summary>
    ///   <para></para>
    /// </summary>
    /// <param name="script"></param>
    /// <returns>Back self-reference to the given <paramref name="builder"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="builder"/> is <see langword="null"/>.</exception>
    public ITagBuilder OnKeyPress(string script) => builder?.Attribute("onkeypress", script) ?? throw new ArgumentNullException(nameof(builder));

    /// <summary>
    ///   <para></para>
    /// </summary>
    /// <param name="script"></param>
    /// <returns>Back self-reference to the given <paramref name="builder"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="builder"/> is <see langword="null"/>.</exception>
    public ITagBuilder OnKeyUp(string script) => builder?.Attribute("onkeyup", script) ?? throw new ArgumentNullException(nameof(builder));

    /// <summary>
    ///   <para></para>
    /// </summary>
    /// <param name="script"></param>
    /// <returns>Back self-reference to the given <paramref name="builder"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="builder"/> is <see langword="null"/>.</exception>
    public ITagBuilder OnLoad(string script) => builder?.Attribute("onload", script) ?? throw new ArgumentNullException(nameof(builder));

    /// <summary>
    ///   <para></para>
    /// </summary>
    /// <param name="script"></param>
    /// <returns>Back self-reference to the given <paramref name="builder"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="builder"/> is <see langword="null"/>.</exception>
    public ITagBuilder OnMouseDown(string script) => builder?.Attribute("onmousedown", script) ?? throw new ArgumentNullException(nameof(builder));

    /// <summary>
    ///   <para></para>
    /// </summary>
    /// <param name="script"></param>
    /// <returns>Back self-reference to the given <paramref name="builder"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="builder"/> is <see langword="null"/>.</exception>
    public ITagBuilder OnMouseMove(string script) => builder?.Attribute("onmousemove", script) ?? throw new ArgumentNullException(nameof(builder));

    /// <summary>
    ///   <para></para>
    /// </summary>
    /// <param name="script"></param>
    /// <returns>Back self-reference to the given <paramref name="builder"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="builder"/> is <see langword="null"/>.</exception>
    public ITagBuilder OnMouseOut(string script) => builder?.Attribute("onmouseout", script) ?? throw new ArgumentNullException(nameof(builder));

    /// <summary>
    ///   <para></para>
    /// </summary>
    /// <param name="script"></param>
    /// <returns>Back self-reference to the given <paramref name="builder"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="builder"/> is <see langword="null"/>.</exception>
    public ITagBuilder OnMouseOver(string script) => builder?.Attribute("onmouseover", script) ?? throw new ArgumentNullException(nameof(builder));

    /// <summary>
    ///   <para></para>
    /// </summary>
    /// <param name="script"></param>
    /// <returns>Back self-reference to the given <paramref name="builder"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="builder"/> is <see langword="null"/>.</exception>
    public ITagBuilder OnMouseUp(string script) => builder?.Attribute("onmouseup", script) ?? throw new ArgumentNullException(nameof(builder));

    /// <summary>
    ///   <para></para>
    /// </summary>
    /// <param name="script"></param>
    /// <returns>Back self-reference to the given <paramref name="builder"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="builder"/> is <see langword="null"/>.</exception>
    public ITagBuilder OnReset(string script) => builder?.Attribute("onreset", script) ?? builder;

    /// <summary>
    ///   <para></para>
    /// </summary>
    /// <param name="script"></param>
    /// <returns>Back self-reference to the given <paramref name="builder"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="builder"/> is <see langword="null"/>.</exception>
    public ITagBuilder OnSelect(string script) => builder?.Attribute("onselect", script) ?? throw new ArgumentNullException(nameof(builder));

    /// <summary>
    ///   <para></para>
    /// </summary>
    /// <param name="script"></param>
    /// <returns>Back self-reference to the given <paramref name="builder"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="builder"/> is <see langword="null"/>.</exception>
    public ITagBuilder OnSubmit(string script) => builder?.Attribute("onsubmit", script) ?? throw new ArgumentNullException(nameof(builder));

    /// <summary>
    ///   <para></para>
    /// </summary>
    /// <param name="script"></param>
    /// <returns>Back self-reference to the given <paramref name="builder"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="builder"/> is <see langword="null"/>.</exception>
    public ITagBuilder OnUnload(string script) => builder?.Attribute("onunload", script) ?? throw new ArgumentNullException(nameof(builder));
  }
}