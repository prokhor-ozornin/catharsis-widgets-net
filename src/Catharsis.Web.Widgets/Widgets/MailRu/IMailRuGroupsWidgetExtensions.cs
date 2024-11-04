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
    ///   <para>Height of Groups box area.</para>
    /// </summary>
    /// <param name="widget">Widget to call method on.</param>
    /// <param name="height">Area height.</param>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="IMailRuGroupsWidget.Height(string)"/>
    public static IMailRuGroupsWidget Height(this IMailRuGroupsWidget widget, short height)
    {
      Assertion.NotNull(widget);

      return widget.Height(height.ToString(CultureInfo.InvariantCulture));
    }

    /// <summary>
    ///   <para>Width of Groups box area.</para>
    /// </summary>
    /// <param name="widget">Widget to call method on.</param>
    /// <param name="width">Area width.</param>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="IMailRuGroupsWidget.Width(string)"/>
    public static IMailRuGroupsWidget Width(this IMailRuGroupsWidget widget, short width)
    {
      Assertion.NotNull(widget);

      return widget.Width(width.ToString(CultureInfo.InvariantCulture));
    }
  }
}