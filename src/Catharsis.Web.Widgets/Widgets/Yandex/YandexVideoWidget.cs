using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IYandexVideoWidget"/>
public class YandexVideoWidget : WebWidget, IYandexVideoWidget
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
  protected virtual string UserValue { get; set; }

  /// <inheritdoc cref="IYandexVideoWidget.Id(string)"/>
  public virtual IYandexVideoWidget Id(string id)
  {
    if (id is null) throw new ArgumentNullException(nameof(id));
    if (id.IsEmpty()) throw new ArgumentException(nameof(id));

    IdValue = id;

    return this;
  }

  /// <inheritdoc cref="IYandexVideoWidget.Height(string)"/>
  public virtual IYandexVideoWidget Height(string height)
  {
    if (height is null) throw new ArgumentNullException(nameof(height));
    if (height.IsEmpty()) throw new ArgumentException(nameof(height));

    HeightValue = height;

    return this;
  }

  /// <inheritdoc cref="IYandexVideoWidget.User(string)"/>
  public virtual IYandexVideoWidget User(string user)
  {
    if (user is null) throw new ArgumentNullException(nameof(user));
    if (user.IsEmpty()) throw new ArgumentException(nameof(user));

    UserValue = user;

    return this;
  }

  /// <inheritdoc cref="IYandexVideoWidget.Width(string)"/>
  public virtual IYandexVideoWidget Width(string width)
  {
    if (width is null) throw new ArgumentNullException(nameof(width));
    if (width.IsEmpty()) throw new ArgumentException(nameof(width));

    WidthValue = width;

    return this;
  }

  /// <inheritdoc cref="ICloneable.Clone()"/>
  public override object Clone() => new YandexVideoWidget
  {
    IdValue = IdValue,
    WidthValue = WidthValue,
    HeightValue = HeightValue,
    UserValue = UserValue
  };

  /// <inheritdoc cref="IWebWidget.ToHtml()"/>
  public override string ToHtml() => IdValue.IsUnset() || UserValue.IsUnset() || HeightValue.IsUnset() || WidthValue.IsUnset() ? string.Empty : new TagBuilder("iframe")
      .Attribute("src", $"http://video.yandex.ru/iframe/${UserValue}/${IdValue}")
      .Attribute("width", WidthValue)
      .Attribute("height", HeightValue)
      .Attribute("frameborder", 0)
      .Attribute("allowfullscreen", true)
      .Attribute("webkitallowfullscreen", true)
      .Attribute("mozallowfullscreen", true)
      .ToString();
}