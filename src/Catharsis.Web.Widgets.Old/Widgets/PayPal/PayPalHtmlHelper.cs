namespace Catharsis.Web.Widgets
{
  internal sealed class PayPalHtmlHelper : IPayPalHtmlHelper
  {
    public IPayPalBuyGiftCertificateWidget BuyGiftCertificate()
    {
      return new PayPalBuyGiftCertificateWidget();
    }

    public IPayPalBuyNowWidget BuyNow()
    {
      return new PayPalBuyNowWidget();
    }

    public IPayPalDonateWidget Donate()
    {
      return new PayPalDonateWidget();
    }

    public IPayPalSubscribeWidget Subscribe()
    {
      return new PayPalSubscribeWidget();
    }
  }
}