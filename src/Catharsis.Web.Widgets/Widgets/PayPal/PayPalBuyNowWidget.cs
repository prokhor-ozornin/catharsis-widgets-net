namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IPayPalBuyNowWidget"/>
public class PayPalBuyNowWidget : HtmlWidget, IPayPalBuyNowWidget
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

  /// <inheritdoc cref="IHtmlWidget.ToHtmlString()"/>
  public override string ToHtmlString() => throw new NotImplementedException();
}