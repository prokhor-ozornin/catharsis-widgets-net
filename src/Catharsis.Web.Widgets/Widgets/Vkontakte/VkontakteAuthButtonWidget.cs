using System.Text;
using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IVkontakteAuthButtonWidget"/>
public class VkontakteAuthButtonWidget : WebWidget, IVkontakteAuthButtonWidget
{
  private string callback;
  private string elementId;
  private VkontakteAuthButtonType type = VkontakteAuthButtonType.Standard;
  private string url;
  private string width;

  /// <inheritdoc cref="IVkontakteAuthButtonWidget.ElementId(string)"/>
  public IVkontakteAuthButtonWidget ElementId(string id)
  {
    if (id is null) throw new ArgumentNullException(nameof(id));
    if (id.IsEmpty()) throw new ArgumentException(nameof(id));

    elementId = id;

    return this;
  }

  /// <inheritdoc cref="IVkontakteAuthButtonWidget.ElementId()"/>
  public string ElementId() => elementId;

  /// <inheritdoc cref="IVkontakteAuthButtonWidget.Width(string)"/>
  public IVkontakteAuthButtonWidget Width(string width)
  {
    if (width is null) throw new ArgumentNullException(nameof(width));
    if (width.IsEmpty()) throw new ArgumentException(nameof(width));

    this.width = width;

    return this;
  }

  /// <inheritdoc cref="IVkontakteAuthButtonWidget.Width()"/>
  public string Width() => width;

  /// <inheritdoc cref="IVkontakteAuthButtonWidget.Url(string)"/>
  public IVkontakteAuthButtonWidget Url(string url)
  {
    if (url is null) throw new ArgumentNullException(nameof(url));
    if (url.IsEmpty()) throw new ArgumentException(nameof(url));

    this.url = url;

    return this;
  }

  /// <inheritdoc cref="IVkontakteAuthButtonWidget.Url()"/>
  public string Url() => url;

  /// <inheritdoc cref="IVkontakteAuthButtonWidget.Type(VkontakteAuthButtonType)"/>
  public IVkontakteAuthButtonWidget Type(VkontakteAuthButtonType type)
  {
    this.type = type;
    return this;
  }

  /// <inheritdoc cref="IVkontakteAuthButtonWidget.Type()"/>
  public VkontakteAuthButtonType Type() => type;

  /// <inheritdoc cref="IVkontakteAuthButtonWidget.Callback(string)"/>
  public IVkontakteAuthButtonWidget Callback(string callback)
  {
    if (callback is null) throw new ArgumentNullException(nameof(callback));
    if (callback.IsEmpty()) throw new ArgumentException(nameof(callback));

    this.callback = callback;

    return this;
  }

  /// <inheritdoc cref="IVkontakteAuthButtonWidget.Callback()"/>
  public string Callback() => callback;

  /// <inheritdoc cref="IWebWidget.ToHtml()"/>
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

    var elementId = ElementId() ?? "vk_auth";

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
      .Append(new TagBuilder("div").Attribute("id", elementId))
      .Append(new TagBuilder("script").Attribute("type", "text/javascript").Html($@"VK.Widgets.Auth(""${elementId}"", ${config.Json()})"))
      .ToString();
  }
}