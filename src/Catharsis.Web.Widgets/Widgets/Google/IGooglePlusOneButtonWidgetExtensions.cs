using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Set of extension methods for interface <see cref="IGooglePlusOneButtonWidget"/>.</para>
/// </summary>
/// <seealso cref="IGooglePlusOneButtonWidget"/>
public static class IGooglePlusOneButtonWidgetExtensions
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="widget"></param>
  /// <param name="url"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is <see langword="null"/>.</exception>
  public static IGooglePlusOneButtonWidget Url(this IGooglePlusOneButtonWidget widget, Uri url) => widget is not null ? widget.Url(url?.ToString()) : throw new ArgumentNullException(nameof(widget));

  /// <summary>
  ///   <para>If annotation is set to "inline", this parameter sets the width in pixels to use for the button and its inline annotation.</para>
  /// </summary>
  /// <param name="widget">Widget to call method on.</param>
  /// <param name="width">Width of the button.</param>
  /// <returns>Reference to provided <paramref name="widget"/>.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
  /// <seealso cref="IGooglePlusOneButtonWidget.Width(string)"/>
  public static IGooglePlusOneButtonWidget Width(this IGooglePlusOneButtonWidget widget, short width) => widget is not null ? widget.Width(width.ToInvariantString()) : throw new ArgumentNullException(nameof(widget));

  /// <summary>
  ///   <para>Size of the button.</para>
  /// </summary>
  /// <param name="widget">Widget to call method on.</param>
  /// <param name="size">Size of the button.</param>
  /// <returns>Reference to provided <paramref name="widget"/>.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
  /// <seealso cref="IGooglePlusOneButtonWidget.Size(string)"/>
  public static IGooglePlusOneButtonWidget Size(this IGooglePlusOneButtonWidget widget, GooglePlusOneButtonSize size) => widget is not null ? widget.Size(size.ToString().ToLowerInvariant()) : throw new ArgumentNullException(nameof(widget));

  /// <summary>
  ///   <para>Horizontal alignment of the button assets within its frame.</para>
  /// </summary>
  /// <param name="widget">Widget to call method on.</param>
  /// <param name="alignment">Horizontal alignment of the button.</param>
  /// <returns>Reference to provided <paramref name="widget"/>.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
  /// <seealso cref="IGooglePlusOneButtonWidget.Alignment(string)"/>
  public static IGooglePlusOneButtonWidget Alignment(this IGooglePlusOneButtonWidget widget, GooglePlusOneButtonAlignment alignment) => widget is not null ? widget.Alignment(alignment.ToString().ToLowerInvariant()) : throw new ArgumentNullException(nameof(widget));

  /// <summary>
  ///   <para>Annotation to display next to the button.</para>
  /// </summary>
  /// <param name="widget">Widget to call method on.</param>
  /// <param name="annotation">Annotation for the button.</param>
  /// <returns>Reference to provided <paramref name="widget"/>.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
  /// <seealso cref="IGooglePlusOneButtonWidget.Annotation(string)"/>
  public static IGooglePlusOneButtonWidget Annotation(this IGooglePlusOneButtonWidget widget, GooglePlusOneButtonAnnotation annotation) => widget is not null ? widget.Annotation(annotation.ToString().ToLowerInvariant()) : throw new ArgumentNullException(nameof(widget));
}