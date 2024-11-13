namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IRobokassaWidgetCreator"/>
public class RobokassaWidgetCreator : IRobokassaWidgetCreator
{
  /// <inheritdoc cref="IRobokassaWidgetCreator.PaymentForm()"/>
  public IRobokassaPaymentFormWidget PaymentForm() => new RobokassaPaymentFormWidget();
}