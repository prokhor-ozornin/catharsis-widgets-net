using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IFacebookActivityFeedWidget"/>
public class FacebookActivityFeedWidget : WebWidget, IFacebookActivityFeedWidget
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

  /// <inheritdoc cref="IFacebookActivityFeedWidget.Actions(IEnumerable{string})"/>
  public IFacebookActivityFeedWidget Actions(IEnumerable<string> actions)
  {
    this.actions = actions ?? throw new ArgumentNullException(nameof(actions));
    return this;
  }

  /// <inheritdoc cref="IFacebookActivityFeedWidget.Actions()"/>
  public IEnumerable<string> Actions() => actions;

  /// <inheritdoc cref="IFacebookActivityFeedWidget.AppId(string)"/>
  public IFacebookActivityFeedWidget AppId(string id)
  {
    if (id is null) throw new ArgumentNullException(nameof(id));
    if (id.IsEmpty()) throw new ArgumentException(nameof(id));

    this.appId = id;

    return this;
  }

  /// <inheritdoc cref="IFacebookActivityFeedWidget.AppId()"/>
  public string AppId() => appId;

  /// <inheritdoc cref="IFacebookActivityFeedWidget.ColorScheme(string)"/>
  public IFacebookActivityFeedWidget ColorScheme(string scheme)
  {
    if (scheme is null) throw new ArgumentNullException(nameof(scheme));
    if (scheme.IsEmpty()) throw new ArgumentException(nameof(scheme));

    this.colorScheme = scheme;

    return this;
  }

  /// <inheritdoc cref="IFacebookActivityFeedWidget.ColorScheme()"/>
  public string ColorScheme() => colorScheme;

  /// <inheritdoc cref="IFacebookActivityFeedWidget.Domain(string)"/>
  public IFacebookActivityFeedWidget Domain(string domain)
  {
    if (domain is null) throw new ArgumentNullException(nameof(domain));
    if (domain.IsEmpty()) throw new ArgumentException(nameof(domain));

    this.domain = domain;

    return this;
  }

  /// <inheritdoc cref="IFacebookActivityFeedWidget.Domain()"/>
  public string Domain() => domain;

  /// <inheritdoc cref="IFacebookActivityFeedWidget.Header(bool)"/>
  public IFacebookActivityFeedWidget Header(bool enabled)
  {
    header = enabled;
    return this;
  }

  /// <inheritdoc cref="IFacebookActivityFeedWidget.Header()"/>
  public bool? Header() => header;

  /// <inheritdoc cref="IFacebookActivityFeedWidget.Height(string)"/>
  public IFacebookActivityFeedWidget Height(string height)
  {
    if (height is null) throw new ArgumentNullException(nameof(height));
    if (height.IsEmpty()) throw new ArgumentException(nameof(height));

    this.height = height;

    return this;
  }

  /// <inheritdoc cref="IFacebookActivityFeedWidget.Height()"/>
  public string Height() => height;

  /// <inheritdoc cref="IFacebookActivityFeedWidget.LinkTarget(string)"/>
  public IFacebookActivityFeedWidget LinkTarget(string target)
  {
    linkTarget = target ?? throw new ArgumentNullException(nameof(target));

    return this;
  }

  /// <inheritdoc cref="IFacebookActivityFeedWidget.LinkTarget()"/>
  public string LinkTarget() => linkTarget;

  /// <inheritdoc cref="IFacebookActivityFeedWidget.MaxAge(byte)"/>
  public IFacebookActivityFeedWidget MaxAge(byte age)
  {
    this.maxAge = age;
    return this;
  }

  /// <inheritdoc cref="IFacebookActivityFeedWidget.MaxAge()"/>
  public byte? MaxAge() => maxAge;

  /// <inheritdoc cref="IFacebookActivityFeedWidget.Recommendations(bool)"/>
  public IFacebookActivityFeedWidget Recommendations(bool enabled)
  {
    recommendations = enabled;
    return this;
  }

  /// <inheritdoc cref="IFacebookActivityFeedWidget.Recommendations()"/>
  public bool? Recommendations() => recommendations;

  /// <inheritdoc cref="IFacebookActivityFeedWidget.TrackLabel(string)"/>
  public IFacebookActivityFeedWidget TrackLabel(string label)
  {
    if (label is null) throw new ArgumentNullException(nameof(label));
    if (label.IsEmpty()) throw new ArgumentException(nameof(label));

    trackLabel = label;

    return this;
  }

  /// <inheritdoc cref="IFacebookActivityFeedWidget.TrackLabel()"/>
  public string TrackLabel() => trackLabel;

  /// <inheritdoc cref="IFacebookActivityFeedWidget.Width(string)"/>
  public IFacebookActivityFeedWidget Width(string width)
  {
    if (width is null) throw new ArgumentNullException(nameof(width));
    if (width.IsEmpty()) throw new ArgumentException(nameof(width));

    this.width = width;

    return this;
  }

  /// <inheritdoc cref="IFacebookActivityFeedWidget.Width()"/>
  public string Width() => width;

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
      .Attribute("data-recommendations", Recommendations())
      .Attribute("data-ref", TrackLabel())
      .CssClass("fb-activity")
      .ToString();
}