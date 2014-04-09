using System;
using System.Collections.Generic;
using System.IO;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Renders VKontakte page subscription widget.</para>
  ///   <para>Requires <see cref="WidgetsScripts.VKontakte"/> script to be included.</para>
  /// </summary>
  /// <seealso cref="http://vk.com/dev/Subscribe"/>
  public sealed class VkontakteSubscriptionWidget : HtmlWidgetBase, IVkontakteSubscriptionWidget
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
    ///   <para>Whether to display both author and button or button only.</para>
    /// </summary>
    /// <param name="onlyButton"><c>false</c> to display both author/button, <c>true</c> to display only button.</param>
    /// <returns>Reference to the current widget.</returns>
    public IVkontakteSubscriptionWidget OnlyButton(bool onlyButton = true)
    {
      this.onlyButton = onlyButton;
      return this;
    }

    /// <summary>
    ///   <para>Generates and writes HTML markup of widget, using specified text writer.</para>
    /// </summary>
    /// <param name="writer">Text writer to use as output destination.</param>
    public override void Write(TextWriter writer)
    {
      Assertion.NotNull(writer);

      if (this.account.IsEmpty())
      {
        return;
      }

      var config = new Dictionary<string, object> { { "mode", this.layout } };
      if (this.onlyButton)
      {
        config["soft"] = 1;
      }

      writer.Write(this.ToTag("div", tag => tag.Attribute("id", "vk_subscribe")));
      writer.Write(this.JavaScript(@"VK.Widgets.Subscribe(""vk_subscribe"", {0}, ""{1}"");".FormatSelf(config.Json(), this.account)));
    }
  }
}