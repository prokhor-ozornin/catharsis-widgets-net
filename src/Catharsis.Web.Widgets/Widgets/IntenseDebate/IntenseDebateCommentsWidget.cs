using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IIntenseDebateCommentsWidget"/>
public class IntenseDebateCommentsWidget : WebWidget, IIntenseDebateCommentsWidget
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string AccountValue { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string PostIdValue { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string PostUrlValue { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string PostTitleValue { get; set; }

  /// <inheritdoc cref="IIntenseDebateCommentsWidget.Account(string)"/>
  public virtual IIntenseDebateCommentsWidget Account(string account)
  {
    if (account is null) throw new ArgumentNullException(nameof(account));
    if (account.IsEmpty()) throw new ArgumentException(nameof(account));

    AccountValue = account;
    return this;
  }

  /// <inheritdoc cref="IIntenseDebateCommentsWidget.PostId(string)"/>
  public virtual IIntenseDebateCommentsWidget PostId(string id)
  {
    if (id is null) throw new ArgumentNullException(nameof(id));
    if (id.IsEmpty()) throw new ArgumentException(nameof(id));

    PostIdValue = id;
    return this;
  }

  /// <inheritdoc cref="IIntenseDebateCommentsWidget.PostUrl(string)"/>
  public virtual IIntenseDebateCommentsWidget PostUrl(string url)
  {
    if (url is null) throw new ArgumentNullException(nameof(url));
    if (url.IsEmpty()) throw new ArgumentException(nameof(url));

    PostUrlValue = url;
    return this;
  }

  /// <inheritdoc cref="IIntenseDebateCommentsWidget.PostTitle(string)"/>
  public virtual IIntenseDebateCommentsWidget PostTitle(string title)
  {
    if (title is null) throw new ArgumentNullException(nameof(title));
    if (title.IsEmpty()) throw new ArgumentException(nameof(title));

    PostTitleValue = title;
    return this;
  }

  /// <inheritdoc cref="ICloneable.Clone()"/>
  public override object Clone() => new IntenseDebateCommentsWidget
  {
    AccountValue = AccountValue,
    PostIdValue = PostIdValue,
    PostUrlValue = PostUrlValue,
    PostTitleValue = PostTitleValue
  };

  /// <inheritdoc cref="IWebWidget.ToHtml()"/>
  public override string ToHtml() => AccountValue.IsUnset() ? string.Empty : string.Format(resources.intensedebate_comments_html, AccountValue, PostIdValue, PostUrlValue, PostTitleValue);
}