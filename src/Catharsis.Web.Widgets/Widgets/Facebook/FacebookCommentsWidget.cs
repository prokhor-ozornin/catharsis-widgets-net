using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IFacebookCommentsWidget"/>
public class FacebookCommentsWidget : WebWidget, IFacebookCommentsWidget
{
  private string ColorSchemeProperty { get; set; }
  private bool? MobileProperty { get; set; }
  private string OrderProperty { get; set; }
  private byte? PostsProperty { get; set; }
  private string UrlProperty { get; set; }
  private string WidthProperty { get; set; }

  /// <summary>
  ///   <para>The color scheme used by the widget.</para>
  /// </summary>
  /// <param name="scheme">Color scheme of widget.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="scheme"/> is a <c>null</c> reference.</exception>
  /// <exception cref="ArgumentException">If <paramref name="scheme"/> is <see cref="string.Empty"/> string.</exception>
  public IFacebookCommentsWidget ColorScheme(string scheme)
  {
    if (scheme is null) throw new ArgumentNullException(nameof(scheme));
    if (scheme.IsEmpty()) throw new ArgumentException(nameof(scheme));

    ColorSchemeProperty = scheme;

    return this;
  }

  /// <summary>
  ///   <para>The color scheme used by the widget.</para>
  /// </summary>
  /// <returns>Color scheme of widget.</returns>
  public string ColorScheme() => ColorSchemeProperty;

  /// <summary>
  ///   <para>A boolean value that specifies whether to show the mobile-optimized version or not. If not specified, auto-detection is used.</para>
  /// </summary>
  /// <param name="enabled"><c>true</c> to use mobile-optimized version, <c>false</c> otherwise.</param>
  /// <returns>Reference to the current widget.</returns>
  public IFacebookCommentsWidget Mobile(bool enabled) 
  {
    MobileProperty = enabled;
    return this;
  }

  /// <summary>
  ///   <para>A boolean value that specifies whether to show the mobile-optimized version or not. If not specified, auto-detection is used.</para>
  /// </summary>
  /// <returns><c>true</c> to use mobile-optimized version, <c>false</c> otherwise.</returns>
  public bool? Mobile() => MobileProperty;

  /// <summary>
  ///   <para>The order to use when displaying comments.</para>
  /// </summary>
  /// <param name="order">Order of comments.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="order"/> is a <c>null</c> reference.</exception>
  /// <exception cref="ArgumentException">If <paramref name="order"/> is <see cref="string.Empty"/> string.</exception>
  public IFacebookCommentsWidget Order(string order)
  {
    if (order is null) throw new ArgumentNullException(nameof(order));
    if (order.IsEmpty()) throw new ArgumentException(nameof(order));

    OrderProperty = order;

    return this;
  }

  /// <summary>
  ///   <para>The order to use when displaying comments.</para>
  /// </summary>
  /// <returns>Order of comments.</returns>
  public string Order() => OrderProperty;

  /// <summary>
  ///   <para>The number of comments to show by default. The minimum value is 1. Default is 10.</para>
  /// </summary>
  /// <param name="count">Number of comments to show.</param>
  /// <returns>Reference to the current widget.</returns>
  public IFacebookCommentsWidget Posts(byte count)
  {
    PostsProperty = count;
    return this;
  }

  /// <summary>
  ///   <para>The number of comments to show by default. The minimum value is 1. Default is 10.</para>
  /// </summary>
  /// <returns>Number of comments to show.</returns>
  public byte? Posts() => PostsProperty;

  /// <summary>
  ///   <para>The absolute URL that comments posted in the widget will be permanently associated with. Stories on Facebook about comments posted in the plugin will link to this URL. Default is current page URL.</para>
  /// </summary>
  /// <param name="url">URL of the page for comments.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="url"/> is a <c>null</c> reference.</exception>
  /// <exception cref="ArgumentException">If <paramref name="url"/> is <see cref="string.Empty"/> string.</exception>
  public IFacebookCommentsWidget Url(string url)
  {
    if (url is null) throw new ArgumentNullException(nameof(url));
    if (url.IsEmpty()) throw new ArgumentException(nameof(url));

    UrlProperty = url;

    return this;
  }

  /// <summary>
  ///   <para>The absolute URL that comments posted in the widget will be permanently associated with. Stories on Facebook about comments posted in the plugin will link to this URL. Default is current page URL.</para>
  /// </summary>
  /// <returns>URL of the page for comments.</returns>
  public string Url() => UrlProperty;

  /// <summary>
  ///   <para>The width of the widget. The mobile version of the Comments widget ignores the width parameter, and instead has a fluid width of 100%.</para>
  /// </summary>
  /// <param name="width">Width of widget.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="width"/> is a <c>null</c> reference.</exception>
  /// <exception cref="ArgumentException">If <paramref name="width"/> is <see cref="string.Empty"/> string.</exception>
  public IFacebookCommentsWidget Width(string width)
  {
    if (width is null) throw new ArgumentNullException(nameof(width));
    if (width.IsEmpty()) throw new ArgumentException(nameof(width));
      
    WidthProperty = width;

    return this;
  }

  /// <summary>
  ///   <para>The width of the widget. The mobile version of the Comments widget ignores the width parameter, and instead has a fluid width of 100%.</para>
  /// </summary>
  /// <returns>Width of widget.</returns>
  public string Width() => WidthProperty;

  /// <inheritdoc cref="IHtmlContent.ToHtml()"/>
  public override string ToHtml() => new TagBuilder("div")
      .Attribute("data-href", Url())
      .Attribute("data-num-posts", Posts())
      .Attribute("data-width", Width())
      .Attribute("data-colorscheme", ColorScheme())
      .Attribute("data-mobile", Mobile())
      .Attribute("data-order-by", Order())
      .CssClass("fb-comments")
      .ToString();
}