using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IVimeoVideoWidget"/>
public class VimeoVideoWidget : WebWidget, IVimeoVideoWidget
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual bool AutoPlayProperty { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string HeightProperty { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string IdProperty { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual bool LoopProperty { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string WidthProperty { get; set; }

  /// <inheritdoc cref="IVimeoVideoWidget.AutoPlay(bool)"/>
  public virtual IVimeoVideoWidget AutoPlay(bool enabled)
  {
    AutoPlayProperty = enabled;
    return this;
  }

  /// <inheritdoc cref="IVimeoVideoWidget.Height(string)"/>
  public virtual IVimeoVideoWidget Height(string height)
  {
    if (height is null) throw new ArgumentNullException(nameof(height));
    if (height.IsEmpty()) throw new ArgumentException(nameof(height));

    HeightProperty = height;
    return this;
  }

  /// <inheritdoc cref="IVimeoVideoWidget.Id(string)"/>
  public virtual IVimeoVideoWidget Id(string id)
  {
    if (id is null) throw new ArgumentNullException(nameof(id));
    if (id.IsEmpty()) throw new ArgumentException(nameof(id));

    IdProperty = id;
    return this;
  }

  /// <inheritdoc cref="IVimeoVideoWidget.Loop(bool)"/>
  public virtual IVimeoVideoWidget Loop(bool enabled)
  {
    LoopProperty = enabled;
    return this;
  }

  /// <inheritdoc cref="IVimeoVideoWidget.Width(string)"/>
  public virtual IVimeoVideoWidget Width(string width)
  {
    if (width is null) throw new ArgumentNullException(nameof(width));
    if (width.IsEmpty()) throw new ArgumentException(nameof(width));

    WidthProperty = width;
    return this;
  }

  public override object Clone() => new VimeoVideoWidget { };

  /// <inheritdoc cref="IWebWidget.ToHtml()"/>
  public override string ToHtml() => IdProperty.IsUnset() || WidthProperty.IsUnset() || HeightProperty.IsUnset() ? string.Empty : new TagBuilder("iframe")
      .Attribute("frameborder", 0)
      .Attribute("allowfullscreen", true)
      .Attribute("webkitallowfullscreen", true)
      .Attribute("mozallowfullscreen", true)
      .Attribute("height", HeightProperty)
      .Attribute("width", WidthProperty)
      .Attribute("src", string.Format("https://player.vimeo.com/video/${Id()}?badge=0{1}{2}", IdProperty, AutoPlayProperty ? "&autoplay=1" : string.Empty, LoopProperty ? "&loop=1" : string.Empty))
      .ToString();
}