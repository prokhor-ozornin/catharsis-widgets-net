using System.Text;
using Catharsis.Extensions;
using Catharsis.Web.Widgets.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IVkontakteCommentsWidget"/>
public class VkontakteCommentsWidget : WebWidget, IVkontakteCommentsWidget
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual IEnumerable<string> AttachProperty { get; set; } = [];

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual bool? AutoPublishProperty { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual bool? AutoUpdateProperty { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string ElementIdProperty { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual byte LimitProperty { get; set; } = (byte)VkontakteCommentsLimit.Limit5;

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual bool? MiniProperty { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string WidthProperty { get; set; }

  /// <inheritdoc cref="IVkontakteCommentsWidget.Attach(string[])"/>
  public virtual IVkontakteCommentsWidget Attach(params string[] types)
  {
    AttachProperty = types;
    return this;
  }

  /// <inheritdoc cref="IVkontakteCommentsWidget.AutoPublish(bool)"/>
  public virtual IVkontakteCommentsWidget AutoPublish(bool enabled)
  {
    AutoPublishProperty = enabled;
    return this;
  }

  /// <inheritdoc cref="IVkontakteCommentsWidget.AutoUpdate(bool)"/>
  public virtual IVkontakteCommentsWidget AutoUpdate(bool enabled)
  {
    AutoUpdateProperty = enabled;
    return this;
  }

  /// <inheritdoc cref="IVkontakteCommentsWidget.ElementId(string)"/>
  public virtual IVkontakteCommentsWidget ElementId(string id)
  {
    if (id is null) throw new ArgumentNullException(nameof(id));
    if (id.IsEmpty()) throw new ArgumentException(nameof(id));

    ElementIdProperty = id;

    return this;
  }

  /// <inheritdoc cref="IVkontakteCommentsWidget.Mini(bool?)"/>
  public virtual IVkontakteCommentsWidget Mini(bool? enabled)
  {
    MiniProperty = enabled;
    return this;
  }

  /// <inheritdoc cref="IVkontakteCommentsWidget.Limit(byte)"/>
  public virtual IVkontakteCommentsWidget Limit(byte count)
  {
    LimitProperty = count;
    return this;
  }

  /// <inheritdoc cref="IVkontakteCommentsWidget.Width(string)"/>
  public virtual IVkontakteCommentsWidget Width(string width)
  {
    if (width is null) throw new ArgumentNullException(nameof(width));
    if (width.IsEmpty()) throw new ArgumentException(nameof(width));

    WidthProperty = width;

    return this;
  }

  /// <inheritdoc cref="ICloneable.Clone()"/>
  public override object Clone() => new VkontakteCommentsWidget
  {
    AttachProperty = AttachProperty?.ToArray(),
    AutoPublishProperty = AutoPublishProperty,
    AutoUpdateProperty = AutoUpdateProperty,
    ElementIdProperty = ElementIdProperty,
    LimitProperty = LimitProperty,
    MiniProperty = MiniProperty,
    WidthProperty = WidthProperty
  };

  /// <inheritdoc cref="IWebWidget.ToHtml()"/>
  public override string ToHtml()
  {
    var config = new Dictionary<string, object>
    {
      { "limit", LimitProperty }
    };
      
    if (AttachProperty.Any())
    {
      config["attach"] = AttachProperty.Join(",");
    }
    else
    {
      config["attach"] = false;
    }

    if (!WidthProperty.IsUnset())
    {
      config["width"] = WidthProperty;
    }
    
    if (AutoPublishProperty is not null)
    {
      config["autoPublish"] = AutoPublishProperty.GetValueOrDefault() ? 1 : 0;
    }
    
    if (AutoUpdateProperty is not null)
    {
      config["norealtime"] = AutoUpdateProperty.GetValueOrDefault() ? 0 : 1;
    }
    
    if (MiniProperty is not null)
    {
      config["mini"] = MiniProperty.GetValueOrDefault() ? 1 : 0;
    }

    var id = ElementIdProperty ?? "vk_comments";

    return new StringBuilder()
      .Append(new TagBuilder("div").Attribute("id", id))
      .Append(new TagBuilder("script").Attribute("type", "text/javascript").Html($"VK.Widgets.Comments(\"${id}\", ${config.Json()})"))
     .ToString();
  }
}