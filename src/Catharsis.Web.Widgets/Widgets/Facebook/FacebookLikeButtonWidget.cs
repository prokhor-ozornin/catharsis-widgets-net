using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IFacebookLikeButtonWidget"/>
public class FacebookLikeButtonWidget : WebWidget, IFacebookLikeButtonWidget
{
  private string colorScheme;
  private bool? faces;
  private bool? kidsMode;
  private string layout;
  private string trackLabel;
  private string url;
  private string verb;
  private string width;

  /// <inheritdoc cref="IFacebookLikeButtonWidget.ColorScheme(string)"/>
  public IFacebookLikeButtonWidget ColorScheme(string scheme)
  {
    if (scheme is null) throw new ArgumentNullException(nameof(scheme));
    if (scheme.IsEmpty()) throw new ArgumentException(nameof(scheme));

    colorScheme = scheme;
    return this;
  }

  /// <inheritdoc cref="IFacebookLikeButtonWidget.ColorScheme()"/>
  public string ColorScheme() => colorScheme;

  /// <inheritdoc cref="IFacebookLikeButtonWidget.Faces(bool)"/>
  public IFacebookLikeButtonWidget Faces(bool show)
  {
    faces = show;
    return this;
  }

  /// <inheritdoc cref="IFacebookLikeButtonWidget.Faces()"/>
  public bool? Faces() => faces;

  /// <inheritdoc cref="IFacebookLikeButtonWidget.KidsMode(bool)"/>
  public IFacebookLikeButtonWidget KidsMode(bool enabled)
  {
    kidsMode = enabled;
    return this;
  }

  /// <inheritdoc cref="IFacebookLikeButtonWidget.KidsMode()"/>
  public bool? KidsMode() => kidsMode;

  /// <inheritdoc cref="IFacebookLikeButtonWidget.Layout(string)"/>
  public IFacebookLikeButtonWidget Layout(string layout)
  {
    if (layout is null) throw new ArgumentNullException(nameof(layout));
    if (layout.IsEmpty()) throw new ArgumentException(nameof(layout));

    this.layout = layout;
    return this;
  }

  /// <inheritdoc cref="IFacebookLikeButtonWidget.Layout()"/>
  public string Layout() => layout;

  /// <inheritdoc cref="IFacebookLikeButtonWidget.TrackLabel(string)"/>
  public IFacebookLikeButtonWidget TrackLabel(string label)
  {
    if (label is null) throw new ArgumentNullException(nameof(label));
    if (label.IsEmpty()) throw new ArgumentException(nameof(label));

    trackLabel = label;
    return this;
  }

  /// <inheritdoc cref="IFacebookLikeButtonWidget.TrackLabel()"/>
  public string TrackLabel() => trackLabel;

  /// <inheritdoc cref="IFacebookLikeButtonWidget.Url(string)"/>
  public IFacebookLikeButtonWidget Url(string url)
  {
    if (url is null) throw new ArgumentNullException(nameof(url));
    if (url.IsEmpty()) throw new ArgumentException(nameof(url));

    this.url = url;
    return this;
  }

  /// <inheritdoc cref="IFacebookLikeButtonWidget.Url()"/>
  public string Url() => url;

  /// <inheritdoc cref="IFacebookLikeButtonWidget.Verb(string)"/>
  public IFacebookLikeButtonWidget Verb(string verb)
  {
    if (verb is null) throw new ArgumentNullException(nameof(verb));
    if (verb.IsEmpty()) throw new ArgumentNullException(nameof(verb));

    this.verb = verb;
    return this;
  }

  /// <inheritdoc cref="IFacebookLikeButtonWidget.Verb()"/>
  public string Verb() => verb;

  /// <inheritdoc cref="IFacebookLikeButtonWidget.Width(string)"/>
  public IFacebookLikeButtonWidget Width(string width)
  {
    if (width is null) throw new ArgumentNullException(nameof(width));
    if (width.IsEmpty()) throw new ArgumentException(nameof(width));

    this.width = width;
    return this;
  }

  /// <inheritdoc cref="IFacebookLikeButtonWidget.Width()"/>
  public string Width() => width;

  /// <inheritdoc cref="IWebWidget.ToHtml()"/>
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