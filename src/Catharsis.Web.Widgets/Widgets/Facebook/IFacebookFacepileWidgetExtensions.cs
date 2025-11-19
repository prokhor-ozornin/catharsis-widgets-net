using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Set of extension methods for interface <see cref="IFacebookFacePileWidget"/>.</para>
/// </summary>
/// <seealso cref="IFacebookFacePileWidget"/>
public static class IFacebookFacePileWidgetExtensions
{
  /// <param name="widget">Widget to call method on.</param>
  extension(IFacebookFacePileWidget widget)
  {
    /// <summary>
    ///   <para>Collection of Open Graph action types.</para>
    /// </summary>
    /// <param name="actions">Collection of Facebook action types.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="IFacebookFacePileWidget.Actions(IEnumerable{string})"/>
    public IFacebookFacePileWidget Actions(params string[] actions) => widget?.Actions(actions) ?? throw new ArgumentNullException(nameof(widget));

    /// <summary>
    ///   <para>Controls the size of the photos shown in the widget.</para>
    /// </summary>
    /// <param name="size">Size of photos.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="IFacebookFacePileWidget.PhotoSize(string)"/>
    public IFacebookFacePileWidget PhotoSize(FacebookFacePilePhotoSize size) => widget?.PhotoSize(size.ToString().ToLowerInvariant()) ?? throw new ArgumentNullException(nameof(widget));

    /// <summary>
    ///   <para></para>
    /// </summary>
    /// <param name="url"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentNullException">Если параметр <paramref name="widget"/> является <see langword="null"/> ссылкой.</exception>
    public IFacebookFacePileWidget Url(Uri url) => widget?.Url(url?.ToString()) ?? throw new ArgumentNullException(nameof(widget));

    /// <summary>
    ///   <para>The width of the widget in pixels.</para>
    /// </summary>
    /// <param name="width">Width of widget.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="IFacebookFacePileWidget.Width(string)"/>
    public IFacebookFacePileWidget Width(short width) => widget?.Width(width.ToInvariantString()) ?? throw new ArgumentNullException(nameof(widget));

    /// <summary>
    ///   <para>The height of the widget in pixels.</para>
    /// </summary>
    /// <param name="height">Height of widget.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="IFacebookFacePileWidget.Height(string)"/>
    public IFacebookFacePileWidget Height(short height) => widget?.Height(height.ToInvariantString()) ?? throw new ArgumentNullException(nameof(widget));

    /// <summary>
    ///   <para>The color scheme used by the widget.</para>
    /// </summary>
    /// <param name="scheme">Color scheme of widget.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="widget"/> is a <c>null</c> reference.</exception>
    /// <seealso cref="IFacebookFacePileWidget.ColorScheme(string)"/>
    public IFacebookFacePileWidget ColorScheme(FacebookColorScheme scheme) => widget?.ColorScheme(scheme.ToString().ToLowerInvariant()) ?? throw new ArgumentNullException(nameof(widget));
  }
}