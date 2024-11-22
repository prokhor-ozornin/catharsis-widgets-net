namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IRobokassaWidgetsCreator"/>
public class RobokassaWidgetsCreator : IRobokassaWidgetsCreator
{
  /// <inheritdoc cref="IRobokassaWidgetsCreator.PaymentForm()"/>
  public IRobokassaPaymentFormWidget PaymentForm() => new RobokassaPaymentFormWidget();
}