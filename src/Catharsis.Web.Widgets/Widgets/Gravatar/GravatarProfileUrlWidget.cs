using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IGravatarProfileUrlWidget"/>
public class GravatarProfileUrlWidget : WebWidget, IGravatarProfileUrlWidget
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string FormatProperty { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string HashProperty { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual IDictionary<string, object> ParametersProperty { get; } = new Dictionary<string, object>();

  /// <inheritdoc cref="IGravatarProfileUrlWidget.Format(string)"/>
  public virtual IGravatarProfileUrlWidget Format(string format)
  {
    if (format is null) throw new ArgumentNullException(nameof(format));
    if (format.IsEmpty()) throw new ArgumentException(nameof(format));

    FormatProperty = format;
    return this;
  }

  /// <inheritdoc cref="IGravatarProfileUrlWidget.Hash(string)"/>
  public virtual IGravatarProfileUrlWidget Hash(string hash)
  {
    if (hash is null) throw new ArgumentNullException(nameof(hash));
    if (hash.IsEmpty()) throw new ArgumentException(nameof(hash));

    HashProperty = hash;
    return this;
  }

  /// <inheritdoc cref="IGravatarProfileUrlWidget.Parameter(string, object)"/>
  public virtual IGravatarProfileUrlWidget Parameter(string name, object value)
  {
    if (name is null) throw new ArgumentNullException(nameof(name));
    if (name.IsEmpty()) throw new ArgumentException(nameof(name));
    if (value is null) throw new ArgumentNullException(nameof(value));

    ParametersProperty[name] = value;
    return this;
  }

  /// <inheritdoc cref="IHtmlContent.ToHtml()"/>
  public override string ToHtml() => HashProperty.IsUnset() ? string.Empty : $"http://www.gravatar.com/{HashProperty}{(FormatProperty.IsUnset() ? string.Empty : $".${FormatProperty}")}{(ParametersProperty.Any() ? $"?${ParametersProperty.ToUrlQuery()}" : string.Empty)}";
}