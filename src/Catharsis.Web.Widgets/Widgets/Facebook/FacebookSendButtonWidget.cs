using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IFacebookSendButtonWidget"/>
public class FacebookSendButtonWidget : WebWidget, IFacebookSendButtonWidget
{
  private string url;
  private string width;
  private string height;
  private string colorScheme;
  private bool? kidsMode;
  private string trackLabel;

  /// <inheritdoc cref="IFacebookSendButtonWidget.ColorScheme(string)"/>
  public IFacebookSendButtonWidget ColorScheme(string colorScheme)
  {
    if (colorScheme is null) throw new ArgumentNullException(nameof(colorScheme));
    if (colorScheme.IsEmpty()) throw new ArgumentException(nameof(colorScheme));

    this.colorScheme = colorScheme;
    return this;
  }

  /// <inheritdoc cref="IFacebookSendButtonWidget.ColorScheme()"/>
  public string ColorScheme() => colorScheme;

  /// <inheritdoc cref="IFacebookSendButtonWidget.Height(string)"/>
  public IFacebookSendButtonWidget Height(string height)
  {
    if (height is null) throw new ArgumentNullException(nameof(height));
    if (height.IsEmpty()) throw new ArgumentNullException(nameof(height));

    this.height = height;
    return this;
  }

  /// <inheritdoc cref="IFacebookSendButtonWidget.Height()"/>
  public string Height() => height;

  /// <inheritdoc cref="IFacebookSendButtonWidget.KidsMode(bool)"/>
  public IFacebookSendButtonWidget KidsMode(bool enabled)
  {
    kidsMode = enabled;
    return this;
  }

  /// <inheritdoc cref="IFacebookSendButtonWidget.KidsMode()"/>
  public bool? KidsMode() => kidsMode;

  /// <inheritdoc cref="IFacebookSendButtonWidget.TrackLabel(string)"/>
  public IFacebookSendButtonWidget TrackLabel(string label)
  {
    if (label is null) throw new ArgumentNullException(nameof(label));
    if (label.IsEmpty()) throw new ArgumentException(nameof(label));

    trackLabel = label;
    return this;
  }

  /// <inheritdoc cref="IFacebookSendButtonWidget.TrackLabel()"/>
  public string TrackLabel() => trackLabel;

  /// <inheritdoc cref="IFacebookSendButtonWidget.Url(string)"/>
  public IFacebookSendButtonWidget Url(string url)
  {
    if (url is null) throw new ArgumentNullException(nameof(url));
    if (url.IsEmpty()) throw new ArgumentException(nameof(url));

    this.url = url;
    return this;
  }

  /// <inheritdoc cref="IFacebookSendButtonWidget.Url()"/>
  public string Url() => url;

  /// <inheritdoc cref="IFacebookSendButtonWidget.Width(string)"/>
  public IFacebookSendButtonWidget Width(string width)
  {
    if (width is null) throw new ArgumentNullException(nameof(width));
    if (width.IsEmpty()) throw new ArgumentException(nameof(width));

    this.width = width;
    return this;
  }

  /// <inheritdoc cref="IFacebookSendButtonWidget.Width()"/>
  public string Width() => width;

  /// <inheritdoc cref="IWebWidget.ToHtml()"/>
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