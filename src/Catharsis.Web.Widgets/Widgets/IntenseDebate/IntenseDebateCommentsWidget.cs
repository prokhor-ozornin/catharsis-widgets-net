using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IIntenseDebateCommentsWidget"/>
public class IntenseDebateCommentsWidget : WebWidget, IIntenseDebateCommentsWidget
{
  private string account;
  private string postId;
  private string postUrl;
  private string postTitle;

  /// <inheritdoc cref="IIntenseDebateCommentsWidget.Account(string)"/>
  public IIntenseDebateCommentsWidget Account(string account)
  {
    if (account is null) throw new ArgumentNullException(nameof(account));
    if (account.IsEmpty()) throw new ArgumentException(nameof(account));

    this.account = account;
    return this;
  }

  /// <inheritdoc cref="IIntenseDebateCommentsWidget.Account()"/>
  public string Account() => account;

  /// <inheritdoc cref="IIntenseDebateCommentsWidget.PostId(string)"/>
  public IIntenseDebateCommentsWidget PostId(string postId)
  {
    if (postId is null) throw new ArgumentNullException(nameof(postId));
    if (postId.IsEmpty()) throw new ArgumentException(nameof(postId));

    this.postId = postId;
    return this;
  }

  /// <inheritdoc cref="IIntenseDebateCommentsWidget.PostId()"/>
  public string PostId() => postId;

  /// <inheritdoc cref="IIntenseDebateCommentsWidget.PostUrl(string)"/>
  public IIntenseDebateCommentsWidget PostUrl(string postUrl)
  {
    if (postUrl is null) throw new ArgumentNullException(nameof(postUrl));
    if (postUrl.IsEmpty()) throw new ArgumentException(nameof(postUrl));

    this.postUrl = postUrl;
    return this;
  }

  /// <inheritdoc cref="IIntenseDebateCommentsWidget.PostUrl()"/>
  public string PostUrl() => postUrl;

  /// <inheritdoc cref="IIntenseDebateCommentsWidget.PostTitle(string)"/>
  public IIntenseDebateCommentsWidget PostTitle(string postTitle)
  {
    if (postTitle is null) throw new ArgumentNullException(nameof(postTitle));
    if (postTitle.IsEmpty()) throw new ArgumentException(nameof(postTitle));

    this.postTitle = postTitle;
    return this;
  }

  /// <inheritdoc cref="IIntenseDebateCommentsWidget.PostTitle()"/>
  public string PostTitle() => postTitle;

  /// <inheritdoc cref="IWebWidget.ToHtml()"/>
  public override string ToHtml() => Account().IsEmpty() ? string.Empty : string.Format(resources.intensedebate_comments, Account(), PostId(), PostUrl(), PostTitle());
}