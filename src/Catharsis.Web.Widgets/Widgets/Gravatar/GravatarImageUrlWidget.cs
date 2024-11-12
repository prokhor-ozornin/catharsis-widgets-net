using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IGravatarImageUrlWidget"/>
public class GravatarImageUrlWidget : HtmlWidget, IGravatarImageUrlWidget
{
  private string extension;
  private string hash;
  private readonly IDictionary<string, object> parameters = new Dictionary<string, object>();

  /// <summary>
  ///   <para>File-type extension for URL (jpg, png, gif, etc).</para>
  /// </summary>
  /// <param name="extension">File-type extension.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="extension"/> is a <c>null</c> reference.</exception>
  /// <exception cref="ArgumentException">If <paramref name="extension"/> is <see cref="string.Empty"/> string.</exception>
  public IGravatarImageUrlWidget Extension(string extension)
  {
    if (extension is null) throw new ArgumentNullException(nameof(extension));
    if (extension.IsEmpty()) throw new ArgumentException(nameof(extension));

    this.extension = extension;
    return this;
  }

  /// <summary>
  ///   <para>File-type extension for URL (jpg, png, gif, etc).</para>
  /// </summary>
  /// <returns>File-type extension.</returns>
  public string Extension()
  {
    return this.extension;
  }

  /// <summary>
  ///   <para>MD5 hash of user's email address.</para>
  /// </summary>
  /// <param name="hash">Hash of user's email.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="hash"/> is a <c>null</c> reference.</exception>
  /// <exception cref="ArgumentException">If <paramref name="hash"/> is <see cref="string.Empty"/> string.</exception>
  /// <remarks>This attribute is required.</remarks>
  public IGravatarImageUrlWidget Hash(string hash)
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
  public IGravatarImageUrlWidget Parameter(string name, object value)
  {
    if (name is null) throw new ArgumentNullException(nameof(name));
    if (name.IsEmpty()) throw new ArgumentException(nameof(name));

    parameters[name] = value;
    return this;
  }

  /// <inheritdoc cref="IHtmlWidget.ToHtmlString()"/>
  public override string ToHtmlString() => Hash().IsEmpty() ? string.Empty : $"http://www.gravatar.com/avatar/{Hash()}{(Extension().IsEmpty() ? string.Empty : $".${Extension()}")}{(parameters.Any() ? $"?${parameters.ToUrlQuery()}" : string.Empty)}";
}