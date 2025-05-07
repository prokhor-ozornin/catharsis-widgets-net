using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IPinterestPinWidget"/>
public class PinterestPinWidget : WebWidget, IPinterestPinWidget
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string IdValue { get; set; }

  /// <inheritdoc cref="IPinterestPinWidget.Id(string)"/>
  public virtual IPinterestPinWidget Id(string id)
  {
    if (id is null) throw new ArgumentNullException(nameof(id));
    if (id.IsEmpty()) throw new ArgumentException(nameof(id));

    IdValue = id;
    return this;
  }

  /// <inheritdoc cref="ICloneable.Clone()"/>
  public override object Clone() => new PinterestPinWidget
  {
    IdValue = IdValue
  };

  /// <inheritdoc cref="IWebWidget.ToHtml()"/>
  public override string ToHtml() => IdValue.IsUnset() ? string.Empty : new TagBuilder("a")
      .Attribute("data-pin-do", "embedPin")
      .Attribute("href", $"http://www.pinterest.com/pin/${IdValue}")
      .ToString();
}