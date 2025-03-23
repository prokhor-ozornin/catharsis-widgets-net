namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IRobokassaWidgetsCreator"/>
public class RobokassaWidgetsCreator : IRobokassaWidgetsCreator
{
  /// <inheritdoc cref="IRobokassaWidgetsCreator.PaymentForm()"/>
  public virtual IRobokassaPaymentFormWidget PaymentForm() => new RobokassaPaymentFormWidget();
}