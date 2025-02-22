using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="ITagBuilder"/>
public class TagBuilder : ITagBuilder
{
  protected string NameProperty { get; set; }
  protected string HtmlProperty { get; set; }
  protected IDictionary<string, string> AttributesProperty { get; } = new SortedDictionary<string, string>();

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="name"></param>
  public TagBuilder(string name) => Name(name);

  /// <inheritdoc cref="ITagBuilder.Name(string)"/>
  public ITagBuilder Name(string name)
  {
    if (name is null) throw new ArgumentNullException(nameof(name));
    if (name.IsEmpty()) throw new ArgumentException(nameof(name));

    NameProperty = name;
    return this;
  }

  /// <inheritdoc cref="ITagBuilder.Name()"/>
  public string Name() => NameProperty;

  /// <inheritdoc cref="ITagBuilder.Attribute(string, string)"/>
  public ITagBuilder Html(string html)
  {
    HtmlProperty = html ?? string.Empty;
    return this;
  }

  /// <inheritdoc cref="ITagBuilder.Html()"/>
  public string Html() => HtmlProperty;

  /// <inheritdoc cref="ITagBuilder.Attribute(string, string)"/>
  public ITagBuilder Attribute(string name, string value)
  {
    if (name is null) throw new ArgumentNullException(nameof(name));
    if (name.IsEmpty()) throw new ArgumentException(nameof(name));

    AttributesProperty[name] = value ?? string.Empty;
    
    return this;
  }

  /// <inheritdoc cref="ITagBuilder.Attributes()"/>
  public IReadOnlyDictionary<string, string> Attributes() => throw new NotImplementedException();

  /// <inheritdoc cref="object.ToString()"/>
  public override string ToString()
  {
    throw new NotImplementedException();
  }
}