namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Renders VKontakte comments widget.</para>
///   <para>Requires Vkontakte JavaScript initialization to be performed first.</para>
/// </summary>
/// <seealso cref="http://vk.com/dev/Comments"/>
public interface IVkontakteCommentsWidget : IWebWidget
{
  /// <summary>
  ///   <para>Collection of attachment types, which are allowed in comment posts.</para>
  /// </summary>
  /// <param name="types">Allowed types of post attachments.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="types"/> is a <c>null</c> reference.</exception>
  IVkontakteCommentsWidget Attach(params string[] types);

  /// <summary>
  ///   <para>Whether to automatically publish user's comment to his status. Default is <c>true</c>.</para>
  /// </summary>
  /// <param name="enabled"><c>true</c> to enable auto-publishing, <c>false</c> to disable it.</param>
  /// <returns>Reference to the current widget.</returns>
  IVkontakteCommentsWidget AutoPublish(bool enabled);

  /// <summary>
  ///   <para>Whether to automatically publish user's comment to his status. Default is <c>true</c>.</para>
  /// </summary>
  /// <param name="enabled"><c>true</c> to enable auto-publishing, <c>false</c> to disable it.</param>
  /// <returns>Reference to the current widget.</returns>
  IVkontakteCommentsWidget AutoUpdate(bool enabled);

  /// <summary>
  ///   <para>Identifier of HTML container for the widget.</para>
  /// </summary>
  /// <param name="id">HTML element's identifier.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="id"/> is a <c>null</c> reference.</exception>
  /// <exception cref="ArgumentException">If <paramref name="id"/> is <see cref="string.Empty"/> string.</exception>
  IVkontakteCommentsWidget ElementId(string id);

  /// <summary>
  ///   <para>Maximum number of comments to display.</para>
  /// </summary>
  /// <param name="limit">Maximum number of comments.</param>
  /// <returns>Reference to the current widget.</returns>
  IVkontakteCommentsWidget Limit(byte limit);

  /// <summary>
  ///   <para>Whether to use minimalistic mode of widget (small fonts, images, etc.). Default is to use auto mode (determine automatically).</para>
  /// </summary>
  /// <param name="enabled"><c>true</c> to enable minimalistic mode, <c>false</c> to disable it.</param>
  /// <returns>Reference to the current widget.</returns>
  IVkontakteCommentsWidget Mini(bool? enabled);

  /// <summary>
  ///   <para>Horizontal width of comment area.</para>
  /// </summary>
  /// <param name="width">Width of comments widget.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="width"/> is a <c>null</c> reference.</exception>
  /// <exception cref="ArgumentException">If <paramref name="width"/> is <see cref="string.Empty"/> string.</exception>
  IVkontakteCommentsWidget Width(string width);
}