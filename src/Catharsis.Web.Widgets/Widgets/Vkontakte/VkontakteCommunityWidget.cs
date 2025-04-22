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
  protected virtual string AccountProperty { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string BackgroundColorProperty { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string ButtonColorProperty { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string ElementIdProperty { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string HeightProperty { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual byte ModeProperty { get; set; } = (byte) VkontakteCommunityMode.Participants;

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string TextColorProperty { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string WidthProperty { get; set; }

  /// <inheritdoc cref="IVkontakteCommunityWidget.Account(string)"/>
  public virtual IVkontakteCommunityWidget Account(string account)
  {
    if (account is null) throw new ArgumentNullException(nameof(account));
    if (account.IsEmpty()) throw new ArgumentException(nameof(account));

    AccountProperty = account;

    return this;
  }

  /// <inheritdoc cref="IVkontakteCommunityWidget.BackgroundColor(string)"/>
  public virtual IVkontakteCommunityWidget BackgroundColor(string color)
  {
    if (color is null) throw new ArgumentNullException(nameof(color));
    if (color.IsEmpty()) throw new ArgumentException(nameof(color));

    BackgroundColorProperty = color;

    return this;
  }

  /// <inheritdoc cref="IVkontakteCommunityWidget.TextColor(string)"/>
  public virtual IVkontakteCommunityWidget TextColor(string color)
  {
    if (color is null) throw new ArgumentNullException(nameof(color));
    if (color.IsEmpty()) throw new ArgumentException(nameof(color));

    TextColorProperty = color;

    return this;
  }

  /// <inheritdoc cref="IVkontakteCommunityWidget.ButtonColor(string)"/>
  public virtual IVkontakteCommunityWidget ButtonColor(string color)
  {
    if (color is null) throw new ArgumentNullException(nameof(color));
    if (color.IsEmpty()) throw new ArgumentException(nameof(color));

    ButtonColorProperty = color;

    return this;
  }

  /// <inheritdoc cref="IVkontakteCommunityWidget.ElementId(string)"/>
  public virtual IVkontakteCommunityWidget ElementId(string id)
  {
    if (id is null) throw new ArgumentNullException(nameof(id));
    if (id.IsEmpty()) throw new ArgumentException(nameof(id));

    ElementIdProperty = id;

    return this;
  }

  /// <inheritdoc cref="IVkontakteCommunityWidget.Height(string)"/>
  public virtual IVkontakteCommunityWidget Height(string height)
  {
    if (height is null) throw new ArgumentNullException(nameof(height));
    if (height.IsEmpty()) throw new ArgumentException(nameof(height));

    HeightProperty = height;

    return this;
  }

  /// <inheritdoc cref="IVkontakteCommunityWidget.Mode(byte)"/>
  public virtual IVkontakteCommunityWidget Mode(byte mode)
  {
    ModeProperty = mode;
    return this;
  }

  /// <inheritdoc cref="IVkontakteCommunityWidget.Width(string)"/>
  public virtual IVkontakteCommunityWidget Width(string width)
  {
    if (width is null) throw new ArgumentNullException(nameof(width));
    if (width.IsEmpty()) throw new ArgumentException(nameof(width));

    WidthProperty = width;

    return this;
  }

  /// <inheritdoc cref="IHtmlContent.ToHtml()"/>
  public override string ToHtml()
  {
    if (AccountProperty.IsUnset())
    {
      return string.Empty;
    }

    var config = new Dictionary<string, object>
    {
      { "mode", ModeProperty }
    };
      
    if (ModeProperty == (byte)VkontakteCommunityMode.News)
    {
      config["wide"] = 1;
    }

    if (!WidthProperty.IsUnset())
    {
      config["width"] = WidthProperty;
    }
    
    if (!HeightProperty.IsUnset())
    {
      config["height"] = HeightProperty;
    }
    
    if (!BackgroundColorProperty.IsUnset())
    {
      config["color1"] = BackgroundColorProperty;
    }
    
    if (!TextColorProperty.IsUnset())
    {
      config["color2"] = TextColorProperty;
    }
    
    if (!ButtonColorProperty.IsUnset())
    {
      config["color3"] = ButtonColorProperty;
    }

    var id = ElementIdProperty ?? $"vk_groups_${AccountProperty}";

    return new StringBuilder()
      .Append(new TagBuilder("div").Attribute("id", id))
      .Append(new TagBuilder("script").Attribute("type", "text/javascript").Html($"VK.Widgets.Group(\"${id}\", ${config.Json()}, \"${AccountProperty}\""))
      .ToString();
  }
}