using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IIntenseDebateLinkWidget"/>
public class IntenseDebateLinkWidget : WebWidget, IIntenseDebateLinkWidget
{
  private string account;
  private string postId;
  private string postUrl;
  private string postTitle;

  /// <inheritdoc cref="IIntenseDebateLinkWidget.Account(string)"/>
  public IIntenseDebateLinkWidget Account(string account)
  {
    if (account is null) throw new ArgumentNullException(nameof(account));
    if (account.IsEmpty()) throw new ArgumentException(nameof(account));

    this.account = account;
    return this;
  }

  /// <inheritdoc cref="IIntenseDebateLinkWidget.Account()"/>
  public string Account() => account;

  /// <inheritdoc cref="IIntenseDebateLinkWidget.PostId(string)"/>
  public IIntenseDebateLinkWidget PostId(string postId)
  {
    if (postId is null) throw new ArgumentNullException(nameof(postId));
    if (postId.IsEmpty()) throw new ArgumentException(nameof(postId));

    this.postId = postId;
    return this;
  }

  /// <inheritdoc cref="IIntenseDebateLinkWidget.PostId()"/>
  public string PostId() => postId;

  /// <inheritdoc cref="IIntenseDebateLinkWidget.PostUrl(string)"/>
  public IIntenseDebateLinkWidget PostUrl(string postUrl)
  {
    if (postUrl is null) throw new ArgumentNullException(nameof(postUrl));
    if (postUrl.IsEmpty()) throw new ArgumentException(nameof(postUrl));

    this.postUrl = postUrl;
    return this;
  }

  /// <inheritdoc cref="IIntenseDebateLinkWidget.PostUrl()"/>
  public string PostUrl() => postUrl;

  /// <inheritdoc cref="IIntenseDebateLinkWidget.PostTitle(string)"/>
  public IIntenseDebateLinkWidget PostTitle(string postTitle)
  {
    if (postTitle is null) throw new ArgumentNullException(nameof(postTitle));
    if (postTitle.IsEmpty()) throw new ArgumentException(nameof(postTitle));

    this.postTitle = postTitle;
    return this;
  }

  /// <inheritdoc cref="IIntenseDebateLinkWidget.PostTitle()"/>
  public string PostTitle() => postTitle;

  /// <inheritdoc cref="IWebWidget.ToHtml()"/>
  public override string ToHtml() => Account().IsEmpty() ? string.Empty : string.Format(resources.intensedebate_link, Account(), PostId(), PostUrl(), PostTitle());
}