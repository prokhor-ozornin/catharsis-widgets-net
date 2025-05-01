using System.Text;
using Catharsis.Extensions;
using Catharsis.Web.Widgets.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IVkontakteSubscriptionWidget"/>
public class VkontakteSubscriptionWidget : WebWidget, IVkontakteSubscriptionWidget
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string AccountProperty { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string ElementIdProperty { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual byte LayoutProperty { get; set; } = (byte) VkontakteSubscriptionButtonLayout.Button;

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual bool OnlyButtonProperty { get; set; }

  /// <inheritdoc cref="IVkontakteSubscriptionWidget.Account(string)"/>
  public virtual IVkontakteSubscriptionWidget Account(string account)
  {
    if (account is null) throw new ArgumentNullException(nameof(account));
    if (account.IsEmpty()) throw new ArgumentException(nameof(account));

    AccountProperty = account;

    return this;
  }

  /// <inheritdoc cref="IVkontakteSubscriptionWidget.ElementId(string)"/>
  public virtual IVkontakteSubscriptionWidget ElementId(string id)
  {
    if (id is null) throw new ArgumentNullException(nameof(id));
    if (id.IsEmpty()) throw new ArgumentException(nameof(id));

    ElementIdProperty = id;

    return this;
  }

  /// <inheritdoc cref="IVkontakteSubscriptionWidget.Layout(byte)"/>
  public virtual IVkontakteSubscriptionWidget Layout(byte layout)
  {
    LayoutProperty = layout;
    return this;
  }

  /// <inheritdoc cref="IVkontakteSubscriptionWidget.OnlyButton(bool)"/>
  public virtual IVkontakteSubscriptionWidget OnlyButton(bool enabled)
  {
    OnlyButtonProperty = enabled;
    return this;
  }

  public override object Clone() => new VkontakteSubscriptionWidget { };

  /// <inheritdoc cref="IWebWidget.ToHtml()"/>
  public override string ToHtml()
  {
    if (AccountProperty.IsUnset())
    {
      return string.Empty;
    }

    var config = new Dictionary<string, object>
    {
      { "mode", LayoutProperty }
    };

    if (OnlyButtonProperty)
    {
      config["soft"] = 1;
    }

    var id = ElementIdProperty ?? $"vk_subscribe_${AccountProperty}";

    return new StringBuilder()
      .Append(new TagBuilder("div").Attribute("id", id))
      .Append(new TagBuilder("script").Attribute("type", "text/javascript")
      .Html($"VK.Widgets.Subscribe(\"${id}\", ${config.Json()}, \"${AccountProperty}\""))
      .ToString();
  }
}