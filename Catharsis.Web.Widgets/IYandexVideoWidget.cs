using System;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Renders embedded Yandex video on web page.</para>
  /// </summary>
  public interface IYandexVideoWidget : IVideoWidget<IYandexVideoWidget>
  {
    /// <summary>
    ///   <para>Specifies account identifier of video's uploader.</para>
    /// </summary>
    /// <param name="user">User's account identifier.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="user"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="user"/> is <see cref="string.Empty"/> string.</exception>
    IYandexVideoWidget User(string user);
  }
}