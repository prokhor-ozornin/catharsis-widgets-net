using System;
using System.Globalization;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Set of extension methods for interface <see cref="IMailRuFacesWidget"/>.</para>
  /// </summary>
  /// <seealso cref="IMailRuFacesWidget"/>
  public static class IMailRuFacesWidgetExtensions
  {
    /// <summary>
    ///   <para>Type of font, used for text labels.</para>
    /// </summary>
    /// <param name="widget">Widget to call method on.</param>
    /// <param name="font">Font type.</param>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="IMailRuFacesWidget.Font(string)"/>
    public static IMailRuFacesWidget Font(this IMailRuFacesWidget widget, MailRuFacesFont font)
    {
      if (widget is null) throw new ArgumentNullException(nameof(widget));

      switch (font)
      {
        case MailRuFacesFont.Arial :
          return widget.Font("Arial");

        case MailRuFacesFont.Georgia :
          return widget.Font("Georgia");

        case MailRuFacesFont.Tahoma :
          return widget.Font("Tahoma");
      }

      return widget;
    }

    /// <summary>
    ///   <para>Height of Faces box area.</para>
    /// </summary>
    /// <param name="widget">Widget to call method on.</param>
    /// <param name="height">Area height.</param>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="IMailRuFacesWidget.Height(string)"/>
    public static IMailRuFacesWidget Height(this IMailRuFacesWidget widget, short height) => widget is not null ? widget.Height(height.ToString(CultureInfo.InvariantCulture)) : throw new ArgumentNullException(nameof(widget));

    /// <summary>
    ///   <para>Width of Faces box area.</para>
    /// </summary>
    /// <param name="widget">Widget to call method on.</param>
    /// <param name="width">>Area width.</param>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="IMailRuFacesWidget.Width(string)"/>
    public static IMailRuFacesWidget Width(this IMailRuFacesWidget widget, short width) => widget is not null ? widget.Width(width.ToString(CultureInfo.InvariantCulture)) : throw new ArgumentNullException(nameof(widget));
  }
}