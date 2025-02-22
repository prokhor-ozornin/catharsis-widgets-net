using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IFacebookLikeBoxWidget"/>
public class FacebookLikeBoxWidget : WebWidget, IFacebookLikeBoxWidget
{
  private bool? BorderProperty { get; set; }
  private string ColorSchemeProperty { get; set; }
  private bool? FacesProperty { get; set; }
  private bool? HeaderProperty { get; set; }
  private string HeightProperty { get; set; }
  private bool? StreamProperty { get; set; }
  private string UrlProperty { get; set; }
  private bool? WallProperty { get; set; }
  private string WidthProperty { get; set; }

  /// <inheritdoc cref="IFacebookLikeBoxWidget.Border(bool)"/>
  public IFacebookLikeBoxWidget Border(bool enabled)
  {
    BorderProperty = enabled;
    return this;
  }

  /// <inheritdoc cref="IFacebookLikeBoxWidget.Border()"/>
  public bool? Border() => BorderProperty;

  /// <inheritdoc cref="IFacebookLikeBoxWidget.ColorScheme(string)"/>
  public IFacebookLikeBoxWidget ColorScheme(string scheme)
  {
    if (scheme is null) throw new ArgumentNullException(nameof(scheme));
    if (scheme.IsEmpty()) throw new ArgumentException(nameof(scheme));

    ColorSchemeProperty = scheme;
    return this;
  }

  /// <inheritdoc cref="IFacebookLikeBoxWidget.ColorScheme()"/>
  public string ColorScheme() => ColorSchemeProperty;

  /// <inheritdoc cref="IFacebookLikeBoxWidget.Faces(bool)"/>
  public IFacebookLikeBoxWidget Faces(bool enabled)
  {
    FacesProperty = enabled;
    return this;
  }

  /// <inheritdoc cref="IFacebookLikeBoxWidget.Faces()"/>
  public bool? Faces() => FacesProperty;

  /// <inheritdoc cref="IFacebookLikeBoxWidget.Header(bool)"/>
  public IFacebookLikeBoxWidget Header(bool enabled)
  {
    HeaderProperty = enabled;
    return this;
  }

  /// <inheritdoc cref="IFacebookLikeBoxWidget.Header()"/>
  public bool? Header() => HeaderProperty;

  /// <inheritdoc cref="IFacebookLikeBoxWidget.Height(string)"/>
  public IFacebookLikeBoxWidget Height(string height)
  {
    if (height is null) throw new ArgumentNullException(nameof(height));
    if (height.IsEmpty()) throw new ArgumentException(nameof(height));

    HeightProperty = height;
    return this;
  }

  /// <inheritdoc cref="IFacebookLikeBoxWidget.Height()"/>
  public string Height() => HeightProperty;

  /// <inheritdoc cref="IFacebookLikeBoxWidget.Stream(bool)"/>
  public IFacebookLikeBoxWidget Stream(bool enabled)
  {
    StreamProperty = enabled;
    return this;
  }

  /// <inheritdoc cref="IFacebookLikeBoxWidget.Stream()"/>
  public bool? Stream() => StreamProperty;

  /// <inheritdoc cref="IFacebookLikeBoxWidget.Url(string)"/>
  public IFacebookLikeBoxWidget Url(string url)
  {
    if (url is null) throw new ArgumentNullException(nameof(url));
    if (url.IsEmpty()) throw new ArgumentException(nameof(url));

    UrlProperty = url;
    return this;
  }

  /// <inheritdoc cref="IFacebookLikeBoxWidget.Url()"/>
  public string Url() => UrlProperty;

  /// <inheritdoc cref="IFacebookLikeBoxWidget.Wall(bool)"/>
  public IFacebookLikeBoxWidget Wall(bool enabled)
  {
    WallProperty = enabled;
    return this;
  }

  /// <inheritdoc cref="IFacebookLikeBoxWidget.Wall()"/>
  public bool? Wall() => WallProperty;

  /// <inheritdoc cref="IFacebookLikeBoxWidget.Width(string)"/>
  public IFacebookLikeBoxWidget Width(string width)
  {
    if (width is null) throw new ArgumentNullException(nameof(width));
    if (width.IsEmpty()) throw new ArgumentException(nameof(width));

    WidthProperty = width;
    return this;
  }

  /// <inheritdoc cref="IFacebookLikeBoxWidget.Width()"/>
  public string Width() => WidthProperty;

  /// <inheritdoc cref="IHtmlContent.ToHtml()"/>
  public override string ToHtml() => Url().IsEmpty() ? string.Empty : new TagBuilder("div")
      .Attribute("data-href", Url())
      .Attribute("data-width", Width())
      .Attribute("data-height", Height())
      .Attribute("data-colorscheme", ColorScheme())
      .Attribute("data-force-wall", Wall())
      .Attribute("data-header", Header())
      .Attribute("data-show-border", Border())
      .Attribute("data-show-faces", Faces())
      .Attribute("data-stream", Stream())
      .CssClass("fb-like-box")
      .ToString();
}