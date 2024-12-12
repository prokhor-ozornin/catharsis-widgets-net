using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IFacebookPostWidget"/>
public class FacebookPostWidget : WebWidget, IFacebookPostWidget
{
  private string url;
  private string width;

  /// <inheritdoc cref="IFacebookPostWidget.Url(string)"/>
  public IFacebookPostWidget Url(string url)
  {
    if (url is null) throw new ArgumentNullException(nameof(url));
    if (url.IsEmpty()) throw new ArgumentException(nameof(url));

    this.url = url;
    return this;
  }

  /// <inheritdoc cref="IFacebookPostWidget.Url()"/>
  public string Url() => url;

  /// <inheritdoc cref="IFacebookPostWidget.Width(string)"/>
  public IFacebookPostWidget Width(string width)
  {
    if (width is null) throw new ArgumentNullException(nameof(width));
    if (width.IsEmpty()) throw new ArgumentException(nameof(width));

    this.width = width;
    return this;
  }

  /// <inheritdoc cref="IFacebookPostWidget.Width()"/>
  public string Width() => width;

  /// <inheritdoc cref="IHtmlContent.ToHtml()"/>
  public override string ToHtml() => Url().IsEmpty() ? string.Empty : new TagBuilder("div")
      .Attribute("data-href", Url())
      .Attribute("data-width", Width())
      .CssClass("fb-post")
      .ToString();
}