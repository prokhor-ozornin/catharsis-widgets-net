using System.Text;
using Catharsis.Extensions;
using Catharsis.Web.Widgets.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IVkontaktePollWidget"/>
public class VkontaktePollWidget : WebWidget, IVkontaktePollWidget
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string ElementIdProperty { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string IdProperty { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string UrlProperty { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string WidthProperty { get; set; }

  /// <inheritdoc cref="IVkontaktePollWidget.Id(string)"/>
  public virtual IVkontaktePollWidget Id(string id)
  {
    if (id is null) throw new ArgumentNullException(nameof(id));
    if (id.IsEmpty()) throw new ArgumentException(nameof(id));

    IdProperty = id;

    return this;
  }

  /// <inheritdoc cref="IVkontaktePollWidget.ElementId(string)"/>
  public virtual IVkontaktePollWidget ElementId(string id)
  {
    if (id is null) throw new ArgumentNullException(nameof(id));
    if (id.IsEmpty()) throw new ArgumentException(nameof(id));

    ElementIdProperty = id;
      
    return this;
  }

  /// <inheritdoc cref="IVkontaktePollWidget.Width(string)"/>
  public virtual IVkontaktePollWidget Width(string width)
  {
    if (width is null) throw new ArgumentNullException(nameof(width));
    if (width.IsEmpty()) throw new ArgumentException(nameof(width));

    WidthProperty = width;

    return this;
  }

  /// <inheritdoc cref="IVkontaktePollWidget.Url(string)"/>
  public virtual IVkontaktePollWidget Url(string url)
  {
    if (url is null) throw new ArgumentNullException(nameof(url));
    if (url.IsEmpty()) throw new ArgumentException(nameof(url));

    UrlProperty = url;

    return this;
  }

  public override object Clone() => new VkontaktePollWidget { };

  /// <inheritdoc cref="IWebWidget.ToHtml()"/>
  public override string ToHtml()
  {
    if (IdProperty.IsUnset())
    {
      return string.Empty;
    }

    var config = new Dictionary<string, object>();
    
    if (!UrlProperty.IsUnset())
    {
      config["pageUrl"] = UrlProperty;
    }

    if (!WidthProperty.IsUnset())
    {
      config["width"] = WidthProperty;
    }

    var id = ElementIdProperty ?? $"vk_poll_{IdProperty}";
      
    return new StringBuilder()
      .Append(new TagBuilder("div").Attribute("id", id))
      .Append(new TagBuilder("script").Attribute("type", "text/javascript").Html($"\"VK.Widgets.Poll(\"{id}\", {config.Json()}, \"{IdProperty}\"));")
      ).ToString();
  }
}