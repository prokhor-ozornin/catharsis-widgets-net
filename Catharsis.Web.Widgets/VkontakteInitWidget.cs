using System;
using System.IO;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Performs initialization of VKontakte JavaScript API. Initialization must be performed before render any VKontakte widgets on web pages.</para>
  ///   <para>Requires <see cref="WidgetsScripts.VKontakte"/> script to be included.</para>
  ///   <seealso cref="http://vk.com/dev/sites"/>
  /// </summary>
  public sealed class VkontakteInitWidget : HtmlWidgetBase<IVkontakteInitWidget>, IVkontakteInitWidget
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
    ///   <para>Generates and writes HTML markup of widget, using specified text writer.</para>
    /// </summary>
    /// <param name="writer">Text writer to use as output destination.</param>
    public override void Write(TextWriter writer)
    {
      Assertion.NotNull(writer);

      if (this.apiId.IsEmpty())
      {
        return;
      }

      writer.Write(this.JavaScript("VK.init({{apiId:{0}, onlyWidgets:true}});".FormatSelf(this.apiId)));
    }
  }
}