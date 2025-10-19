namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Renders VKontakte page subscription widget.</para>
///   <para>Requires Vkontakte JavaScript initialization to be performed first.</para>
/// </summary>
/// <seealso href="http://vk.com/dev/Subscribe"/>
public interface IVkontakteSubscriptionWidget : IWebWidget
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
  ///   <para>Identifier of HTML container for the widget.</para>
  /// </summary>
  /// <param name="id">HTML element's identifier.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="id"/> is a <c>null</c> reference.</exception>
  /// <exception cref="ArgumentException">If <paramref name="id"/> is <see cref="string.Empty"/> string.</exception>
  IVkontakteSubscriptionWidget ElementId(string id);

  /// <summary>
  ///   <para>Visual layout/appearance of the button.</para>
  /// </summary>
  /// <param name="layout">Layout of button.</param>
  /// <returns>Reference to the current widget.</returns>
  IVkontakteSubscriptionWidget Layout(byte layout);

  /// <summary>
  ///   <para>Whether to display both author and button or button only.</para>
  /// </summary>
  /// <param name="enabled"><c>false</c> to display both author/button, <c>true</c> to display only button.</param>
  /// <returns>Reference to the current widget.</returns>
  IVkontakteSubscriptionWidget OnlyButton(bool enabled);
}