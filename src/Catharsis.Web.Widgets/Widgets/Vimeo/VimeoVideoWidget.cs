using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IVimeoVideoWidget"/>
public class VimeoVideoWidget : WebWidget, IVimeoVideoWidget
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual bool AutoPlayValue { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string HeightValue { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string IdValue { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual bool LoopValue { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string WidthValue { get; set; }

  /// <inheritdoc cref="IVimeoVideoWidget.AutoPlay(bool)"/>
  public virtual IVimeoVideoWidget AutoPlay(bool enabled)
  {
    AutoPlayValue = enabled;
    return this;
  }

  /// <inheritdoc cref="IVideoWidget{T}.Height(string)"/>
  public virtual IVimeoVideoWidget Height(string height)
  {
    if (height is null) throw new ArgumentNullException(nameof(height));
    if (height.IsEmpty()) throw new ArgumentException(nameof(height));

    HeightValue = height;
    return this;
  }

  /// <inheritdoc cref="IVideoWidget{T}.Id(string)"/>
  public virtual IVimeoVideoWidget Id(string id)
  {
    if (id is null) throw new ArgumentNullException(nameof(id));
    if (id.IsEmpty()) throw new ArgumentException(nameof(id));

    IdValue = id;
    return this;
  }

  /// <inheritdoc cref="IVimeoVideoWidget.Loop(bool)"/>
  public virtual IVimeoVideoWidget Loop(bool enabled)
  {
    LoopValue = enabled;
    return this;
  }

  /// <inheritdoc cref="IVideoWidget{T}.Width(string)"/>
  public virtual IVimeoVideoWidget Width(string width)
  {
    if (width is null) throw new ArgumentNullException(nameof(width));
    if (width.IsEmpty()) throw new ArgumentException(nameof(width));

    WidthValue = width;
    return this;
  }

  /// <inheritdoc cref="ICloneable.Clone()"/>
  public override object Clone() => new VimeoVideoWidget
  {
    AutoPlayValue = AutoPlayValue,
    HeightValue = HeightValue,
    IdValue = IdValue,
    LoopValue = LoopValue,
    WidthValue = WidthValue
  };

  /// <inheritdoc cref="IWebWidget.ToHtml()"/>
  public override string ToHtml() => IdValue.IsUnset() || WidthValue.IsUnset() || HeightValue.IsUnset() ? string.Empty : new TagBuilder("iframe")
      .Attribute("frameborder", 0)
      .Attribute("allowfullscreen", true)
      .Attribute("webkitallowfullscreen", true)
      .Attribute("mozallowfullscreen", true)
      .Attribute("height", HeightValue)
      .Attribute("width", WidthValue)
      .Attribute("src", string.Format("https://player.vimeo.com/video/${Id()}?badge=0{1}{2}", IdValue, AutoPlayValue ? "&autoplay=1" : string.Empty, LoopValue ? "&loop=1" : string.Empty))
      .ToString();
}