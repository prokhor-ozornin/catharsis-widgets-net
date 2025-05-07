using Catharsis.Extensions;
using Catharsis.Web.Widgets.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IMailRuGroupsWidget"/>
public class MailRuGroupsWidget : WebWidget, IMailRuGroupsWidget
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
  protected virtual string DomainValue { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string HeightValue { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual bool SubscribersValue { get; set; } = true;

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string TextColorValue { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string WidthValue { get; set; }

  /// <inheritdoc cref="IMailRuGroupsWidget.Account(string)"/>
  public virtual IMailRuGroupsWidget Account(string account)
  {
    if (account is null) throw new ArgumentNullException(nameof(account));
    if (account.IsEmpty()) throw new ArgumentException(nameof(account));

    AccountValue = account;
    return this;
  }

  /// <inheritdoc cref="IMailRuGroupsWidget.BackgroundColor(string)"/>
  public virtual IMailRuGroupsWidget BackgroundColor(string color)
  {
    if (color is null) throw new ArgumentNullException(nameof(color));
    if (color.IsEmpty()) throw new ArgumentException(nameof(color));

    BackgroundColorValue = color;
    return this;
  }

  /// <inheritdoc cref="IMailRuGroupsWidget.ButtonColor(string)"/>
  public virtual IMailRuGroupsWidget ButtonColor(string color)
  {
    if (color is null) throw new ArgumentNullException(nameof(color));
    if (color.IsEmpty()) throw new ArgumentException(nameof(color));

    ButtonColorValue = color;
    return this;
  }

  /// <inheritdoc cref="IMailRuGroupsWidget.Domain(string)"/>
  public virtual IMailRuGroupsWidget Domain(string domain)
  {
    if (domain is null) throw new ArgumentNullException(nameof(domain));
    if (domain.IsEmpty()) throw new ArgumentException(nameof(domain));

    DomainValue = domain;
    return this;
  }

  /// <inheritdoc cref="IMailRuGroupsWidget.Height(string)"/>
  public virtual IMailRuGroupsWidget Height(string height)
  {
    if (height is null) throw new ArgumentNullException(nameof(height));
    if (height.IsEmpty()) throw new ArgumentException(nameof(height));

    HeightValue = height;
    return this;
  }

  /// <inheritdoc cref="IMailRuGroupsWidget.Subscribers(bool)"/>
  public virtual IMailRuGroupsWidget Subscribers(bool enabled)
  {
    SubscribersValue = enabled;
    return this;
  }

  /// <inheritdoc cref="IMailRuGroupsWidget.TextColor(string)"/>
  public virtual IMailRuGroupsWidget TextColor(string color)
  {
    if (color is null) throw new ArgumentNullException(nameof(color));
    if (color.IsEmpty()) throw new ArgumentException(nameof(color));

    TextColorValue = color;
    return this;
  }

  /// <inheritdoc cref="IMailRuGroupsWidget.Width(string)"/>
  public virtual IMailRuGroupsWidget Width(string width)
  {
    if (width is null) throw new ArgumentNullException(nameof(width));
    if (width.IsEmpty()) throw new ArgumentException(nameof(width));

    WidthValue = width;
    return this;
  }

  /// <inheritdoc cref="ICloneable.Clone()"/>
  public override object Clone() => new MailRuGroupsWidget
  {
    AccountValue = AccountValue,
    BackgroundColorValue = BackgroundColorValue,
    ButtonColorValue = ButtonColorValue,
    DomainValue = DomainValue,
    HeightValue = HeightValue,
    SubscribersValue = SubscribersValue,
    TextColorValue = TextColorValue,
    WidthValue = WidthValue
  };

  /// <inheritdoc cref="IWebWidget.ToHtml()"/>
  public override string ToHtml()
  {
    if (AccountValue.IsUnset() || WidthValue.IsUnset() || HeightValue.IsUnset())
    {
      return string.Empty;
    }

    var config = new Dictionary<string, object>
    {
      { "group", AccountValue },
      { "max_sub", 50 },
      { "width", WidthValue },
      { "height", HeightValue }
    };

    if (SubscribersValue)
    {
      config["show_subscribers"] = true;
    }
    
    if (!BackgroundColorValue.IsUnset())
    {
      config["background"] = BackgroundColorValue;
    }
    
    if (!TextColorValue.IsUnset())
    {
      config["color"] = TextColorValue;
    }
    
    if (!ButtonColorValue.IsUnset())
    {
      config["button_background"] = ButtonColorValue;
    }
    
    if (!DomainValue.IsUnset())
    {
      config["domain"] = DomainValue;
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