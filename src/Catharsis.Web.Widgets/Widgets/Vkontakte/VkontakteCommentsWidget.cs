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
  protected virtual IEnumerable<string> AttachValue { get; set; } = [];

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual bool? AutoPublishValue { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual bool? AutoUpdateValue { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string ElementIdValue { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual byte LimitValue { get; set; } = (byte)VkontakteCommentsLimit.Limit5;

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual bool? MiniValue { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string WidthValue { get; set; }

  /// <inheritdoc cref="IVkontakteCommentsWidget.Attach(string[])"/>
  public virtual IVkontakteCommentsWidget Attach(params string[] types)
  {
    AttachValue = types;
    return this;
  }

  /// <inheritdoc cref="IVkontakteCommentsWidget.AutoPublish(bool)"/>
  public virtual IVkontakteCommentsWidget AutoPublish(bool enabled)
  {
    AutoPublishValue = enabled;
    return this;
  }

  /// <inheritdoc cref="IVkontakteCommentsWidget.AutoUpdate(bool)"/>
  public virtual IVkontakteCommentsWidget AutoUpdate(bool enabled)
  {
    AutoUpdateValue = enabled;
    return this;
  }

  /// <inheritdoc cref="IVkontakteCommentsWidget.ElementId(string)"/>
  public virtual IVkontakteCommentsWidget ElementId(string id)
  {
    if (id is null) throw new ArgumentNullException(nameof(id));
    if (id.IsEmpty()) throw new ArgumentException(nameof(id));

    ElementIdValue = id;

    return this;
  }

  /// <inheritdoc cref="IVkontakteCommentsWidget.Mini(bool?)"/>
  public virtual IVkontakteCommentsWidget Mini(bool? enabled)
  {
    MiniValue = enabled;
    return this;
  }

  /// <inheritdoc cref="IVkontakteCommentsWidget.Limit(byte)"/>
  public virtual IVkontakteCommentsWidget Limit(byte count)
  {
    LimitValue = count;
    return this;
  }

  /// <inheritdoc cref="IVkontakteCommentsWidget.Width(string)"/>
  public virtual IVkontakteCommentsWidget Width(string width)
  {
    if (width is null) throw new ArgumentNullException(nameof(width));
    if (width.IsEmpty()) throw new ArgumentException(nameof(width));

    WidthValue = width;

    return this;
  }

  /// <inheritdoc cref="ICloneable.Clone()"/>
  public override object Clone() => new VkontakteCommentsWidget
  {
    AttachValue = AttachValue?.ToArray(),
    AutoPublishValue = AutoPublishValue,
    AutoUpdateValue = AutoUpdateValue,
    ElementIdValue = ElementIdValue,
    LimitValue = LimitValue,
    MiniValue = MiniValue,
    WidthValue = WidthValue
  };

  /// <inheritdoc cref="IWebWidget.ToHtml()"/>
  public override string ToHtml()
  {
    var config = new Dictionary<string, object>
    {
      { "limit", LimitValue }
    };
      
    if (AttachValue.Any())
    {
      config["attach"] = AttachValue.Join(",");
    }
    else
    {
      config["attach"] = false;
    }

    if (!WidthValue.IsUnset())
    {
      config["width"] = WidthValue;
    }
    
    if (AutoPublishValue is not null)
    {
      config["autoPublish"] = AutoPublishValue.GetValueOrDefault() ? 1 : 0;
    }
    
    if (AutoUpdateValue is not null)
    {
      config["norealtime"] = AutoUpdateValue.GetValueOrDefault() ? 0 : 1;
    }
    
    if (MiniValue is not null)
    {
      config["mini"] = MiniValue.GetValueOrDefault() ? 1 : 0;
    }

    var id = ElementIdValue ?? "vk_comments";

    return new StringBuilder()
      .Append(new TagBuilder("div").Attribute("id", id))
      .Append(new TagBuilder("script").Attribute("type", "text/javascript").Html($"VK.Widgets.Comments(\"${id}\", ${config.Json()})"))
     .ToString();
  }
}