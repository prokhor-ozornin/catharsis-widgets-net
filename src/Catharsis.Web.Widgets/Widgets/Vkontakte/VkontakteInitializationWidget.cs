using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IVkontakteInitializationWidget"/>
public class VkontakteInitializationWidget : WebWidget, IVkontakteInitializationWidget
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string ApiIdProperty { get; set; }

  /// <inheritdoc cref="IVkontakteInitializationWidget.ApiId(string)"/>
  public virtual IVkontakteInitializationWidget ApiId(string id)
  {
    if (id is null) throw new ArgumentNullException(nameof(id));
    if (id.IsEmpty()) throw new ArgumentException(nameof(id));

    ApiIdProperty = id;

    return this;
  }

  /// <inheritdoc cref="IHtmlContent.ToHtml()"/>
  public override string ToHtml() => ApiIdProperty.IsUnset() ? string.Empty : 
    new TagBuilder("script")
      .Attribute("type", "text/javascript")
      .Html($"VK.init({{apiId:${ApiIdProperty}, onlyWidgets:true}});")
      .ToString();
}