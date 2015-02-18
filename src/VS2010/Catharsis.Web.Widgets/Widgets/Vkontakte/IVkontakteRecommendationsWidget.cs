using System;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Renders VKontakte Recommendations widget.</para>
  ///   <para>Requires Vkontakte JavaScript initialization to be performed first.</para>
  /// </summary>
  /// <seealso cref="http://vk.com/dev/Recommended"/>
  public interface IVkontakteRecommendationsWidget : IHtmlWidget
  {
    /// <summary>
    ///   <para>Identifier of HTML container for the widget.</para>
    /// </summary>
    /// <param name="id">HTML element's identifier.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="id"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="id"/> is <see cref="string.Empty"/> string.</exception>
    IVkontakteRecommendationsWidget ElementId(string id);

    /// <summary>
    ///   <para>Identifier of HTML container for the widget.</para>
    /// </summary>
    /// <returns>HTML element's identifier.</returns>
    string ElementId();

    /// <summary>
    ///   <para>Maximum number of pages to display initially. Default is 5.</para>
    /// </summary>
    /// <param name="limit">Maximum number of pages.</param>
    /// <returns>Reference to the current widget.</returns>
    IVkontakteRecommendationsWidget Limit(byte limit);

    /// <summary>
    ///   <para>Maximum number of pages to display initially. Default is 5.</para>
    /// </summary>
    /// <returns>Maximum number of pages.</returns>
    byte? Limit();

    /// <summary>
    ///   <para>Maximum number of pages to display when "Show all recommendations" is being pressed. Default is 4 * limit.</para>
    /// </summary>
    /// <param name="max">Maximum number of pages.</param>
    /// <returns>Reference to the current widget.</returns>
    IVkontakteRecommendationsWidget Max(short max);

    /// <summary>
    ///   <para>Maximum number of pages to display when "Show all recommendations" is being pressed. Default is 4 * limit.</para>
    /// </summary>
    /// <returns>Maximum number of pages.</returns>
    short? Max();

    /// <summary>
    ///   <para>Report statistical period. Default is "week".</para>
    /// </summary>
    /// <param name="period">Statistical period.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="period"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="period"/> is <see cref="string.Empty"/> string.</exception>
    IVkontakteRecommendationsWidget Period(VkontakteRecommendationsPeriod period);

    /// <summary>
    ///   <para>Report statistical period. Default is "week".</para>
    /// </summary>
    /// <returns>Statistical period.</returns>
    VkontakteRecommendationsPeriod? Period();

    /// <summary>
    ///   <para>Numeric code of verb to use as a label. Default is 0 ("like").</para>
    /// </summary>
    /// <param name="verb">Type of verb.</param>
    /// <returns>Reference to the current widget.</returns>
    IVkontakteRecommendationsWidget Verb(VkontakteRecommendationsVerb verb);

    /// <summary>
    ///   <para>Numeric code of verb to use as a label. Default is <see cref="VkontakteRecommendationsVerb.Like"/>.</para>
    /// </summary>
    /// <returns>Type of verb.</returns>
    VkontakteRecommendationsVerb? Verb();

    /// <summary>
    ///   <para>Recommended materials sorting mode. Default is <see cref="VkontakteRecommendationsSorting.FriendLikes"/>.</para>
    /// </summary>
    /// <param name="sorting">Sorting mode.</param>
    /// <returns>Reference to the current widget.</returns>
    IVkontakteRecommendationsWidget Sorting(VkontakteRecommendationsSorting sorting);

    /// <summary>
    ///   <para>Recommended materials sorting mode. Default is <see cref="VkontakteRecommendationsSorting.FriendLikes"/>.</para>
    /// </summary>
    /// <returns>Sorting mode.</returns>
    VkontakteRecommendationsSorting? Sorting();

    /// <summary>
    ///   <para>Target attribute for recommendations HTML hyperlinks. Default is "parent".</para>
    /// </summary>
    /// <param name="target">HTML hyperlinks target value.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="target"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="target"/> is <see cref="string.Empty"/> string.</exception>
    IVkontakteRecommendationsWidget Target(string target);

    /// <summary>
    ///   <para>Target attribute for recommendations HTML hyperlinks. Default is "parent".</para>
    /// </summary>
    /// <returns>HTML hyperlinks target value.</returns>
    string Target();
  }
}