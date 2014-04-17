using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Renders Mail.ru Group (People In Group) widget.</para>
  ///   <para>Requires <see cref="WidgetsScripts.MailRu"/> script to be included.</para>
  /// </summary>
  /// <seealso cref="http://api.mail.ru/sites/plugins/groups"/>
  public class MailRuGroupsWidget : HtmlWidgetBase, IMailRuGroupsWidget
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
      Assertion.NotEmpty(account);

      this.account = account;
      return this;
    }

    /// <summary>
    ///   <para>Color of Groups box background.</para>
    /// </summary>
    /// <param name="color">Background color.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="color"/> is <see cref="string.Empty"/> string.</exception>
    /// <exception cref="ArgumentException">If <paramref name="color"/> is <see cref="string.Empty"/> string.</exception>
    public IMailRuGroupsWidget BackgroundColor(string color)
    {
      Assertion.NotEmpty(color);

      this.backgroundColor = color;
      return this;
    }

    /// <summary>
    ///   <para>Color of "Subscribe" button in Groups box.</para>
    /// </summary>
    /// <param name="color">Button color.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="color"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="color"/> is <see cref="string.Empty"/> string.</exception>
    public IMailRuGroupsWidget ButtonColor(string color)
    {
      Assertion.NotEmpty(color);

      this.buttonColor = color;
      return this;
    }

    /// <summary>
    ///   <para>Target site domain.</para>
    /// </summary>
    /// <param name="domain">Target domain.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="domain"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="domain"/> is <see cref="string.Empty"/> string.</exception>
    public IMailRuGroupsWidget Domain(string domain)
    {
      Assertion.NotEmpty(domain);

      this.domain = domain;
      return this;
    }

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
      Assertion.NotEmpty(height);

      this.height = height;
      return this;
    }

    /// <summary>
    ///   <para>Whether to show portraits of group's subscribers or not.</para>
    /// </summary>
    /// <param name="show"><c>true</c> to show subscribers, <c>false</c> to hide.</param>
    /// <returns>Reference to the current widget.</returns>
    public IMailRuGroupsWidget Subscribers(bool show = true)
    {
      this.subscribers = show;
      return this;
    }

    /// <summary>
    ///   <para>Color of Groups box text labels.</para>
    /// </summary>
    /// <param name="color">Text color.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="color"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="color"/> is <see cref="string.Empty"/> string.</exception>
    public IMailRuGroupsWidget TextColor(string color)
    {
      Assertion.NotEmpty(color);

      this.textColor = color;
      return this;
    }

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
      Assertion.NotEmpty(width);

      this.width = width;
      return this;
    }

    /// <summary>
    ///   <para>Returns HTML markup text of widget.</para>
    /// </summary>
    /// <returns>Widget's HTML markup.</returns>
    public override string ToHtmlString()
    {
      if (this.account.IsEmpty() || this.width.IsEmpty() || this.height.IsEmpty())
      {
        return string.Empty;
      }

      var config = new Dictionary<string, object> { { "group", this.account }, { "max_sub", 50 }, { "width", this.width }, { "height", this.height } };
      if (this.subscribers)
      {
        config["show_subscribers"] = true;
      }
      if (!this.backgroundColor.IsEmpty())
      {
        config["background"] = this.backgroundColor;
      }
      if (!this.textColor.IsEmpty())
      {
        config["color"] = this.textColor;
      }
      if (!this.buttonColor.IsEmpty())
      {
        config["button_background"] = this.buttonColor;
      }
      if (!this.domain.IsEmpty())
      {
        config["domain"] = this.domain;
      }

      return new TagBuilder("a")
        .Attribute("target", "_blank")
        .Attribute("href", "http://connect.mail.ru/groups_widget?{0}".FormatSelf(config.ToUrlQuery()))
        .Attribute("rel", config.Json())
        .CssClass("mrc__plugin_groups_widget")
        .InnerHtml("Группы")
        .ToString();
    }
  }
}