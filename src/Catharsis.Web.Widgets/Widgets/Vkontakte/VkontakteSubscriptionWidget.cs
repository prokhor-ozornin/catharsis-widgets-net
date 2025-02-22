using System.Text;
using Catharsis.Extensions;
using Catharsis.Web.Widgets.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IVkontakteSubscriptionWidget"/>
public class VkontakteSubscriptionWidget : WebWidget, IVkontakteSubscriptionWidget
{
  private string AccountProperty { get; set; }
  private string ElementIdProperty { get; set; }
  private byte LayoutProperty { get; set; } = (byte) VkontakteSubscriptionButtonLayout.Button;
  private bool OnlyButtonProperty { get; set; }

  /// <inheritdoc cref="IVkontakteSubscriptionWidget.Account(string)"/>
  public IVkontakteSubscriptionWidget Account(string account)
  {
    if (account is null) throw new ArgumentNullException(nameof(account));
    if (account.IsEmpty()) throw new ArgumentException(nameof(account));

    AccountProperty = account;

    return this;
  }

  /// <inheritdoc cref="IVkontakteSubscriptionWidget.Account()"/>
  public string Account() => AccountProperty;

  /// <inheritdoc cref="IVkontakteSubscriptionWidget.ElementId(string)"/>
  public IVkontakteSubscriptionWidget ElementId(string id)
  {
    if (id is null) throw new ArgumentNullException(nameof(id));
    if (id.IsEmpty()) throw new ArgumentException(nameof(id));

    ElementIdProperty = id;

    return this;
  }

  /// <inheritdoc cref="IVkontakteSubscriptionWidget.ElementId()"/>
  public string ElementId() => ElementIdProperty;

  /// <inheritdoc cref="IVkontakteSubscriptionWidget.Layout(byte)"/>
  public IVkontakteSubscriptionWidget Layout(byte layout)
  {
    LayoutProperty = layout;
    return this;
  }

  /// <inheritdoc cref="IVkontakteSubscriptionWidget.Layout()"/>
  public byte Layout() => LayoutProperty;

  /// <inheritdoc cref="IVkontakteSubscriptionWidget.OnlyButton(bool)"/>
  public IVkontakteSubscriptionWidget OnlyButton(bool enabled)
  {
    OnlyButtonProperty = enabled;
    return this;
  }

  /// <inheritdoc cref="IVkontakteSubscriptionWidget.OnlyButton()"/>
  public bool OnlyButton() => OnlyButtonProperty;

  /// <inheritdoc cref="IHtmlContent.ToHtml()"/>
  public override string ToHtml()
  {
    if (Account().IsEmpty())
    {
      return string.Empty;
    }

    var config = new Dictionary<string, object>
    {
      { "mode", Layout() }
    };

    if (OnlyButton())
    {
      config["soft"] = 1;
    }

    var id = ElementId() ?? $"vk_subscribe_${Account()}";

    return new StringBuilder()
      .Append(new TagBuilder("div").Attribute("id", id))
      .Append(new TagBuilder("script").Attribute("type", "text/javascript")
      .Html($"VK.Widgets.Subscribe(\"${id}\", ${config.Json()}, \"${Account()}\""))
      .ToString();
  }
}