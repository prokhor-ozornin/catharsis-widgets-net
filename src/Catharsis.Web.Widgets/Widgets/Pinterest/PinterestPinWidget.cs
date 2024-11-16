using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IPinterestPinWidget"/>
public class PinterestPinWidget : WebWidget, IPinterestPinWidget
{
  private string id;

  /// <inheritdoc cref="IPinterestPinWidget.Id(string)"/>
  public IPinterestPinWidget Id(string id)
  {
    if (id is null) throw new ArgumentNullException(nameof(id));
    if (id.IsEmpty()) throw new ArgumentException(nameof(id));

    this.id = id;
    return this;
  }

  /// <inheritdoc cref="IPinterestPinWidget.Id()"/>
  public string Id() => id;

  /// <inheritdoc cref="IWebWidget.ToHtml()"/>
  public override string ToHtml()
  {
    if (Id().IsEmpty())
    {
      return string.Empty;
    }

    return new TagBuilder("a")
      .Attribute("data-pin-do", "embedPin")
      .Attribute("href", $"http://www.pinterest.com/pin/${Id()}")
      .ToString();
  }
}