using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IVkontakteInitializationWidget"/>
public class VkontakteInitializationWidget : WebWidget, IVkontakteInitializationWidget
{
  private string ApiIdProperty { get; set; }

  /// <inheritdoc cref="IVkontakteInitializationWidget.ApiId(string)"/>
  public IVkontakteInitializationWidget ApiId(string id)
  {
    if (id is null) throw new ArgumentNullException(nameof(id));
    if (id.IsEmpty()) throw new ArgumentException(nameof(id));

    ApiIdProperty = id;

    return this;
  }

  /// <inheritdoc cref="IVkontakteInitializationWidget.ApiId()"/>
  public string ApiId() => ApiIdProperty;

  /// <inheritdoc cref="IHtmlContent.ToHtml()"/>
  public override string ToHtml() => ApiId().IsEmpty() ? string.Empty : 
    new TagBuilder("script")
      .Attribute("type", "text/javascript")
      .Html($"VK.init({{apiId:${ApiId()}, onlyWidgets:true}});")
      .ToString();
}