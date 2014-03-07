using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Renders Facebook Recommendations Feed.</para>
  ///   <para>Requires Facebook JavaScript initialization to be performed first.</para>
  /// </summary>
  /// <seealso cref="https://developers.facebook.com/docs/plugins/recommendations"/>
  public sealed class FacebookRecommendationsFeedWidget : HtmlWidgetBase<IFacebookRecommendationsFeedWidget>, IFacebookRecommendationsFeedWidget
  {
    private string domain;
    private string appId;
    private IEnumerable<string> actions = Enumerable.Empty<string>();
    private string width;
    private string height;
    private string colorScheme;
    private bool? header;
    private string linkTarget;
    private byte? maxAge;
    private string trackLabel;

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
    ///   <para>Whether to show the "Recent Activity" header above the feed or not. Default is <c>true</c>.</para>
    /// </summary>
    /// <param name="header"><c>true</c> to show header, <c>false</c> to hide.</param>
    /// <returns>Reference to the current widget.</returns>
    public IFacebookRecommendationsFeedWidget Header(bool header = true)
    {
      this.header = header;
      return this;
    }

    /// <summary>
    ///   <para>Determines what happens when people click on the links in the feed. Can be any of the standard HTML target values. Default is "_blank".</para>
    /// </summary>
    /// <param name="linkTarget">Hyperlinks HTML target attribute.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="linkTarget"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="linkTarget"/> is <see cref="string.Empty"/> string.</exception>
    public IFacebookRecommendationsFeedWidget LinkTarget(string linkTarget)
    {
      Assertion.NotEmpty(linkTarget);

      this.linkTarget = linkTarget;
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
    /// <param name="trackLabel">Label for tracking referrals.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="trackLabel"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="trackLabel"/> is <see cref="string.Empty"/> string.</exception>
    public IFacebookRecommendationsFeedWidget TrackLabel(string trackLabel)
    {
      Assertion.NotEmpty(trackLabel);

      this.trackLabel = trackLabel;
      return this;
    }

    /// <summary>
    ///   <para>Generates and writes HTML markup of widget, using specified text writer.</para>
    /// </summary>
    /// <param name="writer">Text writer to use as output destination.</param>
    public override void Write(TextWriter writer)
    {
      Assertion.NotNull(writer);

      writer.Write(this.ToTag("div", tag => tag
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
        .AddCssClass("fb-recommendations")));
    }
  }
}