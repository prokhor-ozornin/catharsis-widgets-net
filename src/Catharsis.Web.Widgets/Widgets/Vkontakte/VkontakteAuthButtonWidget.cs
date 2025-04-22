using System.Text;
using Catharsis.Extensions;
using Catharsis.Web.Widgets.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IVkontakteAuthButtonWidget"/>
public class VkontakteAuthButtonWidget : WebWidget, IVkontakteAuthButtonWidget
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string CallbackProperty { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string ElementIdProperty { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual VkontakteAuthButtonType TypeProperty { get; set; } = VkontakteAuthButtonType.Standard;

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string UrlProperty { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string WidthProperty { get; set; }

  /// <inheritdoc cref="IVkontakteAuthButtonWidget.ElementId(string)"/>
  public virtual IVkontakteAuthButtonWidget ElementId(string id)
  {
    if (id is null) throw new ArgumentNullException(nameof(id));
    if (id.IsEmpty()) throw new ArgumentException(nameof(id));

    ElementIdProperty = id;

    return this;
  }

  /// <inheritdoc cref="IVkontakteAuthButtonWidget.Width(string)"/>
  public virtual IVkontakteAuthButtonWidget Width(string width)
  {
    if (width is null) throw new ArgumentNullException(nameof(width));
    if (width.IsEmpty()) throw new ArgumentException(nameof(width));

    WidthProperty = width;

    return this;
  }

  /// <inheritdoc cref="IVkontakteAuthButtonWidget.Url(string)"/>
  public virtual IVkontakteAuthButtonWidget Url(string url)
  {
    if (url is null) throw new ArgumentNullException(nameof(url));
    if (url.IsEmpty()) throw new ArgumentException(nameof(url));

    UrlProperty = url;

    return this;
  }

  /// <inheritdoc cref="IVkontakteAuthButtonWidget.Type(VkontakteAuthButtonType)"/>
  public virtual IVkontakteAuthButtonWidget Type(VkontakteAuthButtonType type)
  {
    TypeProperty = type;
    return this;
  }

  /// <inheritdoc cref="IVkontakteAuthButtonWidget.Callback(string)"/>
  public virtual IVkontakteAuthButtonWidget Callback(string callback)
  {
    if (callback is null) throw new ArgumentNullException(nameof(callback));
    if (callback.IsEmpty()) throw new ArgumentException(nameof(callback));

    CallbackProperty = callback;

    return this;
  }

  /// <inheritdoc cref="IHtmlContent.ToHtml()"/>
  public override string ToHtml()
  {
    if (TypeProperty == VkontakteAuthButtonType.Dynamic && CallbackProperty.IsUnset())
    {
      return string.Empty;
    }

    if (TypeProperty == VkontakteAuthButtonType.Standard && UrlProperty.IsUnset())
    {
      return string.Empty;
    }

    var id = ElementIdProperty ?? "vk_auth";

    var config = new Dictionary<string, object>();
    
    if (!CallbackProperty.IsUnset())
    {
      config["onAuth"] = CallbackProperty;
    }
    
    if (!UrlProperty.IsUnset())
    {
      config["authUrl"] = UrlProperty;
    }
    
    if (!WidthProperty.IsUnset())
    {
      config["width"] = WidthProperty;
    }

    return new StringBuilder()
      .Append(new TagBuilder("div").Attribute("id", id))
      .Append(new TagBuilder("script").Attribute("type", "text/javascript").Html($"\"VK.Widgets.Auth(\"${id}\", ${config.Json()})"))
      .ToString();
  }
}