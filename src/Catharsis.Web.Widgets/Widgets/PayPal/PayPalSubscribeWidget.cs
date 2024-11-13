namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IPayPalSubscribeWidget"/>
public class PayPalSubscribeWidget : WebWidget, IPayPalSubscribeWidget
{
  public IPayPalSubscribeWidget AsForm() => throw new NotImplementedException();

  public IPayPalSubscribeWidget AsUrl() => throw new NotImplementedException();

  /// <inheritdoc cref="IWebWidget.ToHtml()"/>
  public override string ToHtml() => throw new NotImplementedException();
}