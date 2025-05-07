using System.Text;
using Catharsis.Extensions;
using Catharsis.Web.Widgets.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IVkontakteCommunityWidget"/>
public class VkontakteCommunityWidget : WebWidget, IVkontakteCommunityWidget
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string AccountValue { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string BackgroundColorValue { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string ButtonColorValue { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string ElementIdValue { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string HeightValue { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual byte ModeValue { get; set; } = (byte) VkontakteCommunityMode.Participants;

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string TextColorValue { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string WidthValue { get; set; }

  /// <inheritdoc cref="IVkontakteCommunityWidget.Account(string)"/>
  public virtual IVkontakteCommunityWidget Account(string account)
  {
    if (account is null) throw new ArgumentNullException(nameof(account));
    if (account.IsEmpty()) throw new ArgumentException(nameof(account));

    AccountValue = account;

    return this;
  }

  /// <inheritdoc cref="IVkontakteCommunityWidget.BackgroundColor(string)"/>
  public virtual IVkontakteCommunityWidget BackgroundColor(string color)
  {
    if (color is null) throw new ArgumentNullException(nameof(color));
    if (color.IsEmpty()) throw new ArgumentException(nameof(color));

    BackgroundColorValue = color;

    return this;
  }

  /// <inheritdoc cref="IVkontakteCommunityWidget.TextColor(string)"/>
  public virtual IVkontakteCommunityWidget TextColor(string color)
  {
    if (color is null) throw new ArgumentNullException(nameof(color));
    if (color.IsEmpty()) throw new ArgumentException(nameof(color));

    TextColorValue = color;

    return this;
  }

  /// <inheritdoc cref="IVkontakteCommunityWidget.ButtonColor(string)"/>
  public virtual IVkontakteCommunityWidget ButtonColor(string color)
  {
    if (color is null) throw new ArgumentNullException(nameof(color));
    if (color.IsEmpty()) throw new ArgumentException(nameof(color));

    ButtonColorValue = color;

    return this;
  }

  /// <inheritdoc cref="IVkontakteCommunityWidget.ElementId(string)"/>
  public virtual IVkontakteCommunityWidget ElementId(string id)
  {
    if (id is null) throw new ArgumentNullException(nameof(id));
    if (id.IsEmpty()) throw new ArgumentException(nameof(id));

    ElementIdValue = id;

    return this;
  }

  /// <inheritdoc cref="IVkontakteCommunityWidget.Height(string)"/>
  public virtual IVkontakteCommunityWidget Height(string height)
  {
    if (height is null) throw new ArgumentNullException(nameof(height));
    if (height.IsEmpty()) throw new ArgumentException(nameof(height));

    HeightValue = height;

    return this;
  }

  /// <inheritdoc cref="IVkontakteCommunityWidget.Mode(byte)"/>
  public virtual IVkontakteCommunityWidget Mode(byte mode)
  {
    ModeValue = mode;
    return this;
  }

  /// <inheritdoc cref="IVkontakteCommunityWidget.Width(string)"/>
  public virtual IVkontakteCommunityWidget Width(string width)
  {
    if (width is null) throw new ArgumentNullException(nameof(width));
    if (width.IsEmpty()) throw new ArgumentException(nameof(width));

    WidthValue = width;

    return this;
  }

  /// <inheritdoc cref="ICloneable.Clone()"/>
  public override object Clone() => new VkontakteCommunityWidget
  {
    AccountValue = AccountValue,
    BackgroundColorValue = BackgroundColorValue,
    ButtonColorValue = ButtonColorValue,
    ElementIdValue = ElementIdValue,
    HeightValue = HeightValue,
    ModeValue = ModeValue,
    TextColorValue = TextColorValue,
    WidthValue = WidthValue
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
      { "mode", ModeValue }
    };
      
    if (ModeValue == (byte)VkontakteCommunityMode.News)
    {
      config["wide"] = 1;
    }

    if (!WidthValue.IsUnset())
    {
      config["width"] = WidthValue;
    }
    
    if (!HeightValue.IsUnset())
    {
      config["height"] = HeightValue;
    }
    
    if (!BackgroundColorValue.IsUnset())
    {
      config["color1"] = BackgroundColorValue;
    }
    
    if (!TextColorValue.IsUnset())
    {
      config["color2"] = TextColorValue;
    }
    
    if (!ButtonColorValue.IsUnset())
    {
      config["color3"] = ButtonColorValue;
    }

    var id = ElementIdValue ?? $"vk_groups_${AccountValue}";

    return new StringBuilder()
      .Append(new TagBuilder("div").Attribute("id", id))
      .Append(new TagBuilder("script").Attribute("type", "text/javascript").Html($"VK.Widgets.Group(\"${id}\", ${config.Json()}, \"${AccountValue}\""))
      .ToString();
  }
}