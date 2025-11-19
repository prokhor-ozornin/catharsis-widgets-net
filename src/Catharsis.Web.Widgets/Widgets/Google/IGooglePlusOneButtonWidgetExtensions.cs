using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Set of extension methods for interface <see cref="IGooglePlusOneButtonWidget"/>.</para>
/// </summary>
/// <seealso cref="IGooglePlusOneButtonWidget"/>
public static class IGooglePlusOneButtonWidgetExtensions
{
  /// <param name="widget">Widget to call method on.</param>
  extension(IGooglePlusOneButtonWidget widget)
  {
    /// <summary>
    ///   <para></para>
    /// </summary>
    /// <param name="url"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is <see langword="null"/>.</exception>
    public IGooglePlusOneButtonWidget Url(Uri url) => widget?.Url(url?.ToString()) ?? throw new ArgumentNullException(nameof(widget));

    /// <summary>
    ///   <para>If annotation is set to "inline", this parameter sets the width in pixels to use for the button and its inline annotation.</para>
    /// </summary>
    /// <param name="width">Width of the button.</param>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="IGooglePlusOneButtonWidget.Width(string)"/>
    public IGooglePlusOneButtonWidget Width(short width) => widget?.Width(width.ToInvariantString()) ?? throw new ArgumentNullException(nameof(widget));

    /// <summary>
    ///   <para>Size of the button.</para>
    /// </summary>
    /// <param name="size">Size of the button.</param>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="IGooglePlusOneButtonWidget.Size(string)"/>
    public IGooglePlusOneButtonWidget Size(GooglePlusOneButtonSize size) => widget?.Size(size.ToString().ToLowerInvariant()) ?? throw new ArgumentNullException(nameof(widget));

    /// <summary>
    ///   <para>Horizontal alignment of the button assets within its frame.</para>
    /// </summary>
    /// <param name="alignment">Horizontal alignment of the button.</param>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="IGooglePlusOneButtonWidget.Alignment(string)"/>
    public IGooglePlusOneButtonWidget Alignment(GooglePlusOneButtonAlignment alignment) => widget?.Alignment(alignment.ToString().ToLowerInvariant()) ?? throw new ArgumentNullException(nameof(widget));

    /// <summary>
    ///   <para>Annotation to display next to the button.</para>
    /// </summary>
    /// <param name="annotation">Annotation for the button.</param>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="IGooglePlusOneButtonWidget.Annotation(string)"/>
    public IGooglePlusOneButtonWidget Annotation(GooglePlusOneButtonAnnotation annotation) => widget?.Annotation(annotation.ToString().ToLowerInvariant()) ?? throw new ArgumentNullException(nameof(widget));
  }
}