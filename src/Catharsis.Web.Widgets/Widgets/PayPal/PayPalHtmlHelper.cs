namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IPayPalHtmlHelper"/>
public class PayPalHtmlHelper : IPayPalHtmlHelper
{
  /// <inheritdoc cref="IPayPalHtmlHelper.BuyGiftCertificate()"/>
  public IPayPalBuyGiftCertificateWidget BuyGiftCertificate() => new PayPalBuyGiftCertificateWidget();

  /// <inheritdoc cref="IPayPalHtmlHelper.BuyNow()"/>
  public IPayPalBuyNowWidget BuyNow() => new PayPalBuyNowWidget();

  /// <inheritdoc cref="IPayPalHtmlHelper.Donate()"/>
  public IPayPalDonateWidget Donate() => new PayPalDonateWidget();

  /// <inheritdoc cref="IPayPalHtmlHelper.Subscribe()"/>
  public IPayPalSubscribeWidget Subscribe() => new PayPalSubscribeWidget();
}