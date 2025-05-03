namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IDoubleGisContactsMapWidget"/>
public class DoubleGisContactsMapWidget : WebWidget, IDoubleGisContactsMapWidget
{
  /// <inheritdoc cref="ICloneable.Clone()"/>
  public override object Clone() => new DoubleGisContactsMapWidget
  {
  };

  /// <inheritdoc cref="IWebWidget.ToHtml()"/>
  public override string ToHtml() => throw new NotImplementedException();
}