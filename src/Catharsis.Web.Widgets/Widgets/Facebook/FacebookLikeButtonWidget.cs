using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IFacebookLikeButtonWidget"/>
public class FacebookLikeButtonWidget : WebWidget, IFacebookLikeButtonWidget
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string ColorSchemeValue { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual bool? FacesValue { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual bool? KidsModeValue { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string LayoutValue { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string TrackLabelValue { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string UrlValue { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string VerbValue { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string WidthValue { get; set; }

  /// <inheritdoc cref="IFacebookLikeButtonWidget.ColorScheme(string)"/>
  public virtual IFacebookLikeButtonWidget ColorScheme(string scheme)
  {
    if (scheme is null) throw new ArgumentNullException(nameof(scheme));
    if (scheme.IsEmpty()) throw new ArgumentException(nameof(scheme));

    ColorSchemeValue = scheme;
    return this;
  }

  /// <inheritdoc cref="IFacebookLikeButtonWidget.Faces(bool)"/>
  public virtual IFacebookLikeButtonWidget Faces(bool enabled)
  {
    FacesValue = enabled;
    return this;
  }

  /// <inheritdoc cref="IFacebookLikeButtonWidget.KidsMode(bool)"/>
  public virtual IFacebookLikeButtonWidget KidsMode(bool enabled)
  {
    KidsModeValue = enabled;
    return this;
  }

  /// <inheritdoc cref="IFacebookLikeButtonWidget.Layout(string)"/>
  public virtual IFacebookLikeButtonWidget Layout(string layout)
  {
    if (layout is null) throw new ArgumentNullException(nameof(layout));
    if (layout.IsEmpty()) throw new ArgumentException(nameof(layout));

    LayoutValue = layout;
    return this;
  }

  /// <inheritdoc cref="IFacebookLikeButtonWidget.TrackLabel(string)"/>
  public virtual IFacebookLikeButtonWidget TrackLabel(string label)
  {
    if (label is null) throw new ArgumentNullException(nameof(label));
    if (label.IsEmpty()) throw new ArgumentException(nameof(label));

    TrackLabelValue = label;
    return this;
  }

  /// <inheritdoc cref="IFacebookLikeButtonWidget.Url(string)"/>
  public virtual IFacebookLikeButtonWidget Url(string url)
  {
    if (url is null) throw new ArgumentNullException(nameof(url));
    if (url.IsEmpty()) throw new ArgumentException(nameof(url));

    UrlValue = url;
    return this;
  }

  /// <inheritdoc cref="IFacebookLikeButtonWidget.Verb(string)"/>
  public virtual IFacebookLikeButtonWidget Verb(string verb)
  {
    if (verb is null) throw new ArgumentNullException(nameof(verb));
    if (verb.IsEmpty()) throw new ArgumentException(nameof(verb));

    VerbValue = verb;
    return this;
  }

  /// <inheritdoc cref="IFacebookLikeButtonWidget.Width(string)"/>
  public virtual IFacebookLikeButtonWidget Width(string width)
  {
    if (width is null) throw new ArgumentNullException(nameof(width));
    if (width.IsEmpty()) throw new ArgumentException(nameof(width));

    WidthValue = width;
    return this;
  }

  /// <inheritdoc cref="ICloneable.Clone()"/>
  public override object Clone() => new FacebookLikeButtonWidget
  {
    ColorSchemeValue = ColorSchemeValue,
    FacesValue = FacesValue,
    KidsModeValue = KidsModeValue,
    LayoutValue = LayoutValue,
    TrackLabelValue = TrackLabelValue,
    UrlValue = UrlValue,
    VerbValue = VerbValue,
    WidthValue = WidthValue
  };

  /// <inheritdoc cref="IWebWidget.ToHtml()"/>
  public override string ToHtml() => new TagBuilder("div")
      .Attribute("data-action", VerbValue)
      .Attribute("data-layout", LayoutValue)
      .Attribute("data-show-faces", FacesValue)
      .Attribute("data-href", UrlValue)
      .Attribute("data-colorscheme", ColorSchemeValue)
      .Attribute("data-kid-directed-site", KidsModeValue)
      .Attribute("data-ref", TrackLabelValue)
      .Attribute("data-width", WidthValue)
      .CssClass("fb-like")
      .ToString();
}