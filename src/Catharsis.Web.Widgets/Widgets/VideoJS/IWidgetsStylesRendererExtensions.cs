using System.Web;

namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Set of extension methods for interface <see cref="IWidgetsStylesRenderer"/>.</para>
/// </summary>
/// <seealso cref="IWidgetsStylesRenderer"/>
public static class IWidgetsStylesRendererExtensions
{
  /// <summary>
  ///   <para>Renders required CSS tags for VideoJS widgets.</para>
  /// </summary>
  /// <param name="renderer">CSS code renderer.</param>
  /// <returns>CSS code.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="renderer"/> is a <c>null</c> reference.</exception>
  public static IHtmlString VideoJS(this IWidgetsStylesRenderer renderer)
  {
    if (renderer is null) throw new ArgumentNullException(nameof(renderer));

    return new MvcHtmlString(new TagBuilder("link")
      .Attribute("rel", "stylesheet")
      .Attribute("href", "http://vjs.zencdn.net/4.3/video-js.css")
      .Attribute("type", "text/css")
      .ToString());
  }
}