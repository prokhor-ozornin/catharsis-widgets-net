namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IPayPalBuyGiftCertificateWidget"/>
public class PayPalBuyGiftCertificateWidget : WebWidget, IPayPalBuyGiftCertificateWidget
{
  public IPayPalBuyGiftCertificateWidget AsForm()
  {
    throw new NotImplementedException();
  }

  public IPayPalBuyGiftCertificateWidget AsUrl()
  {
    throw new NotImplementedException();
  }

  /// <inheritdoc cref="IWebWidget.ToHtml()"/>
  public override string ToHtml()
  {
    throw new NotImplementedException();
  }
}