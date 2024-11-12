using System.Web.Mvc;
using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IFacebookPostWidget"/>
public class FacebookPostWidget : HtmlWidget, IFacebookPostWidget
{
  private string url;
  private string width;

  /// <summary>
  ///   <para>Specified URL address of Facebook post to embed.</para>
  /// </summary>
  /// <param name="url">URL of Facebook post.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="url"/> is a <c>null</c> reference.</exception>
  /// <exception cref="ArgumentException">If <paramref name="url"/> is <see cref="string.Empty"/> string.</exception>
  /// <remarks>This attribute is required.</remarks>
  public IFacebookPostWidget Url(string url)
  {
    if (url is null) throw new ArgumentNullException(nameof(url));
    if (url.IsEmpty()) throw new ArgumentException(nameof(url));

    this.url = url;
    return this;
  }

  /// <summary>
  ///   <para>Specified URL address of Facebook post to embed.</para>
  /// </summary>
  /// <returns>URL of Facebook post.</returns>
  public string Url() => url;

  /// <summary>
  ///   <para>Specifies width of Facebook post area on page.</para>
  /// </summary>
  /// <param name="width">Width of post.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="width"/> is a <c>null</c> reference.</exception>
  /// <exception cref="ArgumentException">If <paramref name="width"/> is <see cref="string.Empty"/> string.</exception>
  public IFacebookPostWidget Width(string width)
  {
    if (width is null) throw new ArgumentNullException(nameof(width));
    if (width.IsEmpty()) throw new ArgumentException(nameof(width));

    this.width = width;
    return this;
  }

  /// <summary>
  ///   <para>Specifies width of Facebook post area on page.</para>
  /// </summary>
  /// <returns>Width of post.</returns>
  public string Width() => width;

  /// <inheritdoc cref="IHtmlWidget.ToHtmlString()"/>
  public override string ToHtmlString()
  {
    if (Url().IsEmpty())
    {
      return string.Empty;
    }

    return new TagBuilder("div")
      .Attribute("data-href", Url())
      .Attribute("data-width", Width())
      .CssClass("fb-post")
      .ToString();
  }
}