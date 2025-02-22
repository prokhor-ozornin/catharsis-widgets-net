using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IPinterestPinWidget"/>
public class PinterestPinWidget : WebWidget, IPinterestPinWidget
{
  private string IdProperty { get; set; }

  /// <inheritdoc cref="IPinterestPinWidget.Id(string)"/>
  public IPinterestPinWidget Id(string id)
  {
    if (id is null) throw new ArgumentNullException(nameof(id));
    if (id.IsEmpty()) throw new ArgumentException(nameof(id));

    IdProperty = id;
    return this;
  }

  /// <inheritdoc cref="IPinterestPinWidget.Id()"/>
  public string Id() => IdProperty;

  /// <inheritdoc cref="IHtmlContent.ToHtml()"/>
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