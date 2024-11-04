using System;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Renders VKontakte OAuth button widget.</para>
  ///   <para>Requires Vkontakte JavaScript initialization to be performed first.</para>
  /// </summary>
  /// <seealso cref="http://vk.com/dev/Auth"/>
  public interface IVkontakteAuthButtonWidget : IHtmlWidget
  {
    /// <summary>
    ///   <para>Identifier of HTML container for the widget.</para>
    /// </summary>
    /// <param name="id">HTML element's identifier.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="id"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="id"/> is <see cref="string.Empty"/> string.</exception>
    IVkontakteAuthButtonWidget ElementId(string id);

    /// <summary>
    ///   <para>Identifier of HTML container for the widget.</para>
    /// </summary>
    /// <returns>HTML element's identifier.</returns>
    string ElementId();

    /// <summary>
    ///   <para>Horizontal width of button.</para>
    /// </summary>
    /// <param name="width">Width of button.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="width"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="width"/> is <see cref="string.Empty"/> string.</exception>
    IVkontakteAuthButtonWidget Width(string width);

    /// <summary>
    ///   <para>Horizontal width of button.</para>
    /// </summary>
    /// <returns>Width of button.</returns>
    string Width();

    /// <summary>
    ///   <para>URL address of web page to be redirected to, if using standard mode.</para>
    /// </summary>
    /// <param name="url">Target URL web page.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="url"/> is <see cref="string.Empty"/> string.</exception>
    /// <exception cref="ArgumentException">If <paramref name="url"/> is <see cref="string.Empty"/> string.</exception>
    IVkontakteAuthButtonWidget Url(string url);

    /// <summary>
    ///   <para>URL address of web page to be redirected to, if using standard mode.</para>
    /// </summary>
    /// <returns>Target URL web page.</returns>
    string Url();

    /// <summary>
    ///   <para>Type of authentication mode to use.</para>
    /// </summary>
    /// <param name="type">Authentication mode.</param>
    /// <returns>Reference to the current widget.</returns>
    IVkontakteAuthButtonWidget Type(VkontakteAuthButtonType type);

    /// <summary>
    ///   <para>Type of authentication mode to use.</para>
    /// </summary>
    /// <returns>Authentication mode.</returns>
    VkontakteAuthButtonType Type();

    /// <summary>
    ///   <para>Name of JavaScript function to be called after successful authentication, if using dynamic mode.</para>
    /// </summary>
    /// <param name="callback"></param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="callback"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="callback"/> is <see cref="string.Empty"/> string.</exception>
    IVkontakteAuthButtonWidget Callback(string callback);

    /// <summary>
    ///   <para>Name of JavaScript function to be called after successful authentication, if using dynamic mode.</para>
    /// </summary>
    /// <returns>JavaScript callback function.</returns>
    string Callback();
  }
}