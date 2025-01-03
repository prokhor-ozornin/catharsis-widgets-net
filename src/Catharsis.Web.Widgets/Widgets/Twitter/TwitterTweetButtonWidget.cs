using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="ITwitterTweetButtonWidget"/>
public class TwitterTweetButtonWidget : WebWidget, ITwitterTweetButtonWidget
{
  private string url;
  private string language;
  private string text;
  private string via;
  private string size;
  private string countUrl;
  private string counterPosition;
  private bool? suggestions;
  private IEnumerable<string> accounts = [];
  private IEnumerable<string> tags = [];

  /// <inheritdoc cref="ITwitterTweetButtonWidget.CounterPosition(string)"/>
  public ITwitterTweetButtonWidget CounterPosition(string position)
  {
    if (position is null) throw new ArgumentNullException(nameof(position));
    if (position.IsEmpty()) throw new ArgumentException(nameof(position));

    counterPosition = position;
    return this;
  }

  /// <inheritdoc cref="ITwitterTweetButtonWidget.CounterPosition()"/>
  public string CounterPosition() => counterPosition;

  /// <inheritdoc cref="ITwitterTweetButtonWidget.CountUrl(string)"/>
  public ITwitterTweetButtonWidget CountUrl(string url)
  {
    if (url is null) throw new ArgumentNullException(nameof(url));
    if (url.IsEmpty()) throw new ArgumentException(nameof(url));

    countUrl = url;
    return this;
  }

  /// <inheritdoc cref="ITwitterTweetButtonWidget.CountUrl()"/>
  public string CountUrl() => countUrl;

  /// <inheritdoc cref="ITwitterTweetButtonWidget.HashTags(IEnumerable{string})"/>
  public ITwitterTweetButtonWidget HashTags(IEnumerable<string> tags)
  {
    this.tags = tags ?? throw new ArgumentNullException(nameof(tags));
    return this;
  }

  /// <inheritdoc cref="ITwitterTweetButtonWidget.HashTags()"/>
  public IEnumerable<string> HashTags() => tags;

  /// <inheritdoc cref="ITwitterTweetButtonWidget.Language(string)"/>
  public ITwitterTweetButtonWidget Language(string language)
  {
    if (language is null) throw new ArgumentNullException(nameof(language));
    if (language.IsEmpty()) throw new ArgumentException(nameof(language));

    this.language = language;
    return this;
  }

  /// <inheritdoc cref="ITwitterTweetButtonWidget.Language()"/>
  public string Language() => language;

  /// <inheritdoc cref="ITwitterTweetButtonWidget.Suggestions(bool)"/>
  public ITwitterTweetButtonWidget Suggestions(bool enabled)
  {
    suggestions = enabled;
    return this;
  }

  /// <inheritdoc cref="ITwitterTweetButtonWidget.Suggestions()"/>
  public bool? Suggestions() => suggestions;

  /// <inheritdoc cref="ITwitterTweetButtonWidget.RelatedAccounts(IEnumerable{string})"/>
  public ITwitterTweetButtonWidget RelatedAccounts(IEnumerable<string> accounts)
  {
    this.accounts = accounts ?? throw new ArgumentNullException(nameof(accounts));
    return this;
  }

  /// <inheritdoc cref="ITwitterTweetButtonWidget.RelatedAccounts()"/>
  public IEnumerable<string> RelatedAccounts() => accounts;

  /// <inheritdoc cref="ITwitterTweetButtonWidget.Size(string)"/>
  public ITwitterTweetButtonWidget Size(string size)
  {
    if (size is null) throw new ArgumentNullException(nameof(size));
    if (size.IsEmpty()) throw new ArgumentException(nameof(size));

    this.size = size;
    return this;
  }

  /// <inheritdoc cref="ITwitterTweetButtonWidget.Size()"/>
  public string Size() => size;

  /// <inheritdoc cref="ITwitterTweetButtonWidget.Text(string)"/>
  public ITwitterTweetButtonWidget Text(string text)
  {
    if (text is null) throw new ArgumentNullException(nameof(text));
    if (text.IsEmpty()) throw new ArgumentException(nameof(text));

    this.text = text;
    return this;
  }

  /// <inheritdoc cref="ITwitterTweetButtonWidget.Text()"/>
  public string Text() => text;

  /// <inheritdoc cref="ITwitterTweetButtonWidget.Url(string)"/>
  public ITwitterTweetButtonWidget Url(string url)
  {
    if (url is null) throw new ArgumentNullException(nameof(url));
    if (url.IsEmpty()) throw new ArgumentException(nameof(url));

    this.url = url;
    return this;
  }

  /// <inheritdoc cref="ITwitterTweetButtonWidget.Url()"/>
  public string Url() => url;

  /// <inheritdoc cref="ITwitterTweetButtonWidget.Via(string)"/>
  public ITwitterTweetButtonWidget Via(string account)
  {
    if (account is null) throw new ArgumentNullException(nameof(account));
    if (account.IsEmpty()) throw new ArgumentException(nameof(account));

    via = account;
    return this;
  }

  /// <inheritdoc cref="ITwitterTweetButtonWidget.Via()"/>
  public string Via() => via;

  /// <inheritdoc cref="IHtmlContent.ToHtml()"/>
  public override string ToHtml() => new TagBuilder("a")
      .Attribute("href", "https://twitter.com/share")
      .Attribute("data-lang", Language() ?? Thread.CurrentThread.CurrentCulture.TwoLetterISOLanguageName)
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