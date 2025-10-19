namespace Catharsis.Web.Widgets;

/// <summary>
///   <para>Renders IntenseDebate comments widget for registered website.</para>
/// </summary>
/// <seealso href="http://intensedebate.com"/>
public interface IIntenseDebateCommentsWidget : IWebWidget
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
  /// <param name="id">Identifier of post or page.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="id"/> is a <c>null</c> reference.</exception>
  /// <exception cref="ArgumentException">If <paramref name="id"/> is <see cref="string.Empty"/> string.</exception>
  IIntenseDebateCommentsWidget PostId(string id);

  /// <summary>
  ///   <para>This is the url of the post or page. This is url Intense Debate will link to in RSS feeds and on IntenseDebate.com. The default is the current page's URL.</para>
  /// </summary>
  /// <param name="url">URL of post or page.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="url"/> is a <c>null</c> reference.</exception>
  /// <exception cref="ArgumentException">If <paramref name="url"/> is <see cref="string.Empty"/> string.</exception>
  IIntenseDebateCommentsWidget PostUrl(string url);

  /// <summary>
  ///   <para>This is title of the post or page. This is the title that will be displayed in RSS feeds and on IntenseDebate.com. The default value is the title of the current page.</para>
  /// </summary>
  /// <param name="title">Title of post or page.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="title"/> is a <c>null</c> reference.</exception>
  /// <exception cref="ArgumentException">If <paramref name="title"/> is <see cref="string.Empty"/> string.</exception>
  IIntenseDebateCommentsWidget PostTitle(string title);
}