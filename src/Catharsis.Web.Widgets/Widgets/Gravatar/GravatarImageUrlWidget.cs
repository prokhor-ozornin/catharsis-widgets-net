using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IGravatarImageUrlWidget"/>
public class GravatarImageUrlWidget : WebWidget, IGravatarImageUrlWidget
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string ExtensionValue { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string HashValue { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual IDictionary<string, object> ParametersValue { get; } = new SortedDictionary<string, object>();

  /// <inheritdoc cref="IGravatarImageUrlWidget.Extension(string)"/>
  public virtual IGravatarImageUrlWidget Extension(string extension)
  {
    if (extension is null) throw new ArgumentNullException(nameof(extension));
    if (extension.IsEmpty()) throw new ArgumentException(nameof(extension));

    ExtensionValue = extension;
    return this;
  }

  /// <inheritdoc cref="IGravatarImageUrlWidget.Hash(string)"/>
  public virtual IGravatarImageUrlWidget Hash(string hash)
  {
    if (hash is null) throw new ArgumentNullException(nameof(hash));
    if (hash.IsEmpty()) throw new ArgumentException(nameof(hash));

    HashValue = hash;
    return this;
  }

  /// <inheritdoc cref="IGravatarImageUrlWidget.Parameter(string, object)"/>
  public virtual IGravatarImageUrlWidget Parameter(string name, object value)
  {
    if (name is null) throw new ArgumentNullException(nameof(name));
    if (name.IsEmpty()) throw new ArgumentException(nameof(name));

    ParametersValue[name] = value;
    return this;
  }

  /// <inheritdoc cref="ICloneable.Clone()"/>
  public override object Clone() => new GravatarImageUrlWidget
  {
    ExtensionValue = ExtensionValue,
    HashValue = HashValue
  };

  /// <inheritdoc cref="IWebWidget.ToHtml()"/>
  public override string ToHtml() => HashValue.IsUnset() ? string.Empty : $"http://www.gravatar.com/avatar/{HashValue}{(ExtensionValue.IsUnset() ? string.Empty : $".${ExtensionValue}")}{(ParametersValue.Any() ? $"?${ParametersValue.ToUrlQuery()}" : string.Empty)}";
}