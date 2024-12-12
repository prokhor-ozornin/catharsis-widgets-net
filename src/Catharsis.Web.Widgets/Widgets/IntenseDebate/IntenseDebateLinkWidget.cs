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
  public IIntenseDebateLinkWidget PostId(string id)
  {
    if (id is null) throw new ArgumentNullException(nameof(id));
    if (id.IsEmpty()) throw new ArgumentException(nameof(id));

    this.postId = id;
    return this;
  }

  /// <inheritdoc cref="IIntenseDebateLinkWidget.PostId()"/>
  public string PostId() => postId;

  /// <inheritdoc cref="IIntenseDebateLinkWidget.PostUrl(string)"/>
  public IIntenseDebateLinkWidget PostUrl(string url)
  {
    if (url is null) throw new ArgumentNullException(nameof(url));
    if (url.IsEmpty()) throw new ArgumentException(nameof(url));

    this.postUrl = url;
    return this;
  }

  /// <inheritdoc cref="IIntenseDebateLinkWidget.PostUrl()"/>
  public string PostUrl() => postUrl;

  /// <inheritdoc cref="IIntenseDebateLinkWidget.PostTitle(string)"/>
  public IIntenseDebateLinkWidget PostTitle(string title)
  {
    if (title is null) throw new ArgumentNullException(nameof(title));
    if (title.IsEmpty()) throw new ArgumentException(nameof(title));

    this.postTitle = title;
    return this;
  }

  /// <inheritdoc cref="IIntenseDebateLinkWidget.PostTitle()"/>
  public string PostTitle() => postTitle;

  /// <inheritdoc cref="IHtmlContent.ToHtml()"/>
  public override string ToHtml() => Account().IsEmpty() ? string.Empty : string.Format(resources.intensedebate_link, Account(), PostId(), PostUrl(), PostTitle());
}