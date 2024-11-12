namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IPayPalBuyGiftCertificateWidget"/>
public class PayPalBuyGiftCertificateWidget : HtmlWidget, IPayPalBuyGiftCertificateWidget
{
  public IPayPalBuyGiftCertificateWidget AsForm()
  {
    throw new NotImplementedException();
  }

  public IPayPalBuyGiftCertificateWidget AsUrl()
  {
    throw new NotImplementedException();
  }

  /// <inheritdoc cref="IHtmlWidget.ToHtmlString()"/>
  public override string ToHtmlString()
  {
    throw new NotImplementedException();
  }
}