using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="ITagBuilder"/>
public class TagBuilder : ITagBuilder
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string NameProperty { get; set; }
  
  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string HtmlProperty { get; set; }
  
  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual IDictionary<string, string> AttributesProperty { get; } = new SortedDictionary<string, string>();

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="name"></param>
  public TagBuilder(string name) => Name(name);

  /// <inheritdoc cref="ITagBuilder.Name(string)"/>
  public virtual ITagBuilder Name(string name)
  {
    if (name is null) throw new ArgumentNullException(nameof(name));
    if (name.IsEmpty()) throw new ArgumentException(nameof(name));

    NameProperty = name;
    return this;
  }

  /// <inheritdoc cref="ITagBuilder.Attribute(string, string)"/>
  public virtual ITagBuilder Html(string html)
  {
    HtmlProperty = html ?? string.Empty;
    return this;
  }

  /// <inheritdoc cref="ITagBuilder.Attribute(string, string)"/>
  public virtual ITagBuilder Attribute(string name, string value)
  {
    if (name is null) throw new ArgumentNullException(nameof(name));
    if (name.IsEmpty()) throw new ArgumentException(nameof(name));

    AttributesProperty[name] = value ?? string.Empty;
    
    return this;
  }

  /// <inheritdoc cref="ITagBuilder.Attributes()"/>
  public virtual IReadOnlyDictionary<string, string> Attributes() => throw new NotImplementedException();

  /// <inheritdoc cref="object.ToString()"/>
  public override string ToString()
  {
    return string.Empty;
  }
}