using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IVkontakteVideoWidget"/>
public class VkontakteVideoWidget : WebWidget, IVkontakteVideoWidget
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string IdValue { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string WidthValue { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string HeightValue { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual bool HdValue { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string UserValue { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string HashValue { get; set; }

  /// <inheritdoc cref="IVkontakteVideoWidget.Hash(string)"/>
  public virtual IVkontakteVideoWidget Hash(string hash)
  {
    if (hash is null) throw new ArgumentNullException(nameof(hash));
    if (hash.IsEmpty()) throw new ArgumentException(nameof(hash));

    HashValue = hash;

    return this;
  }

  /// <inheritdoc cref="IVkontakteVideoWidget.Hd(bool)"/>
  public virtual IVkontakteVideoWidget Hd(bool enabled)
  {
    HdValue = enabled;
    return this;
  }

  /// <inheritdoc cref="IVkontakteVideoWidget.Height(string)"/>
  public virtual IVkontakteVideoWidget Height(string height)
  {
    if (height is null) throw new ArgumentNullException(nameof(height));
    if (height.IsEmpty()) throw new ArgumentException(nameof(height));

    HeightValue = height;

    return this;
  }

  /// <inheritdoc cref="IVkontakteVideoWidget.Id(string)"/>
  public virtual IVkontakteVideoWidget Id(string id)
  {
    if (id is null) throw new ArgumentNullException(nameof(id));
    if (id.IsEmpty()) throw new ArgumentException(nameof(id));

    IdValue = id;

    return this;
  }

  /// <inheritdoc cref="IVkontakteVideoWidget.User(string)"/>
  public virtual IVkontakteVideoWidget User(string user)
  {
    if (user is null) throw new ArgumentNullException(nameof(user));
    if (user.IsEmpty()) throw new ArgumentException(nameof(user));
      
    UserValue = user;

    return this;
  }

  /// <inheritdoc cref="IVkontakteVideoWidget.Width(string)"/>
  public virtual IVkontakteVideoWidget Width(string width)
  {
    if (width is null) throw new ArgumentNullException(nameof(width));
    if (width.IsEmpty()) throw new ArgumentException(nameof(width));

    WidthValue = width;

    return this;
  }

  /// <inheritdoc cref="ICloneable.Clone()"/>
  public override object Clone() => new VkontakteVideoWidget
  {
    IdValue = IdValue,
    WidthValue = WidthValue,
    HeightValue = HeightValue,
    HdValue = HdValue,
    UserValue = UserValue,
    HashValue = HashValue
  };

  /// <inheritdoc cref="IWebWidget.ToHtml()"/>
  public override string ToHtml() => IdValue.IsUnset() || UserValue.IsUnset() || HashValue.IsUnset() || WidthValue.IsUnset() || HeightValue.IsUnset() ? string.Empty : new TagBuilder("iframe")
      .Attribute("frameborder", 0)
      .Attribute("allowfullscreen", true)
      .Attribute("webkitallowfullscreen", true)
      .Attribute("mozallowfullscreen", true)
      .Attribute("width", WidthValue)
      .Attribute("height", HeightValue)
      .Attribute("src", $"http://vk.com/video_ext.php?oid=${UserValue}&id=${IdValue}&hash=${HashValue}&hd=${(HdValue ? 1 : 0)}")
      .ToString();
}