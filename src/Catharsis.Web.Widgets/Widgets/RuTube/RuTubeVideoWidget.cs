using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IRuTubeVideoWidget"/>
public class RuTubeVideoWidget : WebWidget, IRuTubeVideoWidget
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string IdProperty { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string HeightProperty { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string WidthProperty { get; set; }

  /// <inheritdoc cref="IRuTubeVideoWidget.Id(string)"/>
  public virtual IRuTubeVideoWidget Id(string id)
  {
    if (id is null) throw new ArgumentNullException(nameof(id));
    if (id.IsEmpty()) throw new ArgumentException(nameof(id));

    IdProperty = id;
    return this;
  }

  /// <inheritdoc cref="IRuTubeVideoWidget.Height(string)"/>
  public virtual IRuTubeVideoWidget Height(string height)
  {
    if (height is null) throw new ArgumentNullException(nameof(height));
    if (height.IsEmpty()) throw new ArgumentException(nameof(height));

    HeightProperty = height;
    return this;
  }

  /// <inheritdoc cref="IRuTubeVideoWidget.Width(string)"/>
  public virtual IRuTubeVideoWidget Width(string width)
  {
    if (width is null) throw new ArgumentNullException(nameof(width));
    if (width.IsEmpty()) throw new ArgumentException(nameof(width));

    WidthProperty = width;
    return this;
  }

  /// <inheritdoc cref="IHtmlContent.ToHtml()"/>
  public override string ToHtml() => IdProperty.IsUnset() || HeightProperty.IsUnset() || WidthProperty.IsUnset() ? string.Empty : new TagBuilder("iframe")
      .Attribute("frameborder", 0)
      .Attribute("allowfullscreen", true)
      .Attribute("webkitallowfullscreen", true)
      .Attribute("mozallowfullscreen", true)
      .Attribute("scrolling", "no")
      .Attribute("height", HeightProperty)
      .Attribute("width", WidthProperty)
      .Attribute("src", $"http://rutube.ru/embed/{IdProperty}")
      .ToString();
}