using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IFacebookSendButtonWidget"/>
public class FacebookSendButtonWidget : WebWidget, IFacebookSendButtonWidget
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string UrlValue { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string WidthValue { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string HeightValue { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string ColorSchemeValue { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual bool? KidsModeValue { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string TrackLabelValue { get; set; }

  /// <inheritdoc cref="IFacebookSendButtonWidget.ColorScheme(string)"/>
  public virtual IFacebookSendButtonWidget ColorScheme(string scheme)
  {
    if (scheme is null) throw new ArgumentNullException(nameof(scheme));
    if (scheme.IsEmpty()) throw new ArgumentException(nameof(scheme));

    ColorSchemeValue = scheme;
    return this;
  }

  /// <inheritdoc cref="IFacebookSendButtonWidget.Height(string)"/>
  public virtual IFacebookSendButtonWidget Height(string height)
  {
    if (height is null) throw new ArgumentNullException(nameof(height));
    if (height.IsEmpty()) throw new ArgumentException(nameof(height));

    HeightValue = height;
    return this;
  }

  /// <inheritdoc cref="IFacebookSendButtonWidget.KidsMode(bool)"/>
  public virtual IFacebookSendButtonWidget KidsMode(bool enabled)
  {
    KidsModeValue = enabled;
    return this;
  }

  /// <inheritdoc cref="IFacebookSendButtonWidget.TrackLabel(string)"/>
  public virtual IFacebookSendButtonWidget TrackLabel(string label)
  {
    if (label is null) throw new ArgumentNullException(nameof(label));
    if (label.IsEmpty()) throw new ArgumentException(nameof(label));

    TrackLabelValue = label;
    return this;
  }

  /// <inheritdoc cref="IFacebookSendButtonWidget.Url(string)"/>
  public virtual IFacebookSendButtonWidget Url(string url)
  {
    if (url is null) throw new ArgumentNullException(nameof(url));
    if (url.IsEmpty()) throw new ArgumentException(nameof(url));

    UrlValue = url;
    return this;
  }

  /// <inheritdoc cref="IFacebookSendButtonWidget.Width(string)"/>
  public virtual IFacebookSendButtonWidget Width(string width)
  {
    if (width is null) throw new ArgumentNullException(nameof(width));
    if (width.IsEmpty()) throw new ArgumentException(nameof(width));

    WidthValue = width;
    return this;
  }

  /// <inheritdoc cref="ICloneable.Clone()"/>
  public override object Clone() => new FacebookSendButtonWidget
  {
    UrlValue = UrlValue,
    WidthValue = WidthValue,
    HeightValue = HeightValue,
    ColorSchemeValue = ColorSchemeValue,
    KidsModeValue = KidsModeValue,
    TrackLabelValue = TrackLabelValue
  };

  /// <inheritdoc cref="IWebWidget.ToHtml()"/>
  public override string ToHtml() => new TagBuilder("div")
      .Attribute("data-href", UrlValue)
      .Attribute("data-colorscheme", ColorSchemeValue)
      .Attribute("data-kid-directed-site", KidsModeValue)
      .Attribute("data-width", WidthValue)
      .Attribute("data-height", HeightValue)
      .Attribute("data-ref", TrackLabelValue)
      .CssClass("fb-send")
      .ToString();
}