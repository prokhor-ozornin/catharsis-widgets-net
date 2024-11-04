namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <typeparam name="T"></typeparam>
  public interface IPayPalWidget<T> : IHtmlWidget where T : IPayPalWidget<T>
  {
    /// <summary>
    ///   <para></para>
    /// </summary>
    /// <returns></returns>
    T AsForm();

    /// <summary>
    ///   <para></para>
    /// </summary>
    /// <returns></returns>
    T AsUrl();
  }
}