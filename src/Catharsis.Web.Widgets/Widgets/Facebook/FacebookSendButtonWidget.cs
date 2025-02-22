using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IFacebookSendButtonWidget"/>
public class FacebookSendButtonWidget : WebWidget, IFacebookSendButtonWidget
{
  private string UrlProperty { get; set; }
  private string WidthProperty { get; set; }
  private string HeightProperty { get; set; }
  private string ColorSchemeProperty { get; set; }
  private bool? KidsModeProperty { get; set; }
  private string TrackLabelProperty { get; set; }

  /// <inheritdoc cref="IFacebookSendButtonWidget.ColorScheme(string)"/>
  public IFacebookSendButtonWidget ColorScheme(string scheme)
  {
    if (scheme is null) throw new ArgumentNullException(nameof(scheme));
    if (scheme.IsEmpty()) throw new ArgumentException(nameof(scheme));

    ColorSchemeProperty = scheme;
    return this;
  }

  /// <inheritdoc cref="IFacebookSendButtonWidget.ColorScheme()"/>
  public string ColorScheme() => ColorSchemeProperty;

  /// <inheritdoc cref="IFacebookSendButtonWidget.Height(string)"/>
  public IFacebookSendButtonWidget Height(string height)
  {
    if (height is null) throw new ArgumentNullException(nameof(height));
    if (height.IsEmpty()) throw new ArgumentNullException(nameof(height));

    HeightProperty = height;
    return this;
  }

  /// <inheritdoc cref="IFacebookSendButtonWidget.Height()"/>
  public string Height() => HeightProperty;

  /// <inheritdoc cref="IFacebookSendButtonWidget.KidsMode(bool)"/>
  public IFacebookSendButtonWidget KidsMode(bool enabled)
  {
    KidsModeProperty = enabled;
    return this;
  }

  /// <inheritdoc cref="IFacebookSendButtonWidget.KidsMode()"/>
  public bool? KidsMode() => KidsModeProperty;

  /// <inheritdoc cref="IFacebookSendButtonWidget.TrackLabel(string)"/>
  public IFacebookSendButtonWidget TrackLabel(string label)
  {
    if (label is null) throw new ArgumentNullException(nameof(label));
    if (label.IsEmpty()) throw new ArgumentException(nameof(label));

    TrackLabelProperty = label;
    return this;
  }

  /// <inheritdoc cref="IFacebookSendButtonWidget.TrackLabel()"/>
  public string TrackLabel() => TrackLabelProperty;

  /// <inheritdoc cref="IFacebookSendButtonWidget.Url(string)"/>
  public IFacebookSendButtonWidget Url(string url)
  {
    if (url is null) throw new ArgumentNullException(nameof(url));
    if (url.IsEmpty()) throw new ArgumentException(nameof(url));

    UrlProperty = url;
    return this;
  }

  /// <inheritdoc cref="IFacebookSendButtonWidget.Url()"/>
  public string Url() => UrlProperty;

  /// <inheritdoc cref="IFacebookSendButtonWidget.Width(string)"/>
  public IFacebookSendButtonWidget Width(string width)
  {
    if (width is null) throw new ArgumentNullException(nameof(width));
    if (width.IsEmpty()) throw new ArgumentException(nameof(width));

    WidthProperty = width;
    return this;
  }

  /// <inheritdoc cref="IFacebookSendButtonWidget.Width()"/>
  public string Width() => WidthProperty;

  /// <inheritdoc cref="IHtmlContent.ToHtml()"/>
  public override string ToHtml() => new TagBuilder("div")
      .Attribute("data-href", Url())
      .Attribute("data-colorscheme", ColorScheme())
      .Attribute("data-kid-directed-site", KidsMode())
      .Attribute("data-width", Width())
      .Attribute("data-height", Height())
      .Attribute("data-ref", TrackLabel())
      .CssClass("fb-send")
      .ToString();
}