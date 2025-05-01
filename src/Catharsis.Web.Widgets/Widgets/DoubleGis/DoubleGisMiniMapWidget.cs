namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IDoubleGisMiniMapWidget"/>
public class DoubleGisMiniMapWidget : WebWidget, IDoubleGisMiniMapWidget
{
  /// <inheritdoc cref="ICloneable.Clone()"/>
  public override object Clone() => new DoubleGisMiniMapWidget { };

  /// <inheritdoc cref="IWebWidget.ToHtml()"/>
  public override string ToHtml() => throw new NotImplementedException();
}