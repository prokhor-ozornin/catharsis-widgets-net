using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IIntenseDebateCommentsWidget"/>
public class IntenseDebateCommentsWidget : WebWidget, IIntenseDebateCommentsWidget
{
  private string AccountProperty { get; set; }
  private string PostIdProperty { get; set; }
  private string PostUrlProperty { get; set; }
  private string PostTitleProperty { get; set; }

  /// <inheritdoc cref="IIntenseDebateCommentsWidget.Account(string)"/>
  public IIntenseDebateCommentsWidget Account(string account)
  {
    if (account is null) throw new ArgumentNullException(nameof(account));
    if (account.IsEmpty()) throw new ArgumentException(nameof(account));

    AccountProperty = account;
    return this;
  }

  /// <inheritdoc cref="IIntenseDebateCommentsWidget.Account()"/>
  public string Account() => AccountProperty;

  /// <inheritdoc cref="IIntenseDebateCommentsWidget.PostId(string)"/>
  public IIntenseDebateCommentsWidget PostId(string id)
  {
    if (id is null) throw new ArgumentNullException(nameof(id));
    if (id.IsEmpty()) throw new ArgumentException(nameof(id));

    PostIdProperty = id;
    return this;
  }

  /// <inheritdoc cref="IIntenseDebateCommentsWidget.PostId()"/>
  public string PostId() => PostIdProperty;

  /// <inheritdoc cref="IIntenseDebateCommentsWidget.PostUrl(string)"/>
  public IIntenseDebateCommentsWidget PostUrl(string url)
  {
    if (url is null) throw new ArgumentNullException(nameof(url));
    if (url.IsEmpty()) throw new ArgumentException(nameof(url));

    PostUrlProperty = url;
    return this;
  }

  /// <inheritdoc cref="IIntenseDebateCommentsWidget.PostUrl()"/>
  public string PostUrl() => PostUrlProperty;

  /// <inheritdoc cref="IIntenseDebateCommentsWidget.PostTitle(string)"/>
  public IIntenseDebateCommentsWidget PostTitle(string title)
  {
    if (title is null) throw new ArgumentNullException(nameof(title));
    if (title.IsEmpty()) throw new ArgumentException(nameof(title));

    PostTitleProperty = title;
    return this;
  }

  /// <inheritdoc cref="IIntenseDebateCommentsWidget.PostTitle()"/>
  public string PostTitle() => PostTitleProperty;

  /// <inheritdoc cref="IHtmlContent.ToHtml()"/>
  public override string ToHtml() => Account().IsEmpty() ? string.Empty : string.Format(resources.intensedebate_comments_html, Account(), PostId(), PostUrl(), PostTitle());
}