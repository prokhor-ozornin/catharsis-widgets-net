namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IRobokassaPaymentFormWidget"/>
public class RobokassaPaymentFormWidget : WebWidget, IRobokassaPaymentFormWidget
{
  /// <inheritdoc cref="ICloneable.Clone()"/>
  public override object Clone() => new RobokassaPaymentFormWidget
  {
  };

  /// <inheritdoc cref="IWebWidget.ToHtml()"/>
  public override string ToHtml() => throw new NotImplementedException();
}