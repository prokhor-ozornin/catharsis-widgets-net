using System;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Renders Facebook Like Box.</para>
  ///   <para>Requires Facebook JavaScript initialization to be performed first.</para>
  ///   <seealso cref="https://developers.facebook.com/docs/plugins/like-box-for-pages"/>
  /// </summary>
  public interface IFacebookLikeBoxWidget : IHtmlWidget
  {
    /// <summary>
    ///   <para>The absolute URL of the Facebook Page that will be liked.</para>
    /// </summary>
    /// <param name="url">URL of target web page.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="url"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="url"/> is <see cref="string.Empty"/> string.</exception>
    /// <remarks>This attribute is required.</remarks>
    IFacebookLikeBoxWidget Url(string url);

    /// <summary>
    ///   <para>The width of the widget in pixels. Minimum is 292. Default is 300.</para>
    /// </summary>
    /// <param name="width">Width of button.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="width"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="width"/> is <see cref="string.Empty"/> string.</exception>
    IFacebookLikeBoxWidget Width(string width);

    /// <summary>
    ///   <para>The height of the widget in pixels. The default height varies based on number of faces to display, and whether the stream is displayed. With stream set to true and 10 photos displayed (via showFaces) the default height is 556px. With stream and show_faces both false, the default height is 63px.</para>
    /// </summary>
    /// <param name="height">Height of widget.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="height"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="height"/> is <see cref="string.Empty"/> string.</exception>
    IFacebookLikeBoxWidget Height(string height);

    /// <summary>
    ///   <para>The color scheme used by the widget. Default is "light".</para>
    /// </summary>
    /// <param name="colorScheme">Color scheme of widget.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="colorScheme"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="colorScheme"/> is <see cref="string.Empty"/> string.</exception>
    IFacebookLikeBoxWidget ColorScheme(string colorScheme);

    /// <summary>
    ///   <para>For "place" Pages (Pages that have a physical location that can be used with check-ins), this specifies whether the stream contains posts by the Page or just check-ins from friends. Default is <c>false</c>.</para>
    /// </summary>
    /// <param name="wall"><c>true</c> to include page's posts in the stream, <c>false</c> to exclude.</param>
    /// <returns>Reference to the current widget.</returns>
    IFacebookLikeBoxWidget Wall(bool wall = true);

    /// <summary>
    ///   <para>Specifies whether to display the Facebook header at the top of the widget. Default is <c>true</c>.</para>
    /// </summary>
    /// <param name="header"><c>true</c> to show header, <c>false</c> to hide.</param>
    /// <returns>Reference to the current widget.</returns>
    IFacebookLikeBoxWidget Header(bool header = true);

    /// <summary>
    ///   <para>Specifies whether or not to show a border around the plugin. Default is <c>true</c>.</para>
    /// </summary>
    /// <param name="border"><c>true</c> to show border, <c>false</c> to hide.</param>
    /// <returns>Reference to the current widget.</returns>
    IFacebookLikeBoxWidget Border(bool border = true);

    /// <summary>
    ///   <para>Specifies whether to display profile photos of people who like the page. Default is <c>true</c>.</para>
    /// </summary>
    /// <param name="faces"><c>true</c> to show profile photos, <c>false</c> to hide.</param>
    /// <returns>Reference to the current widget.</returns>
    IFacebookLikeBoxWidget Faces(bool faces = true);

    /// <summary>
    ///   <para>Specifies whether to display a stream of the latest posts by the Page. Default is <c>true</c>.</para>
    /// </summary>
    /// <param name="stream"><c>true</c> to show stream of posts, <c>false</c> to hide.</param>
    /// <returns>Reference to the current widget.</returns>
    IFacebookLikeBoxWidget Stream(bool stream = true);
  }
}