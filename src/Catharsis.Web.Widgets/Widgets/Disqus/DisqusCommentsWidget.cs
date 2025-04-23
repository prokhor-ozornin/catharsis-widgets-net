using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IDisqusCommentsWidget"/>
public class DisqusCommentsWidget : WebWidget, IDisqusCommentsWidget
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string AccountProperty { get; set; }

  /// <inheritdoc cref="IDisqusCommentsWidget.Account(string)"/>
  public virtual IDisqusCommentsWidget Account(string account)
  {
    if (account is null) throw new ArgumentNullException(nameof(account));
    if (account.IsEmpty()) throw new ArgumentException(nameof(account));

    AccountProperty = account;

    return this;
  }

  /// <inheritdoc cref="IHtmlContent.ToHtml()"/>
  public override string ToHtml() => AccountProperty.IsUnset() ? string.Empty : string.Format(resources.disqus_comments_html, AccountProperty);
}