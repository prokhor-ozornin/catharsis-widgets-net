using System;
using System.Globalization;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Set of extension methods for interface <see cref="IFacebookPostWidget"/>.</para>
  ///   <seealso cref="IFacebookPostWidget"/>
  /// </summary>
  public static class IFacebookPostWidgetExtensions
  {
    /// <summary>
    ///   <para>Specifies width of Facebook post area on page.</para>
    /// </summary>
    /// <param name="widget">Widget to call method on.</param>
    /// <param name="width">Width of post.</param>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="IFacebookPostWidget.Width(string)"/>
    public static IFacebookPostWidget Width(this IFacebookPostWidget widget, short width)
    {
      Assertion.NotNull(widget);

      return widget.Width(width.ToString(CultureInfo.InvariantCulture));
    }
  }
}