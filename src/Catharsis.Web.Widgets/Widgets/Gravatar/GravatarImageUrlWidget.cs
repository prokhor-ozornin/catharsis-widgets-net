using Catharsis.Extensions;
using Catharsis.Web.Widgets.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IGravatarImageUrlWidget"/>
public class GravatarImageUrlWidget : WebWidget, IGravatarImageUrlWidget
{
  private string extension;
  private string hash;
  private readonly IDictionary<string, object> parameters = new Dictionary<string, object>();

  /// <inheritdoc cref="IGravatarImageUrlWidget.Extension(string)"/>
  public IGravatarImageUrlWidget Extension(string extension)
  {
    if (extension is null) throw new ArgumentNullException(nameof(extension));
    if (extension.IsEmpty()) throw new ArgumentException(nameof(extension));

    this.extension = extension;
    return this;
  }

  /// <inheritdoc cref="IGravatarImageUrlWidget.Extension(string)"/>
  public string Extension() => extension;

  /// <inheritdoc cref="IGravatarImageUrlWidget.Hash(string)"/>
  public IGravatarImageUrlWidget Hash(string hash)
  {
    if (hash is null) throw new ArgumentNullException(nameof(hash));
    if (hash.IsEmpty()) throw new ArgumentException(nameof(hash));

    this.hash = hash;
    return this;
  }

  /// <inheritdoc cref="IGravatarImageUrlWidget.Hash()"/>
  public string Hash() => hash;

  /// <inheritdoc cref="IGravatarImageUrlWidget.Parameter(string, object)"/>
  public IGravatarImageUrlWidget Parameter(string name, object value)
  {
    if (name is null) throw new ArgumentNullException(nameof(name));
    if (name.IsEmpty()) throw new ArgumentException(nameof(name));

    parameters[name] = value;
    return this;
  }

  /// <inheritdoc cref="IHtmlContent.ToHtml()"/>
  public override string ToHtml() => Hash().IsEmpty() ? string.Empty : $"http://www.gravatar.com/avatar/{Hash()}{(Extension().IsEmpty() ? string.Empty : $".${Extension()}")}{(parameters.Any() ? $"?${parameters.ToUrlQuery()}" : string.Empty)}";
}