using System;
using System.Web.Mvc;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Renders embedded Facebook post on web page.</para>
  ///   <para>Requires Facebook JavaScript initialization to be performed first.</para>
  /// </summary>
  /// <seealso cref="https://developers.facebook.com/docs/plugins/embedded-posts"/>
  public class FacebookPostWidget : HtmlWidget, IFacebookPostWidget
  {
    private string url;
    private string width;

    /// <summary>
    ///   <para>Specified URL address of Facebook post to embed.</para>
    /// </summary>
    /// <param name="url">URL of Facebook post.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="url"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="url"/> is <see cref="string.Empty"/> string.</exception>
    /// <remarks>This attribute is required.</remarks>
    public IFacebookPostWidget Url(string url)
    {
      Assertion.NotEmpty(url);

      this.url = url;
      return this;
    }

    /// <summary>
    ///   <para>Specified URL address of Facebook post to embed.</para>
    /// </summary>
    /// <returns>URL of Facebook post.</returns>
    public string Url()
    {
      return this.url;
    }

    /// <summary>
    ///   <para>Specifies width of Facebook post area on page.</para>
    /// </summary>
    /// <param name="width">Width of post.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="width"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="width"/> is <see cref="string.Empty"/> string.</exception>
    public IFacebookPostWidget Width(string width)
    {
      Assertion.NotEmpty(width);

      this.width = width;
      return this;
    }

    /// <summary>
    ///   <para>Specifies width of Facebook post area on page.</para>
    /// </summary>
    /// <returns>Width of post.</returns>
    public string Width()
    {
      return this.width;
    }

    /// <summary>
    ///   <para>Returns HTML markup text of widget.</para>
    /// </summary>
    /// <returns>Widget's HTML markup.</returns>
    public override string ToHtmlString()
    {
      if (this.Url().IsEmpty())
      {
        return string.Empty;
      }

      return new TagBuilder("div")
        .Attribute("data-href", this.Url())
        .Attribute("data-width", this.Width())
        .CssClass("fb-post")
        .ToString();
    }
  }
}