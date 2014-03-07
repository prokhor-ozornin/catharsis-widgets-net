using System;
using System.IO;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Renders hyperlink to YouTube video.</para>
  /// </summary>
  public sealed class YouTubeVideoLinkWidget : HtmlWidgetBase<IYouTubeVideoLinkWidget>, IYouTubeVideoLinkWidget
  {
    private string id;
    private bool embedded;
    private bool @private;
    private bool secure;

    /// <summary>
    ///   <para>Identifier of video.</para>
    /// </summary>
    /// <param name="id">Identifier of video.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="id"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="id"/> is <see cref="string.Empty"/> string.</exception>
    /// <remarks>This attribute is required.</remarks>
    public IYouTubeVideoLinkWidget Id(string id)
    {
      Assertion.NotEmpty(id);

      this.id = id;
      return this;
    }

    /// <summary>
    ///   <para>Whether to create link for embedded video type (default is <c>false</c>).</para>
    /// </summary>
    /// <param name="embedded"><c>true</c> to use embedded video style, <c>false</c> to use normal link.</param>
    /// <returns>Reference to the current widget.</returns>
    public IYouTubeVideoLinkWidget Embedded(bool embedded = true)
    {
      this.embedded = embedded;
      return this;
    }

    /// <summary>
    ///   <para>Whether to create link that keeps track of user cookies or not (default is <c>false</c>).</para>
    /// </summary>
    /// <param name="private"><c>true</c> to create "cookie-aware" hyperlink, <c>false</c> to not.</param>
    /// <returns>Reference to the current widget.</returns>
    public IYouTubeVideoLinkWidget Private(bool @private = true)
    {
      this.@private = @private;
      return this;
    }

    /// <summary>
    ///   <para>Whether to create link to access video through secure HTTPS protocol or unsecure HTTP (default is <c>false</c>).</para>
    /// </summary>
    /// <param name="secure"><c>true</c> to create link with HTTPS protocol, <c>false</c> to use HTTP.</param>
    /// <returns>Reference to the current widget.</returns>
    public IYouTubeVideoLinkWidget Secure(bool secure = true)
    {
      this.secure = secure;
      return this;
    }

    /// <summary>
    ///   <para>Generates and writes HTML markup of widget, using specified text writer.</para>
    /// </summary>
    /// <param name="writer">Text writer to use as output destination.</param>
    public override void Write(TextWriter writer)
    {
      Assertion.NotNull(writer);

      if (this.id.IsEmpty())
      {
        return;
      }

      writer.Write(this.ToTag("a", tag => tag
        .Attribute("href", "{2}://{1}/{0}".FormatSelf((this.embedded ? "embed/{0}" : "watch?v={0}").FormatSelf(this.id), this.@private ? "www.youtube-nocookie.com" : "www.youtube.com", this.secure ? "https" : "http"))
        .InnerHtml(this.HtmlBody)));
    }
  }
}