using System;
using System.Collections.Generic;
using System.Text;
using System.Web.Mvc;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Renders VKontakte "Like" button widget.</para>
  ///   <para>Requires Vkontakte JavaScript initialization to be performed first.</para>
  /// </summary>
  /// <seealso cref="http://vk.com/dev/Like"/>
  public class VkontakteLikeButtonWidget : HtmlWidget, IVkontakteLikeButtonWidget
  {
    private string text;
    private byte? verb;
    private string layout;
    private string width;
    private string height;
    private string title;
    private string url;
    private string description;
    private string image;

    /// <summary>
    ///   <para>Vertical height of the button in pixels. Default value is "22".</para>
    /// </summary>
    /// <param name="height">Height of button.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="height"/> is a <c>null</c> reference.</exception>
    public IVkontakteLikeButtonWidget Height(string height)
    {
      Assertion.NotEmpty(height);

      this.height = height;
      return this;
    }

    /// <summary>
    ///   <para>Visual layout/appearance of the button.</para>
    /// </summary>
    /// <param name="layout">Layout of button.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="layout"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="layout"/> is <see cref="string.Empty"/> string.</exception>
    public IVkontakteLikeButtonWidget Layout(string layout)
    {
      Assertion.NotEmpty(layout);

      this.layout = layout;
      return this;
    }

    /// <summary>
    ///   <para>Description of the page (to display in preview mode for record on the wall).</para>
    /// </summary>
    /// <param name="description">Description of the page.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="description"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="description"/> is <see cref="string.Empty"/> string.</exception>
    public IVkontakteLikeButtonWidget Description(string description)
    {
      Assertion.NotEmpty(description);

      this.description = description;
      return this;
    }

    /// <summary>
    ///   <para>URL of the thumbnail image (to display in preview mode for record on the wall).</para>
    /// </summary>
    /// <param name="url">URL of post's thumbnail image.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="url"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="url"/> is <see cref="string.Empty"/> string.</exception>
    public IVkontakteLikeButtonWidget Image(string url)
    {
      Assertion.NotEmpty(url);

      this.image = url;
      return this;
    }

    /// <summary>
    ///   <para>Title of the page (to display in preview mode for record on the wall).</para>
    /// </summary>
    /// <param name="title">Title of the page.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="title"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="title"/> is <see cref="string.Empty"/> string.</exception>
    public IVkontakteLikeButtonWidget Title(string title)
    {
      Assertion.NotEmpty(title);

      this.title = title;
      return this;
    }

    /// <summary>
    ///   <para>URL of the page to "like" (this URL will be shown in a record on the wall). Default is URL of the current page.</para>
    /// </summary>
    /// <param name="url">URL of target web page.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="url"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="url"/> is <see cref="string.Empty"/> string.</exception>
    public IVkontakteLikeButtonWidget Url(string url)
    {
      Assertion.NotEmpty(url);

      this.url = url;
      return this;
    }

    /// <summary>
    ///   <para>Text to be published on the wall when "Tell to friends" is pressed. Maximum length is 140 characters. Default value equals to page's title.</para>
    /// </summary>
    /// <param name="text">Text for publishing.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="text"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="text"/> is <see cref="string.Empty"/> string.</exception>
    public IVkontakteLikeButtonWidget Text(string text)
    {
      Assertion.NotEmpty(text);

      this.text = text;
      return this;
    }

    /// <summary>
    ///   <para>Type of text to display on the button.</para>
    /// </summary>
    /// <param name="verb">Displayed button's verb.</param>
    /// <returns>Reference to the current widget.</returns>
    public IVkontakteLikeButtonWidget Verb(byte verb)
    {
      this.verb = verb;
      return this;
    }

    /// <summary>
    ///   <para>Width of button in pixels (integer value > 200, default value is 350). Parameter value has meaning only for a button with a text counter (layout = "full").</para>
    /// </summary>
    /// <param name="width">Width of button.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="width"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="width"/> is <see cref="string.Empty"/> string.</exception>
    public IVkontakteLikeButtonWidget Width(string width)
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
      var config = new Dictionary<string, object>();
      
      if (!this.layout.IsEmpty())
      {
        config["type"] = this.layout;
      }
      if (!this.width.IsEmpty())
      {
        config["width"] = this.width;
      }
      if (!this.title.IsEmpty())
      {
        config["pageTitle"] = this.title;
      }
      if (!this.description.IsEmpty())
      {
        config["pageDescription"] = this.description;
      }
      if (!this.url.IsEmpty())
      {
        config["pageUrl"] = this.url;
      }
      if (!this.image.IsEmpty())
      {
        config["pageImage"] = this.image;
      }
      if (!this.text.IsEmpty())
      {
        config["text"] = this.text;
      }
      if (!this.height.IsEmpty())
      {
        config["height"] = this.height;
      }
      if (this.verb != null)
      {
        config["verb"] = this.verb;
      }

      return new StringBuilder()
        .Append(new TagBuilder("div").Attribute("id", "vk_like"))
        .Append(new TagBuilder("script").Attribute("type", "text/javascript").InnerHtml(@"VK.Widgets.Like(""vk_like"", {0});".FormatSelf(config.Json())))
        .ToString();
    }
  }
}