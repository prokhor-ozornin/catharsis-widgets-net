using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IFacebookCommentsWidget"/>
public class FacebookCommentsWidget : WebWidget, IFacebookCommentsWidget
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string ColorSchemeProperty { get; set; }
  
  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual bool? MobileProperty { get; set; }
  
  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string OrderProperty { get; set; }
  
  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual byte? PostsProperty { get; set; }
  
  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string UrlProperty { get; set; }
  
  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string WidthProperty { get; set; }

  /// <summary>
  ///   <para>The color scheme used by the widget.</para>
  /// </summary>
  /// <param name="scheme">Color scheme of widget.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="scheme"/> is a <c>null</c> reference.</exception>
  /// <exception cref="ArgumentException">If <paramref name="scheme"/> is <see cref="string.Empty"/> string.</exception>
  public virtual IFacebookCommentsWidget ColorScheme(string scheme)
  {
    if (scheme is null) throw new ArgumentNullException(nameof(scheme));
    if (scheme.IsEmpty()) throw new ArgumentException(nameof(scheme));

    ColorSchemeProperty = scheme;

    return this;
  }

 /// <summary>
  ///   <para>A boolean value that specifies whether to show the mobile-optimized version or not. If not specified, auto-detection is used.</para>
  /// </summary>
  /// <param name="enabled"><c>true</c> to use mobile-optimized version, <c>false</c> otherwise.</param>
  /// <returns>Reference to the current widget.</returns>
  public virtual IFacebookCommentsWidget Mobile(bool enabled) 
  {
    MobileProperty = enabled;
    return this;
  }

  /// <summary>
  ///   <para>The order to use when displaying comments.</para>
  /// </summary>
  /// <param name="order">Order of comments.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="order"/> is a <c>null</c> reference.</exception>
  /// <exception cref="ArgumentException">If <paramref name="order"/> is <see cref="string.Empty"/> string.</exception>
  public virtual IFacebookCommentsWidget Order(string order)
  {
    if (order is null) throw new ArgumentNullException(nameof(order));
    if (order.IsEmpty()) throw new ArgumentException(nameof(order));

    OrderProperty = order;

    return this;
  }

  /// <summary>
  ///   <para>The number of comments to show by default. The minimum value is 1. Default is 10.</para>
  /// </summary>
  /// <param name="count">Number of comments to show.</param>
  /// <returns>Reference to the current widget.</returns>
  public virtual IFacebookCommentsWidget Posts(byte count)
  {
    PostsProperty = count;
    return this;
  }

  /// <summary>
  ///   <para>The absolute URL that comments posted in the widget will be permanently associated with. Stories on Facebook about comments posted in the plugin will link to this URL. Default is current page URL.</para>
  /// </summary>
  /// <param name="url">URL of the page for comments.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="url"/> is a <c>null</c> reference.</exception>
  /// <exception cref="ArgumentException">If <paramref name="url"/> is <see cref="string.Empty"/> string.</exception>
  public virtual IFacebookCommentsWidget Url(string url)
  {
    if (url is null) throw new ArgumentNullException(nameof(url));
    if (url.IsEmpty()) throw new ArgumentException(nameof(url));

    UrlProperty = url;

    return this;
  }

  /// <summary>
  ///   <para>The width of the widget. The mobile version of the Comments widget ignores the width parameter, and instead has a fluid width of 100%.</para>
  /// </summary>
  /// <param name="width">Width of widget.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="width"/> is a <c>null</c> reference.</exception>
  /// <exception cref="ArgumentException">If <paramref name="width"/> is <see cref="string.Empty"/> string.</exception>
  public virtual IFacebookCommentsWidget Width(string width)
  {
    if (width is null) throw new ArgumentNullException(nameof(width));
    if (width.IsEmpty()) throw new ArgumentException(nameof(width));
      
    WidthProperty = width;

    return this;
  }

  /// <inheritdoc cref="ICloneable.Clone()"/>
  public override object Clone() => new FacebookCommentsWidget { };

  /// <inheritdoc cref="IWebWidget.ToHtml()"/>
  public override string ToHtml() => new TagBuilder("div")
      .Attribute("data-href", UrlProperty)
      .Attribute("data-num-posts", PostsProperty)
      .Attribute("data-width", WidthProperty)
      .Attribute("data-colorscheme", ColorSchemeProperty)
      .Attribute("data-mobile", MobileProperty)
      .Attribute("data-order-by", OrderProperty)
      .CssClass("fb-comments")
      .ToString();
}