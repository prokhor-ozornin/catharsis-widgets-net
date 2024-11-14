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

  /// <summary>
  ///   <para>Identifier or VKontakte public group/community.</para>
  /// </summary>
  /// <param name="account">Group identifier.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="account"/> is a <c>null</c> reference.</exception>
  /// <exception cref="ArgumentException">If <paramref name="account"/> is <see cref="string.Empty"/> string.</exception>
  /// <remarks>This attribute is required.</remarks>
  public IVkontakteCommunityWidget Account(string account)
  {
    if (account is null) throw new ArgumentNullException(nameof(account));
    if (account.IsEmpty()) throw new ArgumentException(nameof(account));

    this.account = account;

    return this;
  }

  /// <summary>
  ///   <para>Identifier or VKontakte public group/community.</para>
  /// </summary>
  /// <returns>Group identifier.</returns>
  public string Account() => account;

  /// <summary>
  ///   <para>Background color of widget.</para>
  /// </summary>
  /// <param name="color">Widget's background color in RRGGBB format.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="color"/> is a <c>null</c> reference.</exception>
  /// <exception cref="ArgumentException">If <paramref name="color"/> is <see cref="string.Empty"/> string.</exception>
  public IVkontakteCommunityWidget BackgroundColor(string color)
  {
    if (color is null) throw new ArgumentNullException(nameof(color));
    if (color.IsEmpty()) throw new ArgumentException(nameof(color));

    backgroundColor = color;

    return this;
  }

  /// <summary>
  ///   <para>Background color of widget.</para>
  /// </summary>
  /// <returns>Widget's background color in RRGGBB format.</returns>
  public string BackgroundColor() => backgroundColor;

  /// <summary>
  ///   <para>Text color of widget.</para>
  /// </summary>
  /// <param name="color">Widget's text color in RRGGBB format.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="color"/> is a <c>null</c> reference.</exception>
  /// <exception cref="ArgumentException">If <paramref name="color"/> is <see cref="string.Empty"/> string.</exception>
  public IVkontakteCommunityWidget TextColor(string color)
  {
    if (color is null) throw new ArgumentNullException(nameof(color));
    if (color.IsEmpty()) throw new ArgumentException(nameof(color));

    textColor = color;

    return this;
  }

  /// <summary>
  ///   <para>Text color of widget.</para>
  /// </summary>
  /// <returns>Widget's text color in RRGGBB format.</returns>
  public string TextColor() => textColor;

  /// <summary>
  ///   <para>Button color of widget.</para>
  /// </summary>
  /// <param name="color">Widget's button color in RRGGBB format.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="color"/> is a <c>null</c> reference.</exception>
  /// <exception cref="ArgumentException">If <paramref name="color"/> is <see cref="string.Empty"/> string.</exception>
  public IVkontakteCommunityWidget ButtonColor(string color)
  {
    if (color is null) throw new ArgumentNullException(nameof(color));
    if (color.IsEmpty()) throw new ArgumentException(nameof(color));

    buttonColor = color;

    return this;
  }

  /// <summary>
  ///   <para>Button color of widget.</para>
  /// </summary>
  /// <returns>Widget's button color in RRGGBB format.</returns>
  public string ButtonColor() => buttonColor;

  /// <summary>
  ///   <para>Identifier of HTML container for the widget.</para>
  /// </summary>
  /// <param name="id">HTML element's identifier.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="id"/> is a <c>null</c> reference.</exception>
  /// <exception cref="ArgumentException">If <paramref name="id"/> is <see cref="string.Empty"/> string.</exception>
  public IVkontakteCommunityWidget ElementId(string id)
  {
    if (id is null) throw new ArgumentNullException(nameof(id));
    if (id.IsEmpty()) throw new ArgumentException(nameof(id));

    elementId = id;

    return this;
  }

  /// <summary>
  ///   <para>Identifier of HTML container for the widget.</para>
  /// </summary>
  /// <returns>HTML element's identifier.</returns>
  public string ElementId() => elementId;

  /// <summary>
  ///   <para>Vertical height of widget.</para>
  /// </summary>
  /// <param name="height">Height of widget.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="height"/> is a <c>null</c> reference.</exception>
  /// <exception cref="ArgumentException">If <paramref name="height"/> is <see cref="string.Empty"/> string.</exception>
  public IVkontakteCommunityWidget Height(string height)
  {
    if (height is null) throw new ArgumentNullException(nameof(height));
    if (height.IsEmpty()) throw new ArgumentException(nameof(height));

    this.height = height;

    return this;
  }

  /// <summary>
  ///   <para>Vertical height of widget.</para>
  /// </summary>
  /// <returns>Height of widget.</returns>
  public string Height() => height;

  /// <summary>
  ///   <para>Type of information to be displayed about given community.</para>
  /// </summary>
  /// <param name="mode">Community's info type.</param>
  /// <returns>Reference to the current widget.</returns>
  public IVkontakteCommunityWidget Mode(byte mode)
  {
    this.mode = mode;
    return this;
  }

  /// <summary>
  ///   <para>Type of information to be displayed about given community.</para>
  /// </summary>
  /// <returns>Community's info type.</returns>
  public byte Mode() => mode;

  /// <summary>
  ///   <para>Horizontal width of widget.</para>
  /// </summary>
  /// <param name="width">Width of widget.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="width"/> is a <c>null</c> reference.</exception>
  /// <exception cref="ArgumentException">If <paramref name="width"/> is <see cref="string.Empty"/> string.</exception>
  public IVkontakteCommunityWidget Width(string width)
  {
    if (width is null) throw new ArgumentNullException(nameof(width));
    if (width.IsEmpty()) throw new ArgumentException(nameof(width));

    this.width = width;

    return this;
  }

  /// <summary>
  ///   <para>Horizontal width of widget.</para>
  /// </summary>
  /// <returns>Width of widget.</returns>
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