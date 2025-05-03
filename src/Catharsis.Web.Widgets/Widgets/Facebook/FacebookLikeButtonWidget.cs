using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IFacebookLikeButtonWidget"/>
public class FacebookLikeButtonWidget : WebWidget, IFacebookLikeButtonWidget
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string ColorSchemeProperty { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual bool? FacesProperty { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual bool? KidsModeProperty { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string LayoutProperty { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string TrackLabelProperty { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string UrlProperty { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string VerbProperty { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string WidthProperty { get; set; }

  /// <inheritdoc cref="IFacebookLikeButtonWidget.ColorScheme(string)"/>
  public virtual IFacebookLikeButtonWidget ColorScheme(string scheme)
  {
    if (scheme is null) throw new ArgumentNullException(nameof(scheme));
    if (scheme.IsEmpty()) throw new ArgumentException(nameof(scheme));

    ColorSchemeProperty = scheme;
    return this;
  }

  /// <inheritdoc cref="IFacebookLikeButtonWidget.Faces(bool)"/>
  public virtual IFacebookLikeButtonWidget Faces(bool enabled)
  {
    FacesProperty = enabled;
    return this;
  }

  /// <inheritdoc cref="IFacebookLikeButtonWidget.KidsMode(bool)"/>
  public virtual IFacebookLikeButtonWidget KidsMode(bool enabled)
  {
    KidsModeProperty = enabled;
    return this;
  }

  /// <inheritdoc cref="IFacebookLikeButtonWidget.Layout(string)"/>
  public virtual IFacebookLikeButtonWidget Layout(string layout)
  {
    if (layout is null) throw new ArgumentNullException(nameof(layout));
    if (layout.IsEmpty()) throw new ArgumentException(nameof(layout));

    LayoutProperty = layout;
    return this;
  }

  /// <inheritdoc cref="IFacebookLikeButtonWidget.TrackLabel(string)"/>
  public virtual IFacebookLikeButtonWidget TrackLabel(string label)
  {
    if (label is null) throw new ArgumentNullException(nameof(label));
    if (label.IsEmpty()) throw new ArgumentException(nameof(label));

    TrackLabelProperty = label;
    return this;
  }

  /// <inheritdoc cref="IFacebookLikeButtonWidget.Url(string)"/>
  public virtual IFacebookLikeButtonWidget Url(string url)
  {
    if (url is null) throw new ArgumentNullException(nameof(url));
    if (url.IsEmpty()) throw new ArgumentException(nameof(url));

    UrlProperty = url;
    return this;
  }

  /// <inheritdoc cref="IFacebookLikeButtonWidget.Verb(string)"/>
  public virtual IFacebookLikeButtonWidget Verb(string verb)
  {
    if (verb is null) throw new ArgumentNullException(nameof(verb));
    if (verb.IsEmpty()) throw new ArgumentException(nameof(verb));

    VerbProperty = verb;
    return this;
  }

  /// <inheritdoc cref="IFacebookLikeButtonWidget.Width(string)"/>
  public virtual IFacebookLikeButtonWidget Width(string width)
  {
    if (width is null) throw new ArgumentNullException(nameof(width));
    if (width.IsEmpty()) throw new ArgumentException(nameof(width));

    WidthProperty = width;
    return this;
  }

  /// <inheritdoc cref="ICloneable.Clone()"/>
  public override object Clone() => new FacebookLikeButtonWidget
  {
    ColorSchemeProperty = ColorSchemeProperty,
    FacesProperty = FacesProperty,
    KidsModeProperty = KidsModeProperty,
    LayoutProperty = LayoutProperty,
    TrackLabelProperty = TrackLabelProperty,
    UrlProperty = UrlProperty,
    VerbProperty = VerbProperty,
    WidthProperty = WidthProperty
  };

  /// <inheritdoc cref="IWebWidget.ToHtml()"/>
  public override string ToHtml() => new TagBuilder("div")
      .Attribute("data-action", VerbProperty)
      .Attribute("data-layout", LayoutProperty)
      .Attribute("data-show-faces", FacesProperty)
      .Attribute("data-href", UrlProperty)
      .Attribute("data-colorscheme", ColorSchemeProperty)
      .Attribute("data-kid-directed-site", KidsModeProperty)
      .Attribute("data-ref", TrackLabelProperty)
      .Attribute("data-width", WidthProperty)
      .CssClass("fb-like")
      .ToString();
}