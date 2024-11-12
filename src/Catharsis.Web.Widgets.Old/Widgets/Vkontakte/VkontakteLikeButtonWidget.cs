using System;
using System.Collections.Generic;
using System.Text;
using System.Web.Mvc;
using Catharsis.Extensions;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Renders VKontakte "Like" button widget.</para>
  ///   <para>Requires Vkontakte JavaScript initialization to be performed first.</para>
  /// </summary>
  /// <seealso cref="http://vk.com/dev/Like"/>
  public class VkontakteLikeButtonWidget : HtmlWidget, IVkontakteLikeButtonWidget
  {
    private string elementId;
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
    ///   <para>Identifier of HTML container for the widget.</para>
    /// </summary>
    /// <param name="id">HTML element's identifier.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="id"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="id"/> is <see cref="string.Empty"/> string.</exception>
    public IVkontakteLikeButtonWidget ElementId(string id)
    {
      if (id is null) throw new ArgumentNullException(nameof(id));
      if (id.IsEmpty()) throw new ArgumentException(nameof(id));

      elementId = id;

      return this;
    }

    /// <summary>
    ///   <para>Identifier of HTML container for the widget.</para>
    /// </summary>
    /// <returns>HTML element's identifier.</returns>
    public string ElementId() => elementId;

    /// <summary>
    ///   <para>Vertical height of the button in pixels. Default value is "22".</para>
    /// </summary>
    /// <param name="height">Height of button.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="height"/> is a <c>null</c> reference.</exception>
    public IVkontakteLikeButtonWidget Height(string height)
    {
      if (height is null) throw new ArgumentNullException(nameof(height));
      if (height.IsEmpty()) throw new ArgumentException(nameof(height));

      this.height = height;

      return this;
    }

    /// <summary>
    ///   <para>Vertical height of the button in pixels. Default value is "22".</para>
    /// </summary>
    /// <returns>Height of button.</returns>
    public string Height() => height;

    /// <summary>
    ///   <para>Visual layout/appearance of the button.</para>
    /// </summary>
    /// <param name="layout">Layout of button.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="layout"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="layout"/> is <see cref="string.Empty"/> string.</exception>
    public IVkontakteLikeButtonWidget Layout(string layout)
    {
      if (layout is null) throw new ArgumentNullException(nameof(layout));
      if (layout.IsEmpty()) throw new ArgumentException(nameof(layout));

      this.layout = layout;

      return this;
    }

    /// <summary>
    ///   <para>Visual layout/appearance of the button.</para>
    /// </summary>
    /// <returns>Layout of button.</returns>
    public string Layout() => layout;

    /// <summary>
    ///   <para>Description of the page (to display in preview mode for record on the wall).</para>
    /// </summary>
    /// <param name="description">Description of the page.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="description"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="description"/> is <see cref="string.Empty"/> string.</exception>
    public IVkontakteLikeButtonWidget Description(string description)
    {
      if (description is null) throw new ArgumentNullException(nameof(description));
      if (description.IsEmpty()) throw new ArgumentException(nameof(description));

      this.description = description;

      return this;
    }

    /// <summary>
    ///   <para>Description of the page (to display in preview mode for record on the wall).</para>
    /// </summary>
    /// <returns>Description of the page.</returns>
    public string Description() => description;

    /// <summary>
    ///   <para>URL of the thumbnail image (to display in preview mode for record on the wall).</para>
    /// </summary>
    /// <param name="url">URL of post's thumbnail image.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="url"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="url"/> is <see cref="string.Empty"/> string.</exception>
    public IVkontakteLikeButtonWidget Image(string url)
    {
      if (url is null) throw new ArgumentNullException(nameof(url));
      if (url.IsEmpty()) throw new ArgumentException(nameof(url));

      image = url;

      return this;
    }

    /// <summary>
    ///   <para>URL of the thumbnail image (to display in preview mode for record on the wall).</para>
    /// </summary>
    /// <returns>URL of post's thumbnail image.</returns>
    public string Image() => image;

    /// <summary>
    ///   <para>Title of the page (to display in preview mode for record on the wall).</para>
    /// </summary>
    /// <param name="title">Title of the page.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="title"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="title"/> is <see cref="string.Empty"/> string.</exception>
    public IVkontakteLikeButtonWidget Title(string title)
    {
      if (title is null) throw new ArgumentNullException(nameof(title));
      if (title.IsEmpty()) throw new ArgumentException(nameof(title));

      this.title = title;

      return this;
    }

    /// <summary>
    ///   <para>Title of the page (to display in preview mode for record on the wall).</para>
    /// </summary>
    /// <returns>Title of the page.</returns>
    public string Title() => title;
 
    /// <summary>
    ///   <para>URL of the page to "like" (this URL will be shown in a record on the wall). Default is URL of the current page.</para>
    /// </summary>
    /// <param name="url">URL of target web page.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="url"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="url"/> is <see cref="string.Empty"/> string.</exception>
    public IVkontakteLikeButtonWidget Url(string url)
    {
      if (url is null) throw new ArgumentNullException(nameof(url));
      if (url.IsEmpty()) throw new ArgumentException(nameof(url));

      this.url = url;

      return this;
    }

    /// <summary>
    ///   <para>URL of the page to "like" (this URL will be shown in a record on the wall). Default is URL of the current page.</para>
    /// </summary>
    /// <returns>URL of target web page.</returns>
    public string Url() => url;

    /// <summary>
    ///   <para>Text to be published on the wall when "Tell to friends" is pressed. Maximum length is 140 characters. Default value equals to page's title.</para>
    /// </summary>
    /// <param name="text">Text for publishing.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="text"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="text"/> is <see cref="string.Empty"/> string.</exception>
    public IVkontakteLikeButtonWidget Text(string text)
    {
      if (text is null) throw new ArgumentNullException(nameof(text));
      if (text.IsEmpty()) throw new ArgumentException(nameof(text));

      this.text = text;

      return this;
    }

    /// <summary>
    ///   <para>Text to be published on the wall when "Tell to friends" is pressed. Maximum length is 140 characters. Default value equals to page's title.</para>
    /// </summary>
    /// <returns>Text for publishing.</returns>
    public string Text() => text;

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
    ///   <para>Type of text to display on the button.</para>
    /// </summary>
    /// <returns>Displayed button's verb.</returns>
    public byte? Verb() => verb;

    /// <summary>
    ///   <para>Width of button in pixels (integer value > 200, default value is 350). Parameter value has meaning only for a button with a text counter (layout = "full").</para>
    /// </summary>
    /// <param name="width">Width of button.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="width"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="width"/> is <see cref="string.Empty"/> string.</exception>
    public IVkontakteLikeButtonWidget Width(string width)
    {
      if (width is null) throw new ArgumentNullException(nameof(width));
      if (width.IsEmpty()) throw new ArgumentException(nameof(width));

      this.width = width;

      return this;
    }

    /// <summary>
    ///   <para>Width of button in pixels (integer value > 200, default value is 350). Parameter value has meaning only for a button with a text counter (layout = "full").</para>
    /// </summary>
    /// <returns>Width of button.</returns>
    public string Width() => width;

    /// <summary>
    ///   <para>Returns HTML markup text of widget.</para>
    /// </summary>
    /// <returns>Widget's HTML markup.</returns>
    public override string ToHtmlString()
    {
      var config = new Dictionary<string, object>();
      
      if (!Layout().IsEmpty())
      {
        config["type"] = Layout();
      }
      if (!Width().IsEmpty())
      {
        config["width"] = Width();
      }
      if (!Title().IsEmpty())
      {
        config["pageTitle"] = Title();
      }
      if (!Description().IsEmpty())
      {
        config["pageDescription"] = Description();
      }
      if (!Url().IsEmpty())
      {
        config["pageUrl"] = Url();
      }
      if (!Image().IsEmpty())
      {
        config["pageImage"] = Image();
      }
      if (!Text().IsEmpty())
      {
        config["text"] = Text();
      }
      if (!Height().IsEmpty())
      {
        config["height"] = Height();
      }
      if (Verb() is not null)
      {
        config["verb"] = Verb();
      }

      var elementId = ElementId() ?? "vk_like";

      return new StringBuilder()
        .Append(new TagBuilder("div").Attribute("id", elementId))
        .Append(new TagBuilder("script").Attribute("type", "text/javascript").InnerHtml($@"VK.Widgets.Like(""${elementId}"", ${config.Json()});"))
        .ToString();
    }
  }
}