using System;
using System.Web.Mvc;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Performs initialization of VKontakte JavaScript API. Initialization must be performed before render any VKontakte widgets on web pages.</para>
  ///   <para>Requires Vkontakte scripts bundle to be included.</para>
  /// </summary>
  /// <seealso cref="http://vk.com/dev/sites"/>
  /// <seealso cref="IWidgetsScriptsRendererExtensions.Vkontakte(IWidgetsScriptsRenderer)"/>
  public class VkontakteInitializationWidget : HtmlWidget, IVkontakteInitializationWidget
  {
    private string apiId;

    /// <summary>
    ///   <para>API identifier of registered VKontakte application.</para>
    /// </summary>
    /// <param name="apiId">Application API ID.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="apiId"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="apiId"/> is <see cref="string.Empty"/> string.</exception>
    /// <remarks>This attribute is required.</remarks>
    public IVkontakteInitializationWidget ApiId(string apiId)
    {
      Assertion.NotEmpty(apiId);

      this.apiId = apiId;
      return this;
    }

    /// <summary>
    ///   <para>API identifier of registered VKontakte application.</para>
    /// </summary>
    /// <returns>Application API ID.</returns>
    public string ApiId()
    {
      return this.apiId;
    }

    /// <summary>
    ///   <para>Returns HTML markup text of widget.</para>
    /// </summary>
    /// <returns>Widget's HTML markup.</returns>
    public override string ToHtmlString()
    {
      if (this.ApiId().IsEmpty())
      {
        return string.Empty;
      }

      return new TagBuilder("script")
        .Attribute("type", "text/javascript")
        .InnerHtml("VK.init({{apiId:{0}, onlyWidgets:true}});".FormatSelf(this.ApiId()))
        .ToString();
    }
  }
}