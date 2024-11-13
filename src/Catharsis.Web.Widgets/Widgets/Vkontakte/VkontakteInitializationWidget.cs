using System.Web.Mvc;
using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IVkontakteInitializationWidget"/>
public class VkontakteInitializationWidget : WebWidget, IVkontakteInitializationWidget
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
    if (apiId is null) throw new ArgumentNullException(nameof(apiId));
    if (apiId.IsEmpty()) throw new ArgumentException(nameof(apiId));

    this.apiId = apiId;

    return this;
  }

  /// <summary>
  ///   <para>API identifier of registered VKontakte application.</para>
  /// </summary>
  /// <returns>Application API ID.</returns>
  public string ApiId() => apiId;

  /// <inheritdoc cref="IWebWidget.ToHtml()"/>
  public override string ToHtml()
  {
    if (ApiId().IsEmpty())
    {
      return string.Empty;
    }

    return new TagBuilder("script")
      .Attribute("type", "text/javascript")
      .InnerHtml($"VK.init({{apiId:${ApiId()}, onlyWidgets:true}});")
      .ToString();
  }
}