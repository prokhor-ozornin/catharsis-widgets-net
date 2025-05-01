using System.Text;
using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IYandexLikeButtonWidget"/>
public class YandexLikeButtonWidget : WebWidget, IYandexLikeButtonWidget
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string UrlProperty { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string TitleProperty { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string SizeProperty { get; set; } = YandexLikeButtonSize.Large.ToString().ToLowerInvariant();

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string LayoutProperty { get; set; } = YandexLikeButtonLayout.Button.ToString().ToLowerInvariant();

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string TextProperty { get; set; }

  /// <inheritdoc cref="IYandexLikeButtonWidget.Layout(string)"/>
  public virtual IYandexLikeButtonWidget Layout(string layout)
  {
    if (layout is null) throw new ArgumentNullException(nameof(layout));
    if (layout.IsEmpty()) throw new ArgumentException(nameof(layout));

    LayoutProperty = layout;
    return this;
  }

  /// <inheritdoc cref="IYandexLikeButtonWidget.Size(string)"/>
  public virtual IYandexLikeButtonWidget Size(string size)
  {
    if (size is null) throw new ArgumentNullException(nameof(size));
    if (size.IsEmpty()) throw new ArgumentException(nameof(size));

    SizeProperty = size;
    return this;
  }

  /// <inheritdoc cref="IYandexLikeButtonWidget.Text(string)"/>
  public virtual IYandexLikeButtonWidget Text(string text)
  {
    if (text is null) throw new ArgumentNullException(nameof(text));
    if (text.IsEmpty()) throw new ArgumentException(nameof(text));

    TextProperty = text;
    return this;
  }

  /// <inheritdoc cref="IYandexLikeButtonWidget.Title(string)"/>
  public virtual IYandexLikeButtonWidget Title(string title)
  {
    if (title is null) throw new ArgumentNullException(nameof(title));
    if (title.IsEmpty()) throw new ArgumentException(nameof(title));

    TitleProperty = title;
    return this;
  }

  /// <inheritdoc cref="IYandexLikeButtonWidget.Url(string)"/>
  public virtual IYandexLikeButtonWidget Url(string url)
  {
    if (url is null) throw new ArgumentNullException(nameof(url));
    if (url.IsEmpty()) throw new ArgumentException(nameof(url));

    UrlProperty = url;
    return this;
  }

  public override object Clone() => new YandexLikeButtonWidget { };

  /// <inheritdoc cref="IWebWidget.ToHtml()"/>
  public override string ToHtml() => new StringBuilder()
      .Append(new TagBuilder("a")
        .Attribute("name", "ya-share")
        .Attribute("type", LayoutProperty)
        .Attribute("size", SizeProperty)
        .Attribute("share_text", TextProperty)
        .Attribute("share_url", UrlProperty)
        .Attribute("share_title", TitleProperty)
       )
      .Append(resources.yandex_like_html)
      .ToString();
}