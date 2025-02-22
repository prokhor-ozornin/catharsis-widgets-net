using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IFacebookLikeButtonWidget"/>
public class FacebookLikeButtonWidget : WebWidget, IFacebookLikeButtonWidget
{
  private string ColorSchemeProperty { get; set; }
  private bool? FacesProperty { get; set; }
  private bool? KidsModeProperty { get; set; }
  private string LayoutProperty { get; set; }
  private string TrackLabelProperty { get; set; }
  private string UrlProperty { get; set; }
  private string VerbProperty { get; set; }
  private string WidthProperty { get; set; }

  /// <inheritdoc cref="IFacebookLikeButtonWidget.ColorScheme(string)"/>
  public IFacebookLikeButtonWidget ColorScheme(string scheme)
  {
    if (scheme is null) throw new ArgumentNullException(nameof(scheme));
    if (scheme.IsEmpty()) throw new ArgumentException(nameof(scheme));

    ColorSchemeProperty = scheme;
    return this;
  }

  /// <inheritdoc cref="IFacebookLikeButtonWidget.ColorScheme()"/>
  public string ColorScheme() => ColorSchemeProperty;

  /// <inheritdoc cref="IFacebookLikeButtonWidget.Faces(bool)"/>
  public IFacebookLikeButtonWidget Faces(bool enabled)
  {
    FacesProperty = enabled;
    return this;
  }

  /// <inheritdoc cref="IFacebookLikeButtonWidget.Faces()"/>
  public bool? Faces() => FacesProperty;

  /// <inheritdoc cref="IFacebookLikeButtonWidget.KidsMode(bool)"/>
  public IFacebookLikeButtonWidget KidsMode(bool enabled)
  {
    KidsModeProperty = enabled;
    return this;
  }

  /// <inheritdoc cref="IFacebookLikeButtonWidget.KidsMode()"/>
  public bool? KidsMode() => KidsModeProperty;

  /// <inheritdoc cref="IFacebookLikeButtonWidget.Layout(string)"/>
  public IFacebookLikeButtonWidget Layout(string layout)
  {
    if (layout is null) throw new ArgumentNullException(nameof(layout));
    if (layout.IsEmpty()) throw new ArgumentException(nameof(layout));

    LayoutProperty = layout;
    return this;
  }

  /// <inheritdoc cref="IFacebookLikeButtonWidget.Layout()"/>
  public string Layout() => LayoutProperty;

  /// <inheritdoc cref="IFacebookLikeButtonWidget.TrackLabel(string)"/>
  public IFacebookLikeButtonWidget TrackLabel(string label)
  {
    if (label is null) throw new ArgumentNullException(nameof(label));
    if (label.IsEmpty()) throw new ArgumentException(nameof(label));

    TrackLabelProperty = label;
    return this;
  }

  /// <inheritdoc cref="IFacebookLikeButtonWidget.TrackLabel()"/>
  public string TrackLabel() => TrackLabelProperty;

  /// <inheritdoc cref="IFacebookLikeButtonWidget.Url(string)"/>
  public IFacebookLikeButtonWidget Url(string url)
  {
    if (url is null) throw new ArgumentNullException(nameof(url));
    if (url.IsEmpty()) throw new ArgumentException(nameof(url));

    UrlProperty = url;
    return this;
  }

  /// <inheritdoc cref="IFacebookLikeButtonWidget.Url()"/>
  public string Url() => UrlProperty;

  /// <inheritdoc cref="IFacebookLikeButtonWidget.Verb(string)"/>
  public IFacebookLikeButtonWidget Verb(string verb)
  {
    if (verb is null) throw new ArgumentNullException(nameof(verb));
    if (verb.IsEmpty()) throw new ArgumentNullException(nameof(verb));

    VerbProperty = verb;
    return this;
  }

  /// <inheritdoc cref="IFacebookLikeButtonWidget.Verb()"/>
  public string Verb() => VerbProperty;

  /// <inheritdoc cref="IFacebookLikeButtonWidget.Width(string)"/>
  public IFacebookLikeButtonWidget Width(string width)
  {
    if (width is null) throw new ArgumentNullException(nameof(width));
    if (width.IsEmpty()) throw new ArgumentException(nameof(width));

    WidthProperty = width;
    return this;
  }

  /// <inheritdoc cref="IFacebookLikeButtonWidget.Width()"/>
  public string Width() => WidthProperty;

  /// <inheritdoc cref="IHtmlContent.ToHtml()"/>
  public override string ToHtml() => new TagBuilder("div")
      .Attribute("data-action", Verb())
      .Attribute("data-layout", Layout())
      .Attribute("data-show-faces", Faces())
      .Attribute("data-href", Url())
      .Attribute("data-colorscheme", ColorScheme())
      .Attribute("data-kid-directed-site", KidsMode())
      .Attribute("data-ref", TrackLabel())
      .Attribute("data-width", Width())
      .CssClass("fb-like")
      .ToString();
}