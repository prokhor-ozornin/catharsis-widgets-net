namespace Catharsis.Web.Widgets;

/// <summary>
///   <para></para>
/// </summary>
public interface IPayPalBuyNowWidget : IWebWidget
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <returns></returns>
  IPayPalBuyNowWidget AsForm();

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <returns></returns>
  IPayPalBuyNowWidget AsUrl();
}