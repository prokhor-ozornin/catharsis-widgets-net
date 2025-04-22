using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IYandexVideoWidget"/>
public class YandexVideoWidget : WebWidget, IYandexVideoWidget
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
  protected virtual string UserProperty { get; set; }

  /// <inheritdoc cref="IYandexVideoWidget.Id(string)"/>
  public virtual IYandexVideoWidget Id(string id)
  {
    if (id is null) throw new ArgumentNullException(nameof(id));
    if (id.IsEmpty()) throw new ArgumentException(nameof(id));

    IdProperty = id;

    return this;
  }

  /// <inheritdoc cref="IYandexVideoWidget.Height(string)"/>
  public virtual IYandexVideoWidget Height(string height)
  {
    if (height is null) throw new ArgumentNullException(nameof(height));
    if (height.IsEmpty()) throw new ArgumentException(nameof(height));

    HeightProperty = height;

    return this;
  }

  /// <inheritdoc cref="IYandexVideoWidget.User(string)"/>
  public virtual IYandexVideoWidget User(string user)
  {
    if (user is null) throw new ArgumentNullException(nameof(user));
    if (user.IsEmpty()) throw new ArgumentException(nameof(user));

    UserProperty = user;

    return this;
  }

  /// <inheritdoc cref="IYandexVideoWidget.Width(string)"/>
  public virtual IYandexVideoWidget Width(string width)
  {
    if (width is null) throw new ArgumentNullException(nameof(width));
    if (width.IsEmpty()) throw new ArgumentException(nameof(width));

    WidthProperty = width;

    return this;
  }

  /// <inheritdoc cref="IHtmlContent.ToHtml()"/>
  public override string ToHtml() => IdProperty.IsUnset() || UserProperty.IsUnset() || HeightProperty.IsUnset() || WidthProperty.IsUnset() ? string.Empty : new TagBuilder("iframe")
      .Attribute("src", $"http://video.yandex.ru/iframe/${UserProperty}/${IdProperty}")
      .Attribute("width", WidthProperty)
      .Attribute("height", HeightProperty)
      .Attribute("frameborder", 0)
      .Attribute("allowfullscreen", true)
      .Attribute("webkitallowfullscreen", true)
      .Attribute("mozallowfullscreen", true)
      .ToString();
}