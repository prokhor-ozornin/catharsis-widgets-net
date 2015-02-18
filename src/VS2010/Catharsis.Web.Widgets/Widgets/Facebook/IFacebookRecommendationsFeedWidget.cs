using System;
using System.Collections.Generic;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Renders Facebook Recommendations Feed.</para>
  ///   <para>Requires Facebook JavaScript initialization to be performed first.</para>
  /// </summary>
  /// <seealso cref="https://developers.facebook.com/docs/plugins/recommendations"/>
  public interface IFacebookRecommendationsFeedWidget : IHtmlWidget
  {
    /// <summary>
    ///   <para>Collection of Open Graph action types to show in the feed.</para>
    /// </summary>
    /// <param name="actions">Collection of Facebook action types.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="actions"/> is a <c>null</c> reference.</exception>
    IFacebookRecommendationsFeedWidget Actions(IEnumerable<string> actions);

    /// <summary>
    ///   <para>Collection of Open Graph action types to show in the feed.</para>
    /// </summary>
    /// <returns>Collection of Facebook action types.</returns>
    IEnumerable<string> Actions();

    /// <summary>
    ///   <para>Display all actions associated with this app ID. This is usually inferred from the app ID you use to initiate the JavaScript SDK.</para>
    /// </summary>
    /// <param name="appId">Facebook Application ID.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="appId"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="appId"/> is <see cref="string.Empty"/> string.</exception>
    IFacebookRecommendationsFeedWidget AppId(string appId);

    /// <summary>
    ///   <para>Display all actions associated with this app ID. This is usually inferred from the app ID you use to initiate the JavaScript SDK.</para>
    /// </summary>
    /// <returns>Facebook Application ID.</returns>
    string AppId();

    /// <summary>
    ///   <para>The color scheme used by the widget.</para>
    /// </summary>
    /// <param name="colorScheme">Color scheme of widget.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="colorScheme"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="colorScheme"/> is <see cref="string.Empty"/> string.</exception>
    IFacebookRecommendationsFeedWidget ColorScheme(string colorScheme);

    /// <summary>
    ///   <para>The color scheme used by the widget.</para>
    /// </summary>
    /// <returns>Color scheme of widget.</returns>
    string ColorScheme();

    /// <summary>
    ///   <para>The domain for which to show activity. Default is current domain.</para>
    /// </summary>
    /// <param name="domain">Site domain.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="domain"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="domain"/> is <see cref="string.Empty"/> string.</exception>
    IFacebookRecommendationsFeedWidget Domain(string domain);

    /// <summary>
    ///   <para>The domain for which to show activity. Default is current domain.</para>
    /// </summary>
    /// <returns>Site domain.</returns>
    string Domain();

    /// <summary>
    ///   <para>Whether to show the "Recent Activity" header above the feed or not. Default is <c>true</c>.</para>
    /// </summary>
    /// <param name="show"><c>true</c> to show header, <c>false</c> to hide.</param>
    /// <returns>Reference to the current widget.</returns>
    IFacebookRecommendationsFeedWidget Header(bool show);

    /// <summary>
    ///   <para>Whether to show the "Recent Activity" header above the feed or not. Default is <c>true</c>.</para>
    /// </summary>
    /// <returns><c>true</c> to show header, <c>false</c> to hide.</returns>
    bool? Header();

    /// <summary>
    ///   <para>The height of the widget in pixels. Default is 300.</para>
    /// </summary>
    /// <param name="height">Height of widget.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="height"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="height"/> is <see cref="string.Empty"/> string.</exception>
    IFacebookRecommendationsFeedWidget Height(string height);

    /// <summary>
    ///   <para>The height of the widget in pixels. Default is 300.</para>
    /// </summary>
    /// <returns>Height of widget.</returns>
    string Height();

    /// <summary>
    ///   <para>Determines what happens when people click on the links in the feed. Can be any of the standard HTML target values. Default is "_blank".</para>
    /// </summary>
    /// <param name="target">Hyperlinks HTML target attribute.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="target"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="target"/> is <see cref="string.Empty"/> string.</exception>
    IFacebookRecommendationsFeedWidget LinkTarget(string target);

    /// <summary>
    ///   <para>Determines what happens when people click on the links in the feed. Can be any of the standard HTML target values. Default is "_blank".</para>
    /// </summary>
    /// <returns>Hyperlinks HTML target attribute.</returns>
    string LinkTarget();

    /// <summary>
    ///   <para>Limit the created time of articles that are shown in the feed. Valid values are 1-180, which represents the age in days to limit to. Default is 0 (no limit).</para>
    /// </summary>
    /// <param name="maxAge">Days age limit.</param>
    /// <returns>Reference to the current widget.</returns>
    IFacebookRecommendationsFeedWidget MaxAge(byte maxAge);

    /// <summary>
    ///   <para>Limit the created time of articles that are shown in the feed. Valid values are 1-180, which represents the age in days to limit to. Default is 0 (no limit).</para>
    /// </summary>
    /// <returns>Days age limit.</returns>
    byte? MaxAge();

    /// <summary>
    ///   <para>A label for tracking referrals which must be less than 50 characters and can contain alphanumeric characters and some punctuation (currently +/=-.:_).</para>
    /// </summary>
    /// <param name="label">Label for tracking referrals.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="label"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="label"/> is <see cref="string.Empty"/> string.</exception>
    IFacebookRecommendationsFeedWidget TrackLabel(string label);

    /// <summary>
    ///   <para>A label for tracking referrals which must be less than 50 characters and can contain alphanumeric characters and some punctuation (currently +/=-.:_).</para>
    /// </summary>
    /// <returns>Label for tracking referrals.</returns>
    string TrackLabel();

    /// <summary>
    ///   <para>The width of the widget in pixels. Default is 300.</para>
    /// </summary>
    /// <param name="width">Width of widget.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="width"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="width"/> is <see cref="string.Empty"/> string.</exception>
    IFacebookRecommendationsFeedWidget Width(string width);

    /// <summary>
    ///   <para>The width of the widget in pixels. Default is 300.</para>
    /// </summary>
    /// <returns>Width of widget.</returns>
    string Width();
  }
}