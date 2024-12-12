using System.Text;
using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IMailRuIcqWidget"/>
public class MailRuIcqWidget : WebWidget, IMailRuIcqWidget
{
  private string account;
  private string language;

  /// <inheritdoc cref="IMailRuIcqWidget.Account(string)"/>
  public IMailRuIcqWidget Account(string account)
  {
    if (account is null) throw new ArgumentNullException(nameof(account));
    if (account.IsEmpty()) throw new ArgumentException(nameof(account));

    this.account = account;
    return this;
  }

  /// <inheritdoc cref="IMailRuIcqWidget.Account()"/>
  public string Account() => account;

  /// <inheritdoc cref="IMailRuIcqWidget.Language(string)"/>
  public IMailRuIcqWidget Language(string language)
  {
    if (language is null) throw new ArgumentNullException(nameof(language));
    if (language.IsEmpty()) throw new ArgumentException(nameof(language));

    this.language = language;
    return this;
  }

  /// <inheritdoc cref="IMailRuIcqWidget.Language()"/>
  public string Language() => language;

  /// <inheritdoc cref="IHtmlContent.ToHtml()"/>
  public override string ToHtml()
  {
    var builder = new StringBuilder()
      .Append(new TagBuilder("script")
        .Attribute("type", "text/javascript")
        .Attribute("src", $"http://c.icq.com/siteim/icqbar/js/partners/initbar_$@{Language() ?? "ru"}.js")
      );
      
    if (!Account().IsEmpty())
    {
      builder.Append(new TagBuilder("script").Attribute("type", "text/javascript").Html($"window.ICQ = {{siteOwner:'${Account()}'}};"));
    }

    return builder.ToString();
  }
}