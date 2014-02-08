using System;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Renders embedded Facebook post on web page.</para>
  ///   <para>Requires Facebook JavaScript initialization to be performed first.</para>
  ///   <seealso cref="https://developers.facebook.com/docs/plugins/embedded-posts"/>
  /// </summary>
  public interface IFacebookPostWidget : IHtmlWidget
  {
    /// <summary>
    ///   <para>Specified URL address of Facebook post to embed.</para>
    /// </summary>
    /// <param name="url">URL of Facebook post.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="url"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="url"/> is <see cref="string.Empty"/> string.</exception>
    /// <remarks>This attribute is required.</remarks>
    IFacebookPostWidget Url(string url);

    /// <summary>
    ///   <para>Specifies width of Facebook post area on page.</para>
    /// </summary>
    /// <param name="width">Width of post.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="width"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="width"/> is <see cref="string.Empty"/> string.</exception>
    IFacebookPostWidget Width(string width);
  }
}