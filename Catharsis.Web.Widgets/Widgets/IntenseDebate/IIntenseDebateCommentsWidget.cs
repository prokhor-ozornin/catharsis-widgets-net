using System;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Renders IntenseDebate comments widget for registered website.</para>
  /// </summary>
  /// <seealso cref="http://intensedebate.com"/>
  public interface IIntenseDebateCommentsWidget : IHtmlWidget
  {
    /// <summary>
    ///   <para>Identifier of registered website in the "IntenseDebate" comments system.</para>
    /// </summary>
    /// <param name="account">Identifier of website.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="account"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="account"/> is <see cref="string.Empty"/> string.</exception>
    /// <remarks>This attribute is required.</remarks>
    IIntenseDebateCommentsWidget Account(string account);

    /// <summary>
    ///   <para>This is the unique identifier of the post or page. This is what keeps the comments set on this page different than comments set on another page. The default value is the URL of the page.</para>
    /// </summary>
    /// <param name="postId">Identifier of post or page.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="postId"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="postId"/> is <see cref="string.Empty"/> string.</exception>
    IIntenseDebateCommentsWidget PostId(string postId);

    /// <summary>
    ///   <para>This is the url of the post or page. This is url Intense Debate will link to in RSS feeds and on IntenseDebate.com. The default is the current page's URL.</para>
    /// </summary>
    /// <param name="postUrl">URL of post or page.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="postUrl"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="postUrl"/> is <see cref="string.Empty"/> string.</exception>
    IIntenseDebateCommentsWidget PostUrl(string postUrl);

    /// <summary>
    ///   <para>This is title of the post or page. This is the title that will be displayed in RSS feeds and on IntenseDebate.com. The default value is the title of the current page.</para>
    /// </summary>
    /// <param name="postTitle">Title of post or page.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="postTitle"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="postTitle"/> is <see cref="string.Empty"/> string.</exception>
    IIntenseDebateCommentsWidget PostTitle(string postTitle);
  }
}