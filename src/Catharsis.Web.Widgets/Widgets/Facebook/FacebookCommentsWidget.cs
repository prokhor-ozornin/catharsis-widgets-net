using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IFacebookCommentsWidget"/>
public class FacebookCommentsWidget : WebWidget, IFacebookCommentsWidget
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string ColorSchemeValue { get; set; }
  
  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual bool? MobileValue { get; set; }
  
  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string OrderValue { get; set; }
  
  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual byte? PostsValue { get; set; }
  
  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string UrlValue { get; set; }
  
  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string WidthValue { get; set; }

  /// <inheritdoc cref="IFacebookCommentsWidget.ColorScheme(string)"/>
  public virtual IFacebookCommentsWidget ColorScheme(string scheme)
  {
    if (scheme is null) throw new ArgumentNullException(nameof(scheme));
    if (scheme.IsEmpty()) throw new ArgumentException(nameof(scheme));

    ColorSchemeValue = scheme;

    return this;
  }

  /// <inheritdoc cref="IFacebookCommentsWidget.Mobile(bool)"/>
  public virtual IFacebookCommentsWidget Mobile(bool enabled) 
  {
    MobileValue = enabled;
    return this;
  }

  /// <inheritdoc cref="IFacebookCommentsWidget.Order(string)"/>
  public virtual IFacebookCommentsWidget Order(string order)
  {
    if (order is null) throw new ArgumentNullException(nameof(order));
    if (order.IsEmpty()) throw new ArgumentException(nameof(order));

    OrderValue = order;

    return this;
  }

  /// <inheritdoc cref="IFacebookCommentsWidget.Posts(byte)"/>
  public virtual IFacebookCommentsWidget Posts(byte count)
  {
    PostsValue = count;
    return this;
  }

  /// <inheritdoc cref="IFacebookCommentsWidget.Url(string)"/>
  public virtual IFacebookCommentsWidget Url(string url)
  {
    if (url is null) throw new ArgumentNullException(nameof(url));
    if (url.IsEmpty()) throw new ArgumentException(nameof(url));

    UrlValue = url;

    return this;
  }

  /// <inheritdoc cref="IFacebookCommentsWidget.Width(string)"/>
  public virtual IFacebookCommentsWidget Width(string width)
  {
    if (width is null) throw new ArgumentNullException(nameof(width));
    if (width.IsEmpty()) throw new ArgumentException(nameof(width));
      
    WidthValue = width;

    return this;
  }

  /// <inheritdoc cref="ICloneable.Clone()"/>
  public override object Clone() => new FacebookCommentsWidget
  {
    ColorSchemeValue = ColorSchemeValue,
    MobileValue = MobileValue,
    OrderValue = OrderValue,
    PostsValue = PostsValue,
    UrlValue = UrlValue,
    WidthValue = WidthValue
  };

  /// <inheritdoc cref="IWebWidget.ToHtml()"/>
  public override string ToHtml() => new TagBuilder("div")
      .Attribute("data-href", UrlValue)
      .Attribute("data-num-posts", PostsValue)
      .Attribute("data-width", WidthValue)
      .Attribute("data-colorscheme", ColorSchemeValue)
      .Attribute("data-mobile", MobileValue)
      .Attribute("data-order-by", OrderValue)
      .CssClass("fb-comments")
      .ToString();
}