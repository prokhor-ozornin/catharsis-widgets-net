namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Renders Facebook FacePile widget.</para>
///   <para>Requires Facebook JavaScript initialization to be performed first.</para>
/// </summary>
/// <seealso href="https://developers.facebook.com/docs/plugins/facepile"/>
public interface IFacebookFacePileWidget : IWebWidget
{
  /// <summary>
  ///   <para>Collection of Open Graph action types.</para>
  /// </summary>
  /// <param name="actions">Collection of Facebook action types.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="actions"/> is a <c>null</c> reference.</exception>
  IFacebookFacePileWidget Actions(IEnumerable<string> actions);

  /// <summary>
  ///   <para>The color scheme used by the widget. Default is "light".</para>
  /// </summary>
  /// <param name="scheme">Color scheme of widget.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="scheme"/> is a <c>null</c> reference.</exception>
  /// <exception cref="ArgumentException">If <paramref name="scheme"/> is <see cref="string.Empty"/> string.</exception>
  IFacebookFacePileWidget ColorScheme(string scheme);

  /// <summary>
  ///   <para>The height of the widget in pixels.</para>
  /// </summary>
  /// <param name="height">Height of widget.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="height"/> is a <c>null</c> reference.</exception>
  /// <exception cref="ArgumentException">If <paramref name="height"/> is <see cref="string.Empty"/> string.</exception>
  IFacebookFacePileWidget Height(string height);

  /// <summary>
  ///   <para>The maximum number of rows of faces to display. Default is 1.</para>
  /// </summary>
  /// <param name="count">Number of rows of faces to display.</param>
  /// <returns>Reference to the current widget.</returns>
  IFacebookFacePileWidget MaxRows(byte count);

  /// <summary>
  ///   <para>Controls the size of the photos shown in the widget. Default is "medium".</para>
  /// </summary>
  /// <param name="size">Size of photos.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="size"/> is a <c>null</c> reference.</exception>
  /// <exception cref="ArgumentException">If <paramref name="size"/> is <see cref="string.Empty"/> string.</exception>
  IFacebookFacePileWidget PhotoSize(string size);

  /// <summary>
  ///   <para>Display photos of the people who have liked this absolute URL. Default is current page URL.</para>
  /// </summary>
  /// <param name="url">Target "liked" URL.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="url"/> is a <c>null</c> reference.</exception>
  /// <exception cref="ArgumentException">If <paramref name="url"/> is <see cref="string.Empty"/> string.</exception>
  IFacebookFacePileWidget Url(string url);

  /// <summary>
  ///   <para>The width of the widget in pixels. Minimum is 200. Default is 300.</para>
  /// </summary>
  /// <param name="width">Width of widget.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="width"/> is a <c>null</c> reference.</exception>
  /// <exception cref="ArgumentException">If <paramref name="width"/> is <see cref="string.Empty"/> string.</exception>
  IFacebookFacePileWidget Width(string width);
}