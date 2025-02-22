using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IYouTubeVideoWidget"/>
public class YouTubeVideoWidget : WebWidget, IYouTubeVideoWidget
{
  private string IdProperty { get; set; }
  private string WidthProperty { get; set; }
  private string HeightProperty { get; set; }
  private bool PrivateModeProperty { get; set; }
  private bool SecureModeProperty { get; set; }

  /// <inheritdoc cref="IYouTubeVideoWidget.Id(string)"/>
  public IYouTubeVideoWidget Id(string id)
  {
    if (id is null) throw new ArgumentNullException(nameof(id));
    if (id.IsEmpty()) throw new ArgumentException(nameof(id));

    IdProperty = id;

    return this;
  }

  /// <inheritdoc cref="IYouTubeVideoWidget.Id()"/>
  public string Id() => IdProperty;

  /// <inheritdoc cref="IYouTubeVideoWidget.Height(string)"/>
  public IYouTubeVideoWidget Height(string height)
  {
    if (height is null) throw new ArgumentNullException(nameof(height));
    if (height.IsEmpty()) throw new ArgumentException(nameof(height));

    HeightProperty = height;

    return this;
  }

  /// <inheritdoc cref="IYouTubeVideoWidget.Height()"/>
  public string Height() => HeightProperty;

  /// <inheritdoc cref="IYouTubeVideoWidget.PrivateMode(bool)"/>
  public IYouTubeVideoWidget PrivateMode(bool enabled)
  {
    PrivateModeProperty = enabled;
    return this;
  }

  /// <inheritdoc cref="IYouTubeVideoWidget.PrivateMode()"/>
  public bool PrivateMode() => PrivateModeProperty;

  /// <inheritdoc cref="IYouTubeVideoWidget.SecureMode(bool)"/>
  public IYouTubeVideoWidget SecureMode(bool enabled)
  {
    SecureModeProperty = enabled;
    return this;
  }

  /// <inheritdoc cref="IYouTubeVideoWidget.SecureMode()"/>
  public bool SecureMode() => SecureModeProperty;

  /// <inheritdoc cref="IYouTubeVideoWidget.Width(string)"/>
  public IYouTubeVideoWidget Width(string width)
  {
    if (width is null) throw new ArgumentNullException(nameof(width));
    if (width.IsEmpty()) throw new ArgumentException(nameof(width));

    WidthProperty = width;

    return this;
  }

  /// <inheritdoc cref="IYouTubeVideoWidget.Width()"/>
  public string Width() => WidthProperty;

  /// <inheritdoc cref="IHtmlContent.ToHtml()"/>
  public override string ToHtml()
  {
    if (Id().IsEmpty() || Width().IsEmpty() || Height().IsEmpty())
    {
      return string.Empty;
    }

    return new TagBuilder("iframe")
      .Attribute("src", string.Format("{2}://{1}/embed/{0}", Id(), PrivateMode() ? "www.youtube-nocookie.com" : "www.youtube.com", SecureMode() ? "https" : "http"))
      .Attribute("width", Width())
      .Attribute("height", Height())
      .Attribute("frameborder", 0)
      .Attribute("allowfullscreen", true)
      .Attribute("webkitallowfullscreen", true)
      .Attribute("mozallowfullscreen", true)
      .ToString();
  }
}