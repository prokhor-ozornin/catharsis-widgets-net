using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IGravatarProfileUrlWidget"/>
public class GravatarProfileUrlWidget : WebWidget, IGravatarProfileUrlWidget
{
  private string format;
  private string hash;
  private readonly IDictionary<string, object> parameters = new Dictionary<string, object>();

  /// <inheritdoc cref="IGravatarProfileUrlWidget.Format(string)"/>
  public IGravatarProfileUrlWidget Format(string format)
  {
    if (format is null) throw new ArgumentNullException(nameof(format));
    if (format.IsEmpty()) throw new ArgumentException(nameof(format));

    this.format = format;
    return this;
  }

  /// <inheritdoc cref="IGravatarProfileUrlWidget.Format()"/>
  public string Format() => format;

  /// <inheritdoc cref="IGravatarProfileUrlWidget.Hash(string)"/>
  public IGravatarProfileUrlWidget Hash(string hash)
  {
    if (hash is null) throw new ArgumentNullException(nameof(hash));
    if (hash.IsEmpty()) throw new ArgumentException(nameof(hash));

    this.hash = hash;
    return this;
  }

  /// <inheritdoc cref="IGravatarProfileUrlWidget.Hash()"/>
  public string Hash() => hash;

  /// <inheritdoc cref="IGravatarProfileUrlWidget.Parameter(string, object)"/>
  public IGravatarProfileUrlWidget Parameter(string name, object value)
  {
    if (name is null) throw new ArgumentNullException(nameof(name));
    if (name.IsEmpty()) throw new ArgumentException(nameof(name));
    if (value is null) throw new ArgumentNullException(nameof(value));

    parameters[name] = value;
    return this;
  }

  /// <inheritdoc cref="IWebWidget.ToHtml()"/>
  public override string ToHtml() => Hash().IsEmpty() ? string.Empty : $"http://www.gravatar.com/{Hash()}{(Format().IsEmpty() ? string.Empty : $".${Format()}")}{(parameters.Any() ? $"?${parameters.ToUrlQuery()}" : string.Empty)}";
}