using System.Text;
using Catharsis.Extensions;
using Catharsis.Web.Widgets.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="ICackleCommentsWidget"/>
public class CackleCommentsWidget : WebWidget, ICackleCommentsWidget
{
  private string AccountProperty { get; set; }

  /// <inheritdoc cref="ICackleCommentsWidget.Account(string)"/>
  public ICackleCommentsWidget Account(string account)
  {
    if (account is null) throw new ArgumentNullException(nameof(account));
    if (account.IsEmpty()) throw new ArgumentException(nameof(account));

    AccountProperty = account;
    return this;
  }

  /// <inheritdoc cref="ICackleCommentsWidget.Account()"/>
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
      widget = "Comment",
      id = Account()
    };

    return new StringBuilder()
      .Append("""<div id="mc-container"></div>""")
      .Append(
        new TagBuilder("script")
          .Attribute("type", "text/javascript")
          .Html($"cackle_widget = window.cackle_widget || [];cackle_widget.push(${config.Json()});")
        )
      .Append("""<a id="mc-link" href="http://cackle.me">���������� ����������� <b style="color:#4FA3DA">Cackl</b><b style="color:#F65077">e</b></a>""")
      .ToString();
  }
}