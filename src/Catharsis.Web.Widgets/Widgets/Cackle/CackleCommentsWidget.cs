using System.Text;
using Catharsis.Extensions;
using Catharsis.Web.Widgets.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="ICackleCommentsWidget"/>
public class CackleCommentsWidget : WebWidget, ICackleCommentsWidget
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string AccountValue { get; set; }

  /// <inheritdoc cref="ICackleCommentsWidget.Account(string)"/>
  public virtual ICackleCommentsWidget Account(string account)
  {
    if (account is null) throw new ArgumentNullException(nameof(account));
    if (account.IsEmpty()) throw new ArgumentException(nameof(account));

    AccountValue = account;
    return this;
  }

  /// <inheritdoc cref="ICloneable.Clone()"/>
  public override object Clone() => new CackleCommentsWidget
  {
    AccountValue = AccountValue
  };

  /// <inheritdoc cref="IWebWidget.ToHtml()"/>
  public override string ToHtml()
  {
    if (AccountValue.IsUnset())
    {
      return string.Empty;
    }

    var config = new
    {
      widget = "Comment",
      id = AccountValue
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