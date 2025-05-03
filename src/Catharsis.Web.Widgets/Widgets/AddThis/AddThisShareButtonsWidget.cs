namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IAddThisShareButtonsWidget"/>
public class AddThisShareButtonsWidget : WebWidget, IAddThisShareButtonsWidget
{
  /// <inheritdoc cref="ICloneable.Clone()"/>
  public override object Clone() => new AddThisShareButtonsWidget
  {
  };

  /// <inheritdoc cref="IWebWidget.ToHtml()"/>
  public override string ToHtml() => throw new NotImplementedException();
}