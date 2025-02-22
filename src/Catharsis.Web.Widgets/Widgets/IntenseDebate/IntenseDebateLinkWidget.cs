using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IIntenseDebateLinkWidget"/>
public class IntenseDebateLinkWidget : WebWidget, IIntenseDebateLinkWidget
{
  private string AccountProperty { get; set; }
  private string PostIdProperty { get; set; }
  private string PostUrlProperty { get; set; }
  private string PostTitleProperty { get; set; }

  /// <inheritdoc cref="IIntenseDebateLinkWidget.Account(string)"/>
  public IIntenseDebateLinkWidget Account(string account)
  {
    if (account is null) throw new ArgumentNullException(nameof(account));
    if (account.IsEmpty()) throw new ArgumentException(nameof(account));

    AccountProperty = account;
    return this;
  }

  /// <inheritdoc cref="IIntenseDebateLinkWidget.Account()"/>
  public string Account() => AccountProperty;

  /// <inheritdoc cref="IIntenseDebateLinkWidget.PostId(string)"/>
  public IIntenseDebateLinkWidget PostId(string id)
  {
    if (id is null) throw new ArgumentNullException(nameof(id));
    if (id.IsEmpty()) throw new ArgumentException(nameof(id));

    PostIdProperty = id;
    return this;
  }

  /// <inheritdoc cref="IIntenseDebateLinkWidget.PostId()"/>
  public string PostId() => PostIdProperty;

  /// <inheritdoc cref="IIntenseDebateLinkWidget.PostUrl(string)"/>
  public IIntenseDebateLinkWidget PostUrl(string url)
  {
    if (url is null) throw new ArgumentNullException(nameof(url));
    if (url.IsEmpty()) throw new ArgumentException(nameof(url));

    PostUrlProperty = url;
    return this;
  }

  /// <inheritdoc cref="IIntenseDebateLinkWidget.PostUrl()"/>
  public string PostUrl() => PostUrlProperty;

  /// <inheritdoc cref="IIntenseDebateLinkWidget.PostTitle(string)"/>
  public IIntenseDebateLinkWidget PostTitle(string title)
  {
    if (title is null) throw new ArgumentNullException(nameof(title));
    if (title.IsEmpty()) throw new ArgumentException(nameof(title));

    PostTitleProperty = title;
    return this;
  }

  /// <inheritdoc cref="IIntenseDebateLinkWidget.PostTitle()"/>
  public string PostTitle() => PostTitleProperty;

  /// <inheritdoc cref="IHtmlContent.ToHtml()"/>
  public override string ToHtml() => Account().IsEmpty() ? string.Empty : string.Format(resources.intensedebate_link_html, Account(), PostId(), PostUrl(), PostTitle());
}