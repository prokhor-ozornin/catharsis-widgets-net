using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IFacebookLikeBoxWidget"/>
public class FacebookLikeBoxWidget : WebWidget, IFacebookLikeBoxWidget
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual bool? BorderProperty { get; set; }

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
  protected virtual bool? HeaderProperty { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string HeightProperty { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual bool? StreamProperty { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string UrlProperty { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual bool? WallProperty { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string WidthProperty { get; set; }

  /// <inheritdoc cref="IFacebookLikeBoxWidget.Border(bool)"/>
  public virtual IFacebookLikeBoxWidget Border(bool enabled)
  {
    BorderProperty = enabled;
    return this;
  }

  /// <inheritdoc cref="IFacebookLikeBoxWidget.ColorScheme(string)"/>
  public virtual IFacebookLikeBoxWidget ColorScheme(string scheme)
  {
    if (scheme is null) throw new ArgumentNullException(nameof(scheme));
    if (scheme.IsEmpty()) throw new ArgumentException(nameof(scheme));

    ColorSchemeProperty = scheme;
    return this;
  }

  /// <inheritdoc cref="IFacebookLikeBoxWidget.Faces(bool)"/>
  public virtual IFacebookLikeBoxWidget Faces(bool enabled)
  {
    FacesProperty = enabled;
    return this;
  }

  /// <inheritdoc cref="IFacebookLikeBoxWidget.Header(bool)"/>
  public virtual IFacebookLikeBoxWidget Header(bool enabled)
  {
    HeaderProperty = enabled;
    return this;
  }

  /// <inheritdoc cref="IFacebookLikeBoxWidget.Height(string)"/>
  public virtual IFacebookLikeBoxWidget Height(string height)
  {
    if (height is null) throw new ArgumentNullException(nameof(height));
    if (height.IsEmpty()) throw new ArgumentException(nameof(height));

    HeightProperty = height;
    return this;
  }

  /// <inheritdoc cref="IFacebookLikeBoxWidget.Stream(bool)"/>
  public virtual IFacebookLikeBoxWidget Stream(bool enabled)
  {
    StreamProperty = enabled;
    return this;
  }

  /// <inheritdoc cref="IFacebookLikeBoxWidget.Url(string)"/>
  public virtual IFacebookLikeBoxWidget Url(string url)
  {
    if (url is null) throw new ArgumentNullException(nameof(url));
    if (url.IsEmpty()) throw new ArgumentException(nameof(url));

    UrlProperty = url;
    return this;
  }

  /// <inheritdoc cref="IFacebookLikeBoxWidget.Wall(bool)"/>
  public virtual IFacebookLikeBoxWidget Wall(bool enabled)
  {
    WallProperty = enabled;
    return this;
  }

  /// <inheritdoc cref="IFacebookLikeBoxWidget.Width(string)"/>
  public virtual IFacebookLikeBoxWidget Width(string width)
  {
    if (width is null) throw new ArgumentNullException(nameof(width));
    if (width.IsEmpty()) throw new ArgumentException(nameof(width));

    WidthProperty = width;
    return this;
  }

  /// <inheritdoc cref="ICloneable.Clone()"/>
  public override object Clone() => new FacebookLikeBoxWidget { };

  /// <inheritdoc cref="IWebWidget.ToHtml()"/>
  public override string ToHtml() => UrlProperty.IsUnset() ? string.Empty : new TagBuilder("div")
                                                                            .Attribute("data-href", UrlProperty)
                                                                            .Attribute("data-width", WidthProperty)
                                                                            .Attribute("data-height", HeightProperty)
                                                                            .Attribute("data-colorscheme", ColorSchemeProperty)
                                                                            .Attribute("data-force-wall", WallProperty)
                                                                            .Attribute("data-header", HeaderProperty)
                                                                            .Attribute("data-show-border", BorderProperty)
                                                                            .Attribute("data-show-faces", FacesProperty)
                                                                            .Attribute("data-stream", StreamProperty)
                                                                            .CssClass("fb-like-box")
                                                                            .ToString();
}