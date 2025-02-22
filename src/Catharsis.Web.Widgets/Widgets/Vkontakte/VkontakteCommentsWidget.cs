using System.Text;
using Catharsis.Extensions;
using Catharsis.Web.Widgets.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IVkontakteCommentsWidget"/>
public class VkontakteCommentsWidget : WebWidget, IVkontakteCommentsWidget
{
  private IEnumerable<string> AttachProperty { get; set; } = [];
  private bool? AutoPublishProperty { get; set; }
  private bool? AutoUpdateProperty { get; set; }
  private string ElementIdProperty { get; set; }
  private byte LimitProperty { get; set; } = (byte)VkontakteCommentsLimit.Limit5;
  private bool? MiniProperty { get; set; }
  private string WidthProperty { get; set; }

  /// <inheritdoc cref="IVkontakteCommentsWidget.Attach(string[])"/>
  public IVkontakteCommentsWidget Attach(params string[] types)
  {
    AttachProperty = types;
    return this;
  }

  /// <inheritdoc cref="IVkontakteCommentsWidget.Attach()"/>
  public IEnumerable<string> Attach() => AttachProperty;

  /// <inheritdoc cref="IVkontakteCommentsWidget.AutoPublish(bool)"/>
  public IVkontakteCommentsWidget AutoPublish(bool enabled)
  {
    AutoPublishProperty = enabled;
    return this;
  }

  /// <inheritdoc cref="IVkontakteCommentsWidget.AutoPublish()"/>
  public bool? AutoPublish() => AutoPublishProperty;

  /// <inheritdoc cref="IVkontakteCommentsWidget.AutoUpdate(bool)"/>
  public IVkontakteCommentsWidget AutoUpdate(bool enabled)
  {
    AutoUpdateProperty = enabled;
    return this;
  }

  /// <inheritdoc cref="IVkontakteCommentsWidget.AutoUpdate()"/>
  public bool? AutoUpdate() => AutoUpdateProperty;

  /// <inheritdoc cref="IVkontakteCommentsWidget.ElementId(string)"/>
  public IVkontakteCommentsWidget ElementId(string id)
  {
    if (id is null) throw new ArgumentNullException(nameof(id));
    if (id.IsEmpty()) throw new ArgumentException(nameof(id));

    ElementIdProperty = id;

    return this;
  }

  /// <inheritdoc cref="IVkontakteCommentsWidget.ElementId()"/>
  public string ElementId() => ElementIdProperty;

  /// <inheritdoc cref="IVkontakteCommentsWidget.Mini(bool?)"/>
  public IVkontakteCommentsWidget Mini(bool? enabled)
  {
    MiniProperty = enabled;
    return this;
  }

  /// <inheritdoc cref="IVkontakteCommentsWidget.Mini()"/>
  public bool? Mini() => MiniProperty;

  /// <inheritdoc cref="IVkontakteCommentsWidget.Limit(byte)"/>
  public IVkontakteCommentsWidget Limit(byte count)
  {
    LimitProperty = count;
    return this;
  }

  /// <inheritdoc cref="IVkontakteCommentsWidget.Limit()"/>
  public byte Limit() => LimitProperty;

  /// <inheritdoc cref="IVkontakteCommentsWidget.Width(string)"/>
  public IVkontakteCommentsWidget Width(string width)
  {
    if (width is null) throw new ArgumentNullException(nameof(width));
    if (width.IsEmpty()) throw new ArgumentException(nameof(width));

    WidthProperty = width;

    return this;
  }

  /// <inheritdoc cref="IVkontakteCommentsWidget.Width()"/>
  public string Width() => WidthProperty;

  /// <inheritdoc cref="IHtmlContent.ToHtml()"/>
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
      config["autoPublish"] = AutoPublish().GetValueOrDefault() ? 1 : 0;
    }
    
    if (AutoUpdate() is not null)
    {
      config["norealtime"] = AutoUpdate().GetValueOrDefault() ? 0 : 1;
    }
    
    if (Mini() is not null)
    {
      config["mini"] = Mini().GetValueOrDefault() ? 1 : 0;
    }

    var id = ElementId() ?? "vk_comments";

    return new StringBuilder()
      .Append(new TagBuilder("div").Attribute("id", id))
      .Append(new TagBuilder("script").Attribute("type", "text/javascript").Html($"VK.Widgets.Comments(\"${id}\", ${config.Json()})"))
     .ToString();
  }
}