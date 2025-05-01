namespace Catharsis.Web.Widgets;

/// <summary>
///   <para></para>
/// </summary>
public interface IWebWidget : ICloneable
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <returns></returns>
  string ToHtml();
}