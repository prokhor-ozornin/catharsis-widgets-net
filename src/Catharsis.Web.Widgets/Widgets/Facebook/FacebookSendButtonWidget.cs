using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IFacebookSendButtonWidget"/>
public class FacebookSendButtonWidget : WebWidget, IFacebookSendButtonWidget
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string UrlProperty { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string WidthProperty { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string HeightProperty { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string ColorSchemeProperty { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual bool? KidsModeProperty { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string TrackLabelProperty { get; set; }

  /// <inheritdoc cref="IFacebookSendButtonWidget.ColorScheme(string)"/>
  public virtual IFacebookSendButtonWidget ColorScheme(string scheme)
  {
    if (scheme is null) throw new ArgumentNullException(nameof(scheme));
    if (scheme.IsEmpty()) throw new ArgumentException(nameof(scheme));

    ColorSchemeProperty = scheme;
    return this;
  }

  /// <inheritdoc cref="IFacebookSendButtonWidget.Height(string)"/>
  public virtual IFacebookSendButtonWidget Height(string height)
  {
    if (height is null) throw new ArgumentNullException(nameof(height));
    if (height.IsEmpty()) throw new ArgumentException(nameof(height));

    HeightProperty = height;
    return this;
  }

  /// <inheritdoc cref="IFacebookSendButtonWidget.KidsMode(bool)"/>
  public virtual IFacebookSendButtonWidget KidsMode(bool enabled)
  {
    KidsModeProperty = enabled;
    return this;
  }

  /// <inheritdoc cref="IFacebookSendButtonWidget.TrackLabel(string)"/>
  public virtual IFacebookSendButtonWidget TrackLabel(string label)
  {
    if (label is null) throw new ArgumentNullException(nameof(label));
    if (label.IsEmpty()) throw new ArgumentException(nameof(label));

    TrackLabelProperty = label;
    return this;
  }

  /// <inheritdoc cref="IFacebookSendButtonWidget.Url(string)"/>
  public virtual IFacebookSendButtonWidget Url(string url)
  {
    if (url is null) throw new ArgumentNullException(nameof(url));
    if (url.IsEmpty()) throw new ArgumentException(nameof(url));

    UrlProperty = url;
    return this;
  }

  /// <inheritdoc cref="IFacebookSendButtonWidget.Width(string)"/>
  public virtual IFacebookSendButtonWidget Width(string width)
  {
    if (width is null) throw new ArgumentNullException(nameof(width));
    if (width.IsEmpty()) throw new ArgumentException(nameof(width));

    WidthProperty = width;
    return this;
  }

  /// <inheritdoc cref="IHtmlContent.ToHtml()"/>
  public override string ToHtml() => new TagBuilder("div")
      .Attribute("data-href", UrlProperty)
      .Attribute("data-colorscheme", ColorSchemeProperty)
      .Attribute("data-kid-directed-site", KidsModeProperty)
      .Attribute("data-width", WidthProperty)
      .Attribute("data-height", HeightProperty)
      .Attribute("data-ref", TrackLabelProperty)
      .CssClass("fb-send")
      .ToString();
}