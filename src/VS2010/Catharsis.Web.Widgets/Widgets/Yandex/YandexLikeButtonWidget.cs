using System;
using System.Text;
using System.Web.Mvc;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Renders Yandex "Like" button.</para>
  /// </summary>
  public class YandexLikeButtonWidget : HtmlWidget, IYandexLikeButtonWidget
  {
    private string url;
    private string title;
    private string size = YandexLikeButtonSize.Large.ToString().ToLowerInvariant();
    private string layout = YandexLikeButtonLayout.Button.ToString().ToLowerInvariant();
    private string text;

    /// <summary>
    ///   <para>Visual layout/appearance of the button.</para>
    /// </summary>
    /// <param name="layout">Layout of button.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="layout"/> is <see cref="string.Empty"/> string.</exception>
    /// <exception cref="ArgumentException">If <paramref name="layout"/> is <see cref="string.Empty"/> string.</exception>
    public IYandexLikeButtonWidget Layout(string layout)
    {
      Assertion.NotEmpty(layout);

      this.layout = layout;
      return this;
    }

    /// <summary>
    ///   <para>Visual layout/appearance of the button.</para>
    /// </summary>
    /// <returns>Layout of button.</returns>
    public string Layout()
    {
      return this.layout;
    }

    /// <summary>
    ///   <para>Size of the button.</para>
    /// </summary>
    /// <param name="size">Size of button.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="size"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="size"/> is <see cref="string.Empty"/> string.</exception>
    public IYandexLikeButtonWidget Size(string size)
    {
      Assertion.NotEmpty(size);

      this.size = size;
      return this;
    }

    /// <summary>
    ///   <para>Size of the button.</para>
    /// </summary>
    /// <returns>Size of button.</returns>
    public string Size()
    {
      return this.size;
    }

    /// <summary>
    ///   <para>Label text to draw on the button.</para>
    /// </summary>
    /// <param name="text">Label text.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="text"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="text"/> is <see cref="string.Empty"/> string.</exception>
    public IYandexLikeButtonWidget Text(string text)
    {
      Assertion.NotEmpty(text);

      this.text = text;
      return this;
    }

    /// <summary>
    ///   <para>Label text to draw on the button.</para>
    /// </summary>
    /// <returns>Label text.</returns>
    public string Text()
    {
      return this.text;
    }

    /// <summary>
    ///   <para>Custom title text for shared page.</para>
    /// </summary>
    /// <param name="title">Title text.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="title"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="title"/> is <see cref="string.Empty"/> string.</exception>
    public IYandexLikeButtonWidget Title(string title)
    {
      Assertion.NotEmpty(title);

      this.title = title;
      return this;
    }

    /// <summary>
    ///   <para>Custom title text for shared page.</para>
    /// </summary>
    /// <returns>Title text.</returns>
    public string Title()
    {
      return this.title;
    }

    /// <summary>
    ///   <para>URL address of web page to share.</para>
    /// </summary>
    /// <param name="url">URL address of web page.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="url"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="url"/> is <see cref="string.Empty"/> string.</exception>
    public IYandexLikeButtonWidget Url(string url)
    {
      Assertion.NotEmpty(url);

      this.url = url;
      return this;
    }

    /// <summary>
    ///   <para>URL address of web page to share.</para>
    /// </summary>
    /// <returns>URL address of web page.</returns>
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
      return new StringBuilder()
        .Append(new TagBuilder("a")
          .Attribute("name", "ya-share")
          .Attribute("type", this.Layout())
          .Attribute("size", this.Size())
          .Attribute("share_text", this.Text())
          .Attribute("share_url", this.Url())
          .Attribute("share_title", this.Title()))
        .Append(resources.yandex_like)
        .ToString();
    }
  }
}