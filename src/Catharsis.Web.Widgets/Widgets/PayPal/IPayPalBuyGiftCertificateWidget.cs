namespace Catharsis.Web.Widgets;

/// <summary>
///   <para></para>
/// </summary>
public interface IPayPalBuyGiftCertificateWidget : IWebWidget
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <returns></returns>
  IPayPalBuyGiftCertificateWidget AsForm();

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <returns></returns>
  IPayPalBuyGiftCertificateWidget AsUrl();
}