namespace Catharsis.Web.Widgets;

/// <summary>
///   <para></para>
/// </summary>
public interface IPayPalDonateWidget : IWebWidget
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <returns></returns>
  IPayPalDonateWidget AsForm();

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <returns></returns>
  IPayPalDonateWidget AsUrl();
}