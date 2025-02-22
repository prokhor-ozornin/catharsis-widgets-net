using Catharsis.Extensions;
using Catharsis.Web.Widgets.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="ICackleCommentsCountWidget"/>
public class CackleCommentsCountWidget : WebWidget, ICackleCommentsCountWidget
{
  private string AccountProperty { get; set; }

  /// <inheritdoc cref="ICackleCommentsCountWidget.Account(string)"/>
  public ICackleCommentsCountWidget Account(string account)
  {
    if (account is null) throw new ArgumentNullException(nameof(account));
    if (account.IsEmpty()) throw new ArgumentException(nameof(account));

    AccountProperty = account;
      
    return this;
  }

  /// <inheritdoc cref="ICackleCommentsCountWidget.Account()"/>
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
      widget = "CommentCount",
      id = Account()
    };

    return new TagBuilder("script")
      .Attribute("type", "text/javascript")
      .Html($"cackle_widget = window.cackle_widget || [];cackle_widget.push(${config.Json()})")
      .ToString();
  }
}