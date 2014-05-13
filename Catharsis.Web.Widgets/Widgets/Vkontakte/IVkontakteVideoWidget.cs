using System;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Renders embedded VKontakte video on web page.</para>
  /// </summary>
  public interface IVkontakteVideoWidget : IVideoWidget<IVkontakteVideoWidget>
  {
    /// <summary>
    ///   <para>Hash code of video.</para>
    /// </summary>
    /// <param name="hash">Video's hash code.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="hash"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="hash"/> is <see cref="string.Empty"/> string.</exception>
    IVkontakteVideoWidget Hash(string hash);

    /// <summary>
    ///   <para>Hash code of video.</para>
    /// </summary>
    /// <returns>Video's hash code.</returns>
    string Hash();

    /// <summary>
    ///   <para>Whether to play video in High Definition format. Default is <c>false</c>.</para>
    /// </summary>
    /// <param name="enabled"><c>true</c> to use HD quality format, <c>false</c> to use standard quality.</param>
    /// <returns>Reference to the current widget.</returns>
    IVkontakteVideoWidget Hd(bool enabled);

    /// <summary>
    ///   <para>Whether to play video in High Definition format. Default is <c>false</c>.</para>
    /// </summary>
    /// <returns><c>true</c> to use HD quality format, <c>false</c> to use standard quality.</returns>
    bool Hd();

    /// <summary>
    ///   <para>Account identifier of video's uploader.</para>
    /// </summary>
    /// <param name="user">User's account.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="user"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="user"/> is <see cref="string.Empty"/> string.</exception>
    IVkontakteVideoWidget User(string user);

    /// <summary>
    ///   <para>Account identifier of video's uploader.</para>
    /// </summary>
    /// <returns>User's account.</returns>
    string User();
  }
}