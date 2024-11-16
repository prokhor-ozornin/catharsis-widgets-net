using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IVkontakteVideoWidget"/>
public class VkontakteVideoWidget : WebWidget, IVkontakteVideoWidget
{
  private string id;
  private string width;
  private string height;
  private bool hd;
  private string user;
  private string hash;

  /// <inheritdoc cref="IVkontakteVideoWidget.Hash(string)"/>
  public IVkontakteVideoWidget Hash(string hash)
  {
    if (hash is null) throw new ArgumentNullException(nameof(hash));
    if (hash.IsEmpty()) throw new ArgumentException(nameof(hash));

    this.hash = hash;

    return this;
  }

  /// <inheritdoc cref="IVkontakteVideoWidget.Hash()"/>
  public string Hash() => hash;

  /// <inheritdoc cref="IVkontakteVideoWidget.Hd(bool)"/>
  public IVkontakteVideoWidget Hd(bool enabled)
  {
    hd = enabled;
    return this;
  }

  /// <inheritdoc cref="IVkontakteVideoWidget.Hd()"/>
  public bool Hd() => hd;

  /// <inheritdoc cref="IVkontakteVideoWidget.Height(string)"/>
  public IVkontakteVideoWidget Height(string height)
  {
    if (height is null) throw new ArgumentNullException(nameof(height));
    if (height.IsEmpty()) throw new ArgumentException(nameof(height));

    this.height = height;

    return this;
  }

  /// <inheritdoc cref="IVkontakteVideoWidget.Height()"/>
  public string Height() => height;

  /// <inheritdoc cref="IVkontakteVideoWidget.Id(string)"/>
  public IVkontakteVideoWidget Id(string id)
  {
    if (id is null) throw new ArgumentNullException(nameof(id));
    if (id.IsEmpty()) throw new ArgumentException(nameof(id));

    this.id = id;

    return this;
  }

  /// <inheritdoc cref="IVkontakteVideoWidget.Id()"/>
  public string Id() => id;

  /// <inheritdoc cref="IVkontakteVideoWidget.User(string)"/>
  public IVkontakteVideoWidget User(string user)
  {
    if (user is null) throw new ArgumentNullException(nameof(user));
    if (user.IsEmpty()) throw new ArgumentException(nameof(user));
      
    this.user = user;

    return this;
  }

  /// <inheritdoc cref="IVkontakteVideoWidget.User()"/>
  public string User() => user;

  /// <inheritdoc cref="IVkontakteVideoWidget.Width(string)"/>
  public IVkontakteVideoWidget Width(string width)
  {
    if (width is null) throw new ArgumentNullException(nameof(width));
    if (width.IsEmpty()) throw new ArgumentException(nameof(width));

    this.width = width;

    return this;
  }

  /// <inheritdoc cref="IVkontakteVideoWidget.Width()"/>
  public string Width() => width;

  /// <inheritdoc cref="IWebWidget.ToHtml()"/>
  public override string ToHtml()
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