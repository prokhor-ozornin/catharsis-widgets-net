using System.Text;
using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IMailRuIcqWidget"/>
public class MailRuIcqWidget : WebWidget, IMailRuIcqWidget
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string AccountProperty { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string LanguageProperty { get; set; }

  /// <inheritdoc cref="IMailRuIcqWidget.Account(string)"/>
  public virtual IMailRuIcqWidget Account(string account)
  {
    if (account is null) throw new ArgumentNullException(nameof(account));
    if (account.IsEmpty()) throw new ArgumentException(nameof(account));

    AccountProperty = account;
    return this;
  }

  /// <inheritdoc cref="IMailRuIcqWidget.Language(string)"/>
  public virtual IMailRuIcqWidget Language(string language)
  {
    if (language is null) throw new ArgumentNullException(nameof(language));
    if (language.IsEmpty()) throw new ArgumentException(nameof(language));

    LanguageProperty = language;
    return this;
  }

  /// <inheritdoc cref="ICloneable.Clone()"/>
  public override object Clone() => new MailRuIcqWidget
  {
    AccountProperty = AccountProperty,
    LanguageProperty = LanguageProperty
  };

  /// <inheritdoc cref="IWebWidget.ToHtml()"/>
  public override string ToHtml()
  {
    var builder = new StringBuilder()
      .Append(new TagBuilder("script")
        .Attribute("type", "text/javascript")
        .Attribute("src", $"http://c.icq.com/siteim/icqbar/js/partners/initbar_$@{LanguageProperty ?? "ru"}.js")
      );
      
    if (!AccountProperty.IsUnset())
    {
      builder.Append(new TagBuilder("script").Attribute("type", "text/javascript").Html($"window.ICQ = {{siteOwner:'${AccountProperty}'}};"));
    }

    return builder.ToString();
  }
}