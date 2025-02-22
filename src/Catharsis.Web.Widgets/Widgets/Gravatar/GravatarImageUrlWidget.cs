using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IGravatarImageUrlWidget"/>
public class GravatarImageUrlWidget : WebWidget, IGravatarImageUrlWidget
{
  private string ExtensionProperty { get; set; }
  private string HashProperty { get; set; }
  private IDictionary<string, object> ParametersProperty { get; } = new Dictionary<string, object>();

  /// <inheritdoc cref="IGravatarImageUrlWidget.Extension(string)"/>
  public IGravatarImageUrlWidget Extension(string extension)
  {
    if (extension is null) throw new ArgumentNullException(nameof(extension));
    if (extension.IsEmpty()) throw new ArgumentException(nameof(extension));

    ExtensionProperty = extension;
    return this;
  }

  /// <inheritdoc cref="IGravatarImageUrlWidget.Extension(string)"/>
  public string Extension() => ExtensionProperty;

  /// <inheritdoc cref="IGravatarImageUrlWidget.Hash(string)"/>
  public IGravatarImageUrlWidget Hash(string hash)
  {
    if (hash is null) throw new ArgumentNullException(nameof(hash));
    if (hash.IsEmpty()) throw new ArgumentException(nameof(hash));

    HashProperty = hash;
    return this;
  }

  /// <inheritdoc cref="IGravatarImageUrlWidget.Hash()"/>
  public string Hash() => HashProperty;

  /// <inheritdoc cref="IGravatarImageUrlWidget.Parameter(string, object)"/>
  public IGravatarImageUrlWidget Parameter(string name, object value)
  {
    if (name is null) throw new ArgumentNullException(nameof(name));
    if (name.IsEmpty()) throw new ArgumentException(nameof(name));

    ParametersProperty[name] = value;
    return this;
  }

  /// <inheritdoc cref="IHtmlContent.ToHtml()"/>
  public override string ToHtml() => Hash().IsEmpty() ? string.Empty : $"http://www.gravatar.com/avatar/{Hash()}{(Extension().IsEmpty() ? string.Empty : $".${Extension()}")}{(ParametersProperty.Any() ? $"?${ParametersProperty.ToUrlQuery()}" : string.Empty)}";
}