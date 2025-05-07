using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IVkontakteInitializationWidget"/>
public class VkontakteInitializationWidget : WebWidget, IVkontakteInitializationWidget
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string ApiIdValue { get; set; }

  /// <inheritdoc cref="IVkontakteInitializationWidget.ApiId(string)"/>
  public virtual IVkontakteInitializationWidget ApiId(string id)
  {
    if (id is null) throw new ArgumentNullException(nameof(id));
    if (id.IsEmpty()) throw new ArgumentException(nameof(id));

    ApiIdValue = id;

    return this;
  }

  /// <inheritdoc cref="ICloneable.Clone()"/>
  public override object Clone() => new VkontakteInitializationWidget
  {
    ApiIdValue = ApiIdValue
  };

  /// <inheritdoc cref="IWebWidget.ToHtml()"/>
  public override string ToHtml() => ApiIdValue.IsUnset() ? string.Empty : 
    new TagBuilder("script")
      .Attribute("type", "text/javascript")
      .Html($"VK.init({{apiId:${ApiIdValue}, onlyWidgets:true}});")
      .ToString();
}