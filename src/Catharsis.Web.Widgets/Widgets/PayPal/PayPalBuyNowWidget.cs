namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IPayPalBuyNowWidget"/>
public class PayPalBuyNowWidget : WebWidget, IPayPalBuyNowWidget
{
  /// <inheritdoc cref="IPayPalBuyNowWidget.AsForm()"/>
  public IPayPalBuyNowWidget AsForm() => throw new NotImplementedException();

  /// <inheritdoc cref="IPayPalBuyNowWidget.AsUrl()"/>
  public IPayPalBuyNowWidget AsUrl() => throw new NotImplementedException();

  /// <inheritdoc cref="IWebWidget.ToHtml()"/>
  public override string ToHtml() => throw new NotImplementedException();
}