namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IPayPalWidgetsCreator"/>
public class PayPalWidgetsCreator : IPayPalWidgetsCreator
{
  /// <inheritdoc cref="IPayPalWidgetsCreator.BuyGiftCertificate()"/>
  public virtual IPayPalBuyGiftCertificateWidget BuyGiftCertificate() => new PayPalBuyGiftCertificateWidget();

  /// <inheritdoc cref="IPayPalWidgetsCreator.BuyNow()"/>
  public virtual IPayPalBuyNowWidget BuyNow() => new PayPalBuyNowWidget();

  /// <inheritdoc cref="IPayPalWidgetsCreator.Donate()"/>
  public virtual IPayPalDonateWidget Donate() => new PayPalDonateWidget();

  /// <inheritdoc cref="IPayPalWidgetsCreator.Subscribe()"/>
  public virtual IPayPalSubscribeWidget Subscribe() => new PayPalSubscribeWidget();
}