using System;
using System.Collections.Generic;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Renders Facebook Facepile widget.</para>
  ///   <para>Requires Facebook JavaScript initialization to be performed first.</para>
  /// </summary>
  /// <seealso cref="https://developers.facebook.com/docs/plugins/facepile"/>
  public interface IFacebookFacepileWidget : IHtmlWidget
  {
    /// <summary>
    ///   <para>Collection of Open Graph action types.</para>
    /// </summary>
    /// <param name="actions">Collection of Facebook action types.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="actions"/> is a <c>null</c> reference.</exception>
    IFacebookFacepileWidget Actions(IEnumerable<string> actions);

    /// <summary>
    ///   <para>Collection of Open Graph action types.</para>
    /// </summary>
    /// <returns>Collection of Facebook action types.</returns>
    IEnumerable<string> Actions();

    /// <summary>
    ///   <para>The color scheme used by the widget. Default is "light".</para>
    /// </summary>
    /// <param name="colorScheme">Color scheme of widget.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="colorScheme"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="colorScheme"/> is <see cref="string.Empty"/> string.</exception>
    IFacebookFacepileWidget ColorScheme(string colorScheme);

    /// <summary>
    ///   <para>The color scheme used by the widget. Default is "light".</para>
    /// </summary>
    /// <returns>Color scheme of widget.</returns>
    string ColorScheme();

    /// <summary>
    ///   <para>The height of the widget in pixels.</para>
    /// </summary>
    /// <param name="height">Height of widget.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="height"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="height"/> is <see cref="string.Empty"/> string.</exception>
    IFacebookFacepileWidget Height(string height);

    /// <summary>
    ///   <para>The height of the widget in pixels.</para>
    /// </summary>
    /// <returns>Height of widget.</returns>
    string Height();

    /// <summary>
    ///   <para>The maximum number of rows of faces to display. Default is 1.</para>
    /// </summary>
    /// <param name="maxRows">Number of rows of faces to display.</param>
    /// <returns>Reference to the current widget.</returns>
    IFacebookFacepileWidget MaxRows(byte maxRows);

    /// <summary>
    ///   <para>The maximum number of rows of faces to display. Default is 1.</para>
    /// </summary>
    /// <returns>Number of rows of faces to display.</returns>
    byte? MaxRows();

    /// <summary>
    ///   <para>Controls the size of the photos shown in the widget. Default is "medium".</para>
    /// </summary>
    /// <param name="size">Size of photos.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="size"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="size"/> is <see cref="string.Empty"/> string.</exception>
    IFacebookFacepileWidget PhotoSize(string size);

    /// <summary>
    ///   <para>Controls the size of the photos shown in the widget. Default is "medium".</para>
    /// </summary>
    /// <returns>Size of photos.</returns>
    string PhotoSize();

    /// <summary>
    ///   <para>Display photos of the people who have liked this absolute URL. Default is current page URL.</para>
    /// </summary>
    /// <param name="url">Target "liked" URL.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="url"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="url"/> is <see cref="string.Empty"/> string.</exception>
    IFacebookFacepileWidget Url(string url);

    /// <summary>
    ///   <para>Display photos of the people who have liked this absolute URL. Default is current page URL.</para>
    /// </summary>
    /// <returns>Target "liked" URL.</returns>
    string Url();

    /// <summary>
    ///   <para>The width of the widget in pixels. Minimum is 200. Default is 300.</para>
    /// </summary>
    /// <param name="width">Width of widget.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="width"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="width"/> is <see cref="string.Empty"/> string.</exception>
    IFacebookFacepileWidget Width(string width);

    /// <summary>
    ///   <para>The width of the widget in pixels. Minimum is 200. Default is 300.</para>
    /// </summary>
    /// <returns>Width of widget.</returns>
    string Width();
  }
}