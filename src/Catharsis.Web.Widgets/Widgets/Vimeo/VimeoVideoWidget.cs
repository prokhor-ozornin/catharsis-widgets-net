using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IVimeoVideoWidget"/>
public class VimeoVideoWidget : WebWidget, IVimeoVideoWidget
{
  private bool AutoPlayProperty { get; set; }
  private string HeightProperty { get; set; }
  private string IdProperty { get; set; }
  private bool LoopProperty { get; set; }
  private string WidthProperty { get; set; }

  /// <inheritdoc cref="IVimeoVideoWidget.AutoPlay(bool)"/>
  public IVimeoVideoWidget AutoPlay(bool enabled)
  {
    AutoPlayProperty = enabled;
    return this;
  }

  /// <inheritdoc cref="IVimeoVideoWidget.AutoPlay()"/>
  public bool AutoPlay() => AutoPlayProperty;

  /// <inheritdoc cref="IVimeoVideoWidget.Height(string)"/>
  public IVimeoVideoWidget Height(string height)
  {
    if (height is null) throw new ArgumentNullException(nameof(height));
    if (height.IsEmpty()) throw new ArgumentException(nameof(height));

    HeightProperty = height;
    return this;
  }

  /// <inheritdoc cref="IVimeoVideoWidget.Height()"/>
  public string Height() => HeightProperty;

  /// <inheritdoc cref="IVimeoVideoWidget.Id(string)"/>
  public IVimeoVideoWidget Id(string id)
  {
    if (id is null) throw new ArgumentNullException(nameof(id));
    if (id.IsEmpty()) throw new ArgumentException(nameof(id));

    IdProperty = id;
    return this;
  }

  /// <inheritdoc cref="IVimeoVideoWidget.Id()"/>
  public string Id() => IdProperty;

  /// <inheritdoc cref="IVimeoVideoWidget.Loop(bool)"/>
  public IVimeoVideoWidget Loop(bool enabled)
  {
    LoopProperty = enabled;
    return this;
  }

  /// <inheritdoc cref="IVimeoVideoWidget.Loop()"/>
  public bool Loop() => LoopProperty;

  /// <inheritdoc cref="IVimeoVideoWidget.Width(string)"/>
  public IVimeoVideoWidget Width(string width)
  {
    if (width is null) throw new ArgumentNullException(nameof(width));
    if (width.IsEmpty()) throw new ArgumentException(nameof(width));

    WidthProperty = width;
    return this;
  }

  /// <inheritdoc cref="IVimeoVideoWidget.Width()"/>
  public string Width() => WidthProperty;

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