using System.Text;
using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IVkontaktePollWidget"/>
public class VkontaktePollWidget : WebWidget, IVkontaktePollWidget
{
  private string elementId;
  private string id;
  private string url;
  private string width;

  /// <inheritdoc cref="IVkontaktePollWidget.Id(string)"/>
  public IVkontaktePollWidget Id(string id)
  {
    if (id is null) throw new ArgumentNullException(nameof(id));
    if (id.IsEmpty()) throw new ArgumentException(nameof(id));

    this.id = id;

    return this;
  }

  /// <inheritdoc cref="IVkontaktePollWidget.Id()"/>
  public string Id() => id;

  /// <inheritdoc cref="IVkontaktePollWidget.ElementId(string)"/>
  public IVkontaktePollWidget ElementId(string id)
  {
    if (id is null) throw new ArgumentNullException(nameof(id));
    if (id.IsEmpty()) throw new ArgumentException(nameof(id));

    elementId = id;
      
    return this;
  }

  /// <inheritdoc cref="IVkontaktePollWidget.ElementId()"/>
  public string ElementId() => elementId;

  /// <inheritdoc cref="IVkontaktePollWidget.Width(string)"/>
  public IVkontaktePollWidget Width(string width)
  {
    if (width is null) throw new ArgumentNullException(nameof(width));
    if (width.IsEmpty()) throw new ArgumentException(nameof(width));

    this.width = width;

    return this;
  }

  /// <inheritdoc cref="IVkontaktePollWidget.Width()"/>
  public string Width() => width;

  /// <inheritdoc cref="IVkontaktePollWidget.Url(string)"/>
  public IVkontaktePollWidget Url(string url)
  {
    if (url is null) throw new ArgumentNullException(nameof(url));
    if (url.IsEmpty()) throw new ArgumentException(nameof(url));

    this.url = url;

    return this;
  }

  /// <inheritdoc cref="IVkontaktePollWidget.Url()"/>
  public string Url() => url;

  /// <inheritdoc cref="IWebWidget.ToHtml()"/>
  public override string ToHtml()
  {
    if (Id().IsEmpty())
    {
      return string.Empty;
    }

    var config = new Dictionary<string, object>();
    
    if (!Url().IsEmpty())
    {
      config["pageUrl"] = Url();
    }

    if (!Width().IsEmpty())
    {
      config["width"] = Width();
    }

    var id = ElementId() ?? $"vk_poll_{Id()}";
      
    return new StringBuilder()
      .Append(new TagBuilder("div").Attribute("id", id))
      .Append(new TagBuilder("script").Attribute("type", "text/javascript").Html($@"VK.Widgets.Poll(""{id}"", {config.Json()}, ""{Id()}""));")
      ).ToString();
  }
}