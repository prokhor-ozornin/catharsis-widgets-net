using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IGravatarProfileUrlWidget"/>
public class GravatarProfileUrlWidget : WebWidget, IGravatarProfileUrlWidget
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string FormatValue { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string HashValue { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual IDictionary<string, object> ParametersValue { get; init; } = new SortedDictionary<string, object>();

  /// <inheritdoc cref="IGravatarProfileUrlWidget.Format(string)"/>
  public virtual IGravatarProfileUrlWidget Format(string format)
  {
    if (format is null) throw new ArgumentNullException(nameof(format));
    if (format.IsEmpty()) throw new ArgumentException(nameof(format));

    FormatValue = format;
    return this;
  }

  /// <inheritdoc cref="IGravatarProfileUrlWidget.Hash(string)"/>
  public virtual IGravatarProfileUrlWidget Hash(string hash)
  {
    if (hash is null) throw new ArgumentNullException(nameof(hash));
    if (hash.IsEmpty()) throw new ArgumentException(nameof(hash));

    HashValue = hash;
    return this;
  }

  /// <inheritdoc cref="IGravatarProfileUrlWidget.Parameter(string, object)"/>
  public virtual IGravatarProfileUrlWidget Parameter(string name, object value)
  {
    if (name is null) throw new ArgumentNullException(nameof(name));
    if (name.IsEmpty()) throw new ArgumentException(nameof(name));
    if (value is null) throw new ArgumentNullException(nameof(value));

    ParametersValue[name] = value;
    return this;
  }

  /// <inheritdoc cref="ICloneable.Clone()"/>
  public override object Clone() => new GravatarProfileUrlWidget
  {
    FormatValue = FormatValue,
    HashValue = HashValue,
    ParametersValue = ParametersValue?.ToSortedDictionary()
  };

  /// <inheritdoc cref="IWebWidget.ToHtml()"/>
  public override string ToHtml() => HashValue.IsUnset() ? string.Empty : $"http://www.gravatar.com/{HashValue}{(FormatValue.IsUnset() ? string.Empty : $".${FormatValue}")}{(ParametersValue.Any() ? $"?${ParametersValue.ToUrlQuery()}" : string.Empty)}";
}