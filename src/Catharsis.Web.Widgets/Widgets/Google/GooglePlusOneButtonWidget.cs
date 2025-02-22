using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IGooglePlusOneButtonWidget"/>
public class GooglePlusOneButtonWidget : WebWidget, IGooglePlusOneButtonWidget
{
  private string UrlProperty { get; set; }
  private string WidthProperty { get; set; }
  private string SizeProperty { get; set; }
  private string AlignmentProperty { get; set; }
  private string AnnotationProperty { get; set; }
  private string CallbackProperty { get; set; }
  private bool? RecommendationsProperty { get; set; }

  /// <inheritdoc cref="IGooglePlusOneButtonWidget.Alignment(string)"/>
  public IGooglePlusOneButtonWidget Alignment(string alignment)
  {
    if (alignment is null) throw new ArgumentNullException(nameof(alignment));
    if (alignment.IsEmpty()) throw new ArgumentException(nameof(alignment));

    AlignmentProperty = alignment;
    return this;
  }

  /// <inheritdoc cref="IGooglePlusOneButtonWidget.Alignment()"/>
  public string Alignment() => AlignmentProperty;

  /// <inheritdoc cref="IGooglePlusOneButtonWidget.Annotation(string)"/>
  public IGooglePlusOneButtonWidget Annotation(string annotation)
  {
    if (annotation is null) throw new ArgumentNullException(nameof(annotation));
    if (annotation.IsEmpty()) throw new ArgumentException(nameof(annotation));

    AnnotationProperty = annotation;
    return this;
  }

  /// <inheritdoc cref="IGooglePlusOneButtonWidget.Annotation()"/>
  public string Annotation() => AnnotationProperty;

  /// <inheritdoc cref="IGooglePlusOneButtonWidget.Callback(string)"/>
  public IGooglePlusOneButtonWidget Callback(string callback)
  {
    if (callback is null) throw new ArgumentNullException(nameof(callback));
    if (callback.IsEmpty()) throw new ArgumentException(nameof(callback));

    CallbackProperty = callback;
    return this;
  }

  /// <inheritdoc cref="IGooglePlusOneButtonWidget.Callback()"/>
  public string Callback() => CallbackProperty;

  /// <inheritdoc cref="IGooglePlusOneButtonWidget.Recommendations(bool)"/>
  public IGooglePlusOneButtonWidget Recommendations(bool enabled)
  {
    RecommendationsProperty = enabled;
    return this;
  }

  /// <inheritdoc cref="IGooglePlusOneButtonWidget.Recommendations()"/>
  public bool? Recommendations() => RecommendationsProperty;

  /// <inheritdoc cref="IGooglePlusOneButtonWidget.Size(string)"/>
  public IGooglePlusOneButtonWidget Size(string size)
  {
    if (size is null) throw new ArgumentNullException(nameof(size));
    if (size.IsEmpty()) throw new ArgumentException(nameof(size));

    SizeProperty = size;
    return this;
  }

  /// <inheritdoc cref="IGooglePlusOneButtonWidget.Size()"/>
  public string Size() => SizeProperty;

  /// <inheritdoc cref="IGooglePlusOneButtonWidget.Url(string)"/>
  public IGooglePlusOneButtonWidget Url(string url)
  {
    if (url is null) throw new ArgumentNullException(nameof(url));
    if (url.IsEmpty()) throw new ArgumentException(nameof(url));

    UrlProperty = url;
    return this;
  }

  /// <inheritdoc cref="IGooglePlusOneButtonWidget.Url()"/>
  public string Url() => UrlProperty;

  /// <inheritdoc cref="IGooglePlusOneButtonWidget.Width(string)"/>
  public IGooglePlusOneButtonWidget Width(string width)
  {
    if (width is null) throw new ArgumentNullException(nameof(width));
    if (width.IsEmpty()) throw new ArgumentException(nameof(width));

    WidthProperty = width;
    return this;
  }

  /// <inheritdoc cref="IGooglePlusOneButtonWidget.Width()"/>
  public string Width() => WidthProperty;

  /// <inheritdoc cref="IHtmlContent.ToHtml()"/>
  public override string ToHtml() => new TagBuilder("g:plusone")
      .Attribute("href", Url())
      .Attribute("size", Size())
      .Attribute("annotation", Annotation())
      .Attribute("width", Width())
      .Attribute("align", Alignment())
      .Attribute("data-callback", Callback())
      .Attribute("data-recommendations", Recommendations())
      .ToString();
}