using System.Text;
using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IVkontakteSubscriptionWidget"/>
public class VkontakteSubscriptionWidget : WebWidget, IVkontakteSubscriptionWidget
{
  private string account;
  private string elementId;
  private byte layout = (byte) VkontakteSubscriptionButtonLayout.Button;
  private bool onlyButton;

  /// <inheritdoc cref="IVkontakteSubscriptionWidget.Account(string)"/>
  public IVkontakteSubscriptionWidget Account(string account)
  {
    if (account is null) throw new ArgumentNullException(nameof(account));
    if (account.IsEmpty()) throw new ArgumentException(nameof(account));

    this.account = account;

    return this;
  }

  /// <inheritdoc cref="IVkontakteSubscriptionWidget.Account()"/>
  public string Account() => account;

  /// <inheritdoc cref="IVkontakteSubscriptionWidget.ElementId(string)"/>
  public IVkontakteSubscriptionWidget ElementId(string id)
  {
    if (id is null) throw new ArgumentNullException(nameof(id));
    if (id.IsEmpty()) throw new ArgumentException(nameof(id));

    elementId = id;

    return this;
  }

  /// <inheritdoc cref="IVkontakteSubscriptionWidget.ElementId()"/>
  public string ElementId() => elementId;

  /// <inheritdoc cref="IVkontakteSubscriptionWidget.Layout(byte)"/>
  public IVkontakteSubscriptionWidget Layout(byte layout)
  {
    this.layout = layout;
    return this;
  }

  /// <inheritdoc cref="IVkontakteSubscriptionWidget.Layout()"/>
  public byte Layout() => layout;

  /// <inheritdoc cref="IVkontakteSubscriptionWidget.OnlyButton(bool)"/>
  public IVkontakteSubscriptionWidget OnlyButton(bool enabled)
  {
    this.onlyButton = enabled;
    return this;
  }

  /// <inheritdoc cref="IVkontakteSubscriptionWidget.OnlyButton()"/>
  public bool OnlyButton() => onlyButton;

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