using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IDisqusCommentsWidget"/>
public class DisqusCommentsWidget : WebWidget, IDisqusCommentsWidget
{
  private string account;

  /// <inheritdoc cref="IDisqusCommentsWidget.Account(string)"/>
  public IDisqusCommentsWidget Account(string account)
  {
    if (account is null) throw new ArgumentNullException(nameof(account));
    if (account.IsEmpty()) throw new ArgumentException(nameof(account));

    this.account = account;

    return this;
  }

  /// <inheritdoc cref="IDisqusCommentsWidget.Account()"/>
  public string Account() => account;

  /// <inheritdoc cref="IHtmlContent.ToHtml()"/>
  public override string ToHtml() => account.IsEmpty() ? string.Empty : string.Format(resources.disqus_comments, Account());
}