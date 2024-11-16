using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IRuTubeVideoWidget"/>
public class RuTubeVideoWidget : WebWidget, IRuTubeVideoWidget
{
  private string id;
  private string height;
  private string width;

  /// <inheritdoc cref="IRuTubeVideoWidget.Id(string)"/>
  public IRuTubeVideoWidget Id(string id)
  {
    if (id is null) throw new ArgumentNullException(nameof(id));
    if (id.IsEmpty()) throw new ArgumentException(nameof(id));

    this.id = id;
    return this;
  }

  /// <inheritdoc cref="IRuTubeVideoWidget.Id()"/>
  public string Id() => id;

  /// <inheritdoc cref="IRuTubeVideoWidget.Height(string)"/>
  public IRuTubeVideoWidget Height(string height)
  {
    if (height is null) throw new ArgumentNullException(nameof(height));
    if (height.IsEmpty()) throw new ArgumentException(nameof(height));

    this.height = height;
    return this;
  }

  /// <inheritdoc cref="IRuTubeVideoWidget.Height()"/>
  public string Height() => height;

  /// <inheritdoc cref="IRuTubeVideoWidget.Width(string)"/>
  public IRuTubeVideoWidget Width(string width)
  {
    if (width is null) throw new ArgumentNullException(nameof(width));
    if (width.IsEmpty()) throw new ArgumentException(nameof(width));

    this.width = width;
    return this;
  }

  /// <inheritdoc cref="IRuTubeVideoWidget.Width()"/>
  public string Width() => width;

  /// <inheritdoc cref="IWebWidget.ToHtml()"/>
  public override string ToHtml()
  {
    if (Id().IsEmpty() || Height().IsEmpty() || Width().IsEmpty())
    {
      return string.Empty;
    }

    return new TagBuilder("iframe")
      .Attribute("frameborder", 0)
      .Attribute("allowfullscreen", true)
      .Attribute("webkitallowfullscreen", true)
      .Attribute("mozallowfullscreen", true)
      .Attribute("scrolling", "no")
      .Attribute("height", Height())
      .Attribute("width", Width())
      .Attribute("src", $"http://rutube.ru/embed/{Id()}")
      .ToString();
  }
}