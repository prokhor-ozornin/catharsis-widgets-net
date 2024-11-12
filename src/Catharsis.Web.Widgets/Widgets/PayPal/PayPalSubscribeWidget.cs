namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IPayPalSubscribeWidget"/>
public class PayPalSubscribeWidget : HtmlWidget, IPayPalSubscribeWidget
{
  public IPayPalSubscribeWidget AsForm() => throw new NotImplementedException();

  public IPayPalSubscribeWidget AsUrl() => throw new NotImplementedException();

  /// <inheritdoc cref="IHtmlWidget.ToHtmlString()"/>
  public override string ToHtmlString() => throw new NotImplementedException();
}