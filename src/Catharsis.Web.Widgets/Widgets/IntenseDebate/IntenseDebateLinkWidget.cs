using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IIntenseDebateLinkWidget"/>
public class IntenseDebateLinkWidget : WebWidget, IIntenseDebateLinkWidget
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

  /// <inheritdoc cref="IIntenseDebateLinkWidget.Account(string)"/>
  public virtual IIntenseDebateLinkWidget Account(string account)
  {
    if (account is null) throw new ArgumentNullException(nameof(account));
    if (account.IsEmpty()) throw new ArgumentException(nameof(account));

    AccountProperty = account;
    return this;
  }

  /// <inheritdoc cref="IIntenseDebateLinkWidget.PostId(string)"/>
  public virtual IIntenseDebateLinkWidget PostId(string id)
  {
    if (id is null) throw new ArgumentNullException(nameof(id));
    if (id.IsEmpty()) throw new ArgumentException(nameof(id));

    PostIdProperty = id;
    return this;
  }

  /// <inheritdoc cref="IIntenseDebateLinkWidget.PostUrl(string)"/>
  public virtual IIntenseDebateLinkWidget PostUrl(string url)
  {
    if (url is null) throw new ArgumentNullException(nameof(url));
    if (url.IsEmpty()) throw new ArgumentException(nameof(url));

    PostUrlProperty = url;
    return this;
  }

  /// <inheritdoc cref="IIntenseDebateLinkWidget.PostTitle(string)"/>
  public virtual IIntenseDebateLinkWidget PostTitle(string title)
  {
    if (title is null) throw new ArgumentNullException(nameof(title));
    if (title.IsEmpty()) throw new ArgumentException(nameof(title));

    PostTitleProperty = title;
    return this;
  }

  /// <inheritdoc cref="ICloneable.Clone()"/>
  public override object Clone() => new IntenseDebateLinkWidget { };

  /// <inheritdoc cref="IWebWidget.ToHtml()"/>
  public override string ToHtml() => AccountProperty.IsUnset() ? string.Empty : string.Format(resources.intensedebate_link_html, AccountProperty, PostIdProperty, PostUrlProperty, PostTitleProperty);
}