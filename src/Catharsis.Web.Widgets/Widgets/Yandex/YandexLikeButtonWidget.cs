using System.Text;
using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IYandexLikeButtonWidget"/>
public class YandexLikeButtonWidget : WebWidget, IYandexLikeButtonWidget
{
  private string UrlProperty { get; set; }
  private string TitleProperty { get; set; }
  private string SizeProperty { get; set; } = YandexLikeButtonSize.Large.ToString().ToLowerInvariant();
  private string LayoutProperty { get; set; } = YandexLikeButtonLayout.Button.ToString().ToLowerInvariant();
  private string TextProperty { get; set; }

  /// <inheritdoc cref="IYandexLikeButtonWidget.Layout(string)"/>
  public IYandexLikeButtonWidget Layout(string layout)
  {
    if (layout is null) throw new ArgumentNullException(nameof(layout));
    if (layout.IsEmpty()) throw new ArgumentNullException(nameof(layout));

    LayoutProperty = layout;
    return this;
  }

  /// <inheritdoc cref="IYandexLikeButtonWidget.Layout()"/>
  public string Layout() => LayoutProperty;

  /// <inheritdoc cref="IYandexLikeButtonWidget.Size(string)"/>
  public IYandexLikeButtonWidget Size(string size)
  {
    if (size is null) throw new ArgumentNullException(nameof(size));
    if (size.IsEmpty()) throw new ArgumentException(nameof(size));

    SizeProperty = size;
    return this;
  }

  /// <inheritdoc cref="IYandexLikeButtonWidget.Size()"/>
  public string Size() => SizeProperty;

  /// <inheritdoc cref="IYandexLikeButtonWidget.Text(string)"/>
  public IYandexLikeButtonWidget Text(string text)
  {
    if (text is null) throw new ArgumentNullException(nameof(text));
    if (text.IsEmpty()) throw new ArgumentException(nameof(text));

    TextProperty = text;
    return this;
  }

  /// <inheritdoc cref="IYandexLikeButtonWidget.Text()"/>
  public string Text() => TextProperty;

  /// <inheritdoc cref="IYandexLikeButtonWidget.Title(string)"/>
  public IYandexLikeButtonWidget Title(string title)
  {
    if (title is null) throw new ArgumentNullException(nameof(title));
    if (title.IsEmpty()) throw new ArgumentException(nameof(title));

    TitleProperty = title;
    return this;
  }

  /// <inheritdoc cref="IYandexLikeButtonWidget.Title()"/>
  public string Title() => TitleProperty;

  /// <inheritdoc cref="IYandexLikeButtonWidget.Url(string)"/>
  public IYandexLikeButtonWidget Url(string url)
  {
    if (url is null) throw new ArgumentNullException(nameof(url));
    if (url.IsEmpty()) throw new ArgumentException(nameof(url));

    UrlProperty = url;
    return this;
  }

  /// <inheritdoc cref="IYandexLikeButtonWidget.Url()"/>
  public string Url() => UrlProperty;

  /// <inheritdoc cref="IHtmlContent.ToHtml()"/>
  public override string ToHtml() => new StringBuilder()
      .Append(new TagBuilder("a")
        .Attribute("name", "ya-share")
        .Attribute("type", Layout())
        .Attribute("size", Size())
        .Attribute("share_text", Text())
        .Attribute("share_url", Url())
        .Attribute("share_title", Title())
       )
      .Append(resources.yandex_like_html)
      .ToString();
}