using System;
using System.Collections.Generic;
using System.Text;
using System.Web.Mvc;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Renders VKontakte community widget.</para>
  ///   <para>Requires Vkontakte JavaScript initialization to be performed first.</para>
  /// </summary>
  /// <seealso cref="http://vk.com/dev/Community"/>
  public class VkontakteCommunityWidget : HtmlWidget, IVkontakteCommunityWidget
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
      Assertion.NotEmpty(account);

      this.account = account;
      return this;
    }

    /// <summary>
    ///   <para>Identifier or VKontakte public group/community.</para>
    /// </summary>
    /// <returns>Group identifier.</returns>
    public string Account()
    {
      return this.account;
    }

    /// <summary>
    ///   <para>Background color of widget.</para>
    /// </summary>
    /// <param name="color">Widget's background color in RRGGBB format.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="color"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="color"/> is <see cref="string.Empty"/> string.</exception>
    public IVkontakteCommunityWidget BackgroundColor(string color)
    {
      Assertion.NotEmpty(color);

      this.backgroundColor = color;
      return this;
    }

    /// <summary>
    ///   <para>Background color of widget.</para>
    /// </summary>
    /// <returns>Widget's background color in RRGGBB format.</returns>
    public string BackgroundColor()
    {
      return this.backgroundColor;
    }

    /// <summary>
    ///   <para>Text color of widget.</para>
    /// </summary>
    /// <param name="color">Widget's text color in RRGGBB format.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="color"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="color"/> is <see cref="string.Empty"/> string.</exception>
    public IVkontakteCommunityWidget TextColor(string color)
    {
      Assertion.NotEmpty(color);

      this.textColor = color;
      return this;
    }

    /// <summary>
    ///   <para>Text color of widget.</para>
    /// </summary>
    /// <returns>Widget's text color in RRGGBB format.</returns>
    public string TextColor()
    {
      return this.textColor;
    }

    /// <summary>
    ///   <para>Button color of widget.</para>
    /// </summary>
    /// <param name="color">Widget's button color in RRGGBB format.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="color"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="color"/> is <see cref="string.Empty"/> string.</exception>
    public IVkontakteCommunityWidget ButtonColor(string color)
    {
      Assertion.NotEmpty(color);

      this.buttonColor = color;
      return this;
    }

    /// <summary>
    ///   <para>Button color of widget.</para>
    /// </summary>
    /// <returns>Widget's button color in RRGGBB format.</returns>
    public string ButtonColor()
    {
      return this.buttonColor;
    }

    /// <summary>
    ///   <para>Identifier of HTML container for the widget.</para>
    /// </summary>
    /// <param name="id">HTML element's identifier.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="id"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="id"/> is <see cref="string.Empty"/> string.</exception>
    public IVkontakteCommunityWidget ElementId(string id)
    {
      Assertion.NotEmpty(id);

      this.elementId = id;
      return this;
    }

    /// <summary>
    ///   <para>Identifier of HTML container for the widget.</para>
    /// </summary>
    /// <returns>HTML element's identifier.</returns>
    public string ElementId()
    {
      return this.elementId;
    }

    /// <summary>
    ///   <para>Vertical height of widget.</para>
    /// </summary>
    /// <param name="height">Height of widget.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="height"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="height"/> is <see cref="string.Empty"/> string.</exception>
    public IVkontakteCommunityWidget Height(string height)
    {
      Assertion.NotEmpty(height);

      this.height = height;
      return this;
    }

    /// <summary>
    ///   <para>Vertical height of widget.</para>
    /// </summary>
    /// <returns>Height of widget.</returns>
    public string Height()
    {
      return this.height;
    }

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
    public byte Mode()
    {
      return this.mode;
    }

    /// <summary>
    ///   <para>Horizontal width of widget.</para>
    /// </summary>
    /// <param name="width">Width of widget.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="width"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="width"/> is <see cref="string.Empty"/> string.</exception>
    public IVkontakteCommunityWidget Width(string width)
    {
      Assertion.NotEmpty(width);

      this.width = width;
      return this;
    }

    /// <summary>
    ///   <para>Horizontal width of widget.</para>
    /// </summary>
    /// <returns>Width of widget.</returns>
    public string Width()
    {
      return this.width;
    }

    /// <summary>
    ///   <para>Returns HTML markup text of widget.</para>
    /// </summary>
    /// <returns>Widget's HTML markup.</returns>
    public override string ToHtmlString()
    {
      if (this.Account().IsEmpty())
      {
        return string.Empty;
      }

      var config = new Dictionary<string, object>
      {
        { "mode", this.Mode() }
      };
      
      if (this.Mode() == (byte)VkontakteCommunityMode.News)
      {
        config["wide"] = 1;
      }
      if (!this.Width().IsEmpty())
      {
        config["width"] = this.Width();
      }
      if (!this.Height().IsEmpty())
      {
        config["height"] = this.Height();
      }
      if (!this.BackgroundColor().IsEmpty())
      {
        config["color1"] = this.BackgroundColor();
      }
      if (!this.TextColor().IsEmpty())
      {
        config["color2"] = this.TextColor();
      }
      if (!this.ButtonColor().IsEmpty())
      {
        config["color3"] = this.ButtonColor();
      }

      var elementId = this.ElementId() ?? "vk_groups_{0}".FormatSelf(this.Account());

      return new StringBuilder()
        .Append(new TagBuilder("div").Attribute("id", elementId))
        .Append(new TagBuilder("script").Attribute("type", "text/javascript").InnerHtml(@"VK.Widgets.Group(""{0}"", {1}, ""{2}"");".FormatSelf(elementId, config.Json(), this.Account())))
        .ToString();
    }
  }
}