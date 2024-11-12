namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IPayPalDonateWidget"/>
public class PayPalDonateWidget : HtmlWidget, IPayPalDonateWidget
{
  public IPayPalDonateWidget AsForm() => throw new NotImplementedException();

  public IPayPalDonateWidget AsUrl() => throw new NotImplementedException();

  /// <inheritdoc cref="IHtmlWidget.ToHtmlString()"/>
  public override string ToHtmlString() => throw new NotImplementedException();
}