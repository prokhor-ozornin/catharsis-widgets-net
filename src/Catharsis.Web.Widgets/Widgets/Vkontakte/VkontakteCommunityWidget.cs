using System.Text;
using Catharsis.Extensions;
using Catharsis.Web.Widgets.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IVkontakteCommunityWidget"/>
public class VkontakteCommunityWidget : WebWidget, IVkontakteCommunityWidget
{
  private string AccountProperty { get; set; }
  private string BackgroundColorProperty { get; set; }
  private string ButtonColorProperty { get; set; }
  private string ElementIdProperty { get; set; }
  private string HeightProperty { get; set; }
  private byte ModeProperty { get; set; } = (byte) VkontakteCommunityMode.Participants;
  private string TextColorProperty { get; set; }
  private string WidthProperty { get; set; }

  /// <inheritdoc cref="IVkontakteCommunityWidget.Account(string)"/>
  public IVkontakteCommunityWidget Account(string account)
  {
    if (account is null) throw new ArgumentNullException(nameof(account));
    if (account.IsEmpty()) throw new ArgumentException(nameof(account));

    AccountProperty = account;

    return this;
  }

  /// <inheritdoc cref="IVkontakteCommunityWidget.Account()"/>
  public string Account() => AccountProperty;

  /// <inheritdoc cref="IVkontakteCommunityWidget.BackgroundColor(string)"/>
  public IVkontakteCommunityWidget BackgroundColor(string color)
  {
    if (color is null) throw new ArgumentNullException(nameof(color));
    if (color.IsEmpty()) throw new ArgumentException(nameof(color));

    BackgroundColorProperty = color;

    return this;
  }

  /// <inheritdoc cref="IVkontakteCommunityWidget.BackgroundColor()"/>
  public string BackgroundColor() => BackgroundColorProperty;

  /// <inheritdoc cref="IVkontakteCommunityWidget.TextColor(string)"/>
  public IVkontakteCommunityWidget TextColor(string color)
  {
    if (color is null) throw new ArgumentNullException(nameof(color));
    if (color.IsEmpty()) throw new ArgumentException(nameof(color));

    TextColorProperty = color;

    return this;
  }

  /// <inheritdoc cref="IVkontakteCommunityWidget.TextColor()"/>
  public string TextColor() => TextColorProperty;

  /// <inheritdoc cref="IVkontakteCommunityWidget.ButtonColor(string)"/>
  public IVkontakteCommunityWidget ButtonColor(string color)
  {
    if (color is null) throw new ArgumentNullException(nameof(color));
    if (color.IsEmpty()) throw new ArgumentException(nameof(color));

    ButtonColorProperty = color;

    return this;
  }

  /// <inheritdoc cref="IVkontakteCommunityWidget.ButtonColor()"/>
  public string ButtonColor() => ButtonColorProperty;

  /// <inheritdoc cref="IVkontakteCommunityWidget.ElementId(string)"/>
  public IVkontakteCommunityWidget ElementId(string id)
  {
    if (id is null) throw new ArgumentNullException(nameof(id));
    if (id.IsEmpty()) throw new ArgumentException(nameof(id));

    ElementIdProperty = id;

    return this;
  }

  /// <inheritdoc cref="IVkontakteCommunityWidget.ElementId()"/>
  public string ElementId() => ElementIdProperty;

  /// <inheritdoc cref="IVkontakteCommunityWidget.Height(string)"/>
  public IVkontakteCommunityWidget Height(string height)
  {
    if (height is null) throw new ArgumentNullException(nameof(height));
    if (height.IsEmpty()) throw new ArgumentException(nameof(height));

    HeightProperty = height;

    return this;
  }

  /// <inheritdoc cref="IVkontakteCommunityWidget.Height()"/>
  public string Height() => HeightProperty;

  /// <inheritdoc cref="IVkontakteCommunityWidget.Mode(byte)"/>
  public IVkontakteCommunityWidget Mode(byte mode)
  {
    ModeProperty = mode;
    return this;
  }

  /// <inheritdoc cref="IVkontakteCommunityWidget.Mode()"/>
  public byte Mode() => ModeProperty;

  /// <inheritdoc cref="IVkontakteCommunityWidget.Width(string)"/>
  public IVkontakteCommunityWidget Width(string width)
  {
    if (width is null) throw new ArgumentNullException(nameof(width));
    if (width.IsEmpty()) throw new ArgumentException(nameof(width));

    WidthProperty = width;

    return this;
  }

  /// <inheritdoc cref="IVkontakteCommunityWidget.Width()"/>
  public string Width() => WidthProperty;

  /// <inheritdoc cref="IHtmlContent.ToHtml()"/>
  public override string ToHtml()
  {
    if (Account().IsEmpty())
    {
      return string.Empty;
    }

    var config = new Dictionary<string, object>
    {
      { "mode", Mode() }
    };
      
    if (Mode() == (byte)VkontakteCommunityMode.News)
    {
      config["wide"] = 1;
    }

    if (!Width().IsEmpty())
    {
      config["width"] = Width();
    }
    
    if (!Height().IsEmpty())
    {
      config["height"] = Height();
    }
    
    if (!BackgroundColor().IsEmpty())
    {
      config["color1"] = BackgroundColor();
    }
    
    if (!TextColor().IsEmpty())
    {
      config["color2"] = TextColor();
    }
    
    if (!ButtonColor().IsEmpty())
    {
      config["color3"] = ButtonColor();
    }

    var id = ElementId() ?? $"vk_groups_${Account()}";

    return new StringBuilder()
      .Append(new TagBuilder("div").Attribute("id", id))
      .Append(new TagBuilder("script").Attribute("type", "text/javascript").Html($"VK.Widgets.Group(\"${id}\", ${config.Json()}, \"${Account()}\""))
      .ToString();
  }
}