namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IPayPalDonateWidget"/>
public class PayPalDonateWidget : WebWidget, IPayPalDonateWidget
{
  public IPayPalDonateWidget AsForm() => throw new NotImplementedException();

  public IPayPalDonateWidget AsUrl() => throw new NotImplementedException();

  /// <inheritdoc cref="IWebWidget.ToHtml"/>
  public override string ToHtml() => throw new NotImplementedException();
}