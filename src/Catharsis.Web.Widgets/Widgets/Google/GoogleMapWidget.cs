namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IGoogleMapWidget"/>
public class GoogleMapWidget : WebWidget, IGoogleMapWidget
{
  /// <inheritdoc cref="ICloneable.Clone()"/>
  public override object Clone() => new GoogleMapWidget
  {
  };

  /// <inheritdoc cref="IWebWidget.ToHtml()"/>
  public override string ToHtml() => throw new NotImplementedException();
}