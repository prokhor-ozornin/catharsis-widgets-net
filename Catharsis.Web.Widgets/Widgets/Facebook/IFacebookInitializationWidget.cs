using System;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Performs initialization of Facebook JavaScript API. Initialization must be performed before rendering Facebook widgets on the page.</para>
  /// </summary>
  /// <seealso cref="https://developers.facebook.com/docs/javascript"/>
  public interface IFacebookInitializationWidget : IHtmlWidget
  {
    /// <summary>
    ///   <para>Identifier of registered Facebook application.</para>
    /// </summary>
    /// <param name="appId">Identifier of Facebook application.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="appId"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="appId"/> is <see cref="string.Empty"/> string.</exception>
    /// <remarks>This attribute is required.</remarks>
    IFacebookInitializationWidget AppId(string appId);
  }
}