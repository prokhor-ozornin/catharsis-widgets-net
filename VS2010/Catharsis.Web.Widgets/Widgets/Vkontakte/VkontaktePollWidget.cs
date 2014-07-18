using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Renders Vkontakte Poll widget.</para>
  ///   <para>Requires Vkontakte JavaScript initialization to be performed first.</para>
  /// </summary>
  /// <seealso cref="http://vk.com/dev/Poll"/>
  public class VkontaktePollWidget : HtmlWidget, IVkontaktePollWidget
  {
    private string elementId;
    private string id;
    private string url;
    private string width;

    /// <summary>
    ///   <para>Unique identifier of poll.</para>
    /// </summary>
    /// <param name="id">Identifier of poll.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="id"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="id"/> is <see cref="string.Empty"/> string.</exception>
    /// <remarks>This attribute is required.</remarks>
    public IVkontaktePollWidget Id(string id)
    {
      Assertion.NotEmpty(id);

      this.id = id;
      return this;
    }

    /// <summary>
    ///   <para>Unique identifier of poll.</para>
    /// </summary>
    /// <returns>Identifier of poll.</returns>
    public string Id()
    {
      return this.id;
    }

    /// <summary>
    ///   <para>Identifier of HTML container for the widget.</para>
    /// </summary>
    /// <param name="id">HTML element's identifier.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="id"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="id"/> is <see cref="string.Empty"/> string.</exception>
    public IVkontaktePollWidget ElementId(string id)
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
    ///   <para>Horizontal width of widget.</para>
    /// </summary>
    /// <param name="width">Width of widget.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="width"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="width"/> is <see cref="string.Empty"/> string.</exception>
    public IVkontaktePollWidget Width(string width)
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
    ///   <para>URL address of poll's web page, if it differs from the current one.</para>
    /// </summary>
    /// <param name="url">Poll's web page URL.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="url"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="url"/> is <see cref="string.Empty"/> string.</exception>
    public IVkontaktePollWidget Url(string url)
    {
      Assertion.NotEmpty(url);

      this.url = url;
      return this;
    }

    /// <summary>
    ///   <para>URL address of poll's web page, if it differs from the current one.</para>
    /// </summary>
    /// <returns>Poll's web page URL.</returns>
    public string Url()
    {
      return this.url;
    }

    /// <summary>
    ///   <para>Returns HTML markup text of widget.</para>
    /// </summary>
    /// <returns>Widget's HTML markup.</returns>
    public override string ToHtmlString()
    {
      if (this.Id().IsEmpty())
      {
        return string.Empty;
      }

      var config = new Dictionary<string, object>();
      if (!this.Url().IsEmpty())
      {
        config["pageUrl"] = this.Url();
      }
      if (!this.Width().IsEmpty())
      {
        config["width"] = this.Width();
      }

      var elementId = this.ElementId() ?? "vk_poll_{0}".FormatSelf(this.Id());
      
      return new TagBuilder("div").Attribute("id", elementId).ToString() + new TagBuilder("script").Attribute("type", "text/javascript").InnerHtml(@"VK.Widgets.Poll(""{0}"", {1}, ""{2}"");".FormatSelf(elementId, config.Json(), this.Id()));
    }
  }
}