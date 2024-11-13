using System.Web.Mvc;
using System.Web.WebPages;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IFacebookLikeButtonWidget"/>
public class FacebookLikeButtonWidget : WebWidget, IFacebookLikeButtonWidget
{
  private string colorScheme;
  private bool? faces;
  private bool? kidsMode;
  private string layout;
  private string trackLabel;
  private string url;
  private string verb;
  private string width;

  /// <summary>
  ///   <para>Color scheme used by the button. Default is "light".</para>
  /// </summary>
  /// <param name="scheme">The color scheme for the button.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="scheme"/> is a <c>null</c> reference.</exception>
  /// <exception cref="ArgumentException">If <paramref name="scheme"/> is <see cref="string.Empty"/> string.</exception>
  public IFacebookLikeButtonWidget ColorScheme(string scheme)
  {
    if (scheme is null) throw new ArgumentNullException(nameof(scheme));
    if (scheme.IsEmpty()) throw new ArgumentException(nameof(scheme));

    colorScheme = scheme;
    return this;
  }

  /// <summary>
  ///   <para>Color scheme used by the button. Default is "light".</para>
  /// </summary>
  /// <returns>The color scheme for the button.</returns>
  public string ColorScheme() => colorScheme;

  /// <summary>
  ///   <para>Whether to display profile photos below the button (standard layout only). You must not enable this on child-directed sites. Default is <c>false</c>.</para>
  /// </summary>
  /// <param name="show"><c>true</c> to display profile photos, <c>false</c> to hide.</param>
  /// <returns>Reference to the current widget.</returns>
  public IFacebookLikeButtonWidget Faces(bool show)
  {
    faces = show;
    return this;
  }

  /// <summary>
  ///   <para>Whether to display profile photos below the button (standard layout only). You must not enable this on child-directed sites. Default is <c>false</c>.</para>
  /// </summary>
  /// <returns><c>true</c> to display profile photos, <c>false</c> to hide.</returns>
  public bool? Faces() => faces;

  /// <summary>
  ///   <para>If your web site or online service, or a portion of your service, is directed to children under 13 you must enable this. Default is <c>false</c>.</para>
  /// </summary>
  /// <param name="enabled"><c>true</c> if site is directed to small children, <c>false</c> otherwise.</param>
  /// <returns>Reference to the current widget.</returns>
  public IFacebookLikeButtonWidget KidsMode(bool enabled)
  {
    kidsMode = enabled;
    return this;
  }

  /// <summary>
  ///   <para>If your web site or online service, or a portion of your service, is directed to children under 13 you must enable this. Default is <c>false</c>.</para>
  /// </summary>
  /// <returns><c>true</c> if site is directed to small children, <c>false</c> otherwise.</returns>
  public bool? KidsMode() => kidsMode;

  /// <summary>
  ///   <para>One of the different layouts that are available for the button. Default is "standard".</para>
  /// </summary>
  /// <param name="layout">Button layout.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="layout"/> is a <c>null</c> reference.</exception>
  /// <exception cref="ArgumentException">If <paramref name="layout"/> is <see cref="string.Empty"/> string.</exception>
  public IFacebookLikeButtonWidget Layout(string layout)
  {
    if (layout is null) throw new ArgumentNullException(nameof(layout));
    if (layout.IsEmpty()) throw new ArgumentException(nameof(layout));

    this.layout = layout;
    return this;
  }

  /// <summary>
  ///   <para>One of the different layouts that are available for the button. Default is "standard".</para>
  /// </summary>
  /// <returns>Button layout.</returns>
  public string Layout() => layout;

  /// <summary>
  ///   <para>Label for tracking referrals which must be less than 50 characters and can contain alphanumeric characters and some punctuation (currently +/=-.:_).</para>
  /// </summary>
  /// <param name="label">Label to track referrals.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="label"/> is a <c>null</c> reference.</exception>
  /// <exception cref="ArgumentException">If <paramref name="label"/> is <see cref="string.Empty"/> string.</exception>
  public IFacebookLikeButtonWidget TrackLabel(string label)
  {
    if (label is null) throw new ArgumentNullException(nameof(label));
    if (label.IsEmpty()) throw new ArgumentException(nameof(label));

    trackLabel = label;
    return this;
  }

  /// <summary>
  ///   <para>Label for tracking referrals which must be less than 50 characters and can contain alphanumeric characters and some punctuation (currently +/=-.:_).</para>
  /// </summary>
  /// <returns>Label to track referrals.</returns>
  public string TrackLabel() => trackLabel;

  /// <summary>
  ///   <para>Specifies absolute URL of the page that will be liked.</para>
  /// </summary>
  /// <param name="url">URL of the page to "like".</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="url"/> is a <c>null</c> reference.</exception>
  /// <exception cref="ArgumentException">If <paramref name="url"/> is <see cref="string.Empty"/> string.</exception>
  public IFacebookLikeButtonWidget Url(string url)
  {
    if (url is null) throw new ArgumentNullException(nameof(url));
    if (url.IsEmpty()) throw new ArgumentException(nameof(url));

    this.url = url;
    return this;
  }

  /// <summary>
  ///   <para>Specifies absolute URL of the page that will be liked.</para>
  /// </summary>
  /// <returns>URL of the page to "like".</returns>
  public string Url() => url;

  /// <summary>
  ///   <para>The verb to display on the button. Default is "like".</para>
  /// </summary>
  /// <param name="verb">Verb on the button.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="verb"/> is a <c>null</c> reference.</exception>
  /// <exception cref="ArgumentException">If <paramref name="verb"/> is <see cref="string.Empty"/> string.</exception>
  public IFacebookLikeButtonWidget Verb(string verb)
  {
    if (verb is null) throw new ArgumentNullException(nameof(verb));
    if (verb.IsEmpty()) throw new ArgumentNullException(nameof(verb));

    this.verb = verb;
    return this;
  }

  /// <summary>
  ///   <para>The verb to display on the button. Default is "like".</para>
  /// </summary>
  /// <returns>Verb on the button.</returns>
  public string Verb() => verb;

  /// <summary>
  ///   <para>The width of the button. The layout you choose affects the minimum and default widths you can use.</para>
  /// </summary>
  /// <param name="width">Width of button.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="width"/> is a <c>null</c> reference.</exception>
  /// <exception cref="ArgumentException">If <paramref name="width"/> is <see cref="string.Empty"/> string.</exception>
  public IFacebookLikeButtonWidget Width(string width)
  {
    if (width is null) throw new ArgumentNullException(nameof(width));
    if (width.IsEmpty()) throw new ArgumentException(nameof(width));

    this.width = width;
    return this;
  }

  /// <summary>
  ///   <para>The width of the button. The layout you choose affects the minimum and default widths you can use.</para>
  /// </summary>
  /// <returns>Width of button.</returns>
  public string Width() => width;

  /// <inheritdoc cref="IWebWidget.ToHtml()"/>
  public override string ToHtml() => new TagBuilder("div")
      .Attribute("data-action", Verb())
      .Attribute("data-layout", Layout())
      .Attribute("data-show-faces", Faces())
      .Attribute("data-href", Url())
      .Attribute("data-colorscheme", ColorScheme())
      .Attribute("data-kid-directed-site", KidsMode())
      .Attribute("data-ref", TrackLabel())
      .Attribute("data-width", Width())
      .CssClass("fb-like")
      .ToString();
}