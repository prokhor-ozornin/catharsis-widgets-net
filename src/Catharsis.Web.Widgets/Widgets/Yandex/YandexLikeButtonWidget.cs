using System.Text;
using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IYandexLikeButtonWidget"/>
public class YandexLikeButtonWidget : WebWidget, IYandexLikeButtonWidget
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string UrlValue { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string TitleValue { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string SizeValue { get; set; } = nameof(YandexLikeButtonSize.Large).ToLowerInvariant();

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string LayoutValue { get; set; } = nameof(YandexLikeButtonLayout.Button).ToLowerInvariant();

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string TextValue { get; set; }

  /// <inheritdoc cref="IYandexLikeButtonWidget.Layout(string)"/>
  public virtual IYandexLikeButtonWidget Layout(string layout)
  {
    if (layout is null) throw new ArgumentNullException(nameof(layout));
    if (layout.IsEmpty()) throw new ArgumentException(nameof(layout));

    LayoutValue = layout;
    return this;
  }

  /// <inheritdoc cref="IYandexLikeButtonWidget.Size(string)"/>
  public virtual IYandexLikeButtonWidget Size(string size)
  {
    if (size is null) throw new ArgumentNullException(nameof(size));
    if (size.IsEmpty()) throw new ArgumentException(nameof(size));

    SizeValue = size;
    return this;
  }

  /// <inheritdoc cref="IYandexLikeButtonWidget.Text(string)"/>
  public virtual IYandexLikeButtonWidget Text(string text)
  {
    if (text is null) throw new ArgumentNullException(nameof(text));
    if (text.IsEmpty()) throw new ArgumentException(nameof(text));

    TextValue = text;
    return this;
  }

  /// <inheritdoc cref="IYandexLikeButtonWidget.Title(string)"/>
  public virtual IYandexLikeButtonWidget Title(string title)
  {
    if (title is null) throw new ArgumentNullException(nameof(title));
    if (title.IsEmpty()) throw new ArgumentException(nameof(title));

    TitleValue = title;
    return this;
  }

  /// <inheritdoc cref="IYandexLikeButtonWidget.Url(string)"/>
  public virtual IYandexLikeButtonWidget Url(string url)
  {
    if (url is null) throw new ArgumentNullException(nameof(url));
    if (url.IsEmpty()) throw new ArgumentException(nameof(url));

    UrlValue = url;
    return this;
  }

  /// <inheritdoc cref="ICloneable.Clone()"/>
  public override object Clone() => new YandexLikeButtonWidget
  {
    UrlValue = UrlValue,
    TitleValue = TitleValue,
    SizeValue = SizeValue,
    LayoutValue = LayoutValue,
    TextValue = TextValue
  };

  /// <inheritdoc cref="IWebWidget.ToHtml()"/>
  public override string ToHtml() => new StringBuilder()
      .Append(new TagBuilder("a")
        .Attribute("name", "ya-share")
        .Attribute("type", LayoutValue)
        .Attribute("size", SizeValue)
        .Attribute("share_text", TextValue)
        .Attribute("share_url", UrlValue)
        .Attribute("share_title", TitleValue)
       )
      .Append(resources.yandex_like_html)
      .ToString();
}