using System;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Renders hyperlink to Yandex video.</para>
  /// </summary>
  public interface IYandexVideoLinkWidget : IVideoLinkWidget<IYandexVideoLinkWidget>
  {
    /// <summary>
    ///   <para>Whether to create link for playing High Definition video. Default is <c>false</c>.</para>
    /// </summary>
    /// <param name="highQuality"><c>true</c> to use HD quality format, <c>false</c> to use standard quality.</param>
    /// <returns>Reference to the current widget.</returns>
    IYandexVideoLinkWidget HighQuality(bool highQuality = true);

    /// <summary>
    ///   <para>Account identifier of video's uploader.</para>
    /// </summary>
    /// <param name="user">User's account identifier.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="user"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="user"/> is <see cref="string.Empty"/> string.</exception>
    IYandexVideoLinkWidget User(string user);
  }
}