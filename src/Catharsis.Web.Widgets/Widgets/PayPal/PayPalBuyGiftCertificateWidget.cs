namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IPayPalBuyGiftCertificateWidget"/>
public class PayPalBuyGiftCertificateWidget : WebWidget, IPayPalBuyGiftCertificateWidget
{
  /// <inheritdoc cref="IPayPalBuyGiftCertificateWidget.AsForm()"/>
  public virtual IPayPalBuyGiftCertificateWidget AsForm() => throw new NotImplementedException();

  /// <inheritdoc cref="IPayPalBuyGiftCertificateWidget.AsUrl()"/>
  public virtual IPayPalBuyGiftCertificateWidget AsUrl() => throw new NotImplementedException();

  /// <inheritdoc cref="ICloneable.Clone()"/>
  public override object Clone() => new PayPalBuyGiftCertificateWidget
  {
  };

  /// <inheritdoc cref="IWebWidget.ToHtml()"/>
  public override string ToHtml() => throw new NotImplementedException();
}