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
  protected virtual string ElementIdValue { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string IdValue { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string UrlValue { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string WidthValue { get; set; }

  /// <inheritdoc cref="IVkontaktePollWidget.Id(string)"/>
  public virtual IVkontaktePollWidget Id(string id)
  {
    if (id is null) throw new ArgumentNullException(nameof(id));
    if (id.IsEmpty()) throw new ArgumentException(nameof(id));

    IdValue = id;

    return this;
  }

  /// <inheritdoc cref="IVkontaktePollWidget.ElementId(string)"/>
  public virtual IVkontaktePollWidget ElementId(string id)
  {
    if (id is null) throw new ArgumentNullException(nameof(id));
    if (id.IsEmpty()) throw new ArgumentException(nameof(id));

    ElementIdValue = id;
      
    return this;
  }

  /// <inheritdoc cref="IVkontaktePollWidget.Width(string)"/>
  public virtual IVkontaktePollWidget Width(string width)
  {
    if (width is null) throw new ArgumentNullException(nameof(width));
    if (width.IsEmpty()) throw new ArgumentException(nameof(width));

    WidthValue = width;

    return this;
  }

  /// <inheritdoc cref="IVkontaktePollWidget.Url(string)"/>
  public virtual IVkontaktePollWidget Url(string url)
  {
    if (url is null) throw new ArgumentNullException(nameof(url));
    if (url.IsEmpty()) throw new ArgumentException(nameof(url));

    UrlValue = url;

    return this;
  }

  /// <inheritdoc cref="ICloneable.Clone()"/>
  public override object Clone() => new VkontaktePollWidget
  {
    ElementIdValue = ElementIdValue,
    IdValue = IdValue,
    UrlValue = UrlValue,
    WidthValue = WidthValue
  };

  /// <inheritdoc cref="IWebWidget.ToHtml()"/>
  public override string ToHtml()
  {
    if (IdValue.IsUnset())
    {
      return string.Empty;
    }

    var config = new Dictionary<string, object>();
    
    if (!UrlValue.IsUnset())
    {
      config["pageUrl"] = UrlValue;
    }

    if (!WidthValue.IsUnset())
    {
      config["width"] = WidthValue;
    }

    var id = ElementIdValue ?? $"vk_poll_{IdValue}";
      
    return new StringBuilder()
      .Append(new TagBuilder("div").Attribute("id", id))
      .Append(new TagBuilder("script").Attribute("type", "text/javascript").Html($"\"VK.Widgets.Poll(\"{id}\", {config.Json()}, \"{IdValue}\"));")
      ).ToString();
  }
}