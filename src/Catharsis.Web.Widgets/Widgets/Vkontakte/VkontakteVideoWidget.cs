using System.Web.Mvc;
using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IVkontakteVideoWidget"/>
public class VkontakteVideoWidget : HtmlWidget, IVkontakteVideoWidget
{
  private string id;
  private string width;
  private string height;
  private bool hd;
  private string user;
  private string hash;

  /// <summary>
  ///   <para>Hash code of video.</para>
  /// </summary>
  /// <param name="hash">Video's hash code.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="hash"/> is a <c>null</c> reference.</exception>
  /// <exception cref="ArgumentException">If <paramref name="hash"/> is <see cref="string.Empty"/> string.</exception>
  public IVkontakteVideoWidget Hash(string hash)
  {
    if (hash is null) throw new ArgumentNullException(nameof(hash));
    if (hash.IsEmpty()) throw new ArgumentException(nameof(hash));

    this.hash = hash;

    return this;
  }

  /// <summary>
  ///   <para>Hash code of video.</para>
  /// </summary>
  /// <returns>Video's hash code.</returns>
  public string Hash() => hash;

  /// <summary>
  ///   <para>Whether to play video in High Definition format. Default is <c>false</c>.</para>
  /// </summary>
  /// <param name="enabled"><c>true</c> to use HD quality format, <c>false</c> to use standard quality.</param>
  /// <returns>Reference to the current widget.</returns>
  public IVkontakteVideoWidget Hd(bool enabled)
  {
    hd = enabled;
    return this;
  }

  /// <summary>
  ///   <para>Whether to play video in High Definition format. Default is <c>false</c>.</para>
  /// </summary>
  /// <returns><c>true</c> to use HD quality format, <c>false</c> to use standard quality.</returns>
  public bool Hd() => hd;

  /// <summary>
  ///   <para>Height of video control.</para>
  /// </summary>
  /// <param name="height">Height of video.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="height"/> is a <c>null</c> reference.</exception>
  /// <exception cref="ArgumentException">If <paramref name="height"/> is <see cref="string.Empty"/> string.</exception>
  /// <remarks>This attribute is required.</remarks>
  public IVkontakteVideoWidget Height(string height)
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
  ///   <para>Identifier of video.</para>
  /// </summary>
  /// <param name="id">Identifier of video.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="id"/> is a <c>null</c> reference.</exception>
  /// <exception cref="ArgumentException">If <paramref name="id"/> is <see cref="string.Empty"/> string.</exception>
  /// <remarks>This attribute is required.</remarks>
  public IVkontakteVideoWidget Id(string id)
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
  ///   <para>Account identifier of video's uploader.</para>
  /// </summary>
  /// <param name="user">User's account.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="user"/> is a <c>null</c> reference.</exception>
  /// <exception cref="ArgumentException">If <paramref name="user"/> is <see cref="string.Empty"/> string.</exception>
  public IVkontakteVideoWidget User(string user)
  {
    if (user is null) throw new ArgumentNullException(nameof(user));
    if (user.IsEmpty()) throw new ArgumentException(nameof(user));
      
    this.user = user;

    return this;
  }

  /// <summary>
  ///   <para>Account identifier of video's uploader.</para>
  /// </summary>
  /// <returns>User's account.</returns>
  public string User() => user;

  /// <summary>
  ///   <para>Width of video control.</para>
  /// </summary>
  /// <param name="width">Width of video.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="width"/> is a <c>null</c> reference.</exception>
  /// <exception cref="ArgumentException">If <paramref name="width"/> is <see cref="string.Empty"/> string.</exception>
  /// <remarks>This attribute is required.</remarks>
  public IVkontakteVideoWidget Width(string width)
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

  /// <inheritdoc cref="IHtmlWidget.ToHtmlString()"/>
  public override string ToHtmlString()
  {
    if (Id().IsEmpty() || User().IsEmpty() || Hash().IsEmpty() || Width().IsEmpty() || Height().IsEmpty())
    {
      return string.Empty;
    }

    return new TagBuilder("iframe")
      .Attribute("frameborder", 0)
      .Attribute("allowfullscreen", true)
      .Attribute("webkitallowfullscreen", true)
      .Attribute("mozallowfullscreen", true)
      .Attribute("width", Width())
      .Attribute("height", Height())
      .Attribute("src", $"http://vk.com/video_ext.php?oid=${User()}&id=${Id()}&hash=${Hash()}&hd=${Hd() ? 1 : 0}")
      .ToString();
  }
}