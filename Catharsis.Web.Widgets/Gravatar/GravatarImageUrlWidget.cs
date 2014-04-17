using System;
using System.Collections.Generic;
using System.Linq;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Gravatar's avatar image URL.</para>
  /// </summary>
  /// <seealso cref="http://gravatar.com/site/implement/images"/>
  public class GravatarImageUrlWidget : HtmlWidgetBase, IGravatarImageUrlWidget
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
      Assertion.NotEmpty(extension);

      this.extension = extension;
      return this;
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
      Assertion.NotEmpty(hash);

      this.hash = hash;
      return this;
    }

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
      Assertion.NotEmpty(name);
      Assertion.NotNull(value);

      this.parameters[name] = value;
      return this;
    }

    /// <summary>
    ///   <para>Returns HTML markup text of widget.</para>
    /// </summary>
    /// <returns>Widget's HTML markup.</returns>
    public override string ToHtmlString()
    {
      if (this.hash.IsEmpty())
      {
        return string.Empty;
      }

      return "http://www.gravatar.com/avatar/{0}{1}{2}".FormatSelf(this.hash, this.extension.IsEmpty() ? string.Empty : ".{0}".FormatSelf(this.extension), this.parameters.Any() ? "?{0}".FormatSelf(this.parameters.ToUrlQuery()) : string.Empty);
    }
  }
}