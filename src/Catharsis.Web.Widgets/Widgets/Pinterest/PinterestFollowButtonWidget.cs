using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IPinterestFollowButtonWidget"/>
public class PinterestFollowButtonWidget : WebWidget, IPinterestFollowButtonWidget
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string AccountValue { get; set; }
  
  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string LabelValue { get; set; } = "Follow";

  /// <inheritdoc cref="IPinterestFollowButtonWidget.Account(string)"/>
  public virtual IPinterestFollowButtonWidget Account(string account)
  {
    if (account is null) throw new ArgumentNullException(nameof(account));
    if (account.IsEmpty()) throw new ArgumentException(nameof(account));

    AccountValue = account;

    return this;
  }

  /// <inheritdoc cref="IPinterestFollowButtonWidget.Label(string)"/>
  public virtual IPinterestFollowButtonWidget Label(string label)
  {
    if (label is null) throw new ArgumentNullException(nameof(label));
    if (label.IsEmpty()) throw new ArgumentException(nameof(label));

    LabelValue = label;
    return this;
  }

  /// <inheritdoc cref="ICloneable.Clone()"/>
  public override object Clone() => new PinterestFollowButtonWidget
  {
    AccountValue = AccountValue,
    LabelValue = LabelValue
  };

  /// <inheritdoc cref="IWebWidget.ToHtml()"/>
  public override string ToHtml() => AccountValue.IsUnset() || LabelValue.IsUnset() ? string.Empty : new TagBuilder("a")
      .Attribute("data-pin-do", "buttonFollow")
      .Attribute("href", $"http://www.pinterest.com/${AccountValue}")
      .Html(LabelValue)
      .ToString();
}