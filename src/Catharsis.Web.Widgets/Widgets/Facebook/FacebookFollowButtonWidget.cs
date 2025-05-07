using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IFacebookFollowButtonWidget"/>
public class FacebookFollowButtonWidget : WebWidget, IFacebookFollowButtonWidget
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
  protected virtual string HeightValue { get; set; }

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
  protected virtual string UrlValue { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string WidthValue { get; set; }

  /// <inheritdoc cref="IFacebookFollowButtonWidget.ColorScheme(string)"/>
  public virtual IFacebookFollowButtonWidget ColorScheme(string scheme)
  {
    if (scheme is null) throw new ArgumentNullException(nameof(scheme));
    if (scheme.IsEmpty()) throw new ArgumentException(nameof(scheme));

    ColorSchemeValue = scheme;
    return this;
  }

  /// <inheritdoc cref="IFacebookFollowButtonWidget.Faces(bool)"/>
  public virtual IFacebookFollowButtonWidget Faces(bool enabled)
  {
    FacesValue = enabled;
    return this;
  }

  /// <inheritdoc cref="IFacebookFollowButtonWidget.Height(string)"/>
  public virtual IFacebookFollowButtonWidget Height(string height)
  {
    if (height is null) throw new ArgumentNullException(nameof(height));
    if (height.IsEmpty()) throw new ArgumentException(nameof(height));

    HeightValue = height;
    return this;
  }

  /// <inheritdoc cref="IFacebookFollowButtonWidget.KidsMode(bool)"/>
  public virtual IFacebookFollowButtonWidget KidsMode(bool enabled)
  {
    KidsModeValue = enabled;
    return this;
  }

  /// <inheritdoc cref="IFacebookFollowButtonWidget.Layout(string)"/>
  public virtual IFacebookFollowButtonWidget Layout(string layout)
  {
    if (layout is null) throw new ArgumentNullException(nameof(layout));
    if (layout.IsEmpty()) throw new ArgumentException(nameof(layout));

    LayoutValue = layout;
    return this;
  }

  /// <inheritdoc cref="IFacebookFollowButtonWidget.Url(string)"/>
  public virtual IFacebookFollowButtonWidget Url(string url)
  {
    if (url is null) throw new ArgumentNullException(nameof(url));
    if (url.IsEmpty()) throw new ArgumentException(nameof(url));

    UrlValue = url;
    return this;
  }

  /// <inheritdoc cref="IFacebookFollowButtonWidget.Width(string)"/>
  public virtual IFacebookFollowButtonWidget Width(string width)
  {
    if (width is null) throw new ArgumentNullException(nameof(width));
    if (width.IsEmpty()) throw new ArgumentException(nameof(width));

    WidthValue = width;
    return this;
  }

  /// <inheritdoc cref="ICloneable.Clone()"/>
  public override object Clone() => new FacebookFollowButtonWidget
  {
    ColorSchemeValue = ColorSchemeValue,
    FacesValue = FacesValue,
    HeightValue = HeightValue,
    KidsModeValue = KidsModeValue,
    LayoutValue = LayoutValue,
    UrlValue = UrlValue,
    WidthValue = WidthValue
  };

  /// <inheritdoc cref="IWebWidget.ToHtml()"/>
  public override string ToHtml() => UrlValue.IsUnset() ? string.Empty : new TagBuilder("div")
                                                                            .Attribute("data-layout", LayoutValue)
                                                                            .Attribute("data-show-faces", FacesValue)
                                                                            .Attribute("data-href", UrlValue)
                                                                            .Attribute("data-colorscheme", ColorSchemeValue)
                                                                            .Attribute("data-kid-directed-site", KidsModeValue)
                                                                            .Attribute("data-width", WidthValue)
                                                                            .Attribute("data-height", HeightValue)
                                                                            .CssClass("fb-follow")
                                                                            .ToString();
}