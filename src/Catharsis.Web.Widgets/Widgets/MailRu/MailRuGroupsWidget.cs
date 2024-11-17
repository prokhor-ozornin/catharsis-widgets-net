using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IMailRuGroupsWidget"/>
public class MailRuGroupsWidget : WebWidget, IMailRuGroupsWidget
{
  private string account;
  private string backgroundColor;
  private string buttonColor;
  private string domain;
  private string height;
  private bool subscribers = true;
  private string textColor;
  private string width;

  /// <inheritdoc cref="IMailRuGroupsWidget.Account(string)"/>
  public IMailRuGroupsWidget Account(string account)
  {
    if (account is null) throw new ArgumentNullException(nameof(account));
    if (account.IsEmpty()) throw new ArgumentException(nameof(account));

    this.account = account;
    return this;
  }

  /// <inheritdoc cref="IMailRuGroupsWidget.Account()"/>
  public string Account() => account;

  /// <inheritdoc cref="IMailRuGroupsWidget.BackgroundColor(string)"/>
  public IMailRuGroupsWidget BackgroundColor(string color)
  {
    if (color is null) throw new ArgumentNullException(nameof(color));
    if (color.IsEmpty()) throw new ArgumentException(nameof(color));

    backgroundColor = color;
    return this;
  }

  /// <inheritdoc cref="IMailRuGroupsWidget.BackgroundColor()"/>
  public string BackgroundColor() => backgroundColor;

  /// <inheritdoc cref="IMailRuGroupsWidget.ButtonColor(string)"/>
  public IMailRuGroupsWidget ButtonColor(string color)
  {
    if (color is null) throw new ArgumentNullException(nameof(color));
    if (color.IsEmpty()) throw new ArgumentException(nameof(color));

    buttonColor = color;
    return this;
  }

  /// <inheritdoc cref="IMailRuGroupsWidget.ButtonColor()"/>
  public string ButtonColor() => buttonColor;

  /// <inheritdoc cref="IMailRuGroupsWidget.Domain(string)"/>
  public IMailRuGroupsWidget Domain(string domain)
  {
    if (domain is null) throw new ArgumentNullException(nameof(domain));
    if (domain.IsEmpty()) throw new ArgumentException(nameof(domain));

    this.domain = domain;
    return this;
  }

  /// <inheritdoc cref="IMailRuGroupsWidget.Domain()"/>
  public string Domain() => domain;

  /// <inheritdoc cref="IMailRuGroupsWidget.Height(string)"/>
  public IMailRuGroupsWidget Height(string height)
  {
    if (height is null) throw new ArgumentNullException(nameof(height));
    if (height.IsEmpty()) throw new ArgumentException(nameof(height));

    this.height = height;
    return this;
  }

  /// <inheritdoc cref="IMailRuGroupsWidget.Height()"/>
  public string Height() => height;

  /// <inheritdoc cref="IMailRuGroupsWidget.Subscribers(bool)"/>
  public IMailRuGroupsWidget Subscribers(bool enabled)
  {
    subscribers = enabled;
    return this;
  }

  /// <inheritdoc cref="IMailRuGroupsWidget.Subscribers()"/>
  public bool Subscribers() => subscribers;

  /// <inheritdoc cref="IMailRuGroupsWidget.TextColor(string)"/>
  public IMailRuGroupsWidget TextColor(string color)
  {
    if (color is null) throw new ArgumentNullException(nameof(color));
    if (color.IsEmpty()) throw new ArgumentException(nameof(color));

    textColor = color;
    return this;
  }

  /// <inheritdoc cref="IMailRuGroupsWidget.TextColor()"/>
  public string TextColor() => textColor;

  /// <inheritdoc cref="IMailRuGroupsWidget.Width(string)"/>
  public IMailRuGroupsWidget Width(string width)
  {
    if (width is null) throw new ArgumentNullException(nameof(width));
    if (width.IsEmpty()) throw new ArgumentException(nameof(width));

    this.width = width;
    return this;
  }

  /// <inheritdoc cref="IMailRuGroupsWidget.Width()"/>
  public string Width() => width;

  /// <inheritdoc cref="IWebWidget.ToHtml()"/>
  public override string ToHtml()
  {
    if (Account().IsEmpty() || Width().IsEmpty() || Height().IsEmpty())
    {
      return string.Empty;
    }

    var config = new Dictionary<string, object>
    {
      { "group", Account() },
      { "max_sub", 50 },
      { "width", Width() },
      { "height", Height() }
    };

    if (Subscribers())
    {
      config["show_subscribers"] = true;
    }
    
    if (!BackgroundColor().IsEmpty())
    {
      config["background"] = BackgroundColor();
    }
    
    if (!TextColor().IsEmpty())
    {
      config["color"] = TextColor();
    }
    
    if (!ButtonColor().IsEmpty())
    {
      config["button_background"] = ButtonColor();
    }
    
    if (!Domain().IsEmpty())
    {
      config["domain"] = Domain();
    }

    return new TagBuilder("a")
      .Attribute("target", "_blank")
      .Attribute("href", $"http://connect.mail.ru/groups_widget?${config.ToUrlQuery()}")
      .Attribute("rel", config.Json())
      .CssClass("mrc__plugin_groups_widget")
      .InnerHtml("Группы")
      .ToString();
  }
}