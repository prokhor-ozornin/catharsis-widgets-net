using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IVkontakteInitializationWidget"/>
public class VkontakteInitializationWidget : WebWidget, IVkontakteInitializationWidget
{
  private string apiId;

  /// <inheritdoc cref="IVkontakteInitializationWidget.ApiId(string)"/>
  public IVkontakteInitializationWidget ApiId(string id)
  {
    if (id is null) throw new ArgumentNullException(nameof(id));
    if (id.IsEmpty()) throw new ArgumentException(nameof(id));

    this.apiId = id;

    return this;
  }

  /// <inheritdoc cref="IVkontakteInitializationWidget.ApiId()"/>
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