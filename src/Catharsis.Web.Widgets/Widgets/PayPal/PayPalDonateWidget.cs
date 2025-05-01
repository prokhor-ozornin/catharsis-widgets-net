namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IPayPalDonateWidget"/>
public class PayPalDonateWidget : WebWidget, IPayPalDonateWidget
{
  /// <inheritdoc cref="IPayPalDonateWidget.AsForm()"/>
  public virtual IPayPalDonateWidget AsForm() => throw new NotImplementedException();

  /// <inheritdoc cref="IPayPalDonateWidget.AsUrl()"/>
  public virtual IPayPalDonateWidget AsUrl() => throw new NotImplementedException();

  public override object Clone() => new PayPalDonateWidget { };
  
  /// <inheritdoc cref="IWebWidget.ToHtml()"/>
  public override string ToHtml() => throw new NotImplementedException();
}