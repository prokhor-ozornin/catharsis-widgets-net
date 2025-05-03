namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IPayPalBuyNowWidget"/>
public class PayPalBuyNowWidget : WebWidget, IPayPalBuyNowWidget
{
  /// <inheritdoc cref="IPayPalBuyNowWidget.AsForm()"/>
  public virtual IPayPalBuyNowWidget AsForm() => throw new NotImplementedException();

  /// <inheritdoc cref="IPayPalBuyNowWidget.AsUrl()"/>
  public virtual IPayPalBuyNowWidget AsUrl() => throw new NotImplementedException();

  /// <inheritdoc cref="ICloneable.Clone()"/>
  public override object Clone() => new PayPalBuyNowWidget
  {
  };

  /// <inheritdoc cref="IWebWidget.ToHtml()"/>
  public override string ToHtml() => throw new NotImplementedException();
}