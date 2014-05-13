using System;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Gravatar's user profile URL.</para>
  /// </summary>
  /// <seealso cref="http://gravatar.com/site/implement/profiles"/>
  public interface IGravatarProfileUrlWidget : IHtmlWidget
  {
    /// <summary>
    ///   <para>Format in which to retrieve profile's data.</para>
    /// </summary>
    /// <param name="format">Profile's data format.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="format"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="format"/> is <see cref="string.Empty"/> string.</exception>
    IGravatarProfileUrlWidget Format(string format);

    /// <summary>
    ///   <para>Format in which to retrieve profile's data.</para>
    /// </summary>
    /// <returns>Profile's data format.</returns>
    string Format();

    /// <summary>
    ///   <para>MD5 hash of user's email address.</para>
    /// </summary>
    /// <param name="hash">Hash of user's email.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="hash"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="hash"/> is <see cref="string.Empty"/> string.</exception>
    /// <remarks>This attribute is required.</remarks>
    IGravatarProfileUrlWidget Hash(string hash);

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
    IGravatarProfileUrlWidget Parameter(string name, object value);
  }
}