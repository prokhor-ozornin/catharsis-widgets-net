using System.Text;
using Catharsis.Extensions;
using Catharsis.Web.Widgets.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="ICackleLoginWidget"/>
public class CackleLoginWidget : WebWidget, ICackleLoginWidget
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string AccountProperty { get; set; }

  /// <inheritdoc cref="ICackleLoginWidget.Account(string)"/>
  public virtual ICackleLoginWidget Account(string account)
  {
    if (account is null) throw new ArgumentNullException(nameof(account));
    if (account.IsEmpty()) throw new ArgumentException(nameof(account));

    AccountProperty = account;
      
    return this;
  }

  /// <inheritdoc cref="ICloneable.Clone()"/>
  public override object Clone() => new CackleLoginWidget { };

  /// <inheritdoc cref="IWebWidget.ToHtml()"/>
  public override string ToHtml()
  {
    if (AccountProperty.IsUnset())
    {
      return string.Empty;
    }

    var config = new
    {
      widget = "Login",
      id = AccountProperty
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