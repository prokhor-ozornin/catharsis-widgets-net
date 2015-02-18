using System;
using System.Globalization;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Set of extension methods for interface <see cref="IVkontaktePollWidget"/>.</para>
  /// </summary>
  /// <seealso cref="IVkontaktePollWidget"/>
  public static class IVkontaktePollWidgetExtensions
  {
    /// <summary>
    ///   <para>Horizontal width of widget.</para>
    /// </summary>
    /// <param name="widget">Widget to call method on.</param>
    /// <param name="width">Width of widget.</param>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    public static IVkontaktePollWidget Width(this IVkontaktePollWidget widget, short width)
    {
      Assertion.NotNull(widget);

      return widget.Width(width.ToString(CultureInfo.InvariantCulture));
    }
  }
}