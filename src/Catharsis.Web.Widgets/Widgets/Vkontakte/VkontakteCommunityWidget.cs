using System.Text;
using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IVkontakteCommunityWidget"/>
public class VkontakteCommunityWidget : WebWidget, IVkontakteCommunityWidget
{
  private string account;
  private string backgroundColor;
  private string buttonColor;
  private string elementId;
  private string height;
  private byte mode = (byte)VkontakteCommunityMode.Participants;
  private string textColor;
  private string width;

  /// <inheritdoc cref="IVkontakteCommunityWidget.Account(string)"/>
  public IVkontakteCommunityWidget Account(string account)
  {
    if (account is null) throw new ArgumentNullException(nameof(account));
    if (account.IsEmpty()) throw new ArgumentException(nameof(account));

    this.account = account;

    return this;
  }

  /// <inheritdoc cref="IVkontakteCommunityWidget.Account()"/>
  public string Account() => account;

  /// <inheritdoc cref="IVkontakteCommunityWidget.BackgroundColor(string)"/>
  public IVkontakteCommunityWidget BackgroundColor(string color)
  {
    if (color is null) throw new ArgumentNullException(nameof(color));
    if (color.IsEmpty()) throw new ArgumentException(nameof(color));

    backgroundColor = color;

    return this;
  }

  /// <inheritdoc cref="IVkontakteCommunityWidget.BackgroundColor()"/>
  public string BackgroundColor() => backgroundColor;

  /// <inheritdoc cref="IVkontakteCommunityWidget.TextColor(string)"/>
  public IVkontakteCommunityWidget TextColor(string color)
  {
    if (color is null) throw new ArgumentNullException(nameof(color));
    if (color.IsEmpty()) throw new ArgumentException(nameof(color));

    textColor = color;

    return this;
  }

  /// <inheritdoc cref="IVkontakteCommunityWidget.TextColor()"/>
  public string TextColor() => textColor;

  /// <inheritdoc cref="IVkontakteCommunityWidget.ButtonColor(string)"/>
  public IVkontakteCommunityWidget ButtonColor(string color)
  {
    if (color is null) throw new ArgumentNullException(nameof(color));
    if (color.IsEmpty()) throw new ArgumentException(nameof(color));

    buttonColor = color;

    return this;
  }

  /// <inheritdoc cref="IVkontakteCommunityWidget.ButtonColor()"/>
  public string ButtonColor() => buttonColor;

  /// <inheritdoc cref="IVkontakteCommunityWidget.ElementId(string)"/>
  public IVkontakteCommunityWidget ElementId(string id)
  {
    if (id is null) throw new ArgumentNullException(nameof(id));
    if (id.IsEmpty()) throw new ArgumentException(nameof(id));

    elementId = id;

    return this;
  }

  /// <inheritdoc cref="IVkontakteCommunityWidget.ElementId()"/>
  public string ElementId() => elementId;

  /// <inheritdoc cref="IVkontakteCommunityWidget.Height(string)"/>
  public IVkontakteCommunityWidget Height(string height)
  {
    if (height is null) throw new ArgumentNullException(nameof(height));
    if (height.IsEmpty()) throw new ArgumentException(nameof(height));

    this.height = height;

    return this;
  }

  /// <inheritdoc cref="IVkontakteCommunityWidget.Height()"/>
  public string Height() => height;

  /// <inheritdoc cref="IVkontakteCommunityWidget.Mode(byte)"/>
  public IVkontakteCommunityWidget Mode(byte mode)
  {
    this.mode = mode;
    return this;
  }

  /// <inheritdoc cref="IVkontakteCommunityWidget.Mode()"/>
  public byte Mode() => mode;

  /// <inheritdoc cref="IVkontakteCommunityWidget.Width(string)"/>
  public IVkontakteCommunityWidget Width(string width)
  {
    if (width is null) throw new ArgumentNullException(nameof(width));
    if (width.IsEmpty()) throw new ArgumentException(nameof(width));

    this.width = width;

    return this;
  }

  /// <inheritdoc cref="IVkontakteCommunityWidget.Width()"/>
  public string Width() => width;

  /// <inheritdoc cref="IWebWidget.ToHtml()"/>
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

    var elementId = ElementId() ?? $"vk_groups_${Account()}";

    return new StringBuilder()
      .Append(new TagBuilder("div").Attribute("id", elementId))
      .Append(new TagBuilder("script").Attribute("type", "text/javascript").InnerHtml($@"VK.Widgets.Group(""${elementId}"", ${config.Json()}, ""${Account()}"")
        .ToString();
    }
  }
}