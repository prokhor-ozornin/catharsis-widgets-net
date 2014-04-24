using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Renders Facebook Recommendations Feed.</para>
  ///   <para>Requires Facebook JavaScript initialization to be performed first.</para>
  /// </summary>
  /// <seealso cref="https://developers.facebook.com/docs/plugins/recommendations"/>
  public class FacebookRecommendationsFeedWidget : HtmlWidget, IFacebookRecommendationsFeedWidget
  {
    private IEnumerable<string> actions = Enumerable.Empty<string>();
    private string appId;
    private string colorScheme;
    private string domain;
    private bool? header;
    private string height;
    private string linkTarget;
    private byte? maxAge;
    private string trackLabel;
    private string width;

    /// <summary>
    ///   <para>Collection of Open Graph action types to show in the feed.</para>
    /// </summary>
    /// <param name="actions">Collection of Facebook action types.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="actions"/> is a <c>null</c> reference.</exception>
    public IFacebookRecommendationsFeedWidget Actions(IEnumerable<string> actions)
    {
      Assertion.NotNull(actions);

      this.actions = actions;
      return this;
    }

    /// <summary>
    ///   <para>Display all actions associated with this app ID. This is usually inferred from the app ID you use to initiate the JavaScript SDK.</para>
    /// </summary>
    /// <param name="appId">Facebook Application ID.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="appId"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="appId"/> is <see cref="string.Empty"/> string.</exception>
    public IFacebookRecommendationsFeedWidget AppId(string appId)
    {
      Assertion.NotEmpty(appId);

      this.appId = appId;
      return this;
    }

    /// <summary>
    ///   <para>The color scheme used by the widget.</para>
    /// </summary>
    /// <param name="colorScheme">Color scheme of widget.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="colorScheme"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="colorScheme"/> is <see cref="string.Empty"/> string.</exception>
    public IFacebookRecommendationsFeedWidget ColorScheme(string colorScheme)
    {
      Assertion.NotEmpty(colorScheme);

      this.colorScheme = colorScheme;
      return this;
    }

    /// <summary>
    ///   <para>The domain for which to show activity. Default is current domain.</para>
    /// </summary>
    /// <param name="domain">Site domain.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="domain"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="domain"/> is <see cref="string.Empty"/> string.</exception>
    public IFacebookRecommendationsFeedWidget Domain(string domain)
    {
      Assertion.NotEmpty(domain);

      this.domain = domain;
      return this;
    }

    /// <summary>
    ///   <para>The width of the widget in pixels. Default is 300.</para>
    /// </summary>
    /// <param name="width">Width of widget.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="width"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="width"/> is <see cref="string.Empty"/> string.</exception>
    public IFacebookRecommendationsFeedWidget Width(string width)
    {
      Assertion.NotEmpty(width);

      this.width = width;
      return this;
    }

    /// <summary>
    ///   <para>The height of the widget in pixels. Default is 300.</para>
    /// </summary>
    /// <param name="height">Height of widget.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="height"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="height"/> is <see cref="string.Empty"/> string.</exception>
    public IFacebookRecommendationsFeedWidget Height(string height)
    {
      Assertion.NotEmpty(height);

      this.height = height;
      return this;
    }

    /// <summary>
    ///   <para>Whether to show the "Recent Activity" header above the feed or not. Default is <c>true</c>.</para>
    /// </summary>
    /// <param name="show"><c>true</c> to show header, <c>false</c> to hide.</param>
    /// <returns>Reference to the current widget.</returns>
    public IFacebookRecommendationsFeedWidget Header(bool show = true)
    {
      this.header = show;
      return this;
    }

    /// <summary>
    ///   <para>Determines what happens when people click on the links in the feed. Can be any of the standard HTML target values. Default is "_blank".</para>
    /// </summary>
    /// <param name="target">Hyperlinks HTML target attribute.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="target"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="target"/> is <see cref="string.Empty"/> string.</exception>
    public IFacebookRecommendationsFeedWidget LinkTarget(string target)
    {
      Assertion.NotEmpty(target);

      this.linkTarget = target;
      return this;
    }

    /// <summary>
    ///   <para>Limit the created time of articles that are shown in the feed. Valid values are 1-180, which represents the age in days to limit to. Default is 0 (no limit).</para>
    /// </summary>
    /// <param name="maxAge">Days age limit.</param>
    /// <returns>Reference to the current widget.</returns>
    public IFacebookRecommendationsFeedWidget MaxAge(byte maxAge)
    {
      this.maxAge = maxAge;
      return this;
    }

    /// <summary>
    ///   <para>A label for tracking referrals which must be less than 50 characters and can contain alphanumeric characters and some punctuation (currently +/=-.:_).</para>
    /// </summary>
    /// <param name="label">Label for tracking referrals.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="label"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="label is <see cref="string.Empty"/> string.</exception>
    public IFacebookRecommendationsFeedWidget TrackLabel(string label)
    {
      Assertion.NotEmpty(label);

      this.trackLabel = label;
      return this;
    }

    /// <summary>
    ///   <para>Returns HTML markup text of widget.</para>
    /// </summary>
    /// <returns>Widget's HTML markup.</returns>
    public override string ToHtmlString()
    {
      return new TagBuilder("div")
        .Attribute("data-site", this.domain)
        .Attribute("data-app-id", this.appId)
        .Attribute("data-action", this.actions.Any() ? this.actions.Join(",") : null)
        .Attribute("data-width", this.width)
        .Attribute("data-height", this.height)
        .Attribute("data-colorscheme", this.colorScheme)
        .Attribute("data-header", this.header)
        .Attribute("data-linktarget", this.linkTarget)
        .Attribute("data-max-age", this.maxAge)
        .Attribute("data-ref", this.trackLabel)
        .CssClass("fb-recommendations")
        .ToString();
    }
  }
}