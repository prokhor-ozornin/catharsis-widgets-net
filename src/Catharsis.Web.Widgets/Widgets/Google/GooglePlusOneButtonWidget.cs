using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IGooglePlusOneButtonWidget"/>
public class GooglePlusOneButtonWidget : WebWidget, IGooglePlusOneButtonWidget
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string UrlProperty { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string WidthProperty { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string SizeProperty { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string AlignmentProperty { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string AnnotationProperty { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string CallbackProperty { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual bool? RecommendationsProperty { get; set; }

  /// <inheritdoc cref="IGooglePlusOneButtonWidget.Alignment(string)"/>
  public virtual IGooglePlusOneButtonWidget Alignment(string alignment)
  {
    if (alignment is null) throw new ArgumentNullException(nameof(alignment));
    if (alignment.IsEmpty()) throw new ArgumentException(nameof(alignment));

    AlignmentProperty = alignment;
    return this;
  }

  /// <inheritdoc cref="IGooglePlusOneButtonWidget.Annotation(string)"/>
  public virtual IGooglePlusOneButtonWidget Annotation(string annotation)
  {
    if (annotation is null) throw new ArgumentNullException(nameof(annotation));
    if (annotation.IsEmpty()) throw new ArgumentException(nameof(annotation));

    AnnotationProperty = annotation;
    return this;
  }

  /// <inheritdoc cref="IGooglePlusOneButtonWidget.Callback(string)"/>
  public virtual IGooglePlusOneButtonWidget Callback(string callback)
  {
    if (callback is null) throw new ArgumentNullException(nameof(callback));
    if (callback.IsEmpty()) throw new ArgumentException(nameof(callback));

    CallbackProperty = callback;
    return this;
  }

  /// <inheritdoc cref="IGooglePlusOneButtonWidget.Recommendations(bool)"/>
  public virtual IGooglePlusOneButtonWidget Recommendations(bool enabled)
  {
    RecommendationsProperty = enabled;
    return this;
  }

  /// <inheritdoc cref="IGooglePlusOneButtonWidget.Size(string)"/>
  public virtual IGooglePlusOneButtonWidget Size(string size)
  {
    if (size is null) throw new ArgumentNullException(nameof(size));
    if (size.IsEmpty()) throw new ArgumentException(nameof(size));

    SizeProperty = size;
    return this;
  }

  /// <inheritdoc cref="IGooglePlusOneButtonWidget.Url(string)"/>
  public virtual IGooglePlusOneButtonWidget Url(string url)
  {
    if (url is null) throw new ArgumentNullException(nameof(url));
    if (url.IsEmpty()) throw new ArgumentException(nameof(url));

    UrlProperty = url;
    return this;
  }

  /// <inheritdoc cref="IGooglePlusOneButtonWidget.Width(string)"/>
  public virtual IGooglePlusOneButtonWidget Width(string width)
  {
    if (width is null) throw new ArgumentNullException(nameof(width));
    if (width.IsEmpty()) throw new ArgumentException(nameof(width));

    WidthProperty = width;
    return this;
  }

  /// <inheritdoc cref="ICloneable.Clone()"/>
  public override object Clone() => new GooglePlusOneButtonWidget
  {
    UrlProperty = UrlProperty,
    WidthProperty = WidthProperty,
    SizeProperty = SizeProperty,
    AlignmentProperty = AlignmentProperty,
    AnnotationProperty = AnnotationProperty,
    CallbackProperty = CallbackProperty,
    RecommendationsProperty = RecommendationsProperty
  };

  /// <inheritdoc cref="IWebWidget.ToHtml()"/>
  public override string ToHtml() => new TagBuilder("g:plusone")
      .Attribute("href", UrlProperty)
      .Attribute("size", SizeProperty)
      .Attribute("annotation", AnnotationProperty)
      .Attribute("width", WidthProperty)
      .Attribute("align", AlignmentProperty)
      .Attribute("data-callback", CallbackProperty)
      .Attribute("data-recommendations", RecommendationsProperty)
      .ToString();
}