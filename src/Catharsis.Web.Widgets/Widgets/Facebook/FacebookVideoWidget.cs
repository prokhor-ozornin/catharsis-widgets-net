using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IFacebookVideoWidget"/>
public class FacebookVideoWidget : WebWidget, IFacebookVideoWidget
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string IdValue { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string WidthValue { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string HeightValue { get; set; }

  /// <inheritdoc cref="IFacebookVideoWidget.Id(string)"/>
  public virtual IFacebookVideoWidget Id(string id)
  {
    if (id is null) throw new ArgumentNullException(nameof(id));
    if (id.IsEmpty()) throw new ArgumentException(nameof(id));

    IdValue = id;
    return this;
  }

  /// <inheritdoc cref="IFacebookVideoWidget.Height(string)"/>
  public virtual IFacebookVideoWidget Height(string height)
  {
    if (height is null) throw new ArgumentNullException(nameof(height));
    if (height.IsEmpty()) throw new ArgumentException(nameof(height));

    HeightValue = height;
    return this;
  }

  /// <inheritdoc cref="IFacebookVideoWidget.Width(string)"/>
  public virtual IFacebookVideoWidget Width(string width)
  {
    if (width is null) throw new ArgumentNullException(nameof(width));
    if (width.IsEmpty()) throw new ArgumentException(nameof(width));

    WidthValue = width;
    return this;
  }

  /// <inheritdoc cref="ICloneable.Clone()"/>
  public override object Clone() => new FacebookVideoWidget
  {
    IdValue = IdValue,
    WidthValue = WidthValue,
    HeightValue = HeightValue
  };

  /// <inheritdoc cref="IWebWidget.ToHtml()"/>
  public override string ToHtml() => IdValue.IsUnset() || WidthValue.IsUnset() || HeightValue.IsUnset() ? string.Empty : new TagBuilder("iframe")
      .Attribute("src", $"http://www.facebook.com/video/embed?video_id=${IdValue}")
      .Attribute("width", WidthValue)
      .Attribute("height", HeightValue)
      .Attribute("frameborder", 0)
      .Attribute("allowfullscreen", true)
      .Attribute("webkitallowfullscreen", true)
      .Attribute("mozallowfullscreen", true)
      .ToString();
}