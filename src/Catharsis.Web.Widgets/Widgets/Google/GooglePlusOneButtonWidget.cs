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

  /// <summary>
  ///   <para>Horizontal alignment of the button assets within its frame.</para>
  /// </summary>
  /// <param name="alignment">Horizontal alignment of the button.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="alignment"/> is a <c>null</c> reference.</exception>
  /// <exception cref="ArgumentException">If <paramref name="alignment"/> is <see cref="string.Empty"/> string.</exception>
  public IGooglePlusOneButtonWidget Alignment(string alignment)
  {
    if (alignment is null) throw new ArgumentNullException(nameof(alignment));
    if (alignment.IsEmpty()) throw new ArgumentException(nameof(alignment));

    this.alignment = alignment;
    return this;
  }

  /// <summary>
  ///   <para>Horizontal alignment of the button assets within its frame.</para>
  /// </summary>
  /// <returns>Horizontal alignment of the button.</returns>
  public string Alignment() => alignment;

  /// <summary>
  ///   <para>Annotation to display next to the button.</para>
  /// </summary>
  /// <param name="annotation">Annotation for the button.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="annotation"/> is a <c>null</c> reference.</exception>
  /// <exception cref="ArgumentException">If <paramref name="annotation"/> is <see cref="string.Empty"/> string.</exception>
  public IGooglePlusOneButtonWidget Annotation(string annotation)
  {
    if (annotation is null) throw new ArgumentNullException(nameof(annotation));
    if (annotation.IsEmpty()) throw new ArgumentException(nameof(annotation));

    this.annotation = annotation;
    return this;
  }

  /// <summary>
  ///   <para>Annotation to display next to the button.</para>
  /// </summary>
  /// <returns>Annotation for the button.</returns>
  public string Annotation() => annotation;

  /// <summary>
  ///   <para>Callback JavaScript function that is called after the user clicks the +1 button.</para>
  /// </summary>
  /// <param name="callback">Callback JavaScript function.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="callback"/> is a <c>null</c> reference.</exception>
  /// <exception cref="ArgumentException">If <paramref name="callback"/> is <see cref="string.Empty"/> string.</exception>
  public IGooglePlusOneButtonWidget Callback(string callback)
  {
    if (callback is null) throw new ArgumentNullException(nameof(callback));
    if (callback.IsEmpty()) throw new ArgumentException(nameof(callback));

    this.callback = callback;
    return this;
  }

  /// <summary>
  ///   <para>Callback JavaScript function that is called after the user clicks the +1 button.</para>
  /// </summary>
  /// <returns>Callback JavaScript function.</returns>
  public string Callback() => callback;

  /// <summary>
  ///   <para>Whether to show recommendations within the +1 hover bubble. Default is <c>true</c>.</para>
  /// </summary>
  /// <param name="show"><c>true</c> to show recommendations, <c>false</c> to hide.</param>
  /// <returns>Reference to the current widget.</returns>
  public IGooglePlusOneButtonWidget Recommendations(bool show)
  {
    recommendations = show;
    return this;
  }

  /// <summary>
  ///   <para>Whether to show recommendations within the +1 hover bubble. Default is <c>true</c>.</para>
  /// </summary>
  /// <returns><c>true</c> to show recommendations, <c>false</c> to hide.</returns>
  public bool? Recommendations() => recommendations;

  /// <summary>
  ///   <para>Size of the button.</para>
  /// </summary>
  /// <param name="size">Size of the button.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="size"/> is a <c>null</c> reference.</exception>
  /// <exception cref="ArgumentException">If <paramref name="size"/> is <see cref="string.Empty"/> string.</exception>
  public IGooglePlusOneButtonWidget Size(string size)
  {
    if (size is null) throw new ArgumentNullException(nameof(size));
    if (size.IsEmpty()) throw new ArgumentException(nameof(size));

    this.size = size;
    return this;
  }

  /// <summary>
  ///   <para>Size of the button.</para>
  /// </summary>
  /// <returns>Size of the button.</returns>
  public string Size() => size;

  /// <summary>
  ///   <para>URL for the button. Default is current page's URL.</para>
  /// </summary>
  /// <param name="url">URL for the button.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="url"/> is a <c>null</c> reference.</exception>
  /// <exception cref="ArgumentException">If <paramref name="url"/> is <see cref="string.Empty"/> string.</exception>
  public IGooglePlusOneButtonWidget Url(string url)
  {
    if (url is null) throw new ArgumentNullException(nameof(url));
    if (url.IsEmpty()) throw new ArgumentException(nameof(url));

    this.url = url;
    return this;
  }

  /// <summary>
  ///   <para>URL for the button. Default is current page's URL.</para>
  /// </summary>
  /// <returns>URL for the button.</returns>
  public string Url() => url;

  /// <summary>
  ///   <para>If annotation is set to "inline", this parameter sets the width in pixels to use for the button and its inline annotation. If the width is omitted, a button and its inline annotation use 450px.</para>
  /// </summary>
  /// <param name="width">Width of the button.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="width"/> is a <c>null</c> reference.</exception>
  /// <exception cref="ArgumentException">If <paramref name="width"/> is <see cref="string.Empty"/> string.</exception>
  public IGooglePlusOneButtonWidget Width(string width)
  {
    if (width is null) throw new ArgumentNullException(nameof(width));
    if (width.IsEmpty()) throw new ArgumentException(nameof(width));

    this.width = width;
    return this;
  }

  /// <summary>
  ///   <para>If annotation is set to "inline", this parameter sets the width in pixels to use for the button and its inline annotation. If the width is omitted, a button and its inline annotation use 450px.</para>
  /// </summary>
  /// <returns>Width of the button.</returns>
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