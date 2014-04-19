using System;
using System.Web.Mvc;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Performs initialization of VKontakte JavaScript API. Initialization must be performed before render any VKontakte widgets on web pages.</para>
  ///   <para>Requires <see cref="WidgetsScripts.VKontakte"/> script to be included.</para>
  /// </summary>
  /// <seealso cref="http://vk.com/dev/sites"/>
  public class VkontakteInitWidget : HtmlWidgetBase, IVkontakteInitWidget
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
    public IVkontakteInitWidget ApiId(string apiId)
    {
      Assertion.NotEmpty(apiId);

      this.apiId = apiId;
      return this;
    }

    /// <summary>
    ///   <para>Returns HTML markup text of widget.</para>
    /// </summary>
    /// <returns>Widget's HTML markup.</returns>
    public override string ToHtmlString()
    {
      if (this.apiId.IsEmpty())
      {
        return string.Empty;
      }

      return new TagBuilder("script")
        .Attribute("type", "text/javascript")
        .InnerHtml("VK.init({{apiId:{0}, onlyWidgets:true}});".FormatSelf(this.apiId))
        .ToString();
    }
  }
}