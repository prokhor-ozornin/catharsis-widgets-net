using Catharsis.Extensions;
using Catharsis.Web.Widgets.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IMailRuGroupsWidget"/>
public class MailRuGroupsWidget : WebWidget, IMailRuGroupsWidget
{
  private string AccountProperty { get; set; }
  private string BackgroundColorProperty { get; set; }
  private string ButtonColorProperty { get; set; }
  private string DomainProperty { get; set; }
  private string HeightProperty { get; set; }
  private bool SubscribersProperty { get; set; } = true;
  private string TextColorProperty { get; set; }
  private string WidthProperty { get; set; }

  /// <inheritdoc cref="IMailRuGroupsWidget.Account(string)"/>
  public IMailRuGroupsWidget Account(string account)
  {
    if (account is null) throw new ArgumentNullException(nameof(account));
    if (account.IsEmpty()) throw new ArgumentException(nameof(account));

    AccountProperty = account;
    return this;
  }

  /// <inheritdoc cref="IMailRuGroupsWidget.Account()"/>
  public string Account() => AccountProperty;

  /// <inheritdoc cref="IMailRuGroupsWidget.BackgroundColor(string)"/>
  public IMailRuGroupsWidget BackgroundColor(string color)
  {
    if (color is null) throw new ArgumentNullException(nameof(color));
    if (color.IsEmpty()) throw new ArgumentException(nameof(color));

    BackgroundColorProperty = color;
    return this;
  }

  /// <inheritdoc cref="IMailRuGroupsWidget.BackgroundColor()"/>
  public string BackgroundColor() => BackgroundColorProperty;

  /// <inheritdoc cref="IMailRuGroupsWidget.ButtonColor(string)"/>
  public IMailRuGroupsWidget ButtonColor(string color)
  {
    if (color is null) throw new ArgumentNullException(nameof(color));
    if (color.IsEmpty()) throw new ArgumentException(nameof(color));

    ButtonColorProperty = color;
    return this;
  }

  /// <inheritdoc cref="IMailRuGroupsWidget.ButtonColor()"/>
  public string ButtonColor() => ButtonColorProperty;

  /// <inheritdoc cref="IMailRuGroupsWidget.Domain(string)"/>
  public IMailRuGroupsWidget Domain(string domain)
  {
    if (domain is null) throw new ArgumentNullException(nameof(domain));
    if (domain.IsEmpty()) throw new ArgumentException(nameof(domain));

    DomainProperty = domain;
    return this;
  }

  /// <inheritdoc cref="IMailRuGroupsWidget.Domain()"/>
  public string Domain() => DomainProperty;

  /// <inheritdoc cref="IMailRuGroupsWidget.Height(string)"/>
  public IMailRuGroupsWidget Height(string height)
  {
    if (height is null) throw new ArgumentNullException(nameof(height));
    if (height.IsEmpty()) throw new ArgumentException(nameof(height));

    HeightProperty = height;
    return this;
  }

  /// <inheritdoc cref="IMailRuGroupsWidget.Height()"/>
  public string Height() => HeightProperty;

  /// <inheritdoc cref="IMailRuGroupsWidget.Subscribers(bool)"/>
  public IMailRuGroupsWidget Subscribers(bool enabled)
  {
    SubscribersProperty = enabled;
    return this;
  }

  /// <inheritdoc cref="IMailRuGroupsWidget.Subscribers()"/>
  public bool Subscribers() => SubscribersProperty;

  /// <inheritdoc cref="IMailRuGroupsWidget.TextColor(string)"/>
  public IMailRuGroupsWidget TextColor(string color)
  {
    if (color is null) throw new ArgumentNullException(nameof(color));
    if (color.IsEmpty()) throw new ArgumentException(nameof(color));

    TextColorProperty = color;
    return this;
  }

  /// <inheritdoc cref="IMailRuGroupsWidget.TextColor()"/>
  public string TextColor() => TextColorProperty;

  /// <inheritdoc cref="IMailRuGroupsWidget.Width(string)"/>
  public IMailRuGroupsWidget Width(string width)
  {
    if (width is null) throw new ArgumentNullException(nameof(width));
    if (width.IsEmpty()) throw new ArgumentException(nameof(width));

    WidthProperty = width;
    return this;
  }

  /// <inheritdoc cref="IMailRuGroupsWidget.Width()"/>
  public string Width() => WidthProperty;

  /// <inheritdoc cref="IHtmlContent.ToHtml()"/>
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
      .Html("Группы")
      .ToString();
  }
}