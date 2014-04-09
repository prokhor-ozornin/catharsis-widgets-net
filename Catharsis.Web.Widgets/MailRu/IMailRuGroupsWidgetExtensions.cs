using System;
using System.Globalization;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Set of extension methods for interface <see cref="IMailRuGroupsWidget"/>.</para>
  /// </summary>
  /// <seealso cref="IMailRuGroupsWidget"/>
  public static class IMailRuGroupsWidgetExtensions
  {
    /// <summary>
    ///   <para></para>
    /// </summary>
    /// <param name="widget"></param>
    /// <param name="height"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    public static IMailRuGroupsWidget Height(this IMailRuGroupsWidget widget, short height)
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
    public static IMailRuGroupsWidget Width(this IMailRuGroupsWidget widget, short width)
    {
      Assertion.NotNull(widget);

      return widget.Width(width.ToString(CultureInfo.InvariantCulture));
    }
  }
}