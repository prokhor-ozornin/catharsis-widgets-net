namespace Catharsis.Web.Widgets;

/// <summary>
///   <para></para>
/// </summary>
public interface IPayPalSubscribeWidget : IWebWidget
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <returns></returns>
  IPayPalSubscribeWidget AsForm();

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <returns></returns>
  IPayPalSubscribeWidget AsUrl();
}