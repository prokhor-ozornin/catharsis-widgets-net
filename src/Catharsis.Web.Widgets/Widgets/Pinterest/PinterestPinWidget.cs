using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IPinterestPinWidget"/>
public class PinterestPinWidget : WebWidget, IPinterestPinWidget
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string IdProperty { get; set; }

  /// <inheritdoc cref="IPinterestPinWidget.Id(string)"/>
  public virtual IPinterestPinWidget Id(string id)
  {
    if (id is null) throw new ArgumentNullException(nameof(id));
    if (id.IsEmpty()) throw new ArgumentException(nameof(id));

    IdProperty = id;
    return this;
  }

  public override object Clone() => new PinterestPinWidget { };

  /// <inheritdoc cref="IWebWidget.ToHtml()"/>
  public override string ToHtml() => IdProperty.IsUnset() ? string.Empty : new TagBuilder("a")
      .Attribute("data-pin-do", "embedPin")
      .Attribute("href", $"http://www.pinterest.com/pin/${IdProperty}")
      .ToString();
}