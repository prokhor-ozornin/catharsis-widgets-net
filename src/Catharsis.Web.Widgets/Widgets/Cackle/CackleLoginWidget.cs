using System.Text;
using Catharsis.Extensions;
using Catharsis.Web.Widgets.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="ICackleLoginWidget"/>
public class CackleLoginWidget : WebWidget, ICackleLoginWidget
{
  private string AccountProperty { get; set; }

  /// <inheritdoc cref="ICackleLoginWidget.Account(string)"/>
  public ICackleLoginWidget Account(string account)
  {
    if (account is null) throw new ArgumentNullException(nameof(account));
    if (account.IsEmpty()) throw new ArgumentException(nameof(account));

    AccountProperty = account;
      
    return this;
  }

  /// <inheritdoc cref="ICackleLoginWidget.Account()"/>
  public string Account() => AccountProperty;

  /// <inheritdoc cref="IHtmlContent.ToHtml()"/>
  public override string ToHtml()
  {
    if (AccountProperty.IsEmpty())
    {
      return string.Empty;
    }

    var config = new
    {
      widget = "Login",
      id = Account()
    };

    return new StringBuilder()
      .Append("""<div id="mc-login"></div>""")
      .Append(new TagBuilder("script")
        .Attribute("type", "text/javascript")
        .Html($"cackle_widget = window.cackle_widget || [];cackle_widget.push(${config.Json()});")
      )
      .ToString();
  }
}