using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IVkontakteVideoWidget"/>
public class VkontakteVideoWidget : WebWidget, IVkontakteVideoWidget
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string IdProperty { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string WidthProperty { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string HeightProperty { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual bool HdProperty { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string UserProperty { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string HashProperty { get; set; }

  /// <inheritdoc cref="IVkontakteVideoWidget.Hash(string)"/>
  public virtual IVkontakteVideoWidget Hash(string hash)
  {
    if (hash is null) throw new ArgumentNullException(nameof(hash));
    if (hash.IsEmpty()) throw new ArgumentException(nameof(hash));

    HashProperty = hash;

    return this;
  }

  /// <inheritdoc cref="IVkontakteVideoWidget.Hd(bool)"/>
  public virtual IVkontakteVideoWidget Hd(bool enabled)
  {
    HdProperty = enabled;
    return this;
  }

  /// <inheritdoc cref="IVkontakteVideoWidget.Height(string)"/>
  public virtual IVkontakteVideoWidget Height(string height)
  {
    if (height is null) throw new ArgumentNullException(nameof(height));
    if (height.IsEmpty()) throw new ArgumentException(nameof(height));

    HeightProperty = height;

    return this;
  }

  /// <inheritdoc cref="IVkontakteVideoWidget.Id(string)"/>
  public virtual IVkontakteVideoWidget Id(string id)
  {
    if (id is null) throw new ArgumentNullException(nameof(id));
    if (id.IsEmpty()) throw new ArgumentException(nameof(id));

    IdProperty = id;

    return this;
  }

  /// <inheritdoc cref="IVkontakteVideoWidget.User(string)"/>
  public virtual IVkontakteVideoWidget User(string user)
  {
    if (user is null) throw new ArgumentNullException(nameof(user));
    if (user.IsEmpty()) throw new ArgumentException(nameof(user));
      
    UserProperty = user;

    return this;
  }

  /// <inheritdoc cref="IVkontakteVideoWidget.Width(string)"/>
  public virtual IVkontakteVideoWidget Width(string width)
  {
    if (width is null) throw new ArgumentNullException(nameof(width));
    if (width.IsEmpty()) throw new ArgumentException(nameof(width));

    WidthProperty = width;

    return this;
  }

  /// <inheritdoc cref="IHtmlContent.ToHtml()"/>
  public override string ToHtml() => IdProperty.IsUnset() || UserProperty.IsUnset() || HashProperty.IsUnset() || WidthProperty.IsUnset() || HeightProperty.IsUnset() ? string.Empty : new TagBuilder("iframe")
      .Attribute("frameborder", 0)
      .Attribute("allowfullscreen", true)
      .Attribute("webkitallowfullscreen", true)
      .Attribute("mozallowfullscreen", true)
      .Attribute("width", WidthProperty)
      .Attribute("height", HeightProperty)
      .Attribute("src", $"http://vk.com/video_ext.php?oid=${UserProperty}&id=${IdProperty}&hash=${HashProperty}&hd=${(HdProperty ? 1 : 0)}")
      .ToString();
}