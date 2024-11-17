using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IFacebookRecommendationsFeedWidget"/>
public class FacebookRecommendationsFeedWidget : WebWidget, IFacebookRecommendationsFeedWidget
{
  private IEnumerable<string> actions = [];
  private string appId;
  private string colorScheme;
  private string domain;
  private bool? header;
  private string height;
  private string linkTarget;
  private byte? maxAge;
  private string trackLabel;
  private string width;

  /// <inheritdoc cref="IFacebookRecommendationsFeedWidget.Actions(IEnumerable{string})"/>
  public IFacebookRecommendationsFeedWidget Actions(IEnumerable<string> actions)
  {
    this.actions = actions ?? throw new ArgumentNullException(nameof(actions));
    return this;
  }

  /// <inheritdoc cref="IFacebookRecommendationsFeedWidget.Actions()"/>
  public IEnumerable<string> Actions() => actions;

  /// <inheritdoc cref="IFacebookRecommendationsFeedWidget.AppId(string)"/>
  public IFacebookRecommendationsFeedWidget AppId(string id)
  {
    if (id is null) throw new ArgumentNullException(nameof(id));
    if (id.IsEmpty()) throw new ArgumentException(nameof(id));

    this.appId = id;
    return this;
  }

  /// <inheritdoc cref="IFacebookRecommendationsFeedWidget.AppId()"/>
  public string AppId() => appId;

  /// <inheritdoc cref="IFacebookRecommendationsFeedWidget.ColorScheme(string)"/>
  public IFacebookRecommendationsFeedWidget ColorScheme(string scheme)
  {
    if (scheme is null) throw new ArgumentNullException(nameof(scheme));
    if (scheme.IsEmpty()) throw new ArgumentException(nameof(scheme));

    this.colorScheme = scheme;
    return this;
  }

  /// <inheritdoc cref="IFacebookRecommendationsFeedWidget.ColorScheme()"/>
  public string ColorScheme() => colorScheme;

  /// <inheritdoc cref="IFacebookRecommendationsFeedWidget.Domain(string)"/>
  public IFacebookRecommendationsFeedWidget Domain(string domain)
  {
    if (domain is null) throw new ArgumentNullException(nameof(domain));
    if (domain.IsEmpty()) throw new ArgumentException(nameof(domain));

    this.domain = domain;
    return this;
  }

  /// <inheritdoc cref="IFacebookRecommendationsFeedWidget.Domain()"/>
  public string Domain() => domain;

  /// <inheritdoc cref="IFacebookRecommendationsFeedWidget.Width(string)"/>
  public IFacebookRecommendationsFeedWidget Width(string width)
  {
    if (width is null) throw new ArgumentNullException(nameof(width));
    if (width.IsEmpty()) throw new ArgumentException(nameof(width));

    this.width = width;
    return this;
  }

  /// <inheritdoc cref="IFacebookRecommendationsFeedWidget.Width()"/>
  public string Width() => width;

  /// <inheritdoc cref="IFacebookRecommendationsFeedWidget.Height(string)"/>
  public IFacebookRecommendationsFeedWidget Height(string height)
  {
    if (height is null) throw new ArgumentNullException(nameof(height));
    if (height.IsEmpty()) throw new ArgumentException(nameof(height));

    this.height = height;
    return this;
  }

  /// <inheritdoc cref="IFacebookRecommendationsFeedWidget.Height()"/>
  public string Height() => height;

  /// <inheritdoc cref="IFacebookRecommendationsFeedWidget.Header(bool)"/>
  public IFacebookRecommendationsFeedWidget Header(bool enabled)
  {
    header = enabled;
    return this;
  }

  /// <inheritdoc cref="IFacebookRecommendationsFeedWidget.Header()"/>
  public bool? Header() => header;

  /// <inheritdoc cref="IFacebookRecommendationsFeedWidget.LinkTarget(string)"/>
  public IFacebookRecommendationsFeedWidget LinkTarget(string target)
  {
    if (target is null) throw new ArgumentNullException(nameof(target));
    if (target.IsEmpty()) throw new ArgumentException(nameof(target));

    linkTarget = target;
    return this;
  }

  /// <inheritdoc cref="IFacebookRecommendationsFeedWidget.LinkTarget()"/>
  public string LinkTarget() => linkTarget;

  /// <inheritdoc cref="IFacebookRecommendationsFeedWidget.MaxAge(byte)"/>
  public IFacebookRecommendationsFeedWidget MaxAge(byte age)
  {
    this.maxAge = age;
    return this;
  }

  /// <inheritdoc cref="IFacebookRecommendationsFeedWidget.MaxAge()"/>
  public byte? MaxAge() => maxAge;

  /// <inheritdoc cref="IFacebookRecommendationsFeedWidget.TrackLabel(string)"/>
  public IFacebookRecommendationsFeedWidget TrackLabel(string label)
  {
    if (label is null) throw new ArgumentNullException(nameof(label));
    if (label.IsEmpty()) throw new ArgumentException(nameof(label));

    trackLabel = label;
    return this;
  }

  /// <inheritdoc cref="IFacebookRecommendationsFeedWidget.TrackLabel()"/>
  public string TrackLabel() => trackLabel;

  /// <inheritdoc cref="IWebWidget.ToHtml()"/>
  public override string ToHtml() => new TagBuilder("div")
      .Attribute("data-site", Domain())
      .Attribute("data-app-id", AppId())
      .Attribute("data-action", Actions().Any() ? Actions().Join(",") : null)
      .Attribute("data-width", Width())
      .Attribute("data-height", Height())
      .Attribute("data-colorscheme", ColorScheme())
      .Attribute("data-header", Header())
      .Attribute("data-linktarget", LinkTarget())
      .Attribute("data-max-age", MaxAge())
      .Attribute("data-ref", TrackLabel())
      .CssClass("fb-recommendations")
      .ToString();
}