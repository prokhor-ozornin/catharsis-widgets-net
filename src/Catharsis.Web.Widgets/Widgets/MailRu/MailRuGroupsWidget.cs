using Catharsis.Extensions;
using Catharsis.Web.Widgets.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IMailRuGroupsWidget"/>
public class MailRuGroupsWidget : WebWidget, IMailRuGroupsWidget
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
  protected virtual string DomainProperty { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string HeightProperty { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual bool SubscribersProperty { get; set; } = true;

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string TextColorProperty { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string WidthProperty { get; set; }

  /// <inheritdoc cref="IMailRuGroupsWidget.Account(string)"/>
  public virtual IMailRuGroupsWidget Account(string account)
  {
    if (account is null) throw new ArgumentNullException(nameof(account));
    if (account.IsEmpty()) throw new ArgumentException(nameof(account));

    AccountProperty = account;
    return this;
  }

  /// <inheritdoc cref="IMailRuGroupsWidget.BackgroundColor(string)"/>
  public virtual IMailRuGroupsWidget BackgroundColor(string color)
  {
    if (color is null) throw new ArgumentNullException(nameof(color));
    if (color.IsEmpty()) throw new ArgumentException(nameof(color));

    BackgroundColorProperty = color;
    return this;
  }

  /// <inheritdoc cref="IMailRuGroupsWidget.ButtonColor(string)"/>
  public virtual IMailRuGroupsWidget ButtonColor(string color)
  {
    if (color is null) throw new ArgumentNullException(nameof(color));
    if (color.IsEmpty()) throw new ArgumentException(nameof(color));

    ButtonColorProperty = color;
    return this;
  }

  /// <inheritdoc cref="IMailRuGroupsWidget.Domain(string)"/>
  public virtual IMailRuGroupsWidget Domain(string domain)
  {
    if (domain is null) throw new ArgumentNullException(nameof(domain));
    if (domain.IsEmpty()) throw new ArgumentException(nameof(domain));

    DomainProperty = domain;
    return this;
  }

  /// <inheritdoc cref="IMailRuGroupsWidget.Height(string)"/>
  public virtual IMailRuGroupsWidget Height(string height)
  {
    if (height is null) throw new ArgumentNullException(nameof(height));
    if (height.IsEmpty()) throw new ArgumentException(nameof(height));

    HeightProperty = height;
    return this;
  }

  /// <inheritdoc cref="IMailRuGroupsWidget.Subscribers(bool)"/>
  public virtual IMailRuGroupsWidget Subscribers(bool enabled)
  {
    SubscribersProperty = enabled;
    return this;
  }

  /// <inheritdoc cref="IMailRuGroupsWidget.TextColor(string)"/>
  public virtual IMailRuGroupsWidget TextColor(string color)
  {
    if (color is null) throw new ArgumentNullException(nameof(color));
    if (color.IsEmpty()) throw new ArgumentException(nameof(color));

    TextColorProperty = color;
    return this;
  }

  /// <inheritdoc cref="IMailRuGroupsWidget.Width(string)"/>
  public virtual IMailRuGroupsWidget Width(string width)
  {
    if (width is null) throw new ArgumentNullException(nameof(width));
    if (width.IsEmpty()) throw new ArgumentException(nameof(width));

    WidthProperty = width;
    return this;
  }

  /// <inheritdoc cref="IHtmlContent.ToHtml()"/>
  public override string ToHtml()
  {
    if (AccountProperty.IsEmpty() || WidthProperty.IsEmpty() || HeightProperty.IsEmpty())
    {
      return string.Empty;
    }

    var config = new Dictionary<string, object>
    {
      { "group", AccountProperty },
      { "max_sub", 50 },
      { "width", WidthProperty },
      { "height", HeightProperty }
    };

    if (SubscribersProperty)
    {
      config["show_subscribers"] = true;
    }
    
    if (!BackgroundColorProperty.IsEmpty())
    {
      config["background"] = BackgroundColorProperty;
    }
    
    if (!TextColorProperty.IsEmpty())
    {
      config["color"] = TextColorProperty;
    }
    
    if (!ButtonColorProperty.IsEmpty())
    {
      config["button_background"] = ButtonColorProperty;
    }
    
    if (!DomainProperty.IsEmpty())
    {
      config["domain"] = DomainProperty;
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