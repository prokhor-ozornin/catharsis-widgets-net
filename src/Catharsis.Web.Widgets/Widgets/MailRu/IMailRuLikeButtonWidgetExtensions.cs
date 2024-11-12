using System.Globalization;

namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Set of extension methods for interface <see cref="IMailRuLikeButtonWidget"/>.</para>
/// </summary>
/// <seealso cref="IMailRuLikeButtonWidget"/>
public static class IMailRuLikeButtonWidgetExtensions
{
  /// <summary>
  ///   <para>Type of button.</para>
  /// </summary>
  /// <param name="widget">Widget to call method on.</param>
  /// <param name="type">Type of button.</param>
  /// <returns>Reference to provided <paramref name="widget"/>.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
  /// <seealso cref="IMailRuLikeButtonWidget.Type(string)"/>
  public static IMailRuLikeButtonWidget Type(this IMailRuLikeButtonWidget widget, MailRuLikeButtonType type)
  {
    if (widget is null) throw new ArgumentNullException(nameof(widget));

    return type switch
    {
      MailRuLikeButtonType.MailRu => widget.Type("mm"),
      MailRuLikeButtonType.Odnoklassniki => widget.Type("ok"),
      _ => widget.Type("combo")
    };
  }

  /// <summary>
  ///   <para>Vertical size of button.</para>
  /// </summary>
  /// <param name="widget">Widget to call method on.</param>
  /// <param name="size">Vertical size of button.</param>
  /// <returns>Reference to provided <paramref name="widget"/>.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
  /// <seealso cref="IMailRuLikeButtonWidget.Size(string)"/>
  public static IMailRuLikeButtonWidget Size(this IMailRuLikeButtonWidget widget, short size) => widget is not null ? widget.Size(size.ToString(CultureInfo.InvariantCulture)) : throw new ArgumentNullException(nameof(widget));

  /// <summary>
  ///   <para>Vertical size of button.</para>
  /// </summary>
  /// <param name="widget">Widget to call method on.</param>
  /// <param name="size">Vertical size of button.</param>
  /// <returns>Reference to provided <paramref name="widget"/>.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
  /// <seealso cref="IMailRuLikeButtonWidget.Size(string)"/>
  public static IMailRuLikeButtonWidget Size(this IMailRuLikeButtonWidget widget, MailRuLikeButtonSize size) => widget is not null ? widget.Size((short) size) : throw new ArgumentNullException(nameof(widget));

  /// <summary>
  ///   <para>Visual layout/appearance of button.</para>
  /// </summary>
  /// <param name="widget">Widget to call method on.</param>
  /// <param name="layout">Visual layout of button.</param>
  /// <returns>Reference to provided <paramref name="widget"/>.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
  /// <seealso cref="IMailRuLikeButtonWidget.Layout(byte)"/>
  public static IMailRuLikeButtonWidget Layout(this IMailRuLikeButtonWidget widget, MailRuLikeButtonLayout layout) => widget is not null ? widget.Layout((byte) layout) : throw new ArgumentNullException(nameof(widget));

  /// <summary>
  ///   <para>Type of text label to show on button.</para>
  /// </summary>
  /// <param name="widget">Widget to call method on.</param>
  /// <param name="type">Type of text label.</param>
  /// <returns>Reference to provided <paramref name="widget"/>.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
  /// <seealso cref="IMailRuLikeButtonWidget.TextType(byte)"/>
  public static IMailRuLikeButtonWidget TextType(this IMailRuLikeButtonWidget widget, MailRuLikeButtonTextType type) => widget is not null ? widget.TextType((byte) type) : throw new ArgumentNullException(nameof(widget));

  /// <summary>
  ///   <para>Position of a share counter.</para>
  /// </summary>
  /// <param name="widget">Widget to call method on.</param>
  /// <param name="position">Position of a counter.</param>
  /// <returns>Reference to provided <paramref name="widget"/>.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
  /// <seealso cref="IMailRuLikeButtonWidget.CounterPosition(string)"/>
  public static IMailRuLikeButtonWidget CounterPosition(this IMailRuLikeButtonWidget widget, MailRuLikeButtonCounterPosition position) => widget is not null ? widget.CounterPosition(position.ToString().ToLowerInvariant()) : throw new ArgumentNullException(nameof(widget));
}