using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IGooglePlusOneButtonWidget"/>
public class GooglePlusOneButtonWidget : WebWidget, IGooglePlusOneButtonWidget
{
  private string url;
  private string width;
  private string size;
  private string alignment;
  private string annotation;
  private string callback;
  private bool? recommendations;

  /// <inheritdoc cref="IGooglePlusOneButtonWidget.Alignment(string)"/>
  public IGooglePlusOneButtonWidget Alignment(string alignment)
  {
    if (alignment is null) throw new ArgumentNullException(nameof(alignment));
    if (alignment.IsEmpty()) throw new ArgumentException(nameof(alignment));

    this.alignment = alignment;
    return this;
  }

  /// <inheritdoc cref="IGooglePlusOneButtonWidget.Alignment()"/>
  public string Alignment() => alignment;

  /// <inheritdoc cref="IGooglePlusOneButtonWidget.Annotation(string)"/>
  public IGooglePlusOneButtonWidget Annotation(string annotation)
  {
    if (annotation is null) throw new ArgumentNullException(nameof(annotation));
    if (annotation.IsEmpty()) throw new ArgumentException(nameof(annotation));

    this.annotation = annotation;
    return this;
  }

  /// <inheritdoc cref="IGooglePlusOneButtonWidget.Annotation()"/>
  public string Annotation() => annotation;

  /// <inheritdoc cref="IGooglePlusOneButtonWidget.Callback(string)"/>
  public IGooglePlusOneButtonWidget Callback(string callback)
  {
    if (callback is null) throw new ArgumentNullException(nameof(callback));
    if (callback.IsEmpty()) throw new ArgumentException(nameof(callback));

    this.callback = callback;
    return this;
  }

  /// <inheritdoc cref="IGooglePlusOneButtonWidget.Callback()"/>
  public string Callback() => callback;

  /// <inheritdoc cref="IGooglePlusOneButtonWidget.Recommendations(bool)"/>
  public IGooglePlusOneButtonWidget Recommendations(bool enabled)
  {
    recommendations = enabled;
    return this;
  }

  /// <inheritdoc cref="IGooglePlusOneButtonWidget.Recommendations()"/>
  public bool? Recommendations() => recommendations;

  /// <inheritdoc cref="IGooglePlusOneButtonWidget.Size(string)"/>
  public IGooglePlusOneButtonWidget Size(string size)
  {
    if (size is null) throw new ArgumentNullException(nameof(size));
    if (size.IsEmpty()) throw new ArgumentException(nameof(size));

    this.size = size;
    return this;
  }

  /// <inheritdoc cref="IGooglePlusOneButtonWidget.Size()"/>
  public string Size() => size;

  /// <inheritdoc cref="IGooglePlusOneButtonWidget.Url(string)"/>
  public IGooglePlusOneButtonWidget Url(string url)
  {
    if (url is null) throw new ArgumentNullException(nameof(url));
    if (url.IsEmpty()) throw new ArgumentException(nameof(url));

    this.url = url;
    return this;
  }

  /// <inheritdoc cref="IGooglePlusOneButtonWidget.Url()"/>
  public string Url() => url;

  /// <inheritdoc cref="IGooglePlusOneButtonWidget.Width(string)"/>
  public IGooglePlusOneButtonWidget Width(string width)
  {
    if (width is null) throw new ArgumentNullException(nameof(width));
    if (width.IsEmpty()) throw new ArgumentException(nameof(width));

    this.width = width;
    return this;
  }

  /// <inheritdoc cref="IGooglePlusOneButtonWidget.Width()"/>
  public string Width() => width;

  /// <inheritdoc cref="IWebWidget.ToHtml()"/>
  public override string ToHtml()
  {
    return new TagBuilder("g:plusone")
      .Attribute("href", Url())
      .Attribute("size", Size())
      .Attribute("annotation", Annotation())
      .Attribute("width", Width())
      .Attribute("align", Alignment())
      .Attribute("data-callback", Callback())
      .Attribute("data-recommendations", Recommendations())
      .ToString();
  }
}