using System;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Renders Pinterest "Follow Me" button.</para>
  ///   <para>Requires <see cref="WidgetsScripts.Pinterest"/> script to be included.</para>
  /// </summary>
  /// <seealso cref="http://business.pinterest.com/widget-builder/#do_follow_me_button"/>
  public interface IPinterestFollowButtonWidget : IHtmlWidget
  {
    /// <summary>
    ///   <para>Pinterest user account.</para>
    /// </summary>
    /// <param name="account">Account name.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="account"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="account"/> is <see cref="string.Empty"/> string.</exception>
    /// <remarks>This attribute is required.</remarks>
    IPinterestFollowButtonWidget Account(string account);

    /// <summary>
    ///   <para>Text label on the button.</para>
    /// </summary>
    /// <param name="label">Button's label.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="label"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="label"/> is <see cref="string.Empty"/> string.</exception>
    /// <remarks>This attribute is required.</remarks>
    IPinterestFollowButtonWidget Label(string label);
  }
}