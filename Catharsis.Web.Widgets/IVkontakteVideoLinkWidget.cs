using System;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Renders hyperlink to VKontakte video.</para>
  /// </summary>
  public interface IVkontakteVideoLinkWidget : IVideoLinkWidget<IVkontakteVideoLinkWidget>
  {
    /// <summary>
    ///   <para>Specifies account identifier of video's uploader.</para>
    /// </summary>
    /// <param name="user">User's account.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="user"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="user"/> is <see cref="string.Empty"/> string.</exception>
    /// <remarks>This attribute is required.</remarks>
    IVkontakteVideoLinkWidget User(string user);
  }
}