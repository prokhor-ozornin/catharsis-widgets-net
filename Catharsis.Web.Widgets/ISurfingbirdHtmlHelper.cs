namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Helper factory class for managing Surfingbird widgets.</para>
  /// </summary>
  public interface ISurfingbirdHtmlHelper
  {
    /// <summary>
    ///   <para>Creates new Surfingbird "Surf" button widget.</para>
    /// </summary>
    /// <returns>Initialized widget with default options.</returns>
    ISurfingbirdSurfButtonWidget Surf();
  }
}