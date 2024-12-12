using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IYouTubeVideoWidget"/>
public class YouTubeVideoWidget : WebWidget, IYouTubeVideoWidget
{
  private string id;
  private string width;
  private string height;
  private bool privateMode;
  private bool secureMode;

  /// <inheritdoc cref="IYouTubeVideoWidget.Id(string)"/>
  public IYouTubeVideoWidget Id(string id)
  {
    if (id is null) throw new ArgumentNullException(nameof(id));
    if (id.IsEmpty()) throw new ArgumentException(nameof(id));

    this.id = id;

    return this;
  }

  /// <inheritdoc cref="IYouTubeVideoWidget.Id()"/>
  public string Id() => id;

  /// <inheritdoc cref="IYouTubeVideoWidget.Height(string)"/>
  public IYouTubeVideoWidget Height(string height)
  {
    if (height is null) throw new ArgumentNullException(nameof(height));
    if (height.IsEmpty()) throw new ArgumentException(nameof(height));

    this.height = height;

    return this;
  }

  /// <inheritdoc cref="IYouTubeVideoWidget.Height()"/>
  public string Height() => height;

  /// <inheritdoc cref="IYouTubeVideoWidget.PrivateMode(bool)"/>
  public IYouTubeVideoWidget PrivateMode(bool enabled)
  {
    privateMode = enabled;
    return this;
  }

  /// <inheritdoc cref="IYouTubeVideoWidget.PrivateMode()"/>
  public bool PrivateMode() => privateMode;

  /// <inheritdoc cref="IYouTubeVideoWidget.SecureMode(bool)"/>
  public IYouTubeVideoWidget SecureMode(bool enabled)
  {
    secureMode = enabled;
    return this;
  }

  /// <inheritdoc cref="IYouTubeVideoWidget.SecureMode()"/>
  public bool SecureMode() => secureMode;

  /// <inheritdoc cref="IYouTubeVideoWidget.Width(string)"/>
  public IYouTubeVideoWidget Width(string width)
  {
    if (width is null) throw new ArgumentNullException(nameof(width));
    if (width.IsEmpty()) throw new ArgumentException(nameof(width));

    this.width = width;

    return this;
  }

  /// <inheritdoc cref="IYouTubeVideoWidget.Width()"/>
  public string Width() => width;

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