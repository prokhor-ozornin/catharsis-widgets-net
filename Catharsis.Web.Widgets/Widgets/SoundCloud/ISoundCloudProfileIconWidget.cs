using System;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Renders SoundCloud user's profile icon.</para>
  /// </summary>
  /// <seealso cref="https://soundcloud.com/pages/embed"/>
  public interface ISoundCloudProfileIconWidget : IHtmlWidget
  {
    /// <summary>
    ///   <para>SoundCloud user's account name.</para>
    /// </summary>
    /// <param name="account">Account name.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="account"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="account"/> is <see cref="string.Empty"/> string.</exception>
    /// <remarks>This attribute is required.</remarks>
    ISoundCloudProfileIconWidget Account(string account);

    /// <summary>
    ///   <para>Color of profile icon.</para>
    /// </summary>
    /// <param name="color">Icon's color.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="color"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="color"/> is <see cref="string.Empty"/> string.</exception>
    ISoundCloudProfileIconWidget Color(string color);

    /// <summary>
    ///   <para>Edge size of profile icon in pixels.</para>
    /// </summary>
    /// <param name="size">Icon's size.</param>
    /// <returns>Reference to the current widget.</returns>
    ISoundCloudProfileIconWidget Size(short size);
  }
}