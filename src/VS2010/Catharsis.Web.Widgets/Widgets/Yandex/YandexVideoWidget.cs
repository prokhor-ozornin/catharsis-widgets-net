using System;
using System.Web.Mvc;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Renders embedded Yandex video on web page.</para>
  /// </summary>
  public class YandexVideoWidget : HtmlWidget, IYandexVideoWidget
  {
    private string id;
    private string width;
    private string height;
    private string user;

    /// <summary>
    ///   <para>Identifier of video.</para>
    /// </summary>
    /// <param name="id">Identifier of video.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="id"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="id"/> is <see cref="string.Empty"/> string.</exception>
    /// <remarks>This attribute is required.</remarks>
    public IYandexVideoWidget Id(string id)
    {
      Assertion.NotEmpty(id);

      this.id = id;
      return this;
    }

    /// <summary>
    ///   <para>Identifier of video.</para>
    /// </summary>
    /// <returns>Identifier of video.</returns>
    public string Id()
    {
      return this.id;
    }

    /// <summary>
    ///   <para>Height of video control.</para>
    /// </summary>
    /// <param name="height">Height of video.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="height"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="height"/> is <see cref="string.Empty"/> string.</exception>
    /// <remarks>This attribute is required.</remarks>
    public IYandexVideoWidget Height(string height)
    {
      Assertion.NotEmpty(height);

      this.height = height;
      return this;
    }

    /// <summary>
    ///   <para>Height of video control.</para>
    /// </summary>
    /// <returns>Height of video.</returns>
    public string Height()
    {
      return this.height;
    }

    /// <summary>
    ///   <para>Account identifier of video's uploader.</para>
    /// </summary>
    /// <param name="user">User's account identifier.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="user"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="user"/> is <see cref="string.Empty"/> string.</exception>
    public IYandexVideoWidget User(string user)
    {
      Assertion.NotEmpty(user);

      this.user = user;
      return this;
    }

    /// <summary>
    ///   <para>Account identifier of video's uploader.</para>
    /// </summary>
    /// <returns>User's account identifier.</returns>
    public string User()
    {
      return this.user;
    }

    /// <summary>
    ///   <para>Width of video control.</para>
    /// </summary>
    /// <param name="width">Width of video.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="width"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="width"/> is <see cref="string.Empty"/> string.</exception>
    /// <remarks>This attribute is required.</remarks>
    public IYandexVideoWidget Width(string width)
    {
      Assertion.NotEmpty(width);

      this.width = width;
      return this;
    }

    /// <summary>
    ///   <para>Width of video control.</para>
    /// </summary>
    /// <returns>Width of video.</returns>
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
      if (this.Id().IsEmpty() || this.User().IsEmpty() || this.Height().IsEmpty() || this.Width().IsEmpty())
      {
        return string.Empty;
      }

      return new TagBuilder("iframe")
        .Attribute("src", "http://video.yandex.ru/iframe/{1}/{0}".FormatSelf(this.Id(), this.User()))
        .Attribute("width", this.Width())
        .Attribute("height", this.Height())
        .Attribute("frameborder", 0)
        .Attribute("allowfullscreen", true)
        .Attribute("webkitallowfullscreen", true)
        .Attribute("mozallowfullscreen", true)
        .ToString();
    }
  }
}