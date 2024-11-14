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

  /// <summary>
  ///   <para>The color scheme used by the button. Default is "light".</para>
  /// </summary>
  /// <param name="colorScheme">Color scheme of button.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="colorScheme"/> is a <c>null</c> reference.</exception>
  /// <exception cref="ArgumentException">If <paramref name="colorScheme"/> is <see cref="string.Empty"/> string.</exception>
  public IFacebookSendButtonWidget ColorScheme(string colorScheme)
  {
    if (colorScheme is null) throw new ArgumentNullException(nameof(colorScheme));
    if (colorScheme.IsEmpty()) throw new ArgumentException(nameof(colorScheme));

    this.colorScheme = colorScheme;
    return this;
  }

  /// <summary>
  ///   <para>The color scheme used by the button. Default is "light".</para>
  /// </summary>
  /// <returns>Color scheme of button.</returns>
  public string ColorScheme() => colorScheme;

  /// <summary>
  ///   <para>The height of the button.</para>
  /// </summary>
  /// <param name="height">Height of button.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="height"/> is a <c>null</c> reference.</exception>
  /// <exception cref="ArgumentException">If <paramref name="height"/> is <see cref="string.Empty"/> string.</exception>
  public IFacebookSendButtonWidget Height(string height)
  {
    if (height is null) throw new ArgumentNullException(nameof(height));
    if (height.IsEmpty()) throw new ArgumentNullException(nameof(height));

    this.height = height;
    return this;
  }

  /// <summary>
  ///   <para>The height of the button.</para>
  /// </summary>
  /// <returns>Height of button.</returns>
  public string Height() => height;

  /// <summary>
  ///   <para>If your web site or online service, or a portion of your service, is directed to children under 13 you must enable this. Default is <c>false</c>.</para>
  /// </summary>
  /// <param name="enabled"><c>true</c> to activate kids-directed mode, <c>false</c> to use default mode.</param>
  /// <returns>Reference to the current widget.</returns>
  public IFacebookSendButtonWidget KidsMode(bool enabled)
  {
    kidsMode = enabled;
    return this;
  }

  /// <summary>
  ///   <para>If your web site or online service, or a portion of your service, is directed to children under 13 you must enable this. Default is <c>false</c>.</para>
  /// </summary>
  /// <returns><c>true</c> to activate kids-directed mode, <c>false</c> to use default mode.</returns>
  public bool? KidsMode() => kidsMode;

  /// <summary>
  ///   <para>A label for tracking referrals which must be less than 50 characters and can contain alphanumeric characters and some punctuation (currently +/=-.:_).</para>
  /// </summary>
  /// <param name="label">Label to track referrals.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="label"/> is a <c>null</c> reference.</exception>
  /// <exception cref="ArgumentException">If <paramref name="label"/> is <see cref="string.Empty"/> string.</exception>
  public IFacebookSendButtonWidget TrackLabel(string label)
  {
    if (label is null) throw new ArgumentNullException(nameof(label));
    if (label.IsEmpty()) throw new ArgumentException(nameof(label));

    trackLabel = label;
    return this;
  }

  /// <summary>
  ///   <para>A label for tracking referrals which must be less than 50 characters and can contain alphanumeric characters and some punctuation (currently +/=-.:_).</para>
  /// </summary>
  /// <returns>Label to track referrals.</returns>
  public string TrackLabel() => trackLabel;

  /// <summary>
  ///   <para>The absolute URL of the page that will be sent. Default is current page URL.</para>
  /// </summary>
  /// <param name="url">URL of the page to send.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="url"/> is a <c>null</c> reference.</exception>
  /// <exception cref="ArgumentException">If <paramref name="url"/> is <see cref="string.Empty"/> string.</exception>
  public IFacebookSendButtonWidget Url(string url)
  {
    if (url is null) throw new ArgumentNullException(nameof(url));
    if (url.IsEmpty()) throw new ArgumentException(nameof(url));

    this.url = url;
    return this;
  }

  /// <summary>
  ///   <para>The absolute URL of the page that will be sent. Default is current page URL.</para>
  /// </summary>
  /// <returns>URL of the page to send.</returns>
  public string Url() => url;

  /// <summary>
  ///   <para>The width of the button.</para>
  /// </summary>
  /// <param name="width">Width of button.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="width"/> is a <c>null</c> reference.</exception>
  /// <exception cref="ArgumentException">If <paramref name="width"/> is <see cref="string.Empty"/> string.</exception>
  public IFacebookSendButtonWidget Width(string width)
  {
    if (width is null) throw new ArgumentNullException(nameof(width));
    if (width.IsEmpty()) throw new ArgumentException(nameof(width));

    this.width = width;
    return this;
  }

  /// <summary>
  ///   <para>The width of the button.</para>
  /// </summary>
  /// <returns>Width of button.</returns>
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