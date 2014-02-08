namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Renders Cackle comments widget for registered website.</para>
  ///   <para>Requires <see cref="WidgetsScriptsBundles.Cackle"/> scripts bundle to be included.</para>
  ///   <seealso cref="http://ru.cackle.me/help/widget-api"/>
  /// </summary>
  public interface ICackleCommentsWidget : IHtmlWidget
  {
    /// <summary>
    ///   <para>Specifies identifier of registered website in the "Cackle" comments system.</para>
    /// </summary>
    /// <param name="account">Identifier of website.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <remarks>This attribute is required.</remarks>
    ICackleCommentsWidget Account(string account);
  }
}