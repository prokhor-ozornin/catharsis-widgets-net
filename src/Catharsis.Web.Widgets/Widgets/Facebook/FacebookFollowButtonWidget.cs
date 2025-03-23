using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IFacebookFollowButtonWidget"/>
public class FacebookFollowButtonWidget : WebWidget, IFacebookFollowButtonWidget
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
  protected virtual string HeightProperty { get; set; }

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
  protected virtual string UrlProperty { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string WidthProperty { get; set; }

  /// <inheritdoc cref="IFacebookFollowButtonWidget.ColorScheme(string)"/>
  public virtual IFacebookFollowButtonWidget ColorScheme(string scheme)
  {
    if (scheme is null) throw new ArgumentNullException(nameof(scheme));
    if (scheme.IsEmpty()) throw new ArgumentException(nameof(scheme));

    ColorSchemeProperty = scheme;
    return this;
  }

  /// <inheritdoc cref="IFacebookFollowButtonWidget.Faces(bool)"/>
  public virtual IFacebookFollowButtonWidget Faces(bool enabled)
  {
    FacesProperty = enabled;
    return this;
  }

  /// <inheritdoc cref="IFacebookFollowButtonWidget.Height(string)"/>
  public virtual IFacebookFollowButtonWidget Height(string height)
  {
    if (height is null) throw new ArgumentNullException(nameof(height));
    if (height.IsEmpty()) throw new ArgumentException(nameof(height));

    HeightProperty = height;
    return this;
  }

  /// <inheritdoc cref="IFacebookFollowButtonWidget.KidsMode(bool)"/>
  public virtual IFacebookFollowButtonWidget KidsMode(bool enabled)
  {
    KidsModeProperty = enabled;
    return this;
  }

  /// <inheritdoc cref="IFacebookFollowButtonWidget.Layout(string)"/>
  public virtual IFacebookFollowButtonWidget Layout(string layout)
  {
    if (layout is null) throw new ArgumentNullException(nameof(layout));
    if (layout.IsEmpty()) throw new ArgumentException(nameof(layout));

    LayoutProperty = layout;
    return this;
  }

  /// <inheritdoc cref="IFacebookFollowButtonWidget.Url(string)"/>
  public virtual IFacebookFollowButtonWidget Url(string url)
  {
    if (url is null) throw new ArgumentNullException(nameof(url));
    if (url.IsEmpty()) throw new ArgumentException(nameof(url));

    UrlProperty = url;
    return this;
  }

  /// <inheritdoc cref="IFacebookFollowButtonWidget.Width(string)"/>
  public virtual IFacebookFollowButtonWidget Width(string width)
  {
    if (width is null) throw new ArgumentNullException(nameof(width));
    if (width.IsEmpty()) throw new ArgumentException(nameof(width));

    WidthProperty = width;
    return this;
  }

  /// <inheritdoc cref="IHtmlContent.ToHtml()"/>
  public override string ToHtml() => UrlProperty.IsEmpty() ? string.Empty : new TagBuilder("div")
      .Attribute("data-layout", LayoutProperty)
      .Attribute("data-show-faces", FacesProperty)
      .Attribute("data-href", UrlProperty)
      .Attribute("data-colorscheme", ColorSchemeProperty)
      .Attribute("data-kid-directed-site", KidsModeProperty)
      .Attribute("data-width", WidthProperty)
      .Attribute("data-height", HeightProperty)
      .CssClass("fb-follow")
      .ToString();
}