using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IPinterestFollowButtonWidget"/>
public class PinterestFollowButtonWidget : WebWidget, IPinterestFollowButtonWidget
{
  private string account;
  private string label = "Follow";

  /// <inheritdoc cref="IPinterestFollowButtonWidget.Account(string)"/>
  public IPinterestFollowButtonWidget Account(string account)
  {
    if (account is null) throw new ArgumentNullException(nameof(account));
    if (account.IsEmpty()) throw new ArgumentException(nameof(account));

    this.account = account;

    return this;
  }

  /// <inheritdoc cref="IPinterestFollowButtonWidget.Account()"/>
  public string Account() => account;

  /// <inheritdoc cref="IPinterestFollowButtonWidget.Label(string)"/>
  public IPinterestFollowButtonWidget Label(string label)
  {
    if (label is null) throw new ArgumentNullException(nameof(label));
    if (label.IsEmpty()) throw new ArgumentException(nameof(label));

    this.label = label;
    return this;
  }

  /// <inheritdoc cref="IPinterestFollowButtonWidget.Label()"/>
  public string Label() => label;

  /// <inheritdoc cref="IWebWidget.ToHtml()"/>
  public override string ToHtml()
  {
    if (Account().IsEmpty() || Label().IsEmpty())
    {
      return string.Empty;
    }

    return new TagBuilder("a")
      .Attribute("data-pin-do", "buttonFollow")
      .Attribute("href", $"http://www.pinterest.com/${Account()}")
      .Html(Label())
      .ToString();
  }
}