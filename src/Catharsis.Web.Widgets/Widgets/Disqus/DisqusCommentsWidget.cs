using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IDisqusCommentsWidget"/>
public class DisqusCommentsWidget : WebWidget, IDisqusCommentsWidget
{
  private string AccountProperty { get; set; }

  /// <inheritdoc cref="IDisqusCommentsWidget.Account(string)"/>
  public IDisqusCommentsWidget Account(string account)
  {
    if (account is null) throw new ArgumentNullException(nameof(account));
    if (account.IsEmpty()) throw new ArgumentException(nameof(account));

    AccountProperty = account;

    return this;
  }

  /// <inheritdoc cref="IDisqusCommentsWidget.Account()"/>
  public string Account() => AccountProperty;

  /// <inheritdoc cref="IHtmlContent.ToHtml()"/>
  public override string ToHtml() => AccountProperty.IsEmpty() ? string.Empty : string.Format(resources.disqus_comments_html, Account());
}