using System;
using System.Web.Mvc;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Renders embedded YouTube video on web page.</para>
  /// </summary>
  public class YouTubeVideoWidget : HtmlWidget, IYouTubeVideoWidget
  {
    private string id;
    private string width;
    private string height;
    private bool privateMode;
    private bool secureMode;

    /// <summary>
    ///   <para>Specifies identifier of video.</para>
    /// </summary>
    /// <param name="id">Identifier of video.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="id"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="id"/> is <see cref="string.Empty"/> string.</exception>
    /// <remarks>This attribute is required.</remarks>
    public IYouTubeVideoWidget Id(string id)
    {
      Assertion.NotEmpty(id);

      this.id = id;
      return this;
    }

    /// <summary>
    ///   <para>Specifies identifier of video.</para>
    /// </summary>
    /// <returns>Identifier of video.</returns>
    public string Id()
    {
      return this.id;
    }

    /// <summary>
    ///   <para>Specifies height of video control.</para>
    /// </summary>
    /// <param name="height">Height of video.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="height"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="height"/> is <see cref="string.Empty"/> string.</exception>
    /// <remarks>This attribute is required.</remarks>
    public IYouTubeVideoWidget Height(string height)
    {
      Assertion.NotEmpty(height);

      this.height = height;
      return this;
    }

    /// <summary>
    ///   <para>Specifies height of video control.</para>
    /// </summary>
    /// <returns>Height of video.</returns>
    public string Height()
    {
      return this.height;
    }

    /// <summary>
    ///   <para>Specifies whether to keep track of user cookies or not (default is <c>false)</c>.</para>
    /// </summary>
    /// <param name="enabled"><c>true</c> to set cookies, <c>false</c> to not.</param>
    /// <returns>Reference to the current widget.</returns>
    public IYouTubeVideoWidget PrivateMode(bool enabled)
    {
      this.privateMode = enabled;
      return this;
    }

    /// <summary>
    ///   <para>Specifies whether to keep track of user cookies or not (default is <c>false)</c>.</para>
    /// </summary>
    /// <returns><c>true</c> to set cookies, <c>false</c> to not.</returns>
    public bool PrivateMode()
    {
      return this.privateMode;
    }

    /// <summary>
    ///   <para>Specifies whether to access video through secure HTTPS protocol or unsecure HTTP (default is <c>false</c>).</para>
    /// </summary>
    /// <param name="enabled"><c>true</c> to use HTTPS protocol, <c>false</c> to use HTTP.</param>
    /// <returns>Reference to the current widget.</returns>
    public IYouTubeVideoWidget SecureMode(bool enabled)
    {
      this.secureMode = enabled;
      return this;
    }

    /// <summary>
    ///   <para>Specifies whether to access video through secure HTTPS protocol or unsecure HTTP (default is <c>false</c>).</para>
    /// </summary>
    /// <returns><c>true</c> to use HTTPS protocol, <c>false</c> to use HTTP.</returns>
    public bool SecureMode()
    {
      return this.secureMode;
    }

    /// <summary>
    ///   <para>Specifies width of video control.</para>
    /// </summary>
    /// <param name="width">Width of video.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="width"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="width"/> is <see cref="string.Empty"/> string.</exception>
    /// <remarks>This attribute is required.</remarks>
    public IYouTubeVideoWidget Width(string width)
    {
      Assertion.NotEmpty(width);

      this.width = width;
      return this;
    }

    /// <summary>
    ///   <para>Specifies width of video control.</para>
    /// </summary>
    /// <returns>Width of video.</returns>
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
      if (this.Id().IsEmpty() || this.Width().IsEmpty() || this.Height().IsEmpty())
      {
        return string.Empty;
      }

      return new TagBuilder("iframe")
        .Attribute("src", "{2}://{1}/embed/{0}".FormatSelf(this.Id(), this.PrivateMode() ? "www.youtube-nocookie.com" : "www.youtube.com", this.SecureMode() ? "https" : "http"))
        .Attribute("width", this.Width())
        .Attribute("height", this.Height())
        .Attribute("frameborder", 0)
        .Attribute("allowfullscreen", true)
        .Attribute("webkitallowfullscreen", true)
        .Attribute("mozallowfullscreen", true)
        .ToString();
    }
  }
}