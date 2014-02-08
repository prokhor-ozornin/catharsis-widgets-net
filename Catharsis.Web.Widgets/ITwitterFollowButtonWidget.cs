using System;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Renders Twitter "Follow" button.</para>
  ///   <para>Requires <see cref="WidgetsScriptsBundles.Twitter"/> scripts bundle to be included.</para>
  ///   <seealso cref="https://dev.twitter.com/docs/follow-button"/>
  /// </summary>
  public interface ITwitterFollowButtonWidget : IHtmlWidget
  {
    /// <summary>
    ///   <para>Specifies Twitter account name.</para>
    /// </summary>
    /// <param name="account">Account name.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="account"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="account"/> is <see cref="string.Empty"/> string.</exception>
    /// <remarks>This attribute is required.</remarks>
    ITwitterFollowButtonWidget Account(string account);

    /// <summary>
    ///   <para>Specifies language for the "Follow" button. Default is either request locale's language or language of the current thread.</para>
    /// </summary>
    /// <param name="language">Interface language for button.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="language"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="language"/> is <see cref="string.Empty"/> string.</exception>
    ITwitterFollowButtonWidget Language(string language);

    /// <summary>
    ///   <para>Specifies the size of the rendered button. Default is "medium".</para>
    /// </summary>
    /// <param name="size">Size of button.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="size"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="size"/> is <see cref="string.Empty"/> string.</exception>
    ITwitterFollowButtonWidget Size(string size);

    /// <summary>
    ///   <para>Specifies horizontal alignment of the button.</para>
    /// </summary>
    /// <param name="alignment">Horizontal alignment of button.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="alignment"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="alignment"/> is <see cref="string.Empty"/> string.</exception>
    ITwitterFollowButtonWidget Alignment(string alignment);

    /// <summary>
    ///   <para>Specifies whether to display user's followers count. Default is <c>false</c>.</para>
    /// </summary>
    /// <param name="show"><c>true</c> to show followers count, <c>false</c> to hide.</param>
    /// <returns>Reference to the current widget.</returns>
    ITwitterFollowButtonWidget ShowCount(bool show = true);

    /// <summary>
    ///   <para>Specifies whether to show user's screen name. Default is <c>true</c>.</para>
    /// </summary>
    /// <param name="show"><c>true</c> to show screen name, <c>false</c> to hide.</param>
    /// <returns>Reference to the current widget.</returns>
    ITwitterFollowButtonWidget ShowScreenName(bool show = true);

    /// <summary>
    ///   <para>Specifies whether to opt-out of twitter suggestions. Default is <c>false</c>.</para>
    /// </summary>
    /// <param name="optOut"><c>true</c> to opt-out, <c>false</c> to opt-in.</param>
    /// <returns>Reference to the current widget.</returns>
    ITwitterFollowButtonWidget OptOut(bool optOut = true);

    /// <summary>
    ///   <para>Specifies width of the button.</para>
    /// </summary>
    /// <param name="width">Width of button.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="width"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="width"/> is <see cref="string.Empty"/> string.</exception>
    ITwitterFollowButtonWidget Width(string width);
  }
}