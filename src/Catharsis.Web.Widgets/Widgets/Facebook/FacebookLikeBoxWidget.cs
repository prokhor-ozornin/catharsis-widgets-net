using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IFacebookLikeBoxWidget"/>
public class FacebookLikeBoxWidget : WebWidget, IFacebookLikeBoxWidget
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual bool? BorderValue { get; set; }

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
  protected virtual bool? HeaderValue { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string HeightValue { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual bool? StreamValue { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string UrlValue { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual bool? WallValue { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string WidthValue { get; set; }

  /// <inheritdoc cref="IFacebookLikeBoxWidget.Border(bool)"/>
  public virtual IFacebookLikeBoxWidget Border(bool enabled)
  {
    BorderValue = enabled;
    return this;
  }

  /// <inheritdoc cref="IFacebookLikeBoxWidget.ColorScheme(string)"/>
  public virtual IFacebookLikeBoxWidget ColorScheme(string scheme)
  {
    if (scheme is null) throw new ArgumentNullException(nameof(scheme));
    if (scheme.IsEmpty()) throw new ArgumentException(nameof(scheme));

    ColorSchemeValue = scheme;
    return this;
  }

  /// <inheritdoc cref="IFacebookLikeBoxWidget.Faces(bool)"/>
  public virtual IFacebookLikeBoxWidget Faces(bool enabled)
  {
    FacesValue = enabled;
    return this;
  }

  /// <inheritdoc cref="IFacebookLikeBoxWidget.Header(bool)"/>
  public virtual IFacebookLikeBoxWidget Header(bool enabled)
  {
    HeaderValue = enabled;
    return this;
  }

  /// <inheritdoc cref="IFacebookLikeBoxWidget.Height(string)"/>
  public virtual IFacebookLikeBoxWidget Height(string height)
  {
    if (height is null) throw new ArgumentNullException(nameof(height));
    if (height.IsEmpty()) throw new ArgumentException(nameof(height));

    HeightValue = height;
    return this;
  }

  /// <inheritdoc cref="IFacebookLikeBoxWidget.Stream(bool)"/>
  public virtual IFacebookLikeBoxWidget Stream(bool enabled)
  {
    StreamValue = enabled;
    return this;
  }

  /// <inheritdoc cref="IFacebookLikeBoxWidget.Url(string)"/>
  public virtual IFacebookLikeBoxWidget Url(string url)
  {
    if (url is null) throw new ArgumentNullException(nameof(url));
    if (url.IsEmpty()) throw new ArgumentException(nameof(url));

    UrlValue = url;
    return this;
  }

  /// <inheritdoc cref="IFacebookLikeBoxWidget.Wall(bool)"/>
  public virtual IFacebookLikeBoxWidget Wall(bool enabled)
  {
    WallValue = enabled;
    return this;
  }

  /// <inheritdoc cref="IFacebookLikeBoxWidget.Width(string)"/>
  public virtual IFacebookLikeBoxWidget Width(string width)
  {
    if (width is null) throw new ArgumentNullException(nameof(width));
    if (width.IsEmpty()) throw new ArgumentException(nameof(width));

    WidthValue = width;
    return this;
  }

  /// <inheritdoc cref="ICloneable.Clone()"/>
  public override object Clone() => new FacebookLikeBoxWidget
  {
    BorderValue = BorderValue,
    ColorSchemeValue = ColorSchemeValue,
    FacesValue = FacesValue,
    HeaderValue = HeaderValue,
    HeightValue = HeightValue,
    StreamValue = StreamValue,
    UrlValue = UrlValue,
    WallValue = WallValue,
    WidthValue = WidthValue
  };

  /// <inheritdoc cref="IWebWidget.ToHtml()"/>
  public override string ToHtml() => UrlValue.IsUnset() ? string.Empty : new TagBuilder("div")
                                                                            .Attribute("data-href", UrlValue)
                                                                            .Attribute("data-width", WidthValue)
                                                                            .Attribute("data-height", HeightValue)
                                                                            .Attribute("data-colorscheme", ColorSchemeValue)
                                                                            .Attribute("data-force-wall", WallValue)
                                                                            .Attribute("data-header", HeaderValue)
                                                                            .Attribute("data-show-border", BorderValue)
                                                                            .Attribute("data-show-faces", FacesValue)
                                                                            .Attribute("data-stream", StreamValue)
                                                                            .CssClass("fb-like-box")
                                                                            .ToString();
}