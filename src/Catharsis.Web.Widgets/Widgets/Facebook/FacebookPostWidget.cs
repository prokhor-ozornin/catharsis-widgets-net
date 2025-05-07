using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IFacebookPostWidget"/>
public class FacebookPostWidget : WebWidget, IFacebookPostWidget
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string UrlValue { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string WidthValue { get; set; }

  /// <inheritdoc cref="IFacebookPostWidget.Url(string)"/>
  public virtual IFacebookPostWidget Url(string url)
  {
    if (url is null) throw new ArgumentNullException(nameof(url));
    if (url.IsEmpty()) throw new ArgumentException(nameof(url));

    UrlValue = url;
    return this;
  }

  /// <inheritdoc cref="IFacebookPostWidget.Width(string)"/>
  public virtual IFacebookPostWidget Width(string width)
  {
    if (width is null) throw new ArgumentNullException(nameof(width));
    if (width.IsEmpty()) throw new ArgumentException(nameof(width));

    WidthValue = width;
    return this;
  }

  /// <inheritdoc cref="ICloneable.Clone()"/>
  public override object Clone() => new FacebookPostWidget
  {
    UrlValue = UrlValue,
    WidthValue = WidthValue
  };

  /// <inheritdoc cref="IWebWidget.ToHtml()"/>
  public override string ToHtml() => UrlValue.IsUnset() ? string.Empty : new TagBuilder("div")
      .Attribute("data-href", UrlValue)
      .Attribute("data-width", WidthValue)
      .CssClass("fb-post")
      .ToString();
}