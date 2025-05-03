namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IAddThisSmartLayersWidget"/>
public class AddThisSmartLayersWidget : WebWidget, IAddThisSmartLayersWidget
{
  /// <inheritdoc cref="ICloneable.Clone()"/>
  public override object Clone() => new AddThisSmartLayersWidget
  {
  };

  /// <inheritdoc cref="IWebWidget.ToHtml()"/>
  public override string ToHtml() => throw new NotImplementedException();
}