using Catharsis.Extensions;


namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Set of extension methods for interface <see cref="IFacebookPostWidget"/>.</para>
/// </summary>
/// <seealso cref="IFacebookPostWidget"/>
public static class IFacebookPostWidgetExtensions
{
  /// <param name="widget">Widget to call method on.</param>
  extension(IFacebookPostWidget widget)
  {
    /// <summary>
    ///   <para></para>
    /// </summary>
    /// <param name="url"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentNullException">Если параметр <paramref name="widget"/> является <see langword="null"/> ссылкой.</exception>
    public IFacebookPostWidget Url(Uri url) => widget?.Url(url?.ToString()) ?? throw new ArgumentNullException(nameof(widget));

    /// <summary>
    ///   <para>Specifies width of Facebook post area on page.</para>
    /// </summary>
    /// <param name="width">Width of post.</param>
    /// <returns>Reference to provided <paramref name="widget"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="IFacebookPostWidget.Width(string)"/>
    public IFacebookPostWidget Width(short width) => widget?.Width(width.ToInvariantString()) ?? throw new ArgumentNullException(nameof(widget));
  }
}