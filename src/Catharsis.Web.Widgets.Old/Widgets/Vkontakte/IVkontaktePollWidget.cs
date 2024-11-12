using System;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Renders Vkontakte Poll widget.</para>
  ///   <para>Requires Vkontakte JavaScript initialization to be performed first.</para>
  /// </summary>
  /// <seealso cref="http://vk.com/dev/Poll"/>
  public interface IVkontaktePollWidget : IHtmlWidget
  {
    /// <summary>
    ///   <para>Unique identifier of poll.</para>
    /// </summary>
    /// <param name="id">Identifier of poll.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="id"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="id"/> is <see cref="string.Empty"/> string.</exception>
    /// <remarks>This attribute is required.</remarks>
    IVkontaktePollWidget Id(string id);

    /// <summary>
    ///   <para>Unique identifier of poll.</para>
    /// </summary>
    /// <returns>Identifier of poll.</returns>
    string Id();

    /// <summary>
    ///   <para>Identifier of HTML container for the widget.</para>
    /// </summary>
    /// <param name="id">HTML element's identifier.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="id"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="id"/> is <see cref="string.Empty"/> string.</exception>
    IVkontaktePollWidget ElementId(string id);

    /// <summary>
    ///   <para>Identifier of HTML container for the widget.</para>
    /// </summary>
    /// <returns>HTML element's identifier.</returns>
    string ElementId();

    /// <summary>
    ///   <para>Horizontal width of widget.</para>
    /// </summary>
    /// <param name="width">Width of widget.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="width"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="width"/> is <see cref="string.Empty"/> string.</exception>
    IVkontaktePollWidget Width(string width);

    /// <summary>
    ///   <para>Horizontal width of widget.</para>
    /// </summary>
    /// <returns>Width of widget.</returns>
    string Width();

    /// <summary>
    ///   <para>URL address of poll's web page, if it differs from the current one.</para>
    /// </summary>
    /// <param name="url">Poll's web page URL.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="url"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="url"/> is <see cref="string.Empty"/> string.</exception>
    IVkontaktePollWidget Url(string url);

    /// <summary>
    ///   <para>URL address of poll's web page, if it differs from the current one.</para>
    /// </summary>
    /// <returns>Poll's web page URL.</returns>
    string Url();
  }
}