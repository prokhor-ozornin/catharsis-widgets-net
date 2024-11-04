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
    public IVimeoVideoWidget AutoPlay(bool enabled)
    {
      this.autoPlay = enabled;
      return this;
    }

    /// <summary>
    ///   <para>Whether to start playing video automatically. Default is <c>false</c>.</para>
    /// </summary>
    /// <returns><c>true</c> to enable autoplay, <c>false</c> to disable.</returns>
    public bool AutoPlay()
    {
      return this.autoPlay;
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
    ///   <para>Height of video control.</para>
    /// </summary>
    /// <returns>Height of video.</returns>
    public string Height()
    {
      return this.height;
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
    ///   <para>Identifier of video.</para>
    /// </summary>
    /// <returns>Identifier of video.</returns>
    public string Id()
    {
      return this.id;
    }

    /// <summary>
    ///   <para>Whether to replay video when it finishes. Default is <c>false</c>.</para>
    /// </summary>
    /// <param name="enabled"><c>true</c> to enable looping, <c>false</c> to disable.</param>
    /// <returns>Reference to the current widget.</returns>
    public IVimeoVideoWidget Loop(bool enabled)
    {
      this.loop = enabled;
      return this;
    }

    /// <summary>
    ///   <para>Whether to replay video when it finishes. Default is <c>false</c>.</para>
    /// </summary>
    /// <returns><c>true</c> to enable looping, <c>false</c> to disable.</returns>
    public bool Loop()
    {
      return this.loop;
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
    ///   <para>Width of video control.</para>
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
        .Attribute("frameborder", 0)
        .Attribute("allowfullscreen", true)
        .Attribute("webkitallowfullscreen", true)
        .Attribute("mozallowfullscreen", true)
        .Attribute("height", this.Height())
        .Attribute("width", this.Width())
        .Attribute("src", "https://player.vimeo.com/video/{0}?badge=0{1}{2}".FormatSelf(this.Id(), this.AutoPlay() ? "&autoplay=1" : string.Empty, this.Loop() ? "&loop=1" : string.Empty))
        .ToString();
    }
  }
}