using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IGravatarImageUrlWidget"/>
public class GravatarImageUrlWidget : WebWidget, IGravatarImageUrlWidget
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string ExtensionProperty { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string HashProperty { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual IDictionary<string, object> ParametersProperty { get; } = new Dictionary<string, object>();

  /// <inheritdoc cref="IGravatarImageUrlWidget.Extension(string)"/>
  public virtual IGravatarImageUrlWidget Extension(string extension)
  {
    if (extension is null) throw new ArgumentNullException(nameof(extension));
    if (extension.IsEmpty()) throw new ArgumentException(nameof(extension));

    ExtensionProperty = extension;
    return this;
  }

  /// <inheritdoc cref="IGravatarImageUrlWidget.Hash(string)"/>
  public virtual IGravatarImageUrlWidget Hash(string hash)
  {
    if (hash is null) throw new ArgumentNullException(nameof(hash));
    if (hash.IsEmpty()) throw new ArgumentException(nameof(hash));

    HashProperty = hash;
    return this;
  }

  /// <inheritdoc cref="IGravatarImageUrlWidget.Parameter(string, object)"/>
  public virtual IGravatarImageUrlWidget Parameter(string name, object value)
  {
    if (name is null) throw new ArgumentNullException(nameof(name));
    if (name.IsEmpty()) throw new ArgumentException(nameof(name));

    ParametersProperty[name] = value;
    return this;
  }

  /// <inheritdoc cref="IHtmlContent.ToHtml()"/>
  public override string ToHtml() => HashProperty.IsUnset() ? string.Empty : $"http://www.gravatar.com/avatar/{HashProperty}{(ExtensionProperty.IsUnset() ? string.Empty : $".${ExtensionProperty}")}{(ParametersProperty.Any() ? $"?${ParametersProperty.ToUrlQuery()}" : string.Empty)}";
}