using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IPinterestFollowButtonWidget"/>
public class PinterestFollowButtonWidget : WebWidget, IPinterestFollowButtonWidget
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string AccountProperty { get; set; }
  
  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string LabelProperty { get; set; } = "Follow";

  /// <inheritdoc cref="IPinterestFollowButtonWidget.Account(string)"/>
  public virtual IPinterestFollowButtonWidget Account(string account)
  {
    if (account is null) throw new ArgumentNullException(nameof(account));
    if (account.IsEmpty()) throw new ArgumentException(nameof(account));

    AccountProperty = account;

    return this;
  }

  /// <inheritdoc cref="IPinterestFollowButtonWidget.Label(string)"/>
  public virtual IPinterestFollowButtonWidget Label(string label)
  {
    if (label is null) throw new ArgumentNullException(nameof(label));
    if (label.IsEmpty()) throw new ArgumentException(nameof(label));

    LabelProperty = label;
    return this;
  }

  /// <inheritdoc cref="ICloneable.Clone()"/>
  public override object Clone() => new PinterestFollowButtonWidget
  {
    AccountProperty = AccountProperty,
    LabelProperty = LabelProperty
  };

  /// <inheritdoc cref="IWebWidget.ToHtml()"/>
  public override string ToHtml() => AccountProperty.IsUnset() || LabelProperty.IsUnset() ? string.Empty : new TagBuilder("a")
      .Attribute("data-pin-do", "buttonFollow")
      .Attribute("href", $"http://www.pinterest.com/${AccountProperty}")
      .Html(LabelProperty)
      .ToString();
}