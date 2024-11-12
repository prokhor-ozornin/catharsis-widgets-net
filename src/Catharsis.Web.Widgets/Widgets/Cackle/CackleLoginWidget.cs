using System.Text;
using System.Web.Mvc;
using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="ICackleLoginWidget"/>
public class CackleLoginWidget : WebWidget, ICackleLoginWidget
{
  private string account;

  /// <summary>
  ///   <para>Identifier of registered website in the "Cackle" comments system.</para>
  /// </summary>
  /// <param name="account">Identifier of website.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="account"/> is a <c>null</c> reference.</exception>
  /// <exception cref="ArgumentException">If <paramref name="account"/> is <see cref="string.Empty"/> string.</exception>
  /// <remarks>This attribute is required.</remarks>
  public ICackleLoginWidget Account(string account)
  {
    if (account is null) throw new ArgumentNullException(nameof(account));
    if (account.IsEmpty()) throw new ArgumentException(nameof(account));

    this.account = account;
      
    return this;
  }

  /// <summary>
  ///   <para>Identifier of registered website in the "Cackle" comments system.</para>
  /// </summary>
  /// <returns>Identifier of website.</returns>
  public string Account() => account;

  /// <inheritdoc cref="IWebWidget.ToHtml"/>
  public override string ToHtml()
  {
    if (account.IsEmpty())
    {
      return string.Empty;
    }

    var config = new
    {
      widget = "Login",
      id = Account()
    };

    return new StringBuilder()
      .Append(@"<div id=""mc-login""></div>")
      .Append(new TagBuilder("script").Attribute("type", "text/javascript").InnerHtml($"cackle_widget = window.cackle_widget || [];cackle_widget.push(${config.Json()});"))
      .ToString();
  }
}