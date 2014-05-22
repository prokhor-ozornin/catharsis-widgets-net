using System;
using System.Globalization;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Set of extension methods for interface <see cref="IVkontaktePostWidget"/>.</para>
  /// </summary>
  /// <seealso cref="IVkontaktePostWidget"/>
  public static class IVkontaktePostWidgetExtensions
  {
    /// <summary>
    ///   <para>Unique identifier of wall's post.</para>
    /// </summary>
    /// <param name="widget">Widget to call method on.</param>
    /// <param name="id">Identifier of post.</param>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    public static IVkontaktePostWidget Id(this IVkontaktePostWidget widget, long id)
    {
      Assertion.NotNull(widget);

      return widget.Id(id.ToString(CultureInfo.InvariantCulture));
    }

    /// <summary>
    ///   <para>Unique identifier of Vkontakte wall's owner.</para>
    /// </summary>
    /// <param name="widget">Widget to call method on.</param>
    /// <param name="id">Identifier of wall's owner.</param>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    public static IVkontaktePostWidget Owner(this IVkontaktePostWidget widget, long id)
    {
      Assertion.NotNull(widget);

      return widget.Owner(id.ToString(CultureInfo.InvariantCulture));
    }

    /// <summary>
    ///   <para>Width of wall's post. Default is the width of entire screen.</para>
    /// </summary>
    /// <param name="widget">Widget to call method on.</param>
    /// <param name="width">Width of post.</param>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    public static IVkontaktePostWidget Width(this IVkontaktePostWidget widget, short width)
    {
      Assertion.NotNull(widget);

      return widget.Width(width.ToString(CultureInfo.InvariantCulture));
    }
  }
}