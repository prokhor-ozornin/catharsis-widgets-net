using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Renders Twitter "Tweet" button.</para>
  ///   <para>Requires <see cref="WidgetsScriptsBundles.Twitter"/> scripts bundle to be included.</para>
  /// </summary>
  /// <seealso cref="https://dev.twitter.com/docs/tweet-button"/>
  public class TwitterTweetButtonWidget : HtmlWidgetBase, ITwitterTweetButtonWidget
  {
    private string url;
    private string language;
    private string text;
    private string via;
    private string size;
    private string countUrl;
    private string countPosition;
    private bool? optOut;
    private IEnumerable<string> accounts = Enumerable.Empty<string>();
    private IEnumerable<string> tags = Enumerable.Empty<string>();

    /// <summary>
    ///   <para>Count box position. Default is "horizontal".</para>
    /// </summary>
    /// <param name="position">Count box position.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="position"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="position"/> is <see cref="string.Empty"/> string.</exception>
    public ITwitterTweetButtonWidget CountPosition(string position)
    {
      Assertion.NotEmpty(position);

      this.countPosition = position;
      return this;
    }

    /// <summary>
    ///   <para>The URL to which your shared URL resolves. Default is the URL being shared.</para>
    /// </summary>
    /// <param name="url">Resolved URL of shared post.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="url"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="url"/> is <see cref="string.Empty"/> string.</exception>
    public ITwitterTweetButtonWidget CountUrl(string url)
    {
      Assertion.NotEmpty(url);

      this.countUrl = url;
      return this;
    }

    /// <summary>
    ///   <para>Collection of hashtags which are to be appended to tweet text.</para>
    /// </summary>
    /// <param name="tags">Collection of tags for post.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="tags"/> is a <c>null</c> reference.</exception>
    public ITwitterTweetButtonWidget HashTags(IEnumerable<string> tags)
    {
      Assertion.NotNull(tags);

      this.tags = tags;
      return this;
    }

    /// <summary>
    ///   <para>Language for the "Tweet" button. Default is either request locale's language or language of the current thread.</para>
    /// </summary>
    /// <param name="language">Interface language for button.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="language"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="language"/> is <see cref="string.Empty"/> string.</exception>
    public ITwitterTweetButtonWidget Language(string language)
    {
      Assertion.NotEmpty(language);

      this.language = language;
      return this;
    }

    /// <summary>
    ///   <para>Whether to opt-out of twitter suggestions. Default is <c>false</c>.</para>
    /// </summary>
    /// <param name="optOut"><c>true</c> to opt-out, <c>false</c> to opt-in.</param>
    /// <returns>Reference to the current widget.</returns>
    public ITwitterTweetButtonWidget OptOut(bool optOut = true)
    {
      this.optOut = optOut;
      return this;
    }

    /// <summary>
    ///   <para>Collection of related accounts.</para>
    /// </summary>
    /// <param name="accounts">Collection of related accounts.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="accounts"/> is a <c>null</c> reference.</exception>
    public ITwitterTweetButtonWidget RelatedAccounts(IEnumerable<string> accounts)
    {
      Assertion.NotNull(accounts);

      this.accounts = accounts;
      return this;
    }

    /// <summary>
    ///   <para>The size of the rendered button. Default is "medium".</para>
    /// </summary>
    /// <param name="size">Size of button.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="size"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="size"/> is <see cref="string.Empty"/> string.</exception>
    public ITwitterTweetButtonWidget Size(string size)
    {
      Assertion.NotEmpty(size);

      this.size = size;
      return this;
    }

    /// <summary>
    ///   <para>Tweet text. Default is content of the "title" tag.</para>
    /// </summary>
    /// <param name="text">Tweet text.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="text"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="text"/> is <see cref="string.Empty"/> string.</exception>
    public ITwitterTweetButtonWidget Text(string text)
    {
      Assertion.NotEmpty(text);

      this.text = text;
      return this;
    }

    /// <summary>
    ///   <para>URL of the page to share. Default is contents of HTTP "Referrer" header.</para>
    /// </summary>
    /// <param name="url">URL of shared web page.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="url"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="url"/> is <see cref="string.Empty"/> string.</exception>
    public ITwitterTweetButtonWidget Url(string url)
    {
      Assertion.NotEmpty(url);

      this.url = url;
      return this;
    }

    /// <summary>
    ///   <para>Screen name of the user to attribute the Tweet to.</para>
    /// </summary>
    /// <param name="account">Screen name of tweet's author.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="account"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="account"/> is <see cref="string.Empty"/> string.</exception>
    public ITwitterTweetButtonWidget Via(string account)
    {
      Assertion.NotEmpty(account);

      this.via = account;
      return this;
    }

    /// <summary>
    ///   <para>Returns HTML markup text of widget.</para>
    /// </summary>
    /// <returns>Widget's HTML markup.</returns>
    public override string ToHtmlString()
    {
      return new TagBuilder("a")
        .Attribute("href", "https://twitter.com/share")
        .Attribute("data-lang", this.language ?? (HttpContext.Current != null ? HttpContext.Current.Request.Language() : Thread.CurrentThread.CurrentCulture.TwoLetterISOLanguageName))
        .Attribute("data-url", this.url)
        .Attribute("data-via", this.via)
        .Attribute("data-text", this.text)
        .Attribute("data-related", this.accounts.Any() ? this.accounts.Join(",") : null)
        .Attribute("data-count", this.countPosition)
        .Attribute("data-counturl", this.countUrl)
        .Attribute("data-hashtags", this.tags.Any() ? this.tags.Join(" ") : null)
        .Attribute("data-size", this.size)
        .Attribute("data-dnt", this.optOut)
        .CssClass(this.tags.Any() ? "twitter-hashtag-button" : "twitter-share-button")
        .ToString();
    }
  }
}