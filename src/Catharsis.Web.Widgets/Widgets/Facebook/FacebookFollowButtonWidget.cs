using System.Web.Mvc;
using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IFacebookFollowButtonWidget"/>
public class FacebookFollowButtonWidget : HtmlWidget, IFacebookFollowButtonWidget
{
  private string colorScheme;
  private bool? faces;
  private string height;
  private bool? kidsMode;
  private string layout;
  private string url;
  private string width;

  /// <summary>
  ///   <para>The color scheme used by the button. Default is "light".</para>
  /// </summary>
  /// <param name="colorScheme">Color scheme of button.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="colorScheme"/> is a <c>null</c> reference.</exception>
  /// <exception cref="ArgumentException">If <paramref name="colorScheme"/> is <see cref="string.Empty"/> string.</exception>
  public IFacebookFollowButtonWidget ColorScheme(string colorScheme)
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
  ///   <para>Specifies whether to display profile photos below the button (standard layout only). You must not enable this on child-directed sites.</para>
  /// </summary>
  /// <param name="show"><c>true</c> to show profiles photos, <c>false</c> to hide.</param>
  /// <returns>Reference to the current widget.</returns>
  public IFacebookFollowButtonWidget Faces(bool show)
  {
    faces = show;
    return this;
  }

  /// <summary>
  ///   <para>Specifies whether to display profile photos below the button (standard layout only). You must not enable this on child-directed sites.</para>
  /// </summary>
  /// <returns><c>true</c> to show profiles photos, <c>false</c> to hide.</returns>
  public bool? Faces() => faces;

  /// <summary>
  ///   <para>The height of the button.</para>
  /// </summary>
  /// <param name="height">Height of button.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="height"/> is a <c>null</c> reference.</exception>
  /// <exception cref="ArgumentException">If <paramref name="height"/> is <see cref="string.Empty"/> string.</exception>
  public IFacebookFollowButtonWidget Height(string height)
  {
    if (height is null) throw new ArgumentNullException(nameof(height));
    if (height.IsEmpty()) throw new ArgumentException(nameof(height));

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
  public IFacebookFollowButtonWidget KidsMode(bool enabled)
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
  ///   <para>Selects one of the different layouts that are available for the button. Default is "standard".</para>
  /// </summary>
  /// <param name="layout">Layout of button.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="layout"/> is a <c>null</c> reference.</exception>
  /// <exception cref="ArgumentException">If <paramref name="layout"/> is <see cref="string.Empty"/> string.</exception>
  public IFacebookFollowButtonWidget Layout(string layout)
  {
    if (layout is null) throw new ArgumentNullException(nameof(layout));
    if (layout.IsEmpty()) throw new ArgumentException(nameof(layout));

    this.layout = layout;
    return this;
  }

  /// <summary>
  ///   <para>Selects one of the different layouts that are available for the button. Default is "standard".</para>
  /// </summary>
  /// <returns>Layout of button.</returns>
  public string Layout() => layout;

  /// <summary>
  ///   <para>The Facebook.com profile URL of the user to follow.</para>
  /// </summary>
  /// <param name="url">Profile URL.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="url"/> is a <c>null</c> reference.</exception>
  /// <exception cref="ArgumentException">If <paramref name="url"/> is <see cref="string.Empty"/> string.</exception>
  /// <remarks>This attribute is required.</remarks>
  public IFacebookFollowButtonWidget Url(string url)
  {
    if (url is null) throw new ArgumentNullException(nameof(url));
    if (url.IsEmpty()) throw new ArgumentException(nameof(url));

    this.url = url;
    return this;
  }

  /// <summary>
  ///   <para>The Facebook.com profile URL of the user to follow.</para>
  /// </summary>
  /// <returns>Profile URL.</returns>
  public string Url() => url;

  /// <summary>
  ///   <para>The width of the button. The layout you choose affects the minimum and default widths you can use.</para>
  /// </summary>
  /// <param name="width">Width of button.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="width"/> is a <c>null</c> reference.</exception>
  /// <exception cref="ArgumentException">If <paramref name="width"/> is <see cref="string.Empty"/> string.</exception>
  public IFacebookFollowButtonWidget Width(string width)
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
  public string Width() => this.width;

  /// <inheritdoc cref="IHtmlWidget.ToHtmlString()"/>
  public override string ToHtmlString()
  {
    if (Url().IsEmpty())
    {
      return string.Empty;
    }

    return new TagBuilder("div")
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
}