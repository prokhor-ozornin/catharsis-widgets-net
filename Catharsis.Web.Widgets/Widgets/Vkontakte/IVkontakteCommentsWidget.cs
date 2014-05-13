using System;
using System.Collections.Generic;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Renders VKontakte comments widget.</para>
  ///   <para>Requires Vkontakte JavaScript initialization to be performed first.</para>
  /// </summary>
  /// <seealso cref="http://vk.com/dev/Comments"/>
  public interface IVkontakteCommentsWidget : IHtmlWidget
  {
    /// <summary>
    ///   <para>Collection of attachment types, which are allowed in comment posts.</para>
    /// </summary>
    /// <param name="types">Allowed types of post attachments.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="types"/> is a <c>null</c> reference.</exception>
    IVkontakteCommentsWidget Attach(params string[] types);

    /// <summary>
    ///   <para>Collection of attachment types, which are allowed in comment posts.</para>
    /// </summary>
    /// <returns>Allowed types of post attachments.</returns>
    IEnumerable<string> Attach();

    /// <summary>
    ///   <para>Maximum number of comments to display.</para>
    /// </summary>
    /// <param name="limit">Maximum number of comments.</param>
    /// <returns>Reference to the current widget.</returns>
    IVkontakteCommentsWidget Limit(byte limit);

    /// <summary>
    ///   <para>Maximum number of comments to display.</para>
    /// </summary>
    /// <returns>Maximum number of comments.</returns>
    byte Limit();

    /// <summary>
    ///   <para>Horizontal width of comment area.</para>
    /// </summary>
    /// <param name="width">Width of comments widget.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="width"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="width"/> is <see cref="string.Empty"/> string.</exception>
    IVkontakteCommentsWidget Width(string width);

    /// <summary>
    ///   <para>Horizontal width of comment area.</para>
    /// </summary>
    /// <returns>Width of comments widget.</returns>
    string Width();
  }
}