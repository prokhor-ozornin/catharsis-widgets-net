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
  protected virtual string AccountValue { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string ElementIdValue { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual byte LayoutValue { get; set; } = (byte) VkontakteSubscriptionButtonLayout.Button;

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual bool OnlyButtonValue { get; set; }

  /// <inheritdoc cref="IVkontakteSubscriptionWidget.Account(string)"/>
  public virtual IVkontakteSubscriptionWidget Account(string account)
  {
    if (account is null) throw new ArgumentNullException(nameof(account));
    if (account.IsEmpty()) throw new ArgumentException(nameof(account));

    AccountValue = account;

    return this;
  }

  /// <inheritdoc cref="IVkontakteSubscriptionWidget.ElementId(string)"/>
  public virtual IVkontakteSubscriptionWidget ElementId(string id)
  {
    if (id is null) throw new ArgumentNullException(nameof(id));
    if (id.IsEmpty()) throw new ArgumentException(nameof(id));

    ElementIdValue = id;

    return this;
  }

  /// <inheritdoc cref="IVkontakteSubscriptionWidget.Layout(byte)"/>
  public virtual IVkontakteSubscriptionWidget Layout(byte layout)
  {
    LayoutValue = layout;
    return this;
  }

  /// <inheritdoc cref="IVkontakteSubscriptionWidget.OnlyButton(bool)"/>
  public virtual IVkontakteSubscriptionWidget OnlyButton(bool enabled)
  {
    OnlyButtonValue = enabled;
    return this;
  }

  /// <inheritdoc cref="ICloneable.Clone()"/>
  public override object Clone() => new VkontakteSubscriptionWidget
  {
    AccountValue = AccountValue,
    ElementIdValue = ElementIdValue,
    LayoutValue = LayoutValue,
    OnlyButtonValue = OnlyButtonValue
  };

  /// <inheritdoc cref="IWebWidget.ToHtml()"/>
  public override string ToHtml()
  {
    if (AccountValue.IsUnset())
    {
      return string.Empty;
    }

    var config = new Dictionary<string, object>
    {
      { "mode", LayoutValue }
    };

    if (OnlyButtonValue)
    {
      config["soft"] = 1;
    }

    var id = ElementIdValue ?? $"vk_subscribe_${AccountValue}";

    return new StringBuilder()
      .Append(new TagBuilder("div").Attribute("id", id))
      .Append(new TagBuilder("script").Attribute("type", "text/javascript")
      .Html($"VK.Widgets.Subscribe(\"${id}\", ${config.Json()}, \"${AccountValue}\""))
      .ToString();
  }
}