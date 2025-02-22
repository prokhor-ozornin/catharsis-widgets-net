using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IVkontakteVideoWidget"/>
public class VkontakteVideoWidget : WebWidget, IVkontakteVideoWidget
{
  private string IdProperty { get; set; }
  private string WidthProperty { get; set; }
  private string HeightProperty { get; set; }
  private bool HdProperty { get; set; }
  private string UserProperty { get; set; }
  private string HashProperty { get; set; }

  /// <inheritdoc cref="IVkontakteVideoWidget.Hash(string)"/>
  public IVkontakteVideoWidget Hash(string hash)
  {
    if (hash is null) throw new ArgumentNullException(nameof(hash));
    if (hash.IsEmpty()) throw new ArgumentException(nameof(hash));

    HashProperty = hash;

    return this;
  }

  /// <inheritdoc cref="IVkontakteVideoWidget.Hash()"/>
  public string Hash() => HashProperty;

  /// <inheritdoc cref="IVkontakteVideoWidget.Hd(bool)"/>
  public IVkontakteVideoWidget Hd(bool enabled)
  {
    HdProperty = enabled;
    return this;
  }

  /// <inheritdoc cref="IVkontakteVideoWidget.Hd()"/>
  public bool Hd() => HdProperty;

  /// <inheritdoc cref="IVkontakteVideoWidget.Height(string)"/>
  public IVkontakteVideoWidget Height(string height)
  {
    if (height is null) throw new ArgumentNullException(nameof(height));
    if (height.IsEmpty()) throw new ArgumentException(nameof(height));

    HeightProperty = height;

    return this;
  }

  /// <inheritdoc cref="IVkontakteVideoWidget.Height()"/>
  public string Height() => HeightProperty;

  /// <inheritdoc cref="IVkontakteVideoWidget.Id(string)"/>
  public IVkontakteVideoWidget Id(string id)
  {
    if (id is null) throw new ArgumentNullException(nameof(id));
    if (id.IsEmpty()) throw new ArgumentException(nameof(id));

    IdProperty = id;

    return this;
  }

  /// <inheritdoc cref="IVkontakteVideoWidget.Id()"/>
  public string Id() => IdProperty;

  /// <inheritdoc cref="IVkontakteVideoWidget.User(string)"/>
  public IVkontakteVideoWidget User(string user)
  {
    if (user is null) throw new ArgumentNullException(nameof(user));
    if (user.IsEmpty()) throw new ArgumentException(nameof(user));
      
    UserProperty = user;

    return this;
  }

  /// <inheritdoc cref="IVkontakteVideoWidget.User()"/>
  public string User() => UserProperty;

  /// <inheritdoc cref="IVkontakteVideoWidget.Width(string)"/>
  public IVkontakteVideoWidget Width(string width)
  {
    if (width is null) throw new ArgumentNullException(nameof(width));
    if (width.IsEmpty()) throw new ArgumentException(nameof(width));

    WidthProperty = width;

    return this;
  }

  /// <inheritdoc cref="IVkontakteVideoWidget.Width()"/>
  public string Width() => WidthProperty;

  /// <inheritdoc cref="IHtmlContent.ToHtml()"/>
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
      .Attribute("src", $"http://vk.com/video_ext.php?oid=${User()}&id=${Id()}&hash=${Hash()}&hd=${(Hd() ? 1 : 0)}")
      .ToString();
  }
}