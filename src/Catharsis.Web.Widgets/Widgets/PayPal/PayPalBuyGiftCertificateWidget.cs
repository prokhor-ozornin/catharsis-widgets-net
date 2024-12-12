namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IPayPalBuyGiftCertificateWidget"/>
public class PayPalBuyGiftCertificateWidget : WebWidget, IPayPalBuyGiftCertificateWidget
{
  /// <inheritdoc cref="IPayPalBuyGiftCertificateWidget.AsForm()"/>
  public IPayPalBuyGiftCertificateWidget AsForm() => throw new NotImplementedException();

  /// <inheritdoc cref="IPayPalBuyGiftCertificateWidget.AsUrl()"/>
  public IPayPalBuyGiftCertificateWidget AsUrl() => throw new NotImplementedException();

  /// <inheritdoc cref="IHtmlContent.ToHtml()"/>
  public override string ToHtml() => throw new NotImplementedException();
}