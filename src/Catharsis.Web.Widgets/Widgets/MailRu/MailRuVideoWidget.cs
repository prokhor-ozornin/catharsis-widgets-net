using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IMailRuVideoWidget"/>
public class MailRuVideoWidget : WebWidget, IMailRuVideoWidget
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

  /// <inheritdoc cref="IMailRuVideoWidget.Id(string)"/>
  public virtual IMailRuVideoWidget Id(string id)
  {
    if (id is null) throw new ArgumentNullException(nameof(id));
    if (id.IsEmpty()) throw new ArgumentException(nameof(id));

    IdProperty = id;
    return this;
  }

  /// <inheritdoc cref="IMailRuVideoWidget.Height(string)"/>
  public virtual IMailRuVideoWidget Height(string height)
  {
    if (height is null) throw new ArgumentNullException(nameof(height));
    if (height.IsEmpty()) throw new ArgumentException(nameof(height));

    HeightProperty = height;
    return this;
  }

  /// <inheritdoc cref="IMailRuVideoWidget.Width(string)"/>
  public virtual IMailRuVideoWidget Width(string width)
  {
    if (width is null) throw new ArgumentNullException(nameof(width));
    if (width.IsEmpty()) throw new ArgumentException(nameof(width));

    WidthProperty = width;
    return this;
  }

  /// <inheritdoc cref="IHtmlContent.ToHtml()"/>
  public override string ToHtml()
  {
    if (IdProperty.IsEmpty() || HeightProperty.IsEmpty() || WidthProperty.IsEmpty())
    {
      return string.Empty;
    }

    return new TagBuilder("iframe")
      .Attribute("src", $"http://api.video.mail.ru/videos/embed/mail/${IdProperty}")
      .Attribute("width", WidthProperty)
      .Attribute("height", HeightProperty)
      .Attribute("frameborder", 0)
      .Attribute("allowfullscreen", true)
      .Attribute("webkitallowfullscreen", true)
      .Attribute("mozallowfullscreen", true)
      .ToString();
  }
}