using System;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Renders VKontakte community widget.</para>
  ///   <para>Requires <see cref="WidgetsScripts.VKontakte"/> script to be included.</para>
  ///   <seealso cref="http://vk.com/dev/Community"/>
  /// </summary>
  public interface IVkontakteCommunityWidget : IHtmlWidget
  {
    /// <summary>
    ///   <para>Identifier or VKontakte public group/community.</para>
    /// </summary>
    /// <param name="account">Group identifier.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="account"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="account"/> is <see cref="string.Empty"/> string.</exception>
    /// <remarks>This attribute is required.</remarks>
    IVkontakteCommunityWidget Account(string account);

    /// <summary>
    ///   <para>Vertical height of widget.</para>
    /// </summary>
    /// <param name="height">Height of widget.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="height"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="height"/> is <see cref="string.Empty"/> string.</exception>
    IVkontakteCommunityWidget Height(string height);

    /// <summary>
    ///   <para>Type of information to be displayed about given community.</para>
    /// </summary>
    /// <param name="mode">Community's info type.</param>
    /// <returns>Reference to the current widget.</returns>
    IVkontakteCommunityWidget Mode(byte mode);

    /// <summary>
    ///   <para>Horizontal width of widget.</para>
    /// </summary>
    /// <param name="width">Width of widget.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="width"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="width"/> is <see cref="string.Empty"/> string.</exception>
    IVkontakteCommunityWidget Width(string width);

  }
}