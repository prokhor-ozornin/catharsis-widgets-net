namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IPayPalBuyNowWidget"/>
public class PayPalBuyNowWidget : WebWidget, IPayPalBuyNowWidget
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <returns></returns>
  public IPayPalBuyNowWidget AsForm() => throw new NotImplementedException();

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <returns></returns>
  public IPayPalBuyNowWidget AsUrl() => throw new NotImplementedException();

  /// <inheritdoc cref="IWebWidget.ToHtml"/>
  public override string ToHtml() => throw new NotImplementedException();
}