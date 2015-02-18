using System;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Set of extension methods for interface <see cref="IVkontakteRecommendationsWidget"/>.</para>
  /// </summary>
  /// <seealso cref="IVkontakteRecommendationsWidget"/>
  public static class IVkontakteRecommendationsWidgetExtensions
  {
    /// <summary>
    ///   <para>Maximum number of pages to display initially. Default is 5.</para>
    /// </summary>
    /// <param name="widget">Widget to call method on.</param>
    /// <param name="limit">Maximum number of pages.</param>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    public static IVkontakteRecommendationsWidget Limit(this IVkontakteRecommendationsWidget widget, VkontakteRecommendationsLimit limit)
    {
      Assertion.NotNull(widget);

      return widget.Limit((byte)limit);
    }
  }
}