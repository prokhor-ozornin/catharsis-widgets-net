using System;
using System.Web.Mvc;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Renders Pinterest "Follow Me" button.</para>
  ///   <para>Requires Pinterest scripts bundle to be included.</para>
  /// </summary>
  /// <seealso cref="http://business.pinterest.com/widget-builder/#do_follow_me_button"/>
  /// <seealso cref="IWidgetsScriptsRendererExtensions.Pinterest(IWidgetsScriptsRenderer)"/>
  public sealed class PinterestFollowButtonWidget : HtmlWidget, IPinterestFollowButtonWidget
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
      Assertion.NotEmpty(account);

      this.account = account;
      return this;
    }

    /// <summary>
    ///   <para>Pinterest user account.</para>
    /// </summary>
    /// <returns>Account name.</returns>
    public string Account()
    {
      return this.account;
    }

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
      Assertion.NotEmpty(label);

      this.label = label;
      return this;
    }

    /// <summary>
    ///   <para>Text label on the button.</para>
    /// </summary>
    /// <returns>Button's label.</returns>
    public string Label()
    {
      return this.label;
    }

    /// <summary>
    ///   <para>Returns HTML markup text of widget.</para>
    /// </summary>
    /// <returns>Widget's HTML markup.</returns>
    public override string ToHtmlString()
    {
      if (this.Account().IsEmpty() || this.Label().IsEmpty())
      {
        return string.Empty;
      }

      return new TagBuilder("a")
        .Attribute("data-pin-do", "buttonFollow")
        .Attribute("href", "http://www.pinterest.com/{0}".FormatSelf(this.Account()))
        .InnerHtml(this.Label())
        .ToString();
    }
  }
}