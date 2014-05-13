using System;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Renders VKontakte page subscription widget.</para>
  ///   <para>Requires Vkontakte JavaScript initialization to be performed first.</para>
  /// </summary>
  /// <seealso cref="http://vk.com/dev/Subscribe"/>
  public interface IVkontakteSubscriptionWidget : IHtmlWidget
  {
    /// <summary>
    ///   <para>Identifier of user/group to subscribe to.</para>
    /// </summary>
    /// <param name="account">Account to subscribe to.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="account"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="account"/> is <see cref="string.Empty"/> string.</exception>
    /// <remarks>This attribute is required.</remarks>
    IVkontakteSubscriptionWidget Account(string account);

    /// <summary>
    ///   <para>Identifier of user/group to subscribe to.</para>
    /// </summary>
    /// <returns>Account to subscribe to.</returns>
    string Account();

    /// <summary>
    ///   <para>Visual layout/appearance of the button.</para>
    /// </summary>
    /// <param name="layout">Layout of button.</param>
    /// <returns>Reference to the current widget.</returns>
    IVkontakteSubscriptionWidget Layout(byte layout);

    /// <summary>
    ///   <para>Visual layout/appearance of the button.</para>
    /// </summary>
    /// <returns>Layout of button.</returns>
    byte Layout();

    /// <summary>
    ///   <para>Whether to display both author and button or button only.</para>
    /// </summary>
    /// <param name="onlyButton"><c>false</c> to display both author/button, <c>true</c> to display only button.</param>
    /// <returns>Reference to the current widget.</returns>
    IVkontakteSubscriptionWidget OnlyButton(bool onlyButton);

    /// <summary>
    ///   <para>Whether to display both author and button or button only.</para>
    /// </summary>
    /// <returns><c>false</c> to display both author/button, <c>true</c> to display only button.</returns>
    bool OnlyButton();
  }
}