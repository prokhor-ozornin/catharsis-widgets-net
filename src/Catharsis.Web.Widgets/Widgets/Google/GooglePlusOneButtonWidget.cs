using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IGooglePlusOneButtonWidget"/>
public class GooglePlusOneButtonWidget : WebWidget, IGooglePlusOneButtonWidget
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string UrlValue { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string WidthValue { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string SizeValue { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string AlignmentValue { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string AnnotationValue { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string CallbackValue { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual bool? RecommendationsValue { get; set; }

  /// <inheritdoc cref="IGooglePlusOneButtonWidget.Alignment(string)"/>
  public virtual IGooglePlusOneButtonWidget Alignment(string alignment)
  {
    if (alignment is null) throw new ArgumentNullException(nameof(alignment));
    if (alignment.IsEmpty()) throw new ArgumentException(nameof(alignment));

    AlignmentValue = alignment;
    return this;
  }

  /// <inheritdoc cref="IGooglePlusOneButtonWidget.Annotation(string)"/>
  public virtual IGooglePlusOneButtonWidget Annotation(string annotation)
  {
    if (annotation is null) throw new ArgumentNullException(nameof(annotation));
    if (annotation.IsEmpty()) throw new ArgumentException(nameof(annotation));

    AnnotationValue = annotation;
    return this;
  }

  /// <inheritdoc cref="IGooglePlusOneButtonWidget.Callback(string)"/>
  public virtual IGooglePlusOneButtonWidget Callback(string callback)
  {
    if (callback is null) throw new ArgumentNullException(nameof(callback));
    if (callback.IsEmpty()) throw new ArgumentException(nameof(callback));

    CallbackValue = callback;
    return this;
  }

  /// <inheritdoc cref="IGooglePlusOneButtonWidget.Recommendations(bool)"/>
  public virtual IGooglePlusOneButtonWidget Recommendations(bool enabled)
  {
    RecommendationsValue = enabled;
    return this;
  }

  /// <inheritdoc cref="IGooglePlusOneButtonWidget.Size(string)"/>
  public virtual IGooglePlusOneButtonWidget Size(string size)
  {
    if (size is null) throw new ArgumentNullException(nameof(size));
    if (size.IsEmpty()) throw new ArgumentException(nameof(size));

    SizeValue = size;
    return this;
  }

  /// <inheritdoc cref="IGooglePlusOneButtonWidget.Url(string)"/>
  public virtual IGooglePlusOneButtonWidget Url(string url)
  {
    if (url is null) throw new ArgumentNullException(nameof(url));
    if (url.IsEmpty()) throw new ArgumentException(nameof(url));

    UrlValue = url;
    return this;
  }

  /// <inheritdoc cref="IGooglePlusOneButtonWidget.Width(string)"/>
  public virtual IGooglePlusOneButtonWidget Width(string width)
  {
    if (width is null) throw new ArgumentNullException(nameof(width));
    if (width.IsEmpty()) throw new ArgumentException(nameof(width));

    WidthValue = width;
    return this;
  }

  /// <inheritdoc cref="ICloneable.Clone()"/>
  public override object Clone() => new GooglePlusOneButtonWidget
  {
    UrlValue = UrlValue,
    WidthValue = WidthValue,
    SizeValue = SizeValue,
    AlignmentValue = AlignmentValue,
    AnnotationValue = AnnotationValue,
    CallbackValue = CallbackValue,
    RecommendationsValue = RecommendationsValue
  };

  /// <inheritdoc cref="IWebWidget.ToHtml()"/>
  public override string ToHtml() => new TagBuilder("g:plusone")
      .Attribute("href", UrlValue)
      .Attribute("size", SizeValue)
      .Attribute("annotation", AnnotationValue)
      .Attribute("width", WidthValue)
      .Attribute("align", AlignmentValue)
      .Attribute("data-callback", CallbackValue)
      .Attribute("data-recommendations", RecommendationsValue)
      .ToString();
}