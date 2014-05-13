using System;
using System.Collections.Generic;
using System.Text;
using System.Web.Mvc;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Renders VKontakte page subscription widget.</para>
  ///   <para>Requires Vkontakte JavaScript initialization to be performed first.</para>
  /// </summary>
  /// <seealso cref="http://vk.com/dev/Subscribe"/>
  public class VkontakteSubscriptionWidget : HtmlWidget, IVkontakteSubscriptionWidget
  {
    private string account;
    private byte layout = (byte) VkontakteSubscribeButtonLayout.First;
    private bool onlyButton;

    /// <summary>
    ///   <para>Identifier of user/group to subscribe to.</para>
    /// </summary>
    /// <param name="account">Account to subscribe to.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="account"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="account"/> is <see cref="string.Empty"/> string.</exception>
    /// <remarks>This attribute is required.</remarks>
    public IVkontakteSubscriptionWidget Account(string account)
    {
      Assertion.NotEmpty(account);

      this.account = account;
      return this;
    }

    /// <summary>
    ///   <para>Identifier of user/group to subscribe to.</para>
    /// </summary>
    /// <returns>Account to subscribe to.</returns>
    public string Account()
    {
      return this.account;
    }

    /// <summary>
    ///   <para>Visual layout/appearance of the button.</para>
    /// </summary>
    /// <param name="layout">Layout of button.</param>
    /// <returns>Reference to the current widget.</returns>
    public IVkontakteSubscriptionWidget Layout(byte layout)
    {
      this.layout = layout;
      return this;
    }

    /// <summary>
    ///   <para>Visual layout/appearance of the button.</para>
    /// </summary>
    /// <returns>Layout of button.</returns>
    public byte Layout()
    {
      return this.layout;
    }

    /// <summary>
    ///   <para>Whether to display both author and button or button only.</para>
    /// </summary>
    /// <param name="onlyButton"><c>false</c> to display both author/button, <c>true</c> to display only button.</param>
    /// <returns>Reference to the current widget.</returns>
    public IVkontakteSubscriptionWidget OnlyButton(bool onlyButton)
    {
      this.onlyButton = onlyButton;
      return this;
    }

    /// <summary>
    ///   <para>Whether to display both author and button or button only.</para>
    /// </summary>
    /// <returns><c>false</c> to display both author/button, <c>true</c> to display only button.</returns>
    public bool OnlyButton()
    {
      return this.onlyButton;
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
        { "mode", this.Layout() }
      };

      if (this.OnlyButton())
      {
        config["soft"] = 1;
      }

      return new StringBuilder()
        .Append(new TagBuilder("div").Attribute("id", "vk_subscribe"))
        .Append(new TagBuilder("script").Attribute("type", "text/javascript").InnerHtml(@"VK.Widgets.Subscribe(""vk_subscribe"", {0}, ""{1}"");".FormatSelf(config.Json(), this.Account())))
        .ToString();
    }
  }
}