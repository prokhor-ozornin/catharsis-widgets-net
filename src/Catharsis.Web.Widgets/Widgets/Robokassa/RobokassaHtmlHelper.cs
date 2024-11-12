namespace Catharsis.Web.Widgets;

internal sealed class RobokassaHtmlHelper : IRobokassaHtmlHelper
{
  public IRobokassaPaymentFormWidget PaymentForm() => new RobokassaPaymentFormWidget();
}