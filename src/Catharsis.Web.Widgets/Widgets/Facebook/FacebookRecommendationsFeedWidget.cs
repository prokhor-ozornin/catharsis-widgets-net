using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IFacebookRecommendationsFeedWidget"/>
public class FacebookRecommendationsFeedWidget : WebWidget, IFacebookRecommendationsFeedWidget
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual IEnumerable<string> ActionsProperty { get; set; } = [];

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string AppIdProperty { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string ColorSchemeProperty { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string DomainProperty { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual bool? HeaderProperty { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string HeightProperty { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string LinkTargetProperty { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual byte? MaxAgeProperty { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string TrackLabelProperty { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string WidthProperty { get; set; }

  /// <inheritdoc cref="IFacebookRecommendationsFeedWidget.Actions(IEnumerable{string})"/>
  public virtual IFacebookRecommendationsFeedWidget Actions(IEnumerable<string> actions)
  {
    ActionsProperty = actions ?? throw new ArgumentNullException(nameof(actions));
    return this;
  }

  /// <inheritdoc cref="IFacebookRecommendationsFeedWidget.AppId(string)"/>
  public virtual IFacebookRecommendationsFeedWidget AppId(string id)
  {
    if (id is null) throw new ArgumentNullException(nameof(id));
    if (id.IsEmpty()) throw new ArgumentException(nameof(id));

    AppIdProperty = id;
    return this;
  }

  /// <inheritdoc cref="IFacebookRecommendationsFeedWidget.ColorScheme(string)"/>
  public virtual IFacebookRecommendationsFeedWidget ColorScheme(string scheme)
  {
    if (scheme is null) throw new ArgumentNullException(nameof(scheme));
    if (scheme.IsEmpty()) throw new ArgumentException(nameof(scheme));

    ColorSchemeProperty = scheme;
    return this;
  }

  /// <inheritdoc cref="IFacebookRecommendationsFeedWidget.Domain(string)"/>
  public virtual IFacebookRecommendationsFeedWidget Domain(string domain)
  {
    if (domain is null) throw new ArgumentNullException(nameof(domain));
    if (domain.IsEmpty()) throw new ArgumentException(nameof(domain));

    DomainProperty = domain;
    return this;
  }

  /// <inheritdoc cref="IFacebookRecommendationsFeedWidget.Width(string)"/>
  public virtual IFacebookRecommendationsFeedWidget Width(string width)
  {
    if (width is null) throw new ArgumentNullException(nameof(width));
    if (width.IsEmpty()) throw new ArgumentException(nameof(width));

    WidthProperty = width;
    return this;
  }

  /// <inheritdoc cref="IFacebookRecommendationsFeedWidget.Height(string)"/>
  public virtual IFacebookRecommendationsFeedWidget Height(string height)
  {
    if (height is null) throw new ArgumentNullException(nameof(height));
    if (height.IsEmpty()) throw new ArgumentException(nameof(height));

    HeightProperty = height;
    return this;
  }

  /// <inheritdoc cref="IFacebookRecommendationsFeedWidget.Header(bool)"/>
  public virtual IFacebookRecommendationsFeedWidget Header(bool enabled)
  {
    HeaderProperty = enabled;
    return this;
  }

  /// <inheritdoc cref="IFacebookRecommendationsFeedWidget.LinkTarget(string)"/>
  public virtual IFacebookRecommendationsFeedWidget LinkTarget(string target)
  {
    if (target is null) throw new ArgumentNullException(nameof(target));
    if (target.IsEmpty()) throw new ArgumentException(nameof(target));

    LinkTargetProperty = target;
    return this;
  }

  /// <inheritdoc cref="IFacebookRecommendationsFeedWidget.MaxAge(byte)"/>
  public virtual IFacebookRecommendationsFeedWidget MaxAge(byte age)
  {
    MaxAgeProperty = age;
    return this;
  }

  /// <inheritdoc cref="IFacebookRecommendationsFeedWidget.TrackLabel(string)"/>
  public virtual IFacebookRecommendationsFeedWidget TrackLabel(string label)
  {
    if (label is null) throw new ArgumentNullException(nameof(label));
    if (label.IsEmpty()) throw new ArgumentException(nameof(label));

    TrackLabelProperty = label;
    return this;
  }

  /// <inheritdoc cref="ICloneable.Clone()"/>
  public override object Clone() => new FacebookRecommendationsFeedWidget
  {
    ActionsProperty = ActionsProperty?.ToArray(),
    AppIdProperty = AppIdProperty,
    ColorSchemeProperty = ColorSchemeProperty,
    DomainProperty = DomainProperty,
    HeaderProperty = HeaderProperty,
    HeightProperty = HeightProperty,
    LinkTargetProperty = LinkTargetProperty,
    MaxAgeProperty = MaxAgeProperty,
    TrackLabelProperty = TrackLabelProperty,
    WidthProperty = WidthProperty
  };

  /// <inheritdoc cref="IWebWidget.ToHtml()"/>
  public override string ToHtml() => new TagBuilder("div")
      .Attribute("data-site", DomainProperty)
      .Attribute("data-app-id", AppIdProperty)
      .Attribute("data-action", ActionsProperty.Any() ? ActionsProperty.Join(",") : null)
      .Attribute("data-width", WidthProperty)
      .Attribute("data-height", HeightProperty)
      .Attribute("data-colorscheme", ColorSchemeProperty)
      .Attribute("data-header", HeaderProperty)
      .Attribute("data-linktarget", LinkTargetProperty)
      .Attribute("data-max-age", MaxAgeProperty)
      .Attribute("data-ref", TrackLabelProperty)
      .CssClass("fb-recommendations")
      .ToString();
}