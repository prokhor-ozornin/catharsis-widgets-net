using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IFacebookRecommendationsFeedWidget"/>
public class FacebookRecommendationsFeedWidget : WebWidget, IFacebookRecommendationsFeedWidget
{
  private IEnumerable<string> ActionsProperty { get; set; } = [];
  private string AppIdProperty { get; set; }
  private string ColorSchemeProperty { get; set; }
  private string DomainProperty { get; set; }
  private bool? HeaderProperty { get; set; }
  private string HeightProperty { get; set; }
  private string LinkTargetProperty { get; set; }
  private byte? MaxAgeProperty { get; set; }
  private string TrackLabelProperty { get; set; }
  private string WidthProperty { get; set; }

  /// <inheritdoc cref="IFacebookRecommendationsFeedWidget.Actions(IEnumerable{string})"/>
  public IFacebookRecommendationsFeedWidget Actions(IEnumerable<string> actions)
  {
    ActionsProperty = actions ?? throw new ArgumentNullException(nameof(actions));
    return this;
  }

  /// <inheritdoc cref="IFacebookRecommendationsFeedWidget.Actions()"/>
  public IEnumerable<string> Actions() => ActionsProperty;

  /// <inheritdoc cref="IFacebookRecommendationsFeedWidget.AppId(string)"/>
  public IFacebookRecommendationsFeedWidget AppId(string id)
  {
    if (id is null) throw new ArgumentNullException(nameof(id));
    if (id.IsEmpty()) throw new ArgumentException(nameof(id));

    AppIdProperty = id;
    return this;
  }

  /// <inheritdoc cref="IFacebookRecommendationsFeedWidget.AppId()"/>
  public string AppId() => AppIdProperty;

  /// <inheritdoc cref="IFacebookRecommendationsFeedWidget.ColorScheme(string)"/>
  public IFacebookRecommendationsFeedWidget ColorScheme(string scheme)
  {
    if (scheme is null) throw new ArgumentNullException(nameof(scheme));
    if (scheme.IsEmpty()) throw new ArgumentException(nameof(scheme));

    ColorSchemeProperty = scheme;
    return this;
  }

  /// <inheritdoc cref="IFacebookRecommendationsFeedWidget.ColorScheme()"/>
  public string ColorScheme() => ColorSchemeProperty;

  /// <inheritdoc cref="IFacebookRecommendationsFeedWidget.Domain(string)"/>
  public IFacebookRecommendationsFeedWidget Domain(string domain)
  {
    if (domain is null) throw new ArgumentNullException(nameof(domain));
    if (domain.IsEmpty()) throw new ArgumentException(nameof(domain));

    DomainProperty = domain;
    return this;
  }

  /// <inheritdoc cref="IFacebookRecommendationsFeedWidget.Domain()"/>
  public string Domain() => DomainProperty;

  /// <inheritdoc cref="IFacebookRecommendationsFeedWidget.Width(string)"/>
  public IFacebookRecommendationsFeedWidget Width(string width)
  {
    if (width is null) throw new ArgumentNullException(nameof(width));
    if (width.IsEmpty()) throw new ArgumentException(nameof(width));

    WidthProperty = width;
    return this;
  }

  /// <inheritdoc cref="IFacebookRecommendationsFeedWidget.Width()"/>
  public string Width() => WidthProperty;

  /// <inheritdoc cref="IFacebookRecommendationsFeedWidget.Height(string)"/>
  public IFacebookRecommendationsFeedWidget Height(string height)
  {
    if (height is null) throw new ArgumentNullException(nameof(height));
    if (height.IsEmpty()) throw new ArgumentException(nameof(height));

    HeightProperty = height;
    return this;
  }

  /// <inheritdoc cref="IFacebookRecommendationsFeedWidget.Height()"/>
  public string Height() => HeightProperty;

  /// <inheritdoc cref="IFacebookRecommendationsFeedWidget.Header(bool)"/>
  public IFacebookRecommendationsFeedWidget Header(bool enabled)
  {
    HeaderProperty = enabled;
    return this;
  }

  /// <inheritdoc cref="IFacebookRecommendationsFeedWidget.Header()"/>
  public bool? Header() => HeaderProperty;

  /// <inheritdoc cref="IFacebookRecommendationsFeedWidget.LinkTarget(string)"/>
  public IFacebookRecommendationsFeedWidget LinkTarget(string target)
  {
    if (target is null) throw new ArgumentNullException(nameof(target));
    if (target.IsEmpty()) throw new ArgumentException(nameof(target));

    LinkTargetProperty = target;
    return this;
  }

  /// <inheritdoc cref="IFacebookRecommendationsFeedWidget.LinkTarget()"/>
  public string LinkTarget() => LinkTargetProperty;

  /// <inheritdoc cref="IFacebookRecommendationsFeedWidget.MaxAge(byte)"/>
  public IFacebookRecommendationsFeedWidget MaxAge(byte age)
  {
    MaxAgeProperty = age;
    return this;
  }

  /// <inheritdoc cref="IFacebookRecommendationsFeedWidget.MaxAge()"/>
  public byte? MaxAge() => MaxAgeProperty;

  /// <inheritdoc cref="IFacebookRecommendationsFeedWidget.TrackLabel(string)"/>
  public IFacebookRecommendationsFeedWidget TrackLabel(string label)
  {
    if (label is null) throw new ArgumentNullException(nameof(label));
    if (label.IsEmpty()) throw new ArgumentException(nameof(label));

    TrackLabelProperty = label;
    return this;
  }

  /// <inheritdoc cref="IFacebookRecommendationsFeedWidget.TrackLabel()"/>
  public string TrackLabel() => TrackLabelProperty;

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
      .Attribute("data-ref", TrackLabel())
      .CssClass("fb-recommendations")
      .ToString();
}