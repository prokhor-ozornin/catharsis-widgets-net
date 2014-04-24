using System;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Renders Twitter "Follow" button.</para>
  ///   <para>Requires Twitter scripts bundle to be included.</para>
  /// </summary>
  /// <seealso cref="https://dev.twitter.com/docs/follow-button"/>
  /// <seealso cref="IWidgetsScriptsRendererExtensions.Twitter(IWidgetsScriptsRenderer)"/>
  public interface ITwitterFollowButtonWidget : IHtmlWidget
  {
    /// <summary>
    ///   <para>Twitter account name.</para>
    /// </summary>
    /// <param name="account">Account name.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="account"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="account"/> is <see cref="string.Empty"/> string.</exception>
    /// <remarks>This attribute is required.</remarks>
    ITwitterFollowButtonWidget Account(string account);

    /// <summary>
    ///   <para>Horizontal alignment of the button.</para>
    /// </summary>
    /// <param name="alignment">Horizontal alignment of button.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="alignment"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="alignment"/> is <see cref="string.Empty"/> string.</exception>
    ITwitterFollowButtonWidget Alignment(string alignment);

    /// <summary>
    ///   <para>Whether to display user's followers count. Default is <c>false</c>.</para>
    /// </summary>
    /// <param name="show"><c>true</c> to show followers count, <c>false</c> to hide.</param>
    /// <returns>Reference to the current widget.</returns>
    ITwitterFollowButtonWidget Counter(bool show = true);

    /// <summary>
    ///   <para>Language for the "Follow" button. Default is either request locale's language or language of the current thread.</para>
    /// </summary>
    /// <param name="language">Interface language for button.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="language"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="language"/> is <see cref="string.Empty"/> string.</exception>
    ITwitterFollowButtonWidget Language(string language);

    /// <summary>
    ///   <para>Whether to show user's screen name. Default is <c>true</c>.</para>
    /// </summary>
    /// <param name="screenName"><c>true</c> to show screen name, <c>false</c> to hide.</param>
    /// <returns>Reference to the current widget.</returns>
    ITwitterFollowButtonWidget ScreenName(bool screenName = true);

    /// <summary>
    ///   <para>The size of the rendered button. Default is "medium".</para>
    /// </summary>
    /// <param name="size">Size of button.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="size"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="size"/> is <see cref="string.Empty"/> string.</exception>
    ITwitterFollowButtonWidget Size(string size);

    /// <summary>
    ///   <para>Whether to enable twitter suggestions. Default is <c>true</c>.</para>
    /// </summary>
    /// <param name="enabled"><c>true</c> to not opt-out of suggestions, <c>false</c> to opt-in.</param>
    /// <returns>Reference to the current widget.</returns>
    ITwitterFollowButtonWidget Suggestions(bool enabled = true);

    /// <summary>
    ///   <para>Width of the button.</para>
    /// </summary>
    /// <param name="width">Width of button.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="width"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="width"/> is <see cref="string.Empty"/> string.</exception>
    ITwitterFollowButtonWidget Width(string width);
  }
}