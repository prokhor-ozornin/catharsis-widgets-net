using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IMailRuVideoWidget"/>
public class MailRuVideoWidget : WebWidget, IMailRuVideoWidget
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string IdValue { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string HeightValue { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string WidthValue { get; set; }

  /// <inheritdoc cref="IVideoWidget{T}.Id(string)"/>
  public virtual IMailRuVideoWidget Id(string id)
  {
    if (id is null) throw new ArgumentNullException(nameof(id));
    if (id.IsEmpty()) throw new ArgumentException(nameof(id));

    IdValue = id;
    return this;
  }

  /// <inheritdoc cref="IVideoWidget{T}.Height(string)"/>
  public virtual IMailRuVideoWidget Height(string height)
  {
    if (height is null) throw new ArgumentNullException(nameof(height));
    if (height.IsEmpty()) throw new ArgumentException(nameof(height));

    HeightValue = height;
    return this;
  }

  /// <inheritdoc cref="IVideoWidget{T}.Width(string)"/>
  public virtual IMailRuVideoWidget Width(string width)
  {
    if (width is null) throw new ArgumentNullException(nameof(width));
    if (width.IsEmpty()) throw new ArgumentException(nameof(width));

    WidthValue = width;
    return this;
  }

  /// <inheritdoc cref="ICloneable.Clone()"/>
  public override object Clone() => new MailRuVideoWidget
  {
    IdValue = IdValue,
    HeightValue = HeightValue,
    WidthValue = WidthValue
  };

  /// <inheritdoc cref="IWebWidget.ToHtml()"/>
  public override string ToHtml() => IdValue.IsUnset() || HeightValue.IsUnset() || WidthValue.IsUnset() ? string.Empty : new TagBuilder("iframe")
      .Attribute("src", $"http://api.video.mail.ru/videos/embed/mail/${IdValue}")
      .Attribute("width", WidthValue)
      .Attribute("height", HeightValue)
      .Attribute("frameborder", 0)
      .Attribute("allowfullscreen", true)
      .Attribute("webkitallowfullscreen", true)
      .Attribute("mozallowfullscreen", true)
      .ToString();
}