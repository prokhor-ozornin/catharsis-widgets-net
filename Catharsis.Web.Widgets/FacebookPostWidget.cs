using System;
using System.IO;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Renders embedded Facebook post on web page.</para>
  ///   <para>Requires Facebook JavaScript initialization to be performed first.</para>
  /// </summary>
  /// <seealso cref="https://developers.facebook.com/docs/plugins/embedded-posts"/>
  public sealed class FacebookPostWidget : HtmlWidgetBase<IFacebookPostWidget>, IFacebookPostWidget
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
    ///   <para>Generates and writes HTML markup of widget, using specified text writer.</para>
    /// </summary>
    /// <param name="writer">Text writer to use as output destination.</param>
    public override void Write(TextWriter writer)
    {
      Assertion.NotNull(writer);

      if (this.url.IsEmpty())
      {
        return;
      }

      writer.Write(this.ToTag("div", tag => tag
        .Attribute("data-href", this.url)
        .Attribute("data-width", this.width)
        .AddCssClass("fb-post")));
    }
  }
}