using System.Web.Mvc;

namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Set of extension methods for class <see cref="HtmlHelper"/>.</para>
/// </summary>
/// <seealso cref="HtmlHelper"/>
public static partial class HtmlHelperExtensions
{
  private static ISoundCloudHtmlHelper soundcloud;

  /// <summary>
  ///   <para>Initializes HTML helper object for rendering of SoundCloud widgets.</para>
  /// </summary>
  /// <param name="html">Helper object to call method on.</param>
  /// <returns>Widgets factory helper.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="html"/> is a <c>null</c> reference.</exception>
  public static ISoundCloudHtmlHelper SoundCloud(this HtmlHelper html) => html is not null ? soundcloud ??= new SoundCloudHtmlHelper() : throw new ArgumentNullException(nameof(html));
}