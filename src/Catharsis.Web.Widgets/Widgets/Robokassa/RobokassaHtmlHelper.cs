namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IRobokassaHtmlHelper"/>
public class RobokassaHtmlHelper : IRobokassaHtmlHelper
{
  /// <inheritdoc cref="IRobokassaHtmlHelper.PaymentForm()"/>
  public IRobokassaPaymentFormWidget PaymentForm() => new RobokassaPaymentFormWidget();
}