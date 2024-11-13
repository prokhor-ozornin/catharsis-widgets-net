using System.Web.Mvc;
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

  /// <summary>
  ///   <para>Account name of Mail.ru group.</para>
  /// </summary>
  /// <param name="account">Group name.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="account"/> is a <c>null</c> reference.</exception>
  /// <exception cref="ArgumentException">If <paramref name="account"/> is <see cref="string.Empty"/> string.</exception>
  /// <remarks>This attribute is required.</remarks>
  public IMailRuGroupsWidget Account(string account)
  {
    if (account is null) throw new ArgumentNullException(nameof(account));
    if (account.IsEmpty()) throw new ArgumentException(nameof(account));

    this.account = account;
    return this;
  }

  /// <summary>
  ///   <para>Account name of Mail.ru group.</para>
  /// </summary>
  /// <returns>Group name.</returns>
  public string Account() => account;

  /// <summary>
  ///   <para>Color of Groups box background.</para>
  /// </summary>
  /// <param name="color">Background color.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="color"/> is <see cref="string.Empty"/> string.</exception>
  /// <exception cref="ArgumentException">If <paramref name="color"/> is <see cref="string.Empty"/> string.</exception>
  public IMailRuGroupsWidget BackgroundColor(string color)
  {
    if (color is null) throw new ArgumentNullException(nameof(color));
    if (color.IsEmpty()) throw new ArgumentException(nameof(color));

    backgroundColor = color;
    return this;
  }

  /// <summary>
  ///   <para>Color of Groups box background.</para>
  /// </summary>
  /// <returns>Background color.</returns>
  public string BackgroundColor() => backgroundColor;

  /// <summary>
  ///   <para>Color of "Subscribe" button in Groups box.</para>
  /// </summary>
  /// <param name="color">Button color.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="color"/> is a <c>null</c> reference.</exception>
  /// <exception cref="ArgumentException">If <paramref name="color"/> is <see cref="string.Empty"/> string.</exception>
  public IMailRuGroupsWidget ButtonColor(string color)
  {
    if (color is null) throw new ArgumentNullException(nameof(color));
    if (color.IsEmpty()) throw new ArgumentException(nameof(color));

    buttonColor = color;
    return this;
  }

  /// <summary>
  ///   <para>Color of "Subscribe" button in Groups box.</para>
  /// </summary>
  /// <returns>Button color.</returns>
  public string ButtonColor() => buttonColor;

  /// <summary>
  ///   <para>Target site domain.</para>
  /// </summary>
  /// <param name="domain">Target domain.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="domain"/> is a <c>null</c> reference.</exception>
  /// <exception cref="ArgumentException">If <paramref name="domain"/> is <see cref="string.Empty"/> string.</exception>
  public IMailRuGroupsWidget Domain(string domain)
  {
    if (domain is null) throw new ArgumentNullException(nameof(domain));
    if (domain.IsEmpty()) throw new ArgumentException(nameof(domain));

    this.domain = domain;
    return this;
  }

  /// <summary>
  ///   <para>Target site domain.</para>
  /// </summary>
  /// <returns>Target domain.</returns>
  public string Domain() => domain;

  /// <summary>
  ///   <para>Height of Groups box area.</para>
  /// </summary>
  /// <param name="height">Area height.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="height"/> is a <c>null</c> reference.</exception>
  /// <exception cref="ArgumentException">If <paramref name="height"/> is <see cref="string.Empty"/> string.</exception>
  /// <remarks>This attribute is required.</remarks>
  public IMailRuGroupsWidget Height(string height)
  {
    if (height is null) throw new ArgumentNullException(nameof(height));
    if (height.IsEmpty()) throw new ArgumentException(nameof(height));

    this.height = height;
    return this;
  }

  /// <summary>
  ///   <para>Height of Groups box area.</para>
  /// </summary>
  /// <returns>Area height.</returns>
  public string Height() => height;

  /// <summary>
  ///   <para>Whether to show portraits of group's subscribers or not.</para>
  /// </summary>
  /// <param name="show"><c>true</c> to show subscribers, <c>false</c> to hide.</param>
  /// <returns>Reference to the current widget.</returns>
  public IMailRuGroupsWidget Subscribers(bool show)
  {
    subscribers = show;
    return this;
  }

  /// <summary>
  ///   <para>Whether to show portraits of group's subscribers or not.</para>
  /// </summary>
  /// <returns><c>true</c> to show subscribers, <c>false</c> to hide.</returns>
  public bool Subscribers() => subscribers;

  /// <summary>
  ///   <para>Color of Groups box text labels.</para>
  /// </summary>
  /// <param name="color">Text color.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="color"/> is a <c>null</c> reference.</exception>
  /// <exception cref="ArgumentException">If <paramref name="color"/> is <see cref="string.Empty"/> string.</exception>
  public IMailRuGroupsWidget TextColor(string color)
  {
    if (color is null) throw new ArgumentNullException(nameof(color));
    if (color.IsEmpty()) throw new ArgumentException(nameof(color));

    textColor = color;
    return this;
  }

  /// <summary>
  ///   <para>Color of Groups box text labels.</para>
  /// </summary>
  /// <returns>Text color.</returns>
  public string TextColor() => textColor;

  /// <summary>
  ///   <para>Width of Groups box area.</para>
  /// </summary>
  /// <param name="width">Area width.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="width"/> is a <c>null</c> reference.</exception>
  /// <exception cref="ArgumentException">If <paramref name="width"/> is <see cref="string.Empty"/> string.</exception>
  /// <remarks>This attribute is required.</remarks>
  public IMailRuGroupsWidget Width(string width)
  {
    if (width is null) throw new ArgumentNullException(nameof(width));
    if (width.IsEmpty()) throw new ArgumentException(nameof(width));

    this.width = width;
    return this;
  }

  /// <summary>
  ///   <para>Width of Groups box area.</para>
  /// </summary>
  /// <returns>Area width.</returns>
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