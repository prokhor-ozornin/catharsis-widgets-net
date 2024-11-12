using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IGravatarProfileUrlWidget"/>
public class GravatarProfileUrlWidget : HtmlWidget, IGravatarProfileUrlWidget
{
  private string format;
  private string hash;
  private readonly IDictionary<string, object> parameters = new Dictionary<string, object>();

  /// <summary>
  ///   <para>Format in which to retrieve profile's data.</para>
  /// </summary>
  /// <param name="format">Profile's data format.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="format"/> is a <c>null</c> reference.</exception>
  /// <exception cref="ArgumentException">If <paramref name="format"/> is <see cref="string.Empty"/> string.</exception>
  public IGravatarProfileUrlWidget Format(string format)
  {
    if (format is null) throw new ArgumentNullException(nameof(format));
    if (format.IsEmpty()) throw new ArgumentException(nameof(format));

    this.format = format;
    return this;
  }

  /// <summary>
  ///   <para>Format in which to retrieve profile's data.</para>
  /// </summary>
  /// <returns>Profile's data format.</returns>
  public string Format() => format;

  /// <summary>
  ///   <para>MD5 hash of user's email address.</para>
  /// </summary>
  /// <param name="hash">Hash of user's email.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="hash"/> is a <c>null</c> reference.</exception>
  /// <exception cref="ArgumentException">If <paramref name="hash"/> is <see cref="string.Empty"/> string.</exception>
  /// <remarks>This attribute is required.</remarks>
  public IGravatarProfileUrlWidget Hash(string hash)
  {
    if (hash is null) throw new ArgumentNullException(nameof(hash));
    if (hash.IsEmpty()) throw new ArgumentException(nameof(hash));

    this.hash = hash;
    return this;
  }

  /// <summary>
  ///   <para>MD5 hash of user's email address.</para>
  /// </summary>
  /// <returns>Hash of user's email.</returns>
  public string Hash() => hash;

  /// <summary>
  ///   <para>Adds custom parameter to URL's query part.</para>
  /// </summary>
  /// <param name="name">Parameter's name.</param>
  /// <param name="value">Parameter's value.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If either <paramref name="name"/> or <paramref name="value"/> is a <c>null</c> reference.</exception>
  /// <exception cref="ArgumentException">If <paramref name="name"/> is <see cref="string.Empty"/> string.</exception>
  public IGravatarProfileUrlWidget Parameter(string name, object value)
  {
    if (name is null) throw new ArgumentNullException(nameof(name));
    if (name.IsEmpty()) throw new ArgumentException(nameof(name));
    if (value is null) throw new ArgumentNullException(nameof(value));

    parameters[name] = value;
    return this;
  }

  /// <inheritdoc cref="IHtmlWidget.ToHtmlString()"/>
  public override string ToHtmlString() => Hash().IsEmpty() ? string.Empty : $"http://www.gravatar.com/{Hash()}{(Format().IsEmpty() ? string.Empty : $".${Format()}")}{(parameters.Any() ? $"?${parameters.ToUrlQuery()}" : string.Empty)}";
}