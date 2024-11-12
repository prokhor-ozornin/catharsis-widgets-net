using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using Catharsis.Extensions;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Renders Twitter "Tweet" button.</para>
  ///   <para>Requires Twitter scripts bundle to be included.</para>
  /// </summary>
  /// <seealso cref="https://dev.twitter.com/docs/tweet-button"/>
  /// <seealso cref="IWidgetsScriptsRendererExtensions.Twitter(IWidgetsScriptsRenderer)"/>
  public class TwitterTweetButtonWidget : HtmlWidget, ITwitterTweetButtonWidget
  {
    private string url;
    private string language;
    private string text;
    private string via;
    private string size;
    private string countUrl;
    private string counterPosition;
    private bool? suggestions;
    private IEnumerable<string> accounts = Enumerable.Empty<string>();
    private IEnumerable<string> tags = Enumerable.Empty<string>();

    /// <summary>
    ///   <para>Count box position. Default is "horizontal".</para>
    /// </summary>
    /// <param name="position">Count box position.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="position"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="position"/> is <see cref="string.Empty"/> string.</exception>
    public ITwitterTweetButtonWidget CounterPosition(string position)
    {
      if (position is null) throw new ArgumentNullException(nameof(position));
      if (position.IsEmpty()) throw new ArgumentException(nameof(position));

      counterPosition = position;
      return this;
    }

    /// <summary>
    ///   <para>Count box position. Default is "horizontal".</para>
    /// </summary>
    /// <returns>Count box position.</returns>
    public string CounterPosition() => counterPosition;

    /// <summary>
    ///   <para>The URL to which your shared URL resolves. Default is the URL being shared.</para>
    /// </summary>
    /// <param name="url">Resolved URL of shared post.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="url"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="url"/> is <see cref="string.Empty"/> string.</exception>
    public ITwitterTweetButtonWidget CountUrl(string url)
    {
      if (url is null) throw new ArgumentNullException(nameof(url));
      if (url.IsEmpty()) throw new ArgumentException(nameof(url));

      countUrl = url;
      return this;
    }

    /// <summary>
    ///   <para>The URL to which your shared URL resolves. Default is the URL being shared.</para>
    /// </summary>
    /// <returns>Resolved URL of shared post.</returns>
    public string CountUrl() => countUrl;

    /// <summary>
    ///   <para>Collection of hashtags which are to be appended to tweet text.</para>
    /// </summary>
    /// <param name="tags">Collection of tags for post.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="tags"/> is a <c>null</c> reference.</exception>
    public ITwitterTweetButtonWidget HashTags(IEnumerable<string> tags)
    {
      this.tags = tags ?? throw new ArgumentNullException(nameof(tags));
      return this;
    }

    /// <summary>
    ///   <para>Collection of hashtags which are to be appended to tweet text.</para>
    /// </summary>
    /// <returns>Collection of tags for post.</returns>
    public IEnumerable<string> HashTags() => tags;

    /// <summary>
    ///   <para>Language for the "Tweet" button. Default is either request locale's language or language of the current thread.</para>
    /// </summary>
    /// <param name="language">Interface language for button.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="language"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="language"/> is <see cref="string.Empty"/> string.</exception>
    public ITwitterTweetButtonWidget Language(string language)
    {
      if (language is null) throw new ArgumentNullException(nameof(language));
      if (language.IsEmpty()) throw new ArgumentException(nameof(language));

      this.language = language;
      return this;
    }

    /// <summary>
    ///   <para>Language for the "Tweet" button. Default is either request locale's language or language of the current thread.</para>
    /// </summary>
    /// <returns>Interface language for button.</returns>
    public string Language() => language;

    /// <summary>
    ///   <para>Whether to enable twitter suggestions. Default is <c>true</c>.</para>
    /// </summary>
    /// <param name="enabled"><c>true</c> to not opt-out of suggestions, <c>false</c> to opt-in.</param>
    /// <returns>Reference to the current widget.</returns>
    public ITwitterTweetButtonWidget Suggestions(bool enabled)
    {
      suggestions = enabled;
      return this;
    }

    /// <summary>
    ///   <para>Whether to enable twitter suggestions. Default is <c>true</c>.</para>
    /// </summary>
    /// <returns><c>true</c> to not opt-out of suggestions, <c>false</c> to opt-in.</returns>
    public bool? Suggestions() => suggestions;

    /// <summary>
    ///   <para>Collection of related accounts.</para>
    /// </summary>
    /// <param name="accounts">Collection of related accounts.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="accounts"/> is a <c>null</c> reference.</exception>
    public ITwitterTweetButtonWidget RelatedAccounts(IEnumerable<string> accounts)
    {
      if (accounts is null) throw new ArgumentNullException(nameof(accounts));

      this.accounts = accounts;
      return this;
    }

    /// <summary>
    ///   <para>Collection of related accounts.</para>
    /// </summary>
    /// <returns>Collection of related accounts.</returns>
    public IEnumerable<string> RelatedAccounts() => accounts;

    /// <summary>
    ///   <para>The size of the rendered button. Default is "medium".</para>
    /// </summary>
    /// <param name="size">Size of button.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="size"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="size"/> is <see cref="string.Empty"/> string.</exception>
    public ITwitterTweetButtonWidget Size(string size)
    {
      if (size is null) throw new ArgumentNullException(nameof(size));
      if (size.IsEmpty()) throw new ArgumentException(nameof(size));

      this.size = size;
      return this;
    }

    /// <summary>
    ///   <para>The size of the rendered button. Default is "medium".</para>
    /// </summary>
    /// <returns>Size of button.</returns>
    public string Size() => this.size;

    /// <summary>
    ///   <para>Tweet text. Default is content of the "title" tag.</para>
    /// </summary>
    /// <param name="text">Tweet text.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="text"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="text"/> is <see cref="string.Empty"/> string.</exception>
    public ITwitterTweetButtonWidget Text(string text)
    {
      if (text is null) throw new ArgumentNullException(nameof(text));
      if (text.IsEmpty()) throw new ArgumentException(nameof(text));

      this.text = text;
      return this;
    }

    /// <summary>
    ///   <para>Tweet text. Default is content of the "title" tag.</para>
    /// </summary>
    /// <returns>Tweet text.</returns>
    public string Text() => text;

    /// <summary>
    ///   <para>URL of the page to share. Default is contents of HTTP "Referrer" header.</para>
    /// </summary>
    /// <param name="url">URL of shared web page.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="url"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="url"/> is <see cref="string.Empty"/> string.</exception>
    public ITwitterTweetButtonWidget Url(string url)
    {
      if (url is null) throw new ArgumentNullException(nameof(url));
      if (url.IsEmpty()) throw new ArgumentException(nameof(url));

      this.url = url;
      return this;
    }

    /// <summary>
    ///   <para>URL of the page to share. Default is contents of HTTP "Referrer" header.</para>
    /// </summary>
    /// <returns>URL of shared web page.</returns>
    public string Url() => url;

    /// <summary>
    ///   <para>Screen name of the user to attribute the Tweet to.</para>
    /// </summary>
    /// <param name="account">Screen name of tweet's author.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="account"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="account"/> is <see cref="string.Empty"/> string.</exception>
    public ITwitterTweetButtonWidget Via(string account)
    {
      if (account is null) throw new ArgumentNullException(nameof(account));
      if (account.IsEmpty()) throw new ArgumentException(nameof(account));

      via = account;
      return this;
    }

    /// <summary>
    ///   <para>Screen name of the user to attribute the Tweet to.</para>
    /// </summary>
    /// <returns>Screen name of tweet's author.</returns>
    public string Via() => via;

    /// <summary>
    ///   <para>Returns HTML markup text of widget.</para>
    /// </summary>
    /// <returns>Widget's HTML markup.</returns>
    public override string ToHtmlString()
    {
      return new TagBuilder("a")
        .Attribute("href", "https://twitter.com/share")
        .Attribute("data-lang", Language() ?? (HttpContext.Current is not null ? HttpContext.Current.Request.Language() : Thread.CurrentThread.CurrentCulture.TwoLetterISOLanguageName))
        .Attribute("data-url", Url())
        .Attribute("data-via", Via())
        .Attribute("data-text", Text())
        .Attribute("data-related", RelatedAccounts().Any() ? RelatedAccounts().Join(",") : null)
        .Attribute("data-count", CounterPosition())
        .Attribute("data-counturl", CountUrl())
        .Attribute("data-hashtags", HashTags().Any() ? HashTags().Join(" ") : null)
        .Attribute("data-size", Size())
        .Attribute("data-dnt", Suggestions() is null ? null : !Suggestions())
        .CssClass(tags.Any() ? "twitter-hashtag-button" : "twitter-share-button")
        .ToString();
    }
  }
}