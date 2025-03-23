using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IFacebookActivityFeedWidget"/>
public class FacebookActivityFeedWidget : WebWidget, IFacebookActivityFeedWidget
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
  protected virtual bool? RecommendationsProperty { get; set; }
  
  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string TrackLabelProperty { get; set; }
  
  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string WidthProperty { get; set; }

  /// <inheritdoc cref="IFacebookActivityFeedWidget.Actions(IEnumerable{string})"/>
  public virtual IFacebookActivityFeedWidget Actions(IEnumerable<string> actions)
  {
    ActionsProperty = actions ?? throw new ArgumentNullException(nameof(actions));
    return this;
  }

  /// <inheritdoc cref="IFacebookActivityFeedWidget.AppId(string)"/>
  public virtual IFacebookActivityFeedWidget AppId(string id)
  {
    if (id is null) throw new ArgumentNullException(nameof(id));
    if (id.IsEmpty()) throw new ArgumentException(nameof(id));

    AppIdProperty = id;

    return this;
  }

  /// <inheritdoc cref="IFacebookActivityFeedWidget.ColorScheme(string)"/>
  public virtual IFacebookActivityFeedWidget ColorScheme(string scheme)
  {
    if (scheme is null) throw new ArgumentNullException(nameof(scheme));
    if (scheme.IsEmpty()) throw new ArgumentException(nameof(scheme));

    ColorSchemeProperty = scheme;

    return this;
  }

  /// <inheritdoc cref="IFacebookActivityFeedWidget.Domain(string)"/>
  public virtual IFacebookActivityFeedWidget Domain(string domain)
  {
    if (domain is null) throw new ArgumentNullException(nameof(domain));
    if (domain.IsEmpty()) throw new ArgumentException(nameof(domain));

    DomainProperty = domain;

    return this;
  }

  /// <inheritdoc cref="IFacebookActivityFeedWidget.Header(bool)"/>
  public virtual IFacebookActivityFeedWidget Header(bool enabled)
  {
    HeaderProperty = enabled;
    return this;
  }

  /// <inheritdoc cref="IFacebookActivityFeedWidget.Height(string)"/>
  public virtual IFacebookActivityFeedWidget Height(string height)
  {
    if (height is null) throw new ArgumentNullException(nameof(height));
    if (height.IsEmpty()) throw new ArgumentException(nameof(height));

    HeightProperty = height;

    return this;
  }

  /// <inheritdoc cref="IFacebookActivityFeedWidget.LinkTarget(string)"/>
  public virtual IFacebookActivityFeedWidget LinkTarget(string target)
  {
    LinkTargetProperty = target ?? throw new ArgumentNullException(nameof(target));

    return this;
  }

  /// <inheritdoc cref="IFacebookActivityFeedWidget.MaxAge(byte)"/>
  public virtual IFacebookActivityFeedWidget MaxAge(byte age)
  {
    MaxAgeProperty = age;
    return this;
  }

  /// <inheritdoc cref="IFacebookActivityFeedWidget.Recommendations(bool)"/>
  public virtual IFacebookActivityFeedWidget Recommendations(bool enabled)
  {
    RecommendationsProperty = enabled;
    return this;
  }

  /// <inheritdoc cref="IFacebookActivityFeedWidget.TrackLabel(string)"/>
  public virtual IFacebookActivityFeedWidget TrackLabel(string label)
  {
    if (label is null) throw new ArgumentNullException(nameof(label));
    if (label.IsEmpty()) throw new ArgumentException(nameof(label));

    TrackLabelProperty = label;

    return this;
  }

  /// <inheritdoc cref="IFacebookActivityFeedWidget.Width(string)"/>
  public virtual IFacebookActivityFeedWidget Width(string width)
  {
    if (width is null) throw new ArgumentNullException(nameof(width));
    if (width.IsEmpty()) throw new ArgumentException(nameof(width));

    WidthProperty = width;

    return this;
  }

  /// <inheritdoc cref="IHtmlContent.ToHtml()"/>
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
      .Attribute("data-recommendations", RecommendationsProperty)
      .Attribute("data-ref", TrackLabelProperty)
      .CssClass("fb-activity")
      .ToString();
}