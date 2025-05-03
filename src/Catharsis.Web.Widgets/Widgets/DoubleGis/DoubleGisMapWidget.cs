namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IDoubleGisMapWidget"/>
public class DoubleGisMapWidget : WebWidget, IDoubleGisMapWidget
{
  /// <inheritdoc cref="ICloneable.Clone()"/>
  public override object Clone() => new DoubleGisMapWidget
  {
  };

  /// <inheritdoc cref="IWebWidget.ToHtml()"/>
  public override string ToHtml() => throw new NotImplementedException();
}