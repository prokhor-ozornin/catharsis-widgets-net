using System;
using System.Collections.Generic;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Renders Yandex social "Share" button.</para>
  /// </summary>
  public interface IYandexSharePanelWidget : IHtmlWidget
  {
    /// <summary>
    ///   <para>Button's interface language.</para>
    /// </summary>
    /// <param name="language">Interface language.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="language"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="language"/> is <see cref="string.Empty"/> string.</exception>
    IYandexSharePanelWidget Language(string language);

    /// <summary>
    ///   <para>Visual layout/appearance of the button.</para>
    /// </summary>
    /// <param name="layout">Layout of button.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="layout"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="layout"/> is <see cref="string.Empty"/> string.</exception>
    IYandexSharePanelWidget Layout(string layout);

    /// <summary>
    ///   <para>List of included social services. Valid names include : [yaru, vkontakte, facebook, twitter, odnoklassniki ,moimir, lj, friendfeed, moikrug, gplus, pinterest, surfingbird].</para>
    /// </summary>
    /// <param name="services">List of social services for which to render buttons.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="services"/> is a <c>null</c> reference.</exception>
    IYandexSharePanelWidget Services(IEnumerable<string> services);
  }
}