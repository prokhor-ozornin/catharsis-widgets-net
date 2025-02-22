using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IFacebookActivityFeedWidget"/>
public class FacebookActivityFeedWidget : WebWidget, IFacebookActivityFeedWidget
{
  private IEnumerable<string> ActionsProperty { get; set; } = [];
  private string AppIdProperty { get; set; }
  private string ColorSchemeProperty { get; set; }
  private string DomainProperty { get; set; }
  private bool? HeaderProperty { get; set; }
  private string HeightProperty { get; set; }
  private string LinkTargetProperty { get; set; }
  private byte? MaxAgeProperty { get; set; }
  private bool? RecommendationsProperty { get; set; }
  private string TrackLabelProperty { get; set; }
  private string WidthProperty { get; set; }

  /// <inheritdoc cref="IFacebookActivityFeedWidget.Actions(IEnumerable{string})"/>
  public IFacebookActivityFeedWidget Actions(IEnumerable<string> actions)
  {
    ActionsProperty = actions ?? throw new ArgumentNullException(nameof(actions));
    return this;
  }

  /// <inheritdoc cref="IFacebookActivityFeedWidget.Actions()"/>
  public IEnumerable<string> Actions() => ActionsProperty;

  /// <inheritdoc cref="IFacebookActivityFeedWidget.AppId(string)"/>
  public IFacebookActivityFeedWidget AppId(string id)
  {
    if (id is null) throw new ArgumentNullException(nameof(id));
    if (id.IsEmpty()) throw new ArgumentException(nameof(id));

    AppIdProperty = id;

    return this;
  }

  /// <inheritdoc cref="IFacebookActivityFeedWidget.AppId()"/>
  public string AppId() => AppIdProperty;

  /// <inheritdoc cref="IFacebookActivityFeedWidget.ColorScheme(string)"/>
  public IFacebookActivityFeedWidget ColorScheme(string scheme)
  {
    if (scheme is null) throw new ArgumentNullException(nameof(scheme));
    if (scheme.IsEmpty()) throw new ArgumentException(nameof(scheme));

    ColorSchemeProperty = scheme;

    return this;
  }

  /// <inheritdoc cref="IFacebookActivityFeedWidget.ColorScheme()"/>
  public string ColorScheme() => ColorSchemeProperty;

  /// <inheritdoc cref="IFacebookActivityFeedWidget.Domain(string)"/>
  public IFacebookActivityFeedWidget Domain(string domain)
  {
    if (domain is null) throw new ArgumentNullException(nameof(domain));
    if (domain.IsEmpty()) throw new ArgumentException(nameof(domain));

    DomainProperty = domain;

    return this;
  }

  /// <inheritdoc cref="IFacebookActivityFeedWidget.Domain()"/>
  public string Domain() => DomainProperty;

  /// <inheritdoc cref="IFacebookActivityFeedWidget.Header(bool)"/>
  public IFacebookActivityFeedWidget Header(bool enabled)
  {
    HeaderProperty = enabled;
    return this;
  }

  /// <inheritdoc cref="IFacebookActivityFeedWidget.Header()"/>
  public bool? Header() => HeaderProperty;

  /// <inheritdoc cref="IFacebookActivityFeedWidget.Height(string)"/>
  public IFacebookActivityFeedWidget Height(string height)
  {
    if (height is null) throw new ArgumentNullException(nameof(height));
    if (height.IsEmpty()) throw new ArgumentException(nameof(height));

    HeightProperty = height;

    return this;
  }

  /// <inheritdoc cref="IFacebookActivityFeedWidget.Height()"/>
  public string Height() => HeightProperty;

  /// <inheritdoc cref="IFacebookActivityFeedWidget.LinkTarget(string)"/>
  public IFacebookActivityFeedWidget LinkTarget(string target)
  {
    LinkTargetProperty = target ?? throw new ArgumentNullException(nameof(target));

    return this;
  }

  /// <inheritdoc cref="IFacebookActivityFeedWidget.LinkTarget()"/>
  public string LinkTarget() => LinkTargetProperty;

  /// <inheritdoc cref="IFacebookActivityFeedWidget.MaxAge(byte)"/>
  public IFacebookActivityFeedWidget MaxAge(byte age)
  {
    MaxAgeProperty = age;
    return this;
  }

  /// <inheritdoc cref="IFacebookActivityFeedWidget.MaxAge()"/>
  public byte? MaxAge() => MaxAgeProperty;

  /// <inheritdoc cref="IFacebookActivityFeedWidget.Recommendations(bool)"/>
  public IFacebookActivityFeedWidget Recommendations(bool enabled)
  {
    RecommendationsProperty = enabled;
    return this;
  }

  /// <inheritdoc cref="IFacebookActivityFeedWidget.Recommendations()"/>
  public bool? Recommendations() => RecommendationsProperty;

  /// <inheritdoc cref="IFacebookActivityFeedWidget.TrackLabel(string)"/>
  public IFacebookActivityFeedWidget TrackLabel(string label)
  {
    if (label is null) throw new ArgumentNullException(nameof(label));
    if (label.IsEmpty()) throw new ArgumentException(nameof(label));

    TrackLabelProperty = label;

    return this;
  }

  /// <inheritdoc cref="IFacebookActivityFeedWidget.TrackLabel()"/>
  public string TrackLabel() => TrackLabelProperty;

  /// <inheritdoc cref="IFacebookActivityFeedWidget.Width(string)"/>
  public IFacebookActivityFeedWidget Width(string width)
  {
    if (width is null) throw new ArgumentNullException(nameof(width));
    if (width.IsEmpty()) throw new ArgumentException(nameof(width));

    WidthProperty = width;

    return this;
  }

  /// <inheritdoc cref="IFacebookActivityFeedWidget.Width()"/>
  public string Width() => WidthProperty;

  /// <inheritdoc cref="IHtmlContent.ToHtml()"/>
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