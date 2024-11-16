using System.Text;
using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IVkontakteCommentsWidget"/>
public class VkontakteCommentsWidget : WebWidget, IVkontakteCommentsWidget
{
  private IEnumerable<string> attach = Enumerable.Empty<string>();
  private bool? autoPublish;
  private bool? autoUpdate;
  private string elementId;
  private byte limit = (byte)VkontakteCommentsLimit.Limit5;
  private bool? mini;
  private string width;

  /// <inheritdoc cref="IVkontakteCommentsWidget.Attach(string[])"/>
  public IVkontakteCommentsWidget Attach(params string[] types)
  {
    if (attach is null) throw new ArgumentNullException(nameof(types));

    attach = types;
      
    return this;
  }

  /// <inheritdoc cref="IVkontakteCommentsWidget.Attach()"/>
  public IEnumerable<string> Attach() => attach;

  /// <inheritdoc cref="IVkontakteCommentsWidget.AutoPublish(bool)"/>
  public IVkontakteCommentsWidget AutoPublish(bool enabled)
  {
    autoPublish = enabled;
    return this;
  }

  /// <inheritdoc cref="IVkontakteCommentsWidget.AutoPublish()"/>
  public bool? AutoPublish() => autoPublish;

  /// <inheritdoc cref="IVkontakteCommentsWidget.AutoUpdate(bool)"/>
  public IVkontakteCommentsWidget AutoUpdate(bool enabled)
  {
    autoUpdate = enabled;
    return this;
  }

  /// <inheritdoc cref="IVkontakteCommentsWidget.AutoUpdate()"/>
  public bool? AutoUpdate() => autoUpdate;

  /// <inheritdoc cref="IVkontakteCommentsWidget.ElementId(string)"/>
  public IVkontakteCommentsWidget ElementId(string id)
  {
    if (id is null) throw new ArgumentNullException(nameof(id));
    if (id.IsEmpty()) throw new ArgumentException(nameof(id));

    elementId = id;

    return this;
  }

  /// <inheritdoc cref="IVkontakteCommentsWidget.ElementId()"/>
  public string ElementId() => elementId;

  /// <inheritdoc cref="IVkontakteCommentsWidget.Mini(bool?)"/>
  public IVkontakteCommentsWidget Mini(bool? enabled)
  {
    mini = enabled;
    return this;
  }

  /// <inheritdoc cref="IVkontakteCommentsWidget.Mini()"/>
  public bool? Mini() => mini;

  /// <inheritdoc cref="IVkontakteCommentsWidget.Limit(byte)"/>
  public IVkontakteCommentsWidget Limit(byte limit)
  {
    this.limit = limit;
    return this;
  }

  /// <inheritdoc cref="IVkontakteCommentsWidget.Limit()"/>
  public byte Limit() => limit;

  /// <inheritdoc cref="IVkontakteCommentsWidget.Width(string)"/>
  public IVkontakteCommentsWidget Width(string width)
  {
    if (width is null) throw new ArgumentNullException(nameof(width));
    if (width.IsEmpty()) throw new ArgumentException(nameof(width));

    this.width = width;

    return this;
  }

  /// <inheritdoc cref="IVkontakteCommentsWidget.Width()"/>
  public string Width() => width;

  /// <inheritdoc cref="IWebWidget.ToHtml()"/>
  public override string ToHtml()
  {
    var config = new Dictionary<string, object>
    {
      { "limit", Limit() }
    };
      
    if (Attach().Any())
    {
      config["attach"] = Attach().Join(",");
    }
    else
    {
      config["attach"] = false;
    }

    if (!Width().IsEmpty())
    {
      config["width"] = Width();
    }
    
    if (AutoPublish() is not null)
    {
      config["autoPublish"] = AutoPublish().Value ? 1 : 0;
    }
    
    if (AutoUpdate() is not null)
    {
      config["norealtime"] = AutoUpdate().Value ? 0 : 1;
    }
    
    if (Mini() is not null)
    {
      config["mini"] = Mini().Value ? 1 : 0;
    }

    var elementId = ElementId() ?? "vk_comments";

    return new StringBuilder().Append(new TagBuilder("div").Attribute("id", elementId)).Append(new TagBuilder("script").Attribute("type", "text/javascript").InnerHtml($@"VK.Widgets.Comments(""${elementId}"", ${config.Json()}))).ToString();
  }
}