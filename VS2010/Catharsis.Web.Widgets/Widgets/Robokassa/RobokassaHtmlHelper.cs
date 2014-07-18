namespace Catharsis.Web.Widgets
{
  internal sealed class RobokassaHtmlHelper : IRobokassaHtmlHelper
  {
    public IRobokassaPaymentFormWidget PaymentForm()
    {
      return new RobokassaPaymentFormWidget();
    }
  }
}