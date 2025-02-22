using System.Text;
using Catharsis.Extensions;
using Catharsis.Web.Widgets.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IVkontakteAuthButtonWidget"/>
public class VkontakteAuthButtonWidget : WebWidget, IVkontakteAuthButtonWidget
{
  private string CallbackProperty { get; set; }
  private string ElementIdProperty { get; set; }
  private VkontakteAuthButtonType TypeProperty { get; set; } = VkontakteAuthButtonType.Standard;
  private string UrlProperty { get; set; }
  private string WidthProperty { get; set; }

  /// <inheritdoc cref="IVkontakteAuthButtonWidget.ElementId(string)"/>
  public IVkontakteAuthButtonWidget ElementId(string id)
  {
    if (id is null) throw new ArgumentNullException(nameof(id));
    if (id.IsEmpty()) throw new ArgumentException(nameof(id));

    ElementIdProperty = id;

    return this;
  }

  /// <inheritdoc cref="IVkontakteAuthButtonWidget.ElementId()"/>
  public string ElementId() => ElementIdProperty;

  /// <inheritdoc cref="IVkontakteAuthButtonWidget.Width(string)"/>
  public IVkontakteAuthButtonWidget Width(string width)
  {
    if (width is null) throw new ArgumentNullException(nameof(width));
    if (width.IsEmpty()) throw new ArgumentException(nameof(width));

    WidthProperty = width;

    return this;
  }

  /// <inheritdoc cref="IVkontakteAuthButtonWidget.Width()"/>
  public string Width() => WidthProperty;

  /// <inheritdoc cref="IVkontakteAuthButtonWidget.Url(string)"/>
  public IVkontakteAuthButtonWidget Url(string url)
  {
    if (url is null) throw new ArgumentNullException(nameof(url));
    if (url.IsEmpty()) throw new ArgumentException(nameof(url));

    UrlProperty = url;

    return this;
  }

  /// <inheritdoc cref="IVkontakteAuthButtonWidget.Url()"/>
  public string Url() => UrlProperty;

  /// <inheritdoc cref="IVkontakteAuthButtonWidget.Type(VkontakteAuthButtonType)"/>
  public IVkontakteAuthButtonWidget Type(VkontakteAuthButtonType type)
  {
    TypeProperty = type;
    return this;
  }

  /// <inheritdoc cref="IVkontakteAuthButtonWidget.Type()"/>
  public VkontakteAuthButtonType Type() => TypeProperty;

  /// <inheritdoc cref="IVkontakteAuthButtonWidget.Callback(string)"/>
  public IVkontakteAuthButtonWidget Callback(string callback)
  {
    if (callback is null) throw new ArgumentNullException(nameof(callback));
    if (callback.IsEmpty()) throw new ArgumentException(nameof(callback));

    CallbackProperty = callback;

    return this;
  }

  /// <inheritdoc cref="IVkontakteAuthButtonWidget.Callback()"/>
  public string Callback() => CallbackProperty;

  /// <inheritdoc cref="IHtmlContent.ToHtml()"/>
  public override string ToHtml()
  {
    if (Type() == VkontakteAuthButtonType.Dynamic && Callback().IsEmpty())
    {
      return string.Empty;
    }

    if (Type() == VkontakteAuthButtonType.Standard && Url().IsEmpty())
    {
      return string.Empty;
    }

    var id = ElementId() ?? "vk_auth";

    var config = new Dictionary<string, object>();
    
    if (!Callback().IsEmpty())
    {
      config["onAuth"] = Callback();
    }
    
    if (!Url().IsEmpty())
    {
      config["authUrl"] = Url();
    }
    
    if (!Width().IsEmpty())
    {
      config["width"] = Width();
    }

    return new StringBuilder()
      .Append(new TagBuilder("div").Attribute("id", id))
      .Append(new TagBuilder("script").Attribute("type", "text/javascript").Html($"\"VK.Widgets.Auth(\"${id}\", ${config.Json()})"))
      .ToString();
  }
}