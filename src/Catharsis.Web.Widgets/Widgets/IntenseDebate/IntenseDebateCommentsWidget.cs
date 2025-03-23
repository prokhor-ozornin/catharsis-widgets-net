using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IIntenseDebateCommentsWidget"/>
public class IntenseDebateCommentsWidget : WebWidget, IIntenseDebateCommentsWidget
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string AccountProperty { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string PostIdProperty { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string PostUrlProperty { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string PostTitleProperty { get; set; }

  /// <inheritdoc cref="IIntenseDebateCommentsWidget.Account(string)"/>
  public virtual IIntenseDebateCommentsWidget Account(string account)
  {
    if (account is null) throw new ArgumentNullException(nameof(account));
    if (account.IsEmpty()) throw new ArgumentException(nameof(account));

    AccountProperty = account;
    return this;
  }

  /// <inheritdoc cref="IIntenseDebateCommentsWidget.PostId(string)"/>
  public virtual IIntenseDebateCommentsWidget PostId(string id)
  {
    if (id is null) throw new ArgumentNullException(nameof(id));
    if (id.IsEmpty()) throw new ArgumentException(nameof(id));

    PostIdProperty = id;
    return this;
  }

  /// <inheritdoc cref="IIntenseDebateCommentsWidget.PostUrl(string)"/>
  public virtual IIntenseDebateCommentsWidget PostUrl(string url)
  {
    if (url is null) throw new ArgumentNullException(nameof(url));
    if (url.IsEmpty()) throw new ArgumentException(nameof(url));

    PostUrlProperty = url;
    return this;
  }

  /// <inheritdoc cref="IIntenseDebateCommentsWidget.PostTitle(string)"/>
  public virtual IIntenseDebateCommentsWidget PostTitle(string title)
  {
    if (title is null) throw new ArgumentNullException(nameof(title));
    if (title.IsEmpty()) throw new ArgumentException(nameof(title));

    PostTitleProperty = title;
    return this;
  }

  /// <inheritdoc cref="IHtmlContent.ToHtml()"/>
  public override string ToHtml() => AccountProperty.IsEmpty() ? string.Empty : string.Format(resources.intensedebate_comments_html, AccountProperty, PostIdProperty, PostUrlProperty, PostTitleProperty);
}