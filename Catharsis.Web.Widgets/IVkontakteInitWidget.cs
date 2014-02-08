using System;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Performs initialization of VKontakte JavaScript API. Initialization must be performed before render any VKontakte widgets on web pages.</para>
  ///   <para>Requires <see cref="WidgetsScripts.VKontakte"/> script to be included.</para>
  ///   <seealso cref="http://vk.com/dev/sites"/>
  /// </summary>
  public interface IVkontakteInitWidget : IHtmlWidget
  {
    /// <summary>
    ///   <para>Specifies API identifier of registered VKontakte application.</para>
    /// </summary>
    /// <param name="apiId">Application API ID.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="apiId"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="apiId"/> is <see cref="string.Empty"/> string.</exception>
    /// <remarks>This attribute is required.</remarks>
    IVkontakteInitWidget ApiId(string apiId);
  }
}