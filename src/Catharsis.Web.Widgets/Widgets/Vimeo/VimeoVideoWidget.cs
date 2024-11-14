using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IVimeoVideoWidget"/>
public class VimeoVideoWidget : WebWidget, IVimeoVideoWidget
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
    autoPlay = enabled;
    return this;
  }

  /// <summary>
  ///   <para>Whether to start playing video automatically. Default is <c>false</c>.</para>
  /// </summary>
  /// <returns><c>true</c> to enable autoplay, <c>false</c> to disable.</returns>
  public bool AutoPlay() => autoPlay;

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
    if (height is null) throw new ArgumentNullException(nameof(height));
    if (height.IsEmpty()) throw new ArgumentException(nameof(height));

    this.height = height;
    return this;
  }

  /// <summary>
  ///   <para>Height of video control.</para>
  /// </summary>
  /// <returns>Height of video.</returns>
  public string Height() => height;

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
    if (id is null) throw new ArgumentNullException(nameof(id));
    if (id.IsEmpty()) throw new ArgumentException(nameof(id));

    this.id = id;
    return this;
  }

  /// <summary>
  ///   <para>Identifier of video.</para>
  /// </summary>
  /// <returns>Identifier of video.</returns>
  public string Id() => id;

  /// <summary>
  ///   <para>Whether to replay video when it finishes. Default is <c>false</c>.</para>
  /// </summary>
  /// <param name="enabled"><c>true</c> to enable looping, <c>false</c> to disable.</param>
  /// <returns>Reference to the current widget.</returns>
  public IVimeoVideoWidget Loop(bool enabled)
  {
    loop = enabled;
    return this;
  }

  /// <summary>
  ///   <para>Whether to replay video when it finishes. Default is <c>false</c>.</para>
  /// </summary>
  /// <returns><c>true</c> to enable looping, <c>false</c> to disable.</returns>
  public bool Loop() => loop;

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
    if (width is null) throw new ArgumentNullException(nameof(width));
    if (width.IsEmpty()) throw new ArgumentException(nameof(width));

    this.width = width;
    return this;
  }

  /// <summary>
  ///   <para>Width of video control.</para>
  /// </summary>
  /// <returns>Width of video.</returns>
  public string Width() => width;

  /// <inheritdoc cref="IWebWidget.ToHtml()"/>
  public override string ToHtml()
  {
    if (Id().IsEmpty() || Width().IsEmpty() || Height().IsEmpty())
    {
      return string.Empty;
    }

    return new TagBuilder("iframe")
      .Attribute("frameborder", 0)
      .Attribute("allowfullscreen", true)
      .Attribute("webkitallowfullscreen", true)
      .Attribute("mozallowfullscreen", true)
      .Attribute("height", Height())
      .Attribute("width", Width())
      .Attribute("src", string.Format("https://player.vimeo.com/video/${Id()}?badge=0{1}{2}", Id(), AutoPlay() ? "&autoplay=1" : string.Empty, Loop() ? "&loop=1" : string.Empty))
      .ToString();
  }
}