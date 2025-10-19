namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Renders Facebook Activity Feed.</para>
///   <para>Requires Facebook JavaScript initialization to be performed first.</para>
/// </summary>
/// <seealso href="https://developers.facebook.com/docs/plugins/activity"/>
public interface IFacebookActivityFeedWidget : IWebWidget
{
  /// <summary>
  ///   <para>Collection of Open Graph action types to show in the feed.</para>
  /// </summary>
  /// <param name="actions">Collection of Facebook action types.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="actions"/> is a <c>null</c> reference.</exception>
  IFacebookActivityFeedWidget Actions(IEnumerable<string> actions);

  /// <summary>
  ///   <para>Display all actions associated with this app ID. This is usually inferred from the app ID you use to initiate the JavaScript SDK.</para>
  /// </summary>
  /// <param name="id">Facebook Application ID.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="id"/> is a <c>null</c> reference.</exception>
  /// <exception cref="ArgumentException">If <paramref name="id"/> is <see cref="string.Empty"/> string.</exception>
  IFacebookActivityFeedWidget AppId(string id);

  /// <summary>
  ///   <para>The color scheme used by the widget.</para>
  /// </summary>
  /// <param name="scheme">Color scheme of widget.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="scheme"/> is a <c>null</c> reference.</exception>
  /// <exception cref="ArgumentException">If <paramref name="scheme"/> is <see cref="string.Empty"/> string.</exception>
  IFacebookActivityFeedWidget ColorScheme(string scheme);

  /// <summary>
  ///   <para>The domain for which to show activity. Default is current domain.</para>
  /// </summary>
  /// <param name="domain">Site domain.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="domain"/> is a <c>null</c> reference.</exception>
  /// <exception cref="ArgumentException">If <paramref name="domain"/> is <see cref="string.Empty"/> string.</exception>
  IFacebookActivityFeedWidget Domain(string domain);

  /// <summary>
  ///   <para>Whether to enabled the "Recent Activity" header above the feed or not. Default is <c>true</c>.</para>
  /// </summary>
  /// <param name="enabled"><c>true</c> to show header, <c>false</c> to hide.</param>
  /// <returns>Reference to the current widget.</returns>
  IFacebookActivityFeedWidget Header(bool enabled);

  /// <summary>
  ///   <para>The height of the widget in pixels. Default is 300.</para>
  /// </summary>
  /// <param name="height">Height of widget.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="height"/> is a <c>null</c> reference.</exception>
  /// <exception cref="ArgumentException">If <paramref name="height"/> is <see cref="string.Empty"/> string.</exception>
  IFacebookActivityFeedWidget Height(string height);

  /// <summary>
  ///   <para>Determines what happens when people click on the links in the feed. Can be any of the standard HTML target values. Default is "_blank".</para>
  /// </summary>
  /// <param name="target">Hyperlinks HTML target attribute.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="target"/> is a <c>null</c> reference.</exception>
  /// <exception cref="ArgumentException">If <paramref name="target"/> is <see cref="string.Empty"/> string.</exception>
  IFacebookActivityFeedWidget LinkTarget(string target);

  /// <summary>
  ///   <para>Limit the created time of articles that are shown in the feed. Valid values are 1-180, which represents the age in days to limit to. Default is 0 (no limit).</para>
  /// </summary>
  /// <param name="age">Days age limit.</param>
  /// <returns>Reference to the current widget.</returns>
  IFacebookActivityFeedWidget MaxAge(byte age);

  /// <summary>
  ///   <para>Specifies whether to always show recommendations (Articles liked by a high amount of people) in the bottom half of the feed. Default is <c>false</c>.</para>
  /// </summary>
  /// <param name="enabled"><c>true</c> to show recommendations, <c>false</c> to hide.</param>
  /// <returns>Reference to the current widget.</returns>
  IFacebookActivityFeedWidget Recommendations(bool enabled);

  /// <summary>
  ///   <para>A label for tracking referrals which must be less than 50 characters and can contain alphanumeric characters and some punctuation (currently +/=-.:_).</para>
  /// </summary>
  /// <param name="label">Label for tracking referrals.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="label"/> is a <c>null</c> reference.</exception>
  /// <exception cref="ArgumentException">If <paramref name="label"/> is <see cref="string.Empty"/> string.</exception>
  IFacebookActivityFeedWidget TrackLabel(string label);

  /// <summary>
  ///   <para>The width of the widget in pixels. Default is 300.</para>
  /// </summary>
  /// <param name="width">Width of widget.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="width"/> is a <c>null</c> reference.</exception>
  /// <exception cref="ArgumentException">If <paramref name="width"/> is <see cref="string.Empty"/> string.</exception>
  IFacebookActivityFeedWidget Width(string width);
}