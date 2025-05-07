using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IFacebookRecommendationsFeedWidget"/>
public class FacebookRecommendationsFeedWidget : WebWidget, IFacebookRecommendationsFeedWidget
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual IEnumerable<string> ActionsValue { get; set; } = [];

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string AppIdValue { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string ColorSchemeValue { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string DomainValue { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual bool? HeaderValue { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string HeightValue { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string LinkTargetValue { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual byte? MaxAgeValue { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string TrackLabelValue { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string WidthValue { get; set; }

  /// <inheritdoc cref="IFacebookRecommendationsFeedWidget.Actions(IEnumerable{string})"/>
  public virtual IFacebookRecommendationsFeedWidget Actions(IEnumerable<string> actions)
  {
    ActionsValue = actions ?? throw new ArgumentNullException(nameof(actions));
    return this;
  }

  /// <inheritdoc cref="IFacebookRecommendationsFeedWidget.AppId(string)"/>
  public virtual IFacebookRecommendationsFeedWidget AppId(string id)
  {
    if (id is null) throw new ArgumentNullException(nameof(id));
    if (id.IsEmpty()) throw new ArgumentException(nameof(id));

    AppIdValue = id;
    return this;
  }

  /// <inheritdoc cref="IFacebookRecommendationsFeedWidget.ColorScheme(string)"/>
  public virtual IFacebookRecommendationsFeedWidget ColorScheme(string scheme)
  {
    if (scheme is null) throw new ArgumentNullException(nameof(scheme));
    if (scheme.IsEmpty()) throw new ArgumentException(nameof(scheme));

    ColorSchemeValue = scheme;
    return this;
  }

  /// <inheritdoc cref="IFacebookRecommendationsFeedWidget.Domain(string)"/>
  public virtual IFacebookRecommendationsFeedWidget Domain(string domain)
  {
    if (domain is null) throw new ArgumentNullException(nameof(domain));
    if (domain.IsEmpty()) throw new ArgumentException(nameof(domain));

    DomainValue = domain;
    return this;
  }

  /// <inheritdoc cref="IFacebookRecommendationsFeedWidget.Width(string)"/>
  public virtual IFacebookRecommendationsFeedWidget Width(string width)
  {
    if (width is null) throw new ArgumentNullException(nameof(width));
    if (width.IsEmpty()) throw new ArgumentException(nameof(width));

    WidthValue = width;
    return this;
  }

  /// <inheritdoc cref="IFacebookRecommendationsFeedWidget.Height(string)"/>
  public virtual IFacebookRecommendationsFeedWidget Height(string height)
  {
    if (height is null) throw new ArgumentNullException(nameof(height));
    if (height.IsEmpty()) throw new ArgumentException(nameof(height));

    HeightValue = height;
    return this;
  }

  /// <inheritdoc cref="IFacebookRecommendationsFeedWidget.Header(bool)"/>
  public virtual IFacebookRecommendationsFeedWidget Header(bool enabled)
  {
    HeaderValue = enabled;
    return this;
  }

  /// <inheritdoc cref="IFacebookRecommendationsFeedWidget.LinkTarget(string)"/>
  public virtual IFacebookRecommendationsFeedWidget LinkTarget(string target)
  {
    if (target is null) throw new ArgumentNullException(nameof(target));
    if (target.IsEmpty()) throw new ArgumentException(nameof(target));

    LinkTargetValue = target;
    return this;
  }

  /// <inheritdoc cref="IFacebookRecommendationsFeedWidget.MaxAge(byte)"/>
  public virtual IFacebookRecommendationsFeedWidget MaxAge(byte age)
  {
    MaxAgeValue = age;
    return this;
  }

  /// <inheritdoc cref="IFacebookRecommendationsFeedWidget.TrackLabel(string)"/>
  public virtual IFacebookRecommendationsFeedWidget TrackLabel(string label)
  {
    if (label is null) throw new ArgumentNullException(nameof(label));
    if (label.IsEmpty()) throw new ArgumentException(nameof(label));

    TrackLabelValue = label;
    return this;
  }

  /// <inheritdoc cref="ICloneable.Clone()"/>
  public override object Clone() => new FacebookRecommendationsFeedWidget
  {
    ActionsValue = ActionsValue?.ToArray(),
    AppIdValue = AppIdValue,
    ColorSchemeValue = ColorSchemeValue,
    DomainValue = DomainValue,
    HeaderValue = HeaderValue,
    HeightValue = HeightValue,
    LinkTargetValue = LinkTargetValue,
    MaxAgeValue = MaxAgeValue,
    TrackLabelValue = TrackLabelValue,
    WidthValue = WidthValue
  };

  /// <inheritdoc cref="IWebWidget.ToHtml()"/>
  public override string ToHtml() => new TagBuilder("div")
      .Attribute("data-site", DomainValue)
      .Attribute("data-app-id", AppIdValue)
      .Attribute("data-action", ActionsValue.Any() ? ActionsValue.Join(",") : null)
      .Attribute("data-width", WidthValue)
      .Attribute("data-height", HeightValue)
      .Attribute("data-colorscheme", ColorSchemeValue)
      .Attribute("data-header", HeaderValue)
      .Attribute("data-linktarget", LinkTargetValue)
      .Attribute("data-max-age", MaxAgeValue)
      .Attribute("data-ref", TrackLabelValue)
      .CssClass("fb-recommendations")
      .ToString();
}