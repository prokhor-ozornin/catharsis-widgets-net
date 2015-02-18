using System;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Renders VKontakte Wall Post widget.</para>
  ///   <para>Requires Vkontakte JavaScript initialization to be performed first.</para>
  /// </summary>
  /// <seealso cref="http://vk.com/dev/Post"/>
  public interface IVkontaktePostWidget : IHtmlWidget
  {
    /// <summary>
    ///   <para>Identifier of HTML container for the widget.</para>
    /// </summary>
    /// <param name="id">HTML element's identifier.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="id"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="id"/> is <see cref="string.Empty"/> string.</exception>
    IVkontaktePostWidget ElementId(string id);

    /// <summary>
    ///   <para>Identifier of HTML container for the widget.</para>
    /// </summary>
    /// <returns>HTML element's identifier.</returns>
    string ElementId();

    /// <summary>
    ///   <para>Unique identifier of wall's post.</para>
    /// </summary>
    /// <param name="id">Identifier of post.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="id"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="id"/> is <see cref="string.Empty"/> string.</exception>
    /// <remarks>This attribute is required.</remarks>
    IVkontaktePostWidget Id(string id);

    /// <summary>
    ///   <para>Unique identifier of wall's post.</para>
    /// </summary>
    /// <returns>Identifier of post.</returns>
    string Id();

    /// <summary>
    ///   <para>Unique identifier of Vkontakte wall's owner.</para>
    /// </summary>
    /// <param name="id">Identifier of wall's owner.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="id"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="id"/> is <see cref="string.Empty"/> string.</exception>
    /// <remarks>This attribute is required.</remarks>
    IVkontaktePostWidget Owner(string id);

    /// <summary>
    ///   <para>Unique identifier of Vkontakte wall's owner.</para>
    /// </summary>
    /// <returns>Identifier of wall's owner.</returns>
    string Owner();

    /// <summary>
    ///   <para>Unique hash code of wall's post.</para>
    /// </summary>
    /// <param name="hash">Hash code of post.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="hash"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="hash"/> is <see cref="string.Empty"/> string.</exception>
    /// <remarks>This attribute is required.</remarks>
    IVkontaktePostWidget Hash(string hash);

    /// <summary>
    ///   <para>Unique hash code of wall's post.</para>
    /// </summary>
    /// <returns>Hash code of post.</returns>
    string Hash();

    /// <summary>
    ///   <para>Width of wall's post. Default is the width of entire screen.</para>
    /// </summary>
    /// <param name="width">Width of post.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="width"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="width"/> is <see cref="string.Empty"/> string.</exception>
    IVkontaktePostWidget Width(string width);

    /// <summary>
    ///   <para>Width of wall's post.</para>
    /// </summary>
    /// <returns>Width of post.</returns>
    string Width();
  }
}