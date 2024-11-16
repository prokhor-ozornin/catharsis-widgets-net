using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IMailRuVideoWidget"/>
public class MailRuVideoWidget : WebWidget, IMailRuVideoWidget
{
  private string id;
  private string height;
  private string width;

  /// <inheritdoc cref="IMailRuVideoWidget.Id(string)"/>
  public IMailRuVideoWidget Id(string id)
  {
    if (id is null) throw new ArgumentNullException(nameof(id));
    if (id.IsEmpty()) throw new ArgumentException(nameof(id));

    this.id = id;
    return this;
  }

  /// <inheritdoc cref="IMailRuVideoWidget.Id()"/>
  public string Id() => id;

  /// <inheritdoc cref="IMailRuVideoWidget.Height(string)"/>
  public IMailRuVideoWidget Height(string height)
  {
    if (height is null) throw new ArgumentNullException(nameof(height));
    if (height.IsEmpty()) throw new ArgumentException(nameof(height));

    this.height = height;
    return this;
  }

  /// <inheritdoc cref="IMailRuVideoWidget.Height()"/>
  public string Height() => height;

  /// <inheritdoc cref="IMailRuVideoWidget.Width(string)"/>
  public IMailRuVideoWidget Width(string width)
  {
    if (width is null) throw new ArgumentNullException(nameof(width));
    if (width.IsEmpty()) throw new ArgumentException(nameof(width));

    this.width = width;
    return this;
  }

  /// <inheritdoc cref="IMailRuVideoWidget.Width()"/>
  public string Width() => width;

  /// <inheritdoc cref="IWebWidget.ToHtml()"/>
  public override string ToHtml()
  {
    if (Id().IsEmpty() || Height().IsEmpty() || Width().IsEmpty())
    {
      return string.Empty;
    }

    return new TagBuilder("iframe")
      .Attribute("src", $"http://api.video.mail.ru/videos/embed/mail/${Id()}")
      .Attribute("width", Width())
      .Attribute("height", Height())
      .Attribute("frameborder", 0)
      .Attribute("allowfullscreen", true)
      .Attribute("webkitallowfullscreen", true)
      .Attribute("mozallowfullscreen", true)
      .ToString();
  }
}