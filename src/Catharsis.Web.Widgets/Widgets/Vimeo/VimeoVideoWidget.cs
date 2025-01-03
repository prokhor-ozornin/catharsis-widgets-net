using Catharsis.Extensions;
using Catharsis.Web.Widgets.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IVimeoVideoWidget"/>
public class VimeoVideoWidget : WebWidget, IVimeoVideoWidget
{
  private bool autoPlay;
  private string height;
  private string id;
  private bool loop;
  private string width;

  /// <inheritdoc cref="IVimeoVideoWidget.AutoPlay(bool)"/>
  public IVimeoVideoWidget AutoPlay(bool enabled)
  {
    autoPlay = enabled;
    return this;
  }

  /// <inheritdoc cref="IVimeoVideoWidget.AutoPlay()"/>
  public bool AutoPlay() => autoPlay;

  /// <inheritdoc cref="IVimeoVideoWidget.Height(string)"/>
  public IVimeoVideoWidget Height(string height)
  {
    if (height is null) throw new ArgumentNullException(nameof(height));
    if (height.IsEmpty()) throw new ArgumentException(nameof(height));

    this.height = height;
    return this;
  }

  /// <inheritdoc cref="IVimeoVideoWidget.Height()"/>
  public string Height() => height;

  /// <inheritdoc cref="IVimeoVideoWidget.Id(string)"/>
  public IVimeoVideoWidget Id(string id)
  {
    if (id is null) throw new ArgumentNullException(nameof(id));
    if (id.IsEmpty()) throw new ArgumentException(nameof(id));

    this.id = id;
    return this;
  }

  /// <inheritdoc cref="IVimeoVideoWidget.Id()"/>
  public string Id() => id;

  /// <inheritdoc cref="IVimeoVideoWidget.Loop(bool)"/>
  public IVimeoVideoWidget Loop(bool enabled)
  {
    loop = enabled;
    return this;
  }

  /// <inheritdoc cref="IVimeoVideoWidget.Loop()"/>
  public bool Loop() => loop;

  /// <inheritdoc cref="IVimeoVideoWidget.Width(string)"/>
  public IVimeoVideoWidget Width(string width)
  {
    if (width is null) throw new ArgumentNullException(nameof(width));
    if (width.IsEmpty()) throw new ArgumentException(nameof(width));

    this.width = width;
    return this;
  }

  /// <inheritdoc cref="IVimeoVideoWidget.Width()"/>
  public string Width() => width;

  /// <inheritdoc cref="IHtmlContent.ToHtml()"/>
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