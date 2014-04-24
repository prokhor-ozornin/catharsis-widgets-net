using System;
using System.Web.Mvc;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Renders embedded Vimeo video on web page.</para>
  /// </summary>
  public class VimeoVideoWidget : HtmlWidget, IVimeoVideoWidget
  {
    private bool autoPlay;
    private string height;
    private string id;
    private bool loop;
    private string width;

    /// <summary>
    ///   <para>Whether to start playing video automatically. Default is <c>false</c>.</para>
    /// </summary>
    /// <param name="enabled"><c>true</c> to enable autoplay, <c>false</c> to disable.</param>
    /// <returns>Reference to the current widget.</returns>
    public IVimeoVideoWidget AutoPlay(bool enabled = true)
    {
      this.autoPlay = enabled;
      return this;
    }

    /// <summary>
    ///   <para>Height of video control.</para>
    /// </summary>
    /// <param name="height">Height of video.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="height"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="height"/> is <see cref="string.Empty"/> string.</exception>
    /// <remarks>This attribute is required.</remarks>
    public IVimeoVideoWidget Height(string height)
    {
      Assertion.NotEmpty(height);

      this.height = height;
      return this;
    }

    /// <summary>
    ///   <para>Identifier of video.</para>
    /// </summary>
    /// <param name="id">Identifier of video.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="id"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="id"/> is <see cref="string.Empty"/> string.</exception>
    /// <remarks>This attribute is required.</remarks>
    public IVimeoVideoWidget Id(string id)
    {
      Assertion.NotEmpty(id);

      this.id = id;
      return this;
    }

    /// <summary>
    ///   <para>Whether to replay video when it finishes. Default is <c>false</c>.</para>
    /// </summary>
    /// <param name="enabled"><c>true</c> to enable looping, <c>false</c> to disable.</param>
    /// <returns>Reference to the current widget.</returns>
    public IVimeoVideoWidget Loop(bool enabled = true)
    {
      this.loop = enabled;
      return this;
    }

    /// <summary>
    ///   <para>Width of video control.</para>
    /// </summary>
    /// <param name="width">Width of video.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="width"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="width"/> is <see cref="string.Empty"/> string.</exception>
    /// <remarks>This attribute is required.</remarks>
    public IVimeoVideoWidget Width(string width)
    {
      Assertion.NotEmpty(width);

      this.width = width;
      return this;
    }

    /// <summary>
    ///   <para>Returns HTML markup text of widget.</para>
    /// </summary>
    /// <returns>Widget's HTML markup.</returns>
    public override string ToHtmlString()
    {
      if (this.id.IsEmpty() || this.width.IsEmpty() || this.height.IsEmpty())
      {
        return string.Empty;
      }

      return new TagBuilder("iframe")
        .Attribute("frameborder", 0)
        .Attribute("allowfullscreen", true)
        .Attribute("webkitallowfullscreen", true)
        .Attribute("mozallowfullscreen", true)
        .Attribute("height", this.height)
        .Attribute("width", this.width)
        .Attribute("src", "https://player.vimeo.com/video/{0}?badge=0{1}{2}".FormatSelf(this.id, this.autoPlay ? "&autoplay=1" : string.Empty, this.loop ? "&loop=1" : string.Empty))
        .ToString();
    }
  }
}