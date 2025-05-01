using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IFacebookVideoWidget"/>
public class FacebookVideoWidget : WebWidget, IFacebookVideoWidget
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string IdProperty { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string WidthProperty { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string HeightProperty { get; set; }

  /// <inheritdoc cref="IFacebookVideoWidget.Id(string)"/>
  public virtual IFacebookVideoWidget Id(string id)
  {
    if (id is null) throw new ArgumentNullException(nameof(id));
    if (id.IsEmpty()) throw new ArgumentException(nameof(id));

    IdProperty = id;
    return this;
  }

  /// <inheritdoc cref="IFacebookVideoWidget.Height(string)"/>
  public virtual IFacebookVideoWidget Height(string height)
  {
    if (height is null) throw new ArgumentNullException(nameof(height));
    if (height.IsEmpty()) throw new ArgumentException(nameof(height));

    HeightProperty = height;
    return this;
  }

  /// <inheritdoc cref="IFacebookVideoWidget.Width(string)"/>
  public virtual IFacebookVideoWidget Width(string width)
  {
    if (width is null) throw new ArgumentNullException(nameof(width));
    if (width.IsEmpty()) throw new ArgumentException(nameof(width));

    WidthProperty = width;
    return this;
  }

  /// <inheritdoc cref="ICloneable.Clone()"/>
  public override object Clone() => new FacebookVideoWidget { };

  /// <inheritdoc cref="IWebWidget.ToHtml()"/>
  public override string ToHtml() => IdProperty.IsUnset() || WidthProperty.IsUnset() || HeightProperty.IsUnset() ? string.Empty : new TagBuilder("iframe")
      .Attribute("src", $"http://www.facebook.com/video/embed?video_id=${IdProperty}")
      .Attribute("width", WidthProperty)
      .Attribute("height", HeightProperty)
      .Attribute("frameborder", 0)
      .Attribute("allowfullscreen", true)
      .Attribute("webkitallowfullscreen", true)
      .Attribute("mozallowfullscreen", true)
      .ToString();
}