using System.Web.Mvc;
using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IFacebookActivityFeedWidget"/>
public class FacebookActivityFeedWidget : HtmlWidget, IFacebookActivityFeedWidget
{
  private IEnumerable<string> actions = [];
  private string appId;
  private string colorScheme;
  private string domain;
  private bool? header;
  private string height;
  private string linkTarget;
  private byte? maxAge;
  private bool? recommendations;
  private string trackLabel;
  private string width;

  /// <summary>
  ///   <para>Collection of Open Graph action types to show in the feed.</para>
  /// </summary>
  /// <param name="actions">Collection of Facebook action types.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="actions"/> is a <c>null</c> reference.</exception>
  public IFacebookActivityFeedWidget Actions(IEnumerable<string> actions)
  {
    this.actions = actions ?? throw new ArgumentNullException(nameof(actions));
    return this;
  }

  /// <summary>
  ///   <para>Collection of Open Graph action types to show in the feed.</para>
  /// </summary>
  /// <returns>Collection of Facebook action types.</returns>
  public IEnumerable<string> Actions() => this.actions;

  /// <summary>
  ///   <para>Display all actions associated with this app ID. This is usually inferred from the app ID you use to initiate the JavaScript SDK.</para>
  /// </summary>
  /// <param name="appId">Facebook Application ID.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="appId"/> is a <c>null</c> reference.</exception>
  /// <exception cref="ArgumentException">If <paramref name="appId"/> is <see cref="string.Empty"/> string.</exception>
  public IFacebookActivityFeedWidget AppId(string appId)
  {
    if (appId is null) throw new ArgumentNullException(nameof(appId));
    if (appId.IsEmpty()) throw new ArgumentException(nameof(appId));

    this.appId = appId;

    return this;
  }

  /// <summary>
  ///   <para>Display all actions associated with this app ID. This is usually inferred from the app ID you use to initiate the JavaScript SDK.</para>
  /// </summary>
  /// <returns>Facebook Application ID.</returns>
  public string AppId() => appId;

  /// <summary>
  ///   <para>The color scheme used by the widget.</para>
  /// </summary>
  /// <param name="colorScheme">Color scheme of widget.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="colorScheme"/> is a <c>null</c> reference.</exception>
  /// <exception cref="ArgumentException">If <paramref name="colorScheme"/> is <see cref="string.Empty"/> string.</exception>
  public IFacebookActivityFeedWidget ColorScheme(string colorScheme)
  {
    if (colorScheme is null) throw new ArgumentNullException(nameof(colorScheme));
    if (colorScheme.IsEmpty()) throw new ArgumentException(nameof(colorScheme));

    this.colorScheme = colorScheme;
      
    return this;
  }

  /// <summary>
  ///   <para>The color scheme used by the widget.</para>
  /// </summary>
  /// <returns>Color scheme of widget.</returns>
  public string ColorScheme() => colorScheme;

  /// <summary>
  ///   <para>The domain for which to show activity. Default is current domain.</para>
  /// </summary>
  /// <param name="domain">Site domain.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="domain"/> is a <c>null</c> reference.</exception>
  /// <exception cref="ArgumentException">If <paramref name="domain"/> is <see cref="string.Empty"/> string.</exception>
  public IFacebookActivityFeedWidget Domain(string domain)
  {
    if (domain is null) throw new ArgumentNullException(nameof(domain));
    if (domain.IsEmpty()) throw new ArgumentException(nameof(domain));

    this.domain = domain;

    return this;
  }

  /// <summary>
  ///   <para>The domain for which to show activity. Default is current domain.</para>
  /// </summary>
  /// <returns>Site domain.</returns>
  public string Domain() => domain;

  /// <summary>
  ///   <para>Whether to show the "Recent Activity" header above the feed or not. Default is <c>true</c>.</para>
  /// </summary>
  /// <param name="show"><c>true</c> to show header, <c>false</c> to hide.</param>
  /// <returns>Reference to the current widget.</returns>
  public IFacebookActivityFeedWidget Header(bool show)
  {
    header = show;
    return this;
  }

  /// <summary>
  ///   <para>Whether to show the "Recent Activity" header above the feed or not. Default is <c>true</c>.</para>
  /// </summary>
  /// <returns><c>true</c> to show header, <c>false</c> to hide.</returns>
  public bool? Header() => header;

  /// <summary>
  ///   <para>The height of the widget in pixels. Default is 300.</para>
  /// </summary>
  /// <param name="height">Height of widget.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="height"/> is a <c>null</c> reference.</exception>
  /// <exception cref="ArgumentException">If <paramref name="height"/> is <see cref="string.Empty"/> string.</exception>
  public IFacebookActivityFeedWidget Height(string height)
  {
    if (height is null) throw new ArgumentNullException(nameof(height));
    if (height.IsEmpty()) throw new ArgumentException(nameof(height));

    this.height = height;

    return this;
  }

  /// <summary>
  ///   <para>The height of the widget in pixels. Default is 300.</para>
  /// </summary>
  /// <returns>Height of widget.</returns>
  public string Height() => height;

  /// <summary>
  ///   <para>Determines what happens when people click on the links in the feed. Can be any of the standard HTML target values. Default is "_blank".</para>
  /// </summary>
  /// <param name="target">Hyperlinks HTML target attribute.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="target"/> is a <c>null</c> reference.</exception>
  /// <exception cref="ArgumentException">If <paramref name="target"/> is <see cref="string.Empty"/> string.</exception>
  public IFacebookActivityFeedWidget LinkTarget(string target)
  {
    linkTarget = target ?? throw new ArgumentNullException(nameof(target));

    return this;
  }

  /// <summary>
  ///   <para>Determines what happens when people click on the links in the feed. Can be any of the standard HTML target values. Default is "_blank".</para>
  /// </summary>
  /// <returns>Hyperlinks HTML target attribute.</returns>
  public string LinkTarget() => linkTarget;

  /// <summary>
  ///   <para>Limit the created time of articles that are shown in the feed. Valid values are 1-180, which represents the age in days to limit to. Default is 0 (no limit).</para>
  /// </summary>
  /// <param name="maxAge">Days age limit.</param>
  /// <returns>Reference to the current widget.</returns>
  public IFacebookActivityFeedWidget MaxAge(byte maxAge)
  {
    this.maxAge = maxAge;
    return this;
  }

  /// <summary>
  ///   <para>Limit the created time of articles that are shown in the feed. Valid values are 1-180, which represents the age in days to limit to. Default is 0 (no limit).</para>
  /// </summary>
  /// <returns>Days age limit.</returns>
  public byte? MaxAge() => maxAge;

  /// <summary>
  ///   <para>Whether to always show recommendations (Articles liked by a high amount of people) in the bottom half of the feed. Default is <c>false</c>.</para>
  /// </summary>
  /// <param name="show"><c>true</c> to show recommendations, <c>false</c> to hide.</param>
  /// <returns>Reference to the current widget.</returns>
  public IFacebookActivityFeedWidget Recommendations(bool show)
  {
    recommendations = show;
    return this;
  }

  /// <summary>
  ///   <para>Whether to always show recommendations (Articles liked by a high amount of people) in the bottom half of the feed. Default is <c>false</c>.</para>
  /// </summary>
  /// <returns><c>true</c> to show recommendations, <c>false</c> to hide.</returns>
  public bool? Recommendations() => recommendations;

  /// <summary>
  ///   <para>A label for tracking referrals which must be less than 50 characters and can contain alphanumeric characters and some punctuation (currently +/=-.:_).</para>
  /// </summary>
  /// <param name="label">Label for tracking referrals.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="label"/> is a <c>null</c> reference.</exception>
  /// <exception cref="ArgumentException">If <paramref name="label"/> is <see cref="string.Empty"/> string.</exception>
  public IFacebookActivityFeedWidget TrackLabel(string label)
  {
    if (label is null) throw new ArgumentNullException(nameof(label));
    if (label.IsEmpty()) throw new ArgumentException(nameof(label));

    trackLabel = label;

    return this;
  }

  /// <summary>
  ///   <para>A label for tracking referrals which must be less than 50 characters and can contain alphanumeric characters and some punctuation (currently +/=-.:_).</para>
  /// </summary>
  /// <returns>Label for tracking referrals.</returns>
  public string TrackLabel() => trackLabel;

  /// <summary>
  ///   <para>The width of the widget in pixels. Default is 300.</para>
  /// </summary>
  /// <param name="width">Width of widget.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="width"/> is a <c>null</c> reference.</exception>
  /// <exception cref="ArgumentException">If <paramref name="width"/> is <see cref="string.Empty"/> string.</exception>
  public IFacebookActivityFeedWidget Width(string width)
  {
    if (width is null) throw new ArgumentNullException(nameof(width));
    if (width.IsEmpty()) throw new ArgumentException(nameof(width));

    this.width = width;

    return this;
  }

  /// <summary>
  ///   <para>The width of the widget in pixels. Default is 300.</para>
  /// </summary>
  /// <returns>Width of widget.</returns>
  public string Width() => width;

  /// <inheritdoc cref="IHtmlWidget.ToHtmlString()"/>
  public override string ToHtmlString()
  {
    return new TagBuilder("div")
      .Attribute("data-site", Domain())
      .Attribute("data-app-id", AppId())
      .Attribute("data-action", Actions().Any() ? Actions().Join(",") : null)
      .Attribute("data-width", Width())
      .Attribute("data-height", Height())
      .Attribute("data-colorscheme", ColorScheme())
      .Attribute("data-header", Header())
      .Attribute("data-linktarget", LinkTarget())
      .Attribute("data-max-age", MaxAge())
      .Attribute("data-recommendations", Recommendations())
      .Attribute("data-ref", TrackLabel())
      .CssClass("fb-activity")
      .ToString();
  }
}