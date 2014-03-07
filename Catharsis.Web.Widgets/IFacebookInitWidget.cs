using System;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Performs initialization of Facebook JavaScript API. Initialization must be performed before rendering Facebook widgets on the page.</para>
  ///   <para>Requires <see cref="WidgetsScriptsBundles.Facebook"/> scripts bundle to be included.</para>
  /// </summary>
  /// <seealso cref="https://developers.facebook.com/docs/javascript"/>
  public interface IFacebookInitWidget : IHtmlWidget
  {
    /// <summary>
    ///   <para>Identifier of registered Facebook application.</para>
    /// </summary>
    /// <param name="id">Identifier of Facebook application.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="id"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="id"/> is <see cref="string.Empty"/> string.</exception>
    /// <remarks>This attribute is required.</remarks>
    IFacebookInitWidget AppId(string id);
  }
}