using System;
using System.Globalization;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Set of extension methods for interface <see cref="IMailRuLikeButtonWidget"/>.</para>
  ///   <seealso cref="IMailRuLikeButtonWidget"/>
  /// </summary>
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
      Assertion.NotNull(widget);
      
      string typeName;
      switch (type)
      {
        case MailRuLikeButtonType.All :
          typeName = "combo";
        break;

        case MailRuLikeButtonType.MailRu :
          typeName = "mm";
        break;

        case MailRuLikeButtonType.Odnoklassniki :
          typeName = "ok";
        break;

        default :
          throw new NotSupportedException();
      }

      return widget.Type(typeName);
    }

    /// <summary>
    ///   <para>Vertical size of button.</para>
    /// </summary>
    /// <param name="widget">Widget to call method on.</param>
    /// <param name="size">Vertical size of button.</param>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="IMailRuLikeButtonWidget.Size(string)"/>
    public static IMailRuLikeButtonWidget Size(this IMailRuLikeButtonWidget widget, short size)
    {
      Assertion.NotNull(widget);

      return widget.Size(size.ToString(CultureInfo.InvariantCulture));
    }

    /// <summary>
    ///   <para>Vertical size of button.</para>
    /// </summary>
    /// <param name="widget">Widget to call method on.</param>
    /// <param name="size">Vertical size of button.</param>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="IMailRuLikeButtonWidget.Size(string)"/>
    public static IMailRuLikeButtonWidget Size(this IMailRuLikeButtonWidget widget, MailRuLikeButtonSize size)
    {
      Assertion.NotNull(widget);

      return widget.Size((short)size);
    }

    /// <summary>
    ///   <para>Visual layout/appearance of button.</para>
    /// </summary>
    /// <param name="widget">Widget to call method on.</param>
    /// <param name="layout">Visual layout of button.</param>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="IMailRuLikeButtonWidget.Layout(byte)"/>
    public static IMailRuLikeButtonWidget Layout(this IMailRuLikeButtonWidget widget, MailRuLikeButtonLayout layout)
    {
      Assertion.NotNull(widget);

      return widget.Layout((byte)layout);
    }

    /// <summary>
    ///   <para>Type of text label to show on button.</para>
    /// </summary>
    /// <param name="widget">Widget to call method on.</param>
    /// <param name="type">Type of text label.</param>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="IMailRuLikeButtonWidget.TextType(byte)"/>
    public static IMailRuLikeButtonWidget TextType(this IMailRuLikeButtonWidget widget, MailRuLikeButtonTextType type)
    {
      Assertion.NotNull(widget);

      return widget.TextType((byte)type);
    }

    /// <summary>
    ///   <para>Position of a share counter.</para>
    /// </summary>
    /// <param name="widget">Widget to call method on.</param>
    /// <param name="position">Position of a counter.</param>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="IMailRuLikeButtonWidget.CounterPosition(string)"/>
    public static IMailRuLikeButtonWidget CounterPosition(this IMailRuLikeButtonWidget widget, MailRuLikeButtonCounterPosition position)
    {
      Assertion.NotNull(widget);

      return widget.CounterPosition(Enum.GetName(typeof(MailRuLikeButtonCounterPosition), position).ToLowerInvariant());
    }
  }
}