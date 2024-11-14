using System.Text;
using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IMailRuIcqWidget"/>
public class MailRuIcqWidget : WebWidget, IMailRuIcqWidget
{
  private string account;
  private string language;

  /// <summary>
  ///   <para>ICQ UIN number of contact person. If specified, "Ask Me" option will be added to the widget.</para>
  /// </summary>
  /// <param name="account">ICQ UIN number.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="account"/> is a <c>null</c> reference.</exception>
  /// <exception cref="ArgumentException">If <paramref name="account"/> is <see cref="string.Empty"/> string.</exception>
  public IMailRuIcqWidget Account(string account)
  {
    if (account is null) throw new ArgumentNullException(nameof(account));
    if (account.IsEmpty()) throw new ArgumentException(nameof(account));

    this.account = account;
    return this;
  }

  /// <summary>
  ///   <para>ICQ UIN number of contact person. If specified, "Ask Me" option will be added to the widget.</para>
  /// </summary>
  /// <returns>ICQ UIN number.</returns>
  public string Account() => account;

  /// <summary>
  ///   <para>Two-letter ISO language code that determines the interface language. Default is "ru".</para>
  /// </summary>
  /// <param name="language">ISO language code for interface.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="language"/> is a <c>null</c> reference.</exception>
  /// <exception cref="ArgumentException">If <paramref name="language"/> is <see cref="string.Empty"/> string.</exception>
  public IMailRuIcqWidget Language(string language)
  {
    if (language is null) throw new ArgumentNullException(nameof(language));
    if (language.IsEmpty()) throw new ArgumentException(nameof(language));

    this.language = language;
    return this;
  }

  /// <summary>
  ///   <para>Two-letter ISO language code that determines the interface language. Default is "ru".</para>
  /// </summary>
  /// <returns>ISO language code for interface.</returns>
  public string Language() => language;

  /// <inheritdoc cref="IWebWidget.ToHtml()"/>
  public override string ToHtml()
  {
    var builder = new StringBuilder()
      .Append(new TagBuilder("script")
        .Attribute("type", "text/javascript")
        .Attribute("src", $"http://c.icq.com/siteim/icqbar/js/partners/initbar_$@{Language() ?? "ru"}.js"));
      
    if (!Account().IsEmpty())
    {
      builder.Append(new TagBuilder("script").Attribute("type", "text/javascript").InnerHtml($"window.ICQ = {{siteOwner:'${Account()}'}};"));
    }

    return builder.ToString();
  }
}