using System.Web.Mvc;
using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IYandexVideoWidget"/>
public class YandexVideoWidget : WebWidget, IYandexVideoWidget
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
    if (id is null) throw new ArgumentNullException(nameof(id));
    if (id.IsEmpty()) throw new ArgumentException(nameof(id));

    this.id = id;

    return this;
  }

  /// <summary>
  ///   <para>Identifier of video.</para>
  /// </summary>
  /// <returns>Identifier of video.</returns>
  public string Id() => id;

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
    if (height is null) throw new ArgumentNullException(nameof(height));
    if (height.IsEmpty()) throw new ArgumentException(nameof(height));

    this.height = height;

    return this;
  }

  /// <summary>
  ///   <para>Height of video control.</para>
  /// </summary>
  /// <returns>Height of video.</returns>
  public string Height() => height;

  /// <summary>
  ///   <para>Account identifier of video's uploader.</para>
  /// </summary>
  /// <param name="user">User's account identifier.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="user"/> is a <c>null</c> reference.</exception>
  /// <exception cref="ArgumentException">If <paramref name="user"/> is <see cref="string.Empty"/> string.</exception>
  public IYandexVideoWidget User(string user)
  {
    if (user is null) throw new ArgumentNullException(nameof(user));
    if (user.IsEmpty()) throw new ArgumentException(nameof(user));

    this.user = user;

    return this;
  }

  /// <summary>
  ///   <para>Account identifier of video's uploader.</para>
  /// </summary>
  /// <returns>User's account identifier.</returns>
  public string User() => user;

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
    if (width is null) throw new ArgumentNullException(nameof(width));
    if (width.IsEmpty()) throw new ArgumentException(nameof(width));

    this.width = width;

    return this;
  }

  /// <summary>
  ///   <para>Width of video control.</para>
  /// </summary>
  /// <returns>Width of video.</returns>
  public string Width() => width;

  /// <inheritdoc cref="IWebWidget.ToHtml()"/>
  public override string ToHtml()
  {
    if (Id().IsEmpty() || User().IsEmpty() || Height().IsEmpty() || Width().IsEmpty())
    {
      return string.Empty;
    }

    return new TagBuilder("iframe")
      .Attribute("src", $"http://video.yandex.ru/iframe/${User()}/${Id()}")
      .Attribute("width", Width())
      .Attribute("height", Height())
      .Attribute("frameborder", 0)
      .Attribute("allowfullscreen", true)
      .Attribute("webkitallowfullscreen", true)
      .Attribute("mozallowfullscreen", true)
      .ToString();
  }
}