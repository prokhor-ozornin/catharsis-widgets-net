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
  protected virtual string CallbackValue { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string ElementIdValue { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual VkontakteAuthButtonType TypeValue { get; set; } = VkontakteAuthButtonType.Standard;

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string UrlValue { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string WidthValue { get; set; }

  /// <inheritdoc cref="IVkontakteAuthButtonWidget.ElementId(string)"/>
  public virtual IVkontakteAuthButtonWidget ElementId(string id)
  {
    if (id is null) throw new ArgumentNullException(nameof(id));
    if (id.IsEmpty()) throw new ArgumentException(nameof(id));

    ElementIdValue = id;

    return this;
  }

  /// <inheritdoc cref="IVkontakteAuthButtonWidget.Width(string)"/>
  public virtual IVkontakteAuthButtonWidget Width(string width)
  {
    if (width is null) throw new ArgumentNullException(nameof(width));
    if (width.IsEmpty()) throw new ArgumentException(nameof(width));

    WidthValue = width;

    return this;
  }

  /// <inheritdoc cref="IVkontakteAuthButtonWidget.Url(string)"/>
  public virtual IVkontakteAuthButtonWidget Url(string url)
  {
    if (url is null) throw new ArgumentNullException(nameof(url));
    if (url.IsEmpty()) throw new ArgumentException(nameof(url));

    UrlValue = url;

    return this;
  }

  /// <inheritdoc cref="IVkontakteAuthButtonWidget.Type(VkontakteAuthButtonType)"/>
  public virtual IVkontakteAuthButtonWidget Type(VkontakteAuthButtonType type)
  {
    TypeValue = type;
    return this;
  }

  /// <inheritdoc cref="IVkontakteAuthButtonWidget.Callback(string)"/>
  public virtual IVkontakteAuthButtonWidget Callback(string callback)
  {
    if (callback is null) throw new ArgumentNullException(nameof(callback));
    if (callback.IsEmpty()) throw new ArgumentException(nameof(callback));

    CallbackValue = callback;

    return this;
  }

  /// <inheritdoc cref="ICloneable.Clone()"/>
  public override object Clone() => new VkontakteAuthButtonWidget
  {
    CallbackValue = CallbackValue,
    ElementIdValue = ElementIdValue,
    TypeValue = TypeValue,
    UrlValue = UrlValue,
    WidthValue = WidthValue
  };

  /// <inheritdoc cref="IWebWidget.ToHtml()"/>
  public override string ToHtml()
  {
    if (TypeValue == VkontakteAuthButtonType.Dynamic && CallbackValue.IsUnset())
    {
      return string.Empty;
    }

    if (TypeValue == VkontakteAuthButtonType.Standard && UrlValue.IsUnset())
    {
      return string.Empty;
    }

    var id = ElementIdValue ?? "vk_auth";

    var config = new Dictionary<string, object>();
    
    if (!CallbackValue.IsUnset())
    {
      config["onAuth"] = CallbackValue;
    }
    
    if (!UrlValue.IsUnset())
    {
      config["authUrl"] = UrlValue;
    }
    
    if (!WidthValue.IsUnset())
    {
      config["width"] = WidthValue;
    }

    return new StringBuilder()
      .Append(new TagBuilder("div").Attribute("id", id))
      .Append(new TagBuilder("script").Attribute("type", "text/javascript").Html($"\"VK.Widgets.Auth(\"${id}\", ${config.Json()})"))
      .ToString();
  }
}