using System;
using System.Globalization;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Set of extension methods for interface <see cref="IMailRuFacesWidget"/>.</para>
  /// </summary>
  /// <seealso cref="IMailRuFacesWidget"/>
  public static class IMailRuFacesWidgetExtensions
  {
    /// <summary>
    ///   <para></para>
    /// </summary>
    /// <param name="widget"></param>
    /// <param name="font"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    public static IMailRuFacesWidget Font(this IMailRuFacesWidget widget, MailRuFacesFont font)
    {
      Assertion.NotNull(widget);

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
    ///   <para></para>
    /// </summary>
    /// <param name="widget"></param>
    /// <param name="height"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    public static IMailRuFacesWidget Height(this IMailRuFacesWidget widget, short height)
    {
      Assertion.NotNull(widget);

      return widget.Height(height.ToString(CultureInfo.InvariantCulture));
    }

    /// <summary>
    ///   <para></para>
    /// </summary>
    /// <param name="widget"></param>
    /// <param name="width"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    public static IMailRuFacesWidget Width(this IMailRuFacesWidget widget, short width)
    {
      Assertion.NotNull(widget);

      return widget.Width(width.ToString(CultureInfo.InvariantCulture));
    }
  }
}