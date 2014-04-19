using System;
using System.Collections.Generic;
using System.Linq;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Gravatar's user profile URL.</para>
  /// </summary>
  /// <seealso cref="http://gravatar.com/site/implement/profiles"/>
  public class GravatarProfileUrlWidget : HtmlWidgetBase, IGravatarProfileUrlWidget
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
      Assertion.NotEmpty(format);

      this.format = format;
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
    public IGravatarProfileUrlWidget Hash(string hash)
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
    public IGravatarProfileUrlWidget Parameter(string name, object value)
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

      return "http://www.gravatar.com/{0}{1}{2}".FormatSelf(this.hash, this.format.IsEmpty() ? string.Empty : ".{0}".FormatSelf(this.format), this.parameters.Any() ? "?{0}".FormatSelf(this.parameters.ToUrlQuery()) : string.Empty);
    }
  }
}