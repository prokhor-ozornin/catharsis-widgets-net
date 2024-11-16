namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IPayPalDonateWidget"/>
public class PayPalDonateWidget : WebWidget, IPayPalDonateWidget
{
  /// <inheritdoc cref="IPayPalDonateWidget.AsForm()"/>
  public IPayPalDonateWidget AsForm() => throw new NotImplementedException();

  /// <inheritdoc cref="IPayPalDonateWidget.AsUrl()"/>
  public IPayPalDonateWidget AsUrl() => throw new NotImplementedException();

  /// <inheritdoc cref="IWebWidget.ToHtml()"/>
  public override string ToHtml() => throw new NotImplementedException();
}