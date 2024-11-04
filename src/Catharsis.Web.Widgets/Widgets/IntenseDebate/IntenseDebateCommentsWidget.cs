using System;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Renders IntenseDebate comments widget for registered website.</para>
  /// </summary>
  /// <seealso cref="http://intensedebate.com"/>
  public class IntenseDebateCommentsWidget : HtmlWidget, IIntenseDebateCommentsWidget
  {
    private string account;
    private string postId;
    private string postUrl;
    private string postTitle;

    /// <summary>
    ///   <para>Identifier of registered website in the "IntenseDebate" comments system.</para>
    /// </summary>
    /// <param name="account">Identifier of website.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="account"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="account"/> is <see cref="string.Empty"/> string.</exception>
    /// <remarks>This attribute is required.</remarks>
    public IIntenseDebateCommentsWidget Account(string account)
    {
      Assertion.NotEmpty(account);

      this.account = account;
      return this;
    }

    /// <summary>
    ///   <para>Identifier of registered website in the "IntenseDebate" comments system.</para>
    /// </summary>
    /// <returns>Identifier of website.</returns>
    public string Account()
    {
      return this.account;
    }

    /// <summary>
    ///   <para>This is the unique identifier of the post or page. This is what keeps the comments set on this page different than comments set on another page. The default value is the URL of the page.</para>
    /// </summary>
    /// <param name="postId">Identifier of post or page.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="postId"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="postId"/> is <see cref="string.Empty"/> string.</exception>
    public IIntenseDebateCommentsWidget PostId(string postId)
    {
      Assertion.NotEmpty(postId);

      this.postId = postId;
      return this;
    }

    /// <summary>
    ///   <para>This is the unique identifier of the post or page. This is what keeps the comments set on this page different than comments set on another page. The default value is the URL of the page.</para>
    /// </summary>
    /// <returns>Identifier of post or page.</returns>
    public string PostId()
    {
      return this.postId;
    }

    /// <summary>
    ///   <para>This is the url of the post or page. This is url Intense Debate will link to in RSS feeds and on IntenseDebate.com. The default is the current page's URL.</para>
    /// </summary>
    /// <param name="postUrl">URL of post or page.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="postUrl"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="postUrl"/> is <see cref="string.Empty"/> string.</exception>
    public IIntenseDebateCommentsWidget PostUrl(string postUrl)
    {
      Assertion.NotEmpty(postUrl);

      this.postUrl = postUrl;
      return this;
    }

    /// <summary>
    ///   <para>This is the url of the post or page. This is url Intense Debate will link to in RSS feeds and on IntenseDebate.com. The default is the current page's URL.</para>
    /// </summary>
    /// <returns>URL of post or page.</returns>
    public string PostUrl()
    {
      return this.postUrl;
    }

    /// <summary>
    ///   <para>This is title of the post or page. This is the title that will be displayed in RSS feeds and on IntenseDebate.com. The default value is the title of the current page.</para>
    /// </summary>
    /// <param name="postTitle">Title of post or page.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="postTitle"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="postTitle"/> is <see cref="string.Empty"/> string.</exception>
    public IIntenseDebateCommentsWidget PostTitle(string postTitle)
    {
      Assertion.NotEmpty(postTitle);

      this.postTitle = postTitle;
      return this;
    }

    /// <summary>
    ///   <para>This is title of the post or page. This is the title that will be displayed in RSS feeds and on IntenseDebate.com. The default value is the title of the current page.</para>
    /// </summary>
    /// <returns>Title of post or page.</returns>
    public string PostTitle()
    {
      return this.postTitle;
    }

    /// <summary>
    ///   <para>Returns HTML markup text of widget.</para>
    /// </summary>
    /// <returns>Widget's HTML markup.</returns>
    public override string ToHtmlString()
    {
      if (this.Account().IsEmpty())
      {
        return string.Empty;
      }

      return resources.intensedebate_comments.FormatSelf(this.Account(), this.PostId(), this.PostUrl(), this.PostTitle());
    }
  }
}