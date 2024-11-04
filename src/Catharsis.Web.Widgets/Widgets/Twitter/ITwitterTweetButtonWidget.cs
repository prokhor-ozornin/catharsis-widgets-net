using System;
using System.Collections.Generic;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Renders Twitter "Tweet" button.</para>
  ///   <para>Requires Twitter scripts bundle to be included.</para>
  /// </summary>
  /// <seealso cref="https://dev.twitter.com/docs/tweet-button"/>
  /// <seealso cref="IWidgetsScriptsRendererExtensions.Twitter(IWidgetsScriptsRenderer)"/>
  public interface ITwitterTweetButtonWidget : IHtmlWidget
  {
    /// <summary>
    ///   <para>Count box position. Default is "horizontal".</para>
    /// </summary>
    /// <param name="position">Count box position.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="position"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="position"/> is <see cref="string.Empty"/> string.</exception>
    ITwitterTweetButtonWidget CounterPosition(string position);

    /// <summary>
    ///   <para>Count box position. Default is "horizontal".</para>
    /// </summary>
    /// <returns>Count box position.</returns>
    string CounterPosition();

    /// <summary>
    ///   <para>The URL to which your shared URL resolves. Default is the URL being shared.</para>
    /// </summary>
    /// <param name="url">Resolved URL of shared post.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="url"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="url"/> is <see cref="string.Empty"/> string.</exception>
    ITwitterTweetButtonWidget CountUrl(string url);

    /// <summary>
    ///   <para>The URL to which your shared URL resolves. Default is the URL being shared.</para>
    /// </summary>
    /// <returns>Resolved URL of shared post.</returns>
    string CountUrl();

    /// <summary>
    ///   <para>Collection of hashtags which are to be appended to tweet text.</para>
    /// </summary>
    /// <param name="tags">Collection of tags for post.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="tags"/> is a <c>null</c> reference.</exception>
    ITwitterTweetButtonWidget HashTags(IEnumerable<string> tags);

    /// <summary>
    ///   <para>Collection of hashtags which are to be appended to tweet text.</para>
    /// </summary>
    /// <returns>Collection of tags for post.</returns>
    IEnumerable<string> HashTags();

    /// <summary>
    ///   <para>Language for the "Tweet" button. Default is either request locale's language or language of the current thread.</para>
    /// </summary>
    /// <param name="language">Interface language for button.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="language"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="language"/> is <see cref="string.Empty"/> string.</exception>
    ITwitterTweetButtonWidget Language(string language);

    /// <summary>
    ///   <para>Language for the "Tweet" button. Default is either request locale's language or language of the current thread.</para>
    /// </summary>
    /// <returns>Interface language for button.</returns>
    string Language();

    /// <summary>
    ///   <para>Whether to enable twitter suggestions. Default is <c>true</c>.</para>
    /// </summary>
    /// <param name="enabled"><c>true</c> to not opt-out of suggestions, <c>false</c> to opt-in.</param>
    /// <returns>Reference to the current widget.</returns>
    ITwitterTweetButtonWidget Suggestions(bool enabled);

    /// <summary>
    ///   <para>Whether to enable twitter suggestions. Default is <c>true</c>.</para>
    /// </summary>
    /// <returns><c>true</c> to not opt-out of suggestions, <c>false</c> to opt-in.</returns>
    bool? Suggestions();

    /// <summary>
    ///   <para>Collection of related accounts.</para>
    /// </summary>
    /// <param name="accounts">Collection of related accounts.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="accounts"/> is a <c>null</c> reference.</exception>
    ITwitterTweetButtonWidget RelatedAccounts(IEnumerable<string> accounts);

    /// <summary>
    ///   <para>Collection of related accounts.</para>
    /// </summary>
    /// <returns>Collection of related accounts.</returns>
    IEnumerable<string> RelatedAccounts();

    /// <summary>
    ///   <para>The size of the rendered button. Default is "medium".</para>
    /// </summary>
    /// <param name="size">Size of button.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="size"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="size"/> is <see cref="string.Empty"/> string.</exception>
    ITwitterTweetButtonWidget Size(string size);

    /// <summary>
    ///   <para>The size of the rendered button. Default is "medium".</para>
    /// </summary>
    /// <returns>Size of button.</returns>
    string Size();

    /// <summary>
    ///   <para>Tweet text. Default is content of the "title" tag.</para>
    /// </summary>
    /// <param name="text">Tweet text.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="text"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="text"/> is <see cref="string.Empty"/> string.</exception>
    ITwitterTweetButtonWidget Text(string text);

    /// <summary>
    ///   <para>Tweet text. Default is content of the "title" tag.</para>
    /// </summary>
    /// <returns>Tweet text.</returns>
    string Text();

    /// <summary>
    ///   <para>URL of the page to share. Default is contents of HTTP "Referrer" header.</para>
    /// </summary>
    /// <param name="url">URL of shared web page.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="url"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="url"/> is <see cref="string.Empty"/> string.</exception>
    ITwitterTweetButtonWidget Url(string url);

    /// <summary>
    ///   <para>URL of the page to share. Default is contents of HTTP "Referrer" header.</para>
    /// </summary>
    /// <returns>URL of shared web page.</returns>
    string Url();

    /// <summary>
    ///   <para>Screen name of the user to attribute the Tweet to.</para>
    /// </summary>
    /// <param name="account">Screen name of tweet's author.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="account"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="account"/> is <see cref="string.Empty"/> string.</exception>
    ITwitterTweetButtonWidget Via(string account);

    /// <summary>
    ///   <para>Screen name of the user to attribute the Tweet to.</para>
    /// </summary>
    /// <returns>Screen name of tweet's author.</returns>
    string Via();
  }
}