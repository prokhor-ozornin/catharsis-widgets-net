namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Set of extension methods for interface <see cref="IWidgetsStylesRenderer"/>.</para>
/// </summary>
/// <seealso cref="IWidgetsStylesRenderer"/>
public static class IWidgetsStylesRendererExtensions
{
  /// <param name="renderer">CSS code renderer.</param>
  extension(IWidgetsStylesRenderer renderer)
  {
    /// <summary>
    ///   <para>Renders required CSS tags for VideoJS widgets.</para>
    /// </summary>
    /// <returns>CSS code.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="renderer"/> is a <c>null</c> reference.</exception>
    public string VideoJS() => renderer is not null ?
      new TagBuilder("link")
        .Attribute("rel", "stylesheet")
        .Attribute("href", "http://vjs.zencdn.net/4.3/video-js.css")
        .Attribute("type", "text/css")
        .ToString()
      : throw new ArgumentNullException(nameof(renderer));
  }
}