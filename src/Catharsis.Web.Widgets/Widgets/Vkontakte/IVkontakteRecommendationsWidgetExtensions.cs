namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Set of extension methods for interface <see cref="IVkontakteRecommendationsWidget"/>.</para>
/// </summary>
/// <seealso cref="IVkontakteRecommendationsWidget"/>
public static class IVkontakteRecommendationsWidgetExtensions
{
  /// <param name="widget">Widget to call method on.</param>
  extension(IVkontakteRecommendationsWidget widget)
  {
    /// <summary>
    ///   <para>Maximum number of pages to display initially. Default is 5.</para>
    /// </summary>
    /// <param name="limit">Maximum number of pages.</param>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    public IVkontakteRecommendationsWidget Limit(VkontakteRecommendationsLimit limit) => widget?.Limit((byte) limit) ?? throw new ArgumentNullException(nameof(widget));
  }
}