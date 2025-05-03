namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IPayPalSubscribeWidget"/>
public class PayPalSubscribeWidget : WebWidget, IPayPalSubscribeWidget
{
  /// <inheritdoc cref="IPayPalSubscribeWidget.AsForm()"/>
  public virtual IPayPalSubscribeWidget AsForm() => throw new NotImplementedException();

  /// <inheritdoc cref="IPayPalSubscribeWidget.AsUrl()"/>
  public virtual IPayPalSubscribeWidget AsUrl() => throw new NotImplementedException();

  /// <inheritdoc cref="ICloneable.Clone()"/>
  public override object Clone() => new PayPalSubscribeWidget
  {
  };

  /// <inheritdoc cref="IWebWidget.ToHtml()"/>
  public override string ToHtml() => throw new NotImplementedException();
}