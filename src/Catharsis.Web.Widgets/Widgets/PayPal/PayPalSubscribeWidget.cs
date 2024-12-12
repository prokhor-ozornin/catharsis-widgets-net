namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IPayPalSubscribeWidget"/>
public class PayPalSubscribeWidget : WebWidget, IPayPalSubscribeWidget
{
  /// <inheritdoc cref="IPayPalSubscribeWidget.AsForm()"/>
  public IPayPalSubscribeWidget AsForm() => throw new NotImplementedException();

  /// <inheritdoc cref="IPayPalSubscribeWidget.AsUrl()"/>
  public IPayPalSubscribeWidget AsUrl() => throw new NotImplementedException();

  /// <inheritdoc cref="IHtmlContent.ToHtml()"/>
  public override string ToHtml() => throw new NotImplementedException();
}