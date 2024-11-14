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

  /// <summary>
  ///   <para>Identifier of HTML container for the widget.</para>
  /// </summary>
  /// <param name="id">HTML element's identifier.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="id"/> is a <c>null</c> reference.</exception>
  /// <exception cref="ArgumentException">If <paramref name="id"/> is <see cref="string.Empty"/> string.</exception>
  public IVkontakteAuthButtonWidget ElementId(string id)
  {
    if (id is null) throw new ArgumentNullException(nameof(id));
    if (id.IsEmpty()) throw new ArgumentException(nameof(id));

    elementId = id;

    return this;
  }

  /// <summary>
  ///   <para>Identifier of HTML container for the widget.</para>
  /// </summary>
  /// <returns>HTML element's identifier.</returns>
  public string ElementId() => elementId;

  /// <summary>
  ///   <para>Horizontal width of button.</para>
  /// </summary>
  /// <param name="width">Width of button.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="width"/> is a <c>null</c> reference.</exception>
  /// <exception cref="ArgumentException">If <paramref name="width"/> is <see cref="string.Empty"/> string.</exception>
  public IVkontakteAuthButtonWidget Width(string width)
  {
    if (width is null) throw new ArgumentNullException(nameof(width));
    if (width.IsEmpty()) throw new ArgumentException(nameof(width));

    this.width = width;

    return this;
  }

  /// <summary>
  ///   <para>Horizontal width of button.</para>
  /// </summary>
  /// <returns>Width of button.</returns>
  public string Width() => width;

  /// <summary>
  ///   <para>URL address of web page to be redirected to, if using standard mode.</para>
  /// </summary>
  /// <param name="url">Target URL web page.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="url"/> is <see cref="string.Empty"/> string.</exception>
  /// <exception cref="ArgumentException">If <paramref name="url"/> is <see cref="string.Empty"/> string.</exception>
  public IVkontakteAuthButtonWidget Url(string url)
  {
    if (url is null) throw new ArgumentNullException(nameof(url));
    if (url.IsEmpty()) throw new ArgumentException(nameof(url));

    this.url = url;

    return this;
  }

  /// <summary>
  ///   <para>URL address of web page to be redirected to, if using standard mode.</para>
  /// </summary>
  /// <returns>Target URL web page.</returns>
  public string Url() => url;

  /// <summary>
  ///   <para>Type of authentication mode to use.</para>
  /// </summary>
  /// <param name="type">Authentication mode.</param>
  /// <returns>Reference to the current widget.</returns>
  public IVkontakteAuthButtonWidget Type(VkontakteAuthButtonType type)
  {
    this.type = type;
    return this;
  }

  /// <summary>
  ///   <para>Type of authentication mode to use.</para>
  /// </summary>
  /// <returns>Authentication mode.</returns>
  public VkontakteAuthButtonType Type() => type;

  /// <summary>
  ///   <para>Name of JavaScript function to be called after successful authentication, if using dynamic mode.</para>
  /// </summary>
  /// <param name="callback"></param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="callback"/> is a <c>null</c> reference.</exception>
  /// <exception cref="ArgumentException">If <paramref name="callback"/> is <see cref="string.Empty"/> string.</exception>
  public IVkontakteAuthButtonWidget Callback(string callback)
  {
    if (callback is null) throw new ArgumentNullException(nameof(callback));
    if (callback.IsEmpty()) throw new ArgumentException(nameof(callback));

    this.callback = callback;

    return this;
  }

  /// <summary>
  ///   <para>Name of JavaScript function to be called after successful authentication, if using dynamic mode.</para>
  /// </summary>
  /// <returns>JavaScript callback function.</returns>
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

    return
      new TagBuilder("div").Attribute("id", elementId).ToString() +
      new TagBuilder("script").Attribute("type", "text/javascript")
        .InnerHtml($@"VK.Widgets.Auth(""${elementId}"", ${config.Json()})");
  }
}