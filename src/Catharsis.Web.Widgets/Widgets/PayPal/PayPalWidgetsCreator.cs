namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IPayPalWidgetsCreator"/>
public class PayPalWidgetsCreator : IPayPalWidgetsCreator
{
  /// <inheritdoc cref="IPayPalWidgetsCreator.BuyGiftCertificate()"/>
  public IPayPalBuyGiftCertificateWidget BuyGiftCertificate() => new PayPalBuyGiftCertificateWidget();

  /// <inheritdoc cref="IPayPalWidgetsCreator.BuyNow()"/>
  public IPayPalBuyNowWidget BuyNow() => new PayPalBuyNowWidget();

  /// <inheritdoc cref="IPayPalWidgetsCreator.Donate()"/>
  public IPayPalDonateWidget Donate() => new PayPalDonateWidget();

  /// <inheritdoc cref="IPayPalWidgetsCreator.Subscribe()"/>
  public IPayPalSubscribeWidget Subscribe() => new PayPalSubscribeWidget();
}