using System;
using System.Collections.Generic;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Renders Twitter "Tweet" button.</para>
  ///   <para>Requires <see cref="WidgetsScriptsBundles.Twitter"/> scripts bundle to be included.</para>
  ///   <seealso cref="https://dev.twitter.com/docs/tweet-button"/>
  /// </summary>
  public interface ITwitterTweetButtonWidget : IHtmlWidget
  {
    /// <summary>
    ///   <para>Specifies URL of the page to share. Default is contents of HTTP "Referrer" header.</para>
    /// </summary>
    /// <param name="url">URL of shared web page.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="url"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="url"/> is <see cref="string.Empty"/> string.</exception>
    ITwitterTweetButtonWidget Url(string url);

    /// <summary>
    ///   <para>Specifies language for the "Tweet" button. Default is either request locale's language or language of the current thread.</para>
    /// </summary>
    /// <param name="language">Interface language for button.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="language"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="language"/> is <see cref="string.Empty"/> string.</exception>
    ITwitterTweetButtonWidget Language(string language);
    
    /// <summary>
    ///   <para>Specifies Tweet text. Default is content of the "title" tag.</para>
    /// </summary>
    /// <param name="text">Tweet text.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="text"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="text"/> is <see cref="string.Empty"/> string.</exception>
    ITwitterTweetButtonWidget Text(string text);

    /// <summary>
    ///   <para>Specifies screen name of the user to attribute the Tweet to.</para>
    /// </summary>
    /// <param name="account">Screen name of tweet's author.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="account"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="account"/> is <see cref="string.Empty"/> string.</exception>
    ITwitterTweetButtonWidget Via(string account);

    /// <summary>
    ///   <para>Specifies the size of the rendered button. Default is "medium".</para>
    /// </summary>
    /// <param name="size">Size of button.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="size"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="size"/> is <see cref="string.Empty"/> string.</exception>
    ITwitterTweetButtonWidget Size(string size);

    /// <summary>
    ///   <para>Specifies the URL to which your shared URL resolves. Default is the URL being shared.</para>
    /// </summary>
    /// <param name="url">Resolved URL of shared post.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="url"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="url"/> is <see cref="string.Empty"/> string.</exception>
    ITwitterTweetButtonWidget CountUrl(string url);

    /// <summary>
    ///   <para>Specifies count box position. Default is "horizontal".</para>
    /// </summary>
    /// <param name="position">Count box position.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="position"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="position"/> is <see cref="string.Empty"/> string.</exception>
    ITwitterTweetButtonWidget CountPosition(string position);

    /// <summary>
    ///   <para>Specifies whether to opt-out of twitter suggestions. Default is <c>false</c>.</para>
    /// </summary>
    /// <param name="optOut"><c>true</c> to opt-out, <c>false</c> to opt-in.</param>
    /// <returns>Reference to the current widget.</returns>
    ITwitterTweetButtonWidget OptOut(bool optOut = true);

    /// <summary>
    ///   <para>Specifies collection of hashtags which are to be appended to tweet text.</para>
    /// </summary>
    /// <param name="tags">Collection of tags for post.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="tags"/> is a <c>null</c> reference.</exception>
    ITwitterTweetButtonWidget HashTags(IEnumerable<string> tags);

    /// <summary>
    ///   <para>Specifies collection of related accounts.</para>
    /// </summary>
    /// <param name="accounts">Collection of related accounts.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="accounts"/> is a <c>null</c> reference.</exception>
    ITwitterTweetButtonWidget RelatedAccounts(IEnumerable<string> accounts);
  }
}