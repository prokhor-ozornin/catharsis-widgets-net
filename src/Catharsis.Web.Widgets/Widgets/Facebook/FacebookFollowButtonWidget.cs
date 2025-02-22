using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IFacebookFollowButtonWidget"/>
public class FacebookFollowButtonWidget : WebWidget, IFacebookFollowButtonWidget
{
  private string ColorSchemeProperty;
  private bool? FacesProperty;
  private string HeightProperty;
  private bool? KidsModeProperty;
  private string LayoutProperty;
  private string UrlProperty;
  private string WidthProperty;

  /// <inheritdoc cref="IFacebookFollowButtonWidget.ColorScheme(string)"/>
  public IFacebookFollowButtonWidget ColorScheme(string scheme)
  {
    if (scheme is null) throw new ArgumentNullException(nameof(scheme));
    if (scheme.IsEmpty()) throw new ArgumentException(nameof(scheme));

    ColorSchemeProperty = scheme;
    return this;
  }

  /// <inheritdoc cref="IFacebookFollowButtonWidget.ColorScheme()"/>
  public string ColorScheme() => ColorSchemeProperty;

  /// <inheritdoc cref="IFacebookFollowButtonWidget.Faces(bool)"/>
  public IFacebookFollowButtonWidget Faces(bool enabled)
  {
    FacesProperty = enabled;
    return this;
  }

  /// <inheritdoc cref="IFacebookFollowButtonWidget.Faces()"/>
  public bool? Faces() => FacesProperty;

  /// <inheritdoc cref="IFacebookFollowButtonWidget.Height(string)"/>
  public IFacebookFollowButtonWidget Height(string height)
  {
    if (height is null) throw new ArgumentNullException(nameof(height));
    if (height.IsEmpty()) throw new ArgumentException(nameof(height));

    HeightProperty = height;
    return this;
  }

  /// <inheritdoc cref="IFacebookFollowButtonWidget.Height()"/>
  public string Height() => HeightProperty;

  /// <inheritdoc cref="IFacebookFollowButtonWidget.KidsMode(bool)"/>
  public IFacebookFollowButtonWidget KidsMode(bool enabled)
  {
    KidsModeProperty = enabled;
    return this;
  }

  /// <inheritdoc cref="IFacebookFollowButtonWidget.KidsMode()"/>
  public bool? KidsMode() => KidsModeProperty;

  /// <inheritdoc cref="IFacebookFollowButtonWidget.Layout(string)"/>
  public IFacebookFollowButtonWidget Layout(string layout)
  {
    if (layout is null) throw new ArgumentNullException(nameof(layout));
    if (layout.IsEmpty()) throw new ArgumentException(nameof(layout));

    LayoutProperty = layout;
    return this;
  }

  /// <inheritdoc cref="IFacebookFollowButtonWidget.Layout()"/>
  public string Layout() => LayoutProperty;

  /// <inheritdoc cref="IFacebookFollowButtonWidget.Url(string)"/>
  public IFacebookFollowButtonWidget Url(string url)
  {
    if (url is null) throw new ArgumentNullException(nameof(url));
    if (url.IsEmpty()) throw new ArgumentException(nameof(url));

    UrlProperty = url;
    return this;
  }

  /// <inheritdoc cref="IFacebookFollowButtonWidget.Url()"/>
  public string Url() => UrlProperty;

  /// <inheritdoc cref="IFacebookFollowButtonWidget.Width(string)"/>
  public IFacebookFollowButtonWidget Width(string width)
  {
    if (width is null) throw new ArgumentNullException(nameof(width));
    if (width.IsEmpty()) throw new ArgumentException(nameof(width));

    WidthProperty = width;
    return this;
  }

  /// <inheritdoc cref="IFacebookFollowButtonWidget.Width()"/>
  public string Width() => WidthProperty;

  /// <inheritdoc cref="IHtmlContent.ToHtml()"/>
  public override string ToHtml() => Url().IsEmpty() ? string.Empty : new TagBuilder("div")
      .Attribute("data-layout", Layout())
      .Attribute("data-show-faces", Faces())
      .Attribute("data-href", Url())
      .Attribute("data-colorscheme", ColorScheme())
      .Attribute("data-kid-directed-site", KidsMode())
      .Attribute("data-width", Width())
      .Attribute("data-height", Height())
      .CssClass("fb-follow")
      .ToString();
}