using System;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Gravatar's avatar image URL.</para>
  /// </summary>
  /// <seealso cref="http://gravatar.com/site/implement/images"/>
  public interface IGravatarImageUrlWidget : IHtmlWidget
  {
    /// <summary>
    ///   <para>File-type extension for URL (jpg, png, gif, etc).</para>
    /// </summary>
    /// <param name="extension">File-type extension.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="extension"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="extension"/> is <see cref="string.Empty"/> string.</exception>
    IGravatarImageUrlWidget Extension(string extension);

    /// <summary>
    ///   <para>File-type extension for URL (jpg, png, gif, etc).</para>
    /// </summary>
    /// <returns>File-type extension.</returns>
    string Extension();

    /// <summary>
    ///   <para>MD5 hash of user's email address.</para>
    /// </summary>
    /// <param name="hash">Hash of user's email.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="hash"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="hash"/> is <see cref="string.Empty"/> string.</exception>
    /// <remarks>This attribute is required.</remarks>
    IGravatarImageUrlWidget Hash(string hash);

    /// <summary>
    ///   <para>MD5 hash of user's email address.</para>
    /// </summary>
    /// <returns>Hash of user's email.</returns>
    string Hash();

    /// <summary>
    ///   <para>Adds custom parameter to URL's query part.</para>
    /// </summary>
    /// <param name="name">Parameter's name.</param>
    /// <param name="value">Parameter's value.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If either <paramref name="name"/> or <paramref name="value"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="name"/> is <see cref="string.Empty"/> string.</exception>
    IGravatarImageUrlWidget Parameter(string name, object value);
  }
}