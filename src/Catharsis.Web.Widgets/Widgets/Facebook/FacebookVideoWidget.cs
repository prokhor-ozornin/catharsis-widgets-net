using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IFacebookVideoWidget"/>
public class FacebookVideoWidget : WebWidget, IFacebookVideoWidget
{
  private string IdProperty { get; set; }
  private string WidthProperty { get; set; }
  private string HeightProperty { get; set; }

  /// <inheritdoc cref="IFacebookVideoWidget.Id(string)"/>
  public IFacebookVideoWidget Id(string id)
  {
    if (id is null) throw new ArgumentNullException(nameof(id));
    if (id.IsEmpty()) throw new ArgumentException(nameof(id));

    IdProperty = id;
    return this;
  }

  /// <inheritdoc cref="IFacebookVideoWidget.Id()"/>
  public string Id() => IdProperty;

  /// <inheritdoc cref="IFacebookVideoWidget.Height(string)"/>
  public IFacebookVideoWidget Height(string height)
  {
    if (height is null) throw new ArgumentNullException(nameof(height));
    if (height.IsEmpty()) throw new ArgumentException(nameof(height));

    HeightProperty = height;
    return this;
  }

  /// <inheritdoc cref="IFacebookVideoWidget.Height()"/>
  public string Height() => HeightProperty;

  /// <inheritdoc cref="IFacebookVideoWidget.Width(string)"/>
  public IFacebookVideoWidget Width(string width)
  {
    if (width is null) throw new ArgumentNullException(nameof(width));
    if (width.IsEmpty()) throw new ArgumentException(nameof(width));

    WidthProperty = width;
    return this;
  }

  /// <inheritdoc cref="IFacebookVideoWidget.Width()"/>
  public string Width() => WidthProperty;

  /// <inheritdoc cref="IHtmlContent.ToHtml()"/>
  public override string ToHtml()
  {
    if (Id().IsEmpty() || Width().IsEmpty() || Height().IsEmpty())
    {
      return string.Empty;
    }

    return new TagBuilder("iframe")
      .Attribute("src", $"http://www.facebook.com/video/embed?video_id=${IdProperty}")
      .Attribute("width", Width())
      .Attribute("height", Height())
      .Attribute("frameborder", 0)
      .Attribute("allowfullscreen", true)
      .Attribute("webkitallowfullscreen", true)
      .Attribute("mozallowfullscreen", true)
      .ToString();
  }
}