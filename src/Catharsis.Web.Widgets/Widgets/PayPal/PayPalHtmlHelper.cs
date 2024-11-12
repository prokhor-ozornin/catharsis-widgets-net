namespace Catharsis.Web.Widgets;

internal sealed class PayPalHtmlHelper : IPayPalHtmlHelper
{
  public IPayPalBuyGiftCertificateWidget BuyGiftCertificate() => new PayPalBuyGiftCertificateWidget();

  public IPayPalBuyNowWidget BuyNow() => new PayPalBuyNowWidget();

  public IPayPalDonateWidget Donate() => new PayPalDonateWidget();

  public IPayPalSubscribeWidget Subscribe() => new PayPalSubscribeWidget();
}