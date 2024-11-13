namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IPayPalWidgetCreator"/>
public class PayPalWidgetCreator : IPayPalWidgetCreator
{
  /// <inheritdoc cref="IPayPalWidgetCreator.BuyGiftCertificate()"/>
  public IPayPalBuyGiftCertificateWidget BuyGiftCertificate() => new PayPalBuyGiftCertificateWidget();

  /// <inheritdoc cref="IPayPalWidgetCreator.BuyNow()"/>
  public IPayPalBuyNowWidget BuyNow() => new PayPalBuyNowWidget();

  /// <inheritdoc cref="IPayPalWidgetCreator.Donate()"/>
  public IPayPalDonateWidget Donate() => new PayPalDonateWidget();

  /// <inheritdoc cref="IPayPalWidgetCreator.Subscribe()"/>
  public IPayPalSubscribeWidget Subscribe() => new PayPalSubscribeWidget();
}