using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Renders VKontakte OAuth button widget.</para>
  ///   <para>Requires Vkontakte JavaScript initialization to be performed first.</para>
  /// </summary>
  /// <seealso cref="http://vk.com/dev/Auth"/>
  public class VkontakteAuthButtonWidget : HtmlWidget, IVkontakteAuthButtonWidget
  {
    private string callback;
    private string elementId;
    private VkontakteAuthButtonType type = VkontakteAuthButtonType.Standard;
    private string url;
    private string width;

    /// <summary>
    ///   <para>Identifier of HTML container for the widget.</para>
    /// </summary>
    /// <param name="id">HTML element's identifier.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="id"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="id"/> is <see cref="string.Empty"/> string.</exception>
    public IVkontakteAuthButtonWidget ElementId(string id)
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
    ///   <para>Horizontal width of button.</para>
    /// </summary>
    /// <param name="width">Width of button.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="width"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="width"/> is <see cref="string.Empty"/> string.</exception>
    public IVkontakteAuthButtonWidget Width(string width)
    {
      Assertion.NotEmpty(width);

      this.width = width;
      return this;
    }

    /// <summary>
    ///   <para>Horizontal width of button.</para>
    /// </summary>
    /// <returns>Width of button.</returns>
    public string Width()
    {
      return this.width;
    }

    /// <summary>
    ///   <para>URL address of web page to be redirected to, if using standard mode.</para>
    /// </summary>
    /// <param name="url">Target URL web page.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="url"/> is <see cref="string.Empty"/> string.</exception>
    /// <exception cref="ArgumentException">If <paramref name="url"/> is <see cref="string.Empty"/> string.</exception>
    public IVkontakteAuthButtonWidget Url(string url)
    {
      Assertion.NotEmpty(url);

      this.url = url;
      return this;
    }

    /// <summary>
    ///   <para>URL address of web page to be redirected to, if using standard mode.</para>
    /// </summary>
    /// <returns>Target URL web page.</returns>
    public string Url()
    {
      return this.url;
    }

    /// <summary>
    ///   <para>Type of authentication mode to use.</para>
    /// </summary>
    /// <param name="type">Authentication mode.</param>
    /// <returns>Reference to the current widget.</returns>
    public IVkontakteAuthButtonWidget Type(VkontakteAuthButtonType type)
    {
      this.type = type;
      return this;
    }

    /// <summary>
    ///   <para>Type of authentication mode to use.</para>
    /// </summary>
    /// <returns>Authentication mode.</returns>
    public VkontakteAuthButtonType Type()
    {
      return this.type;
    }

    /// <summary>
    ///   <para>Name of JavaScript function to be called after successful authentication, if using dynamic mode.</para>
    /// </summary>
    /// <param name="callback"></param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="callback"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="callback"/> is <see cref="string.Empty"/> string.</exception>
    public IVkontakteAuthButtonWidget Callback(string callback)
    {
      Assertion.NotEmpty(callback);

      this.callback = callback;
      return this;
    }

    /// <summary>
    ///   <para>Name of JavaScript function to be called after successful authentication, if using dynamic mode.</para>
    /// </summary>
    /// <returns>JavaScript callback function.</returns>
    public string Callback()
    {
      return this.callback;
    }

    /// <summary>
    ///   <para>Returns HTML markup text of widget.</para>
    /// </summary>
    /// <returns>Widget's HTML markup.</returns>
    public override string ToHtmlString()
    {
      if (this.Type() == VkontakteAuthButtonType.Dynamic && this.Callback().IsEmpty())
      {
        return string.Empty;
      }

      if (this.Type() == VkontakteAuthButtonType.Standard && this.Url().IsEmpty())
      {
        return string.Empty;
      }

      var elementId = this.ElementId() ?? "vk_auth";

      var config = new Dictionary<string, object>();
      if (!this.Callback().IsEmpty())
      {
        config["onAuth"] = this.Callback();
      }
      if (!this.Url().IsEmpty())
      {
        config["authUrl"] = this.Url();
      }
      if (!this.Width().IsEmpty())
      {
        config["width"] = this.Width();
      }

      return
        new TagBuilder("div").Attribute("id", elementId).ToString() +
        new TagBuilder("script").Attribute("type", "text/javascript").InnerHtml(@"VK.Widgets.Auth(""{0}"", {1});".FormatSelf(elementId, config.Json()));
    }
  }
}