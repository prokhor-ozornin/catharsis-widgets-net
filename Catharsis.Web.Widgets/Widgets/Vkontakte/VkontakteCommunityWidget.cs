using System;
using System.Collections.Generic;
using System.Text;
using System.Web.Mvc;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Renders VKontakte community widget.</para>
  ///   <para>Requires <see cref="WidgetsScripts.VKontakte"/> script to be included.</para>
  /// </summary>
  /// <seealso cref="http://vk.com/dev/Community"/>
  public class VkontakteCommunityWidget : HtmlWidgetBase, IVkontakteCommunityWidget
  {
    private string account;
    private byte mode = (byte) VkontakteCommunityMode.Participants;
    private string width;
    private string height;

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
    ///   <para>Returns HTML markup text of widget.</para>
    /// </summary>
    /// <returns>Widget's HTML markup.</returns>
    public override string ToHtmlString()
    {
      if (this.account.IsEmpty())
      {
        return string.Empty;
      }

      var config = new Dictionary<string, object> { { "mode", this.mode } };
      
      if (this.mode == (byte)VkontakteCommunityMode.News)
      {
        config["wide"] = 1;
      }
      if (!this.width.IsEmpty())
      {
        config["width"] = this.width;
      }
      if (!this.height.IsEmpty())
      {
        config["height"] = this.height;
      }

      return new StringBuilder()
        .Append(new TagBuilder("div").Attribute("id", "vk_groups"))
        .Append(new TagBuilder("script").Attribute("type", "text/javascript").InnerHtml(@"VK.Widgets.Group(""vk_groups"", {0}, ""{1}"");".FormatSelf(config.Json(), this.account)))
        .ToString();
    }
  }
}