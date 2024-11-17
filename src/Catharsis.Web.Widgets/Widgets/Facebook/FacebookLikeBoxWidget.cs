using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IFacebookLikeBoxWidget"/>
public class FacebookLikeBoxWidget : WebWidget, IFacebookLikeBoxWidget
{
  private bool? border;
  private string colorScheme;
  private bool? faces;
  private bool? header;
  private string height;
  private bool? stream;
  private string url;
  private bool? wall;
  private string width;

  /// <inheritdoc cref="IFacebookLikeBoxWidget.Border(bool)"/>
  public IFacebookLikeBoxWidget Border(bool enabled)
  {
    this.border = enabled;
    return this;
  }

  /// <inheritdoc cref="IFacebookLikeBoxWidget.Border()"/>
  public bool? Border() => border;

  /// <inheritdoc cref="IFacebookLikeBoxWidget.ColorScheme(string)"/>
  public IFacebookLikeBoxWidget ColorScheme(string scheme)
  {
    if (scheme is null) throw new ArgumentNullException(nameof(scheme));
    if (scheme.IsEmpty()) throw new ArgumentException(nameof(scheme));

    this.colorScheme = scheme;
    return this;
  }

  /// <inheritdoc cref="IFacebookLikeBoxWidget.ColorScheme()"/>
  public string ColorScheme() => colorScheme;

  /// <inheritdoc cref="IFacebookLikeBoxWidget.Faces(bool)"/>
  public IFacebookLikeBoxWidget Faces(bool enabled)
  {
    faces = enabled;
    return this;
  }

  /// <inheritdoc cref="IFacebookLikeBoxWidget.Faces()"/>
  public bool? Faces() => faces;

  /// <inheritdoc cref="IFacebookLikeBoxWidget.Header(bool)"/>
  public IFacebookLikeBoxWidget Header(bool enabled)
  {
    header = enabled;
    return this;
  }

  /// <inheritdoc cref="IFacebookLikeBoxWidget.Header()"/>
  public bool? Header() => header;

  /// <inheritdoc cref="IFacebookLikeBoxWidget.Height(string)"/>
  public IFacebookLikeBoxWidget Height(string height)
  {
    if (height is null) throw new ArgumentNullException(nameof(height));
    if (height.IsEmpty()) throw new ArgumentException(nameof(height));

    this.height = height;
    return this;
  }

  /// <inheritdoc cref="IFacebookLikeBoxWidget.Height()"/>
  public string Height() => height;

  /// <inheritdoc cref="IFacebookLikeBoxWidget.Stream(bool)"/>
  public IFacebookLikeBoxWidget Stream(bool enabled)
  {
    stream = enabled;
    return this;
  }

  /// <inheritdoc cref="IFacebookLikeBoxWidget.Stream()"/>
  public bool? Stream() => stream;

  /// <inheritdoc cref="IFacebookLikeBoxWidget.Url(string)"/>
  public IFacebookLikeBoxWidget Url(string url)
  {
    if (url is null) throw new ArgumentNullException(nameof(url));
    if (url.IsEmpty()) throw new ArgumentException(nameof(url));

    this.url = url;
    return this;
  }

  /// <inheritdoc cref="IFacebookLikeBoxWidget.Url()"/>
  public string Url() => url;

  /// <inheritdoc cref="IFacebookLikeBoxWidget.Wall(bool)"/>
  public IFacebookLikeBoxWidget Wall(bool enabled)
  {
    wall = enabled;
    return this;
  }

  /// <inheritdoc cref="IFacebookLikeBoxWidget.Wall()"/>
  public bool? Wall() => wall;

  /// <inheritdoc cref="IFacebookLikeBoxWidget.Width(string)"/>
  public IFacebookLikeBoxWidget Width(string width)
  {
    if (width is null) throw new ArgumentNullException(nameof(width));
    if (width.IsEmpty()) throw new ArgumentException(nameof(width));

    this.width = width;
    return this;
  }

  /// <inheritdoc cref="IFacebookLikeBoxWidget.Width()"/>
  public string Width() => width;

  /// <inheritdoc cref="IWebWidget.ToHtml()"/>
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