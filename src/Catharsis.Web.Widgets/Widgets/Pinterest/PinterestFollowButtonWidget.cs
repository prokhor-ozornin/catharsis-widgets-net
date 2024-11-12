using System.Web.Mvc;
using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="IPinterestFollowButtonWidget"/>
public class PinterestFollowButtonWidget : WebWidget, IPinterestFollowButtonWidget
{
  private string account;
  private string label = "Follow";

  /// <summary>
  ///   <para>Pinterest user account.</para>
  /// </summary>
  /// <param name="account">Account name.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="account"/> is a <c>null</c> reference.</exception>
  /// <exception cref="ArgumentException">If <paramref name="account"/> is <see cref="string.Empty"/> string.</exception>
  /// <remarks>This attribute is required.</remarks>
  public IPinterestFollowButtonWidget Account(string account)
  {
    if (account is null) throw new ArgumentNullException(nameof(account));
    if (account.IsEmpty()) throw new ArgumentException(nameof(account));

    this.account = account;

    return this;
  }

  /// <summary>
  ///   <para>Pinterest user account.</para>
  /// </summary>
  /// <returns>Account name.</returns>
  public string Account() => account;

  /// <summary>
  ///   <para>Text label on the button.</para>
  /// </summary>
  /// <param name="label">Button's label.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="label"/> is a <c>null</c> reference.</exception>
  /// <exception cref="ArgumentException">If <paramref name="label"/> is <see cref="string.Empty"/> string.</exception>
  /// <remarks>This attribute is required.</remarks>
  public IPinterestFollowButtonWidget Label(string label)
  {
    if (label is null) throw new ArgumentNullException(nameof(label));
    if (label.IsEmpty()) throw new ArgumentException(nameof(label));

    this.label = label;
    return this;
  }

  /// <summary>
  ///   <para>Text label on the button.</para>
  /// </summary>
  /// <returns>Button's label.</returns>
  public string Label() => label;

  /// <inheritdoc cref="IWebWidget.ToHtml"/>
  public override string ToHtml()
  {
    if (Account().IsEmpty() || Label().IsEmpty())
    {
      return string.Empty;
    }

    return new TagBuilder("a")
      .Attribute("data-pin-do", "buttonFollow")
      .Attribute("href", $"http://www.pinterest.com/${Account()}")
      .InnerHtml(Label())
      .ToString();
  }
}