using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IFacebookPostWidget"/>
public class FacebookPostWidget : WebWidget, IFacebookPostWidget
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string UrlProperty { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string WidthProperty { get; set; }

  /// <inheritdoc cref="IFacebookPostWidget.Url(string)"/>
  public virtual IFacebookPostWidget Url(string url)
  {
    if (url is null) throw new ArgumentNullException(nameof(url));
    if (url.IsEmpty()) throw new ArgumentException(nameof(url));

    UrlProperty = url;
    return this;
  }

  /// <inheritdoc cref="IFacebookPostWidget.Width(string)"/>
  public virtual IFacebookPostWidget Width(string width)
  {
    if (width is null) throw new ArgumentNullException(nameof(width));
    if (width.IsEmpty()) throw new ArgumentException(nameof(width));

    WidthProperty = width;
    return this;
  }

  /// <inheritdoc cref="ICloneable.Clone()"/>
  public override object Clone() => new FacebookPostWidget
  {
    UrlProperty = UrlProperty,
    WidthProperty = WidthProperty
  };

  /// <inheritdoc cref="IWebWidget.ToHtml()"/>
  public override string ToHtml() => UrlProperty.IsUnset() ? string.Empty : new TagBuilder("div")
      .Attribute("data-href", UrlProperty)
      .Attribute("data-width", WidthProperty)
      .CssClass("fb-post")
      .ToString();
}