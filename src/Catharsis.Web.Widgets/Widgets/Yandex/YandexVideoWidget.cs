using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IYandexVideoWidget"/>
public class YandexVideoWidget : WebWidget, IYandexVideoWidget
{
  private string id;
  private string width;
  private string height;
  private string user;

  /// <inheritdoc cref="IYandexVideoWidget.Id(string)"/>
  public IYandexVideoWidget Id(string id)
  {
    if (id is null) throw new ArgumentNullException(nameof(id));
    if (id.IsEmpty()) throw new ArgumentException(nameof(id));

    this.id = id;

    return this;
  }

  /// <inheritdoc cref="IYandexVideoWidget.Id()"/>
  public string Id() => id;

  /// <inheritdoc cref="IYandexVideoWidget.Height(string)"/>
  public IYandexVideoWidget Height(string height)
  {
    if (height is null) throw new ArgumentNullException(nameof(height));
    if (height.IsEmpty()) throw new ArgumentException(nameof(height));

    this.height = height;

    return this;
  }

  /// <inheritdoc cref="IYandexVideoWidget.Height()"/>
  public string Height() => height;

  /// <inheritdoc cref="IYandexVideoWidget.User(string)"/>
  public IYandexVideoWidget User(string user)
  {
    if (user is null) throw new ArgumentNullException(nameof(user));
    if (user.IsEmpty()) throw new ArgumentException(nameof(user));

    this.user = user;

    return this;
  }

  /// <inheritdoc cref="IYandexVideoWidget.User()"/>
  public string User() => user;

  /// <inheritdoc cref="IYandexVideoWidget.Width(string)"/>
  public IYandexVideoWidget Width(string width)
  {
    if (width is null) throw new ArgumentNullException(nameof(width));
    if (width.IsEmpty()) throw new ArgumentException(nameof(width));

    this.width = width;

    return this;
  }

  /// <inheritdoc cref="IYandexVideoWidget.Width()"/>
  public string Width() => width;

  /// <inheritdoc cref="IHtmlContent.ToHtml()"/>
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