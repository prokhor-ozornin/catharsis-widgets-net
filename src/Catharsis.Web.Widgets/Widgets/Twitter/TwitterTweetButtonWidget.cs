using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="ITwitterTweetButtonWidget"/>
public class TwitterTweetButtonWidget : WebWidget, ITwitterTweetButtonWidget
{
  private string UrlProperty { get; set; }
  private string LanguageProperty { get; set; }
  private string TextProperty { get; set; }
  private string ViaProperty { get; set; }
  private string SizeProperty { get; set; }
  private string CountUrlProperty { get; set; }
  private string CounterPositionProperty { get; set; }
  private bool? SuggestionsProperty { get; set; }
  private IEnumerable<string> AccountsProperty { get; set; } = [];
  private IEnumerable<string> TagsProperty { get; set; } = [];

  /// <inheritdoc cref="ITwitterTweetButtonWidget.CounterPosition(string)"/>
  public ITwitterTweetButtonWidget CounterPosition(string position)
  {
    if (position is null) throw new ArgumentNullException(nameof(position));
    if (position.IsEmpty()) throw new ArgumentException(nameof(position));

    CounterPositionProperty = position;
    return this;
  }

  /// <inheritdoc cref="ITwitterTweetButtonWidget.CounterPosition()"/>
  public string CounterPosition() => CounterPositionProperty;

  /// <inheritdoc cref="ITwitterTweetButtonWidget.CountUrl(string)"/>
  public ITwitterTweetButtonWidget CountUrl(string url)
  {
    if (url is null) throw new ArgumentNullException(nameof(url));
    if (url.IsEmpty()) throw new ArgumentException(nameof(url));

    CountUrlProperty = url;
    return this;
  }

  /// <inheritdoc cref="ITwitterTweetButtonWidget.CountUrl()"/>
  public string CountUrl() => CountUrlProperty;

  /// <inheritdoc cref="ITwitterTweetButtonWidget.HashTags(IEnumerable{string})"/>
  public ITwitterTweetButtonWidget HashTags(IEnumerable<string> tags)
  {
    TagsProperty = tags ?? throw new ArgumentNullException(nameof(tags));
    return this;
  }

  /// <inheritdoc cref="ITwitterTweetButtonWidget.HashTags()"/>
  public IEnumerable<string> HashTags() => TagsProperty;

  /// <inheritdoc cref="ITwitterTweetButtonWidget.Language(string)"/>
  public ITwitterTweetButtonWidget Language(string language)
  {
    if (language is null) throw new ArgumentNullException(nameof(language));
    if (language.IsEmpty()) throw new ArgumentException(nameof(language));

    LanguageProperty = language;
    return this;
  }

  /// <inheritdoc cref="ITwitterTweetButtonWidget.Language()"/>
  public string Language() => LanguageProperty;

  /// <inheritdoc cref="ITwitterTweetButtonWidget.Suggestions(bool)"/>
  public ITwitterTweetButtonWidget Suggestions(bool enabled)
  {
    SuggestionsProperty = enabled;
    return this;
  }

  /// <inheritdoc cref="ITwitterTweetButtonWidget.Suggestions()"/>
  public bool? Suggestions() => SuggestionsProperty;

  /// <inheritdoc cref="ITwitterTweetButtonWidget.RelatedAccounts(IEnumerable{string})"/>
  public ITwitterTweetButtonWidget RelatedAccounts(IEnumerable<string> accounts)
  {
    AccountsProperty = accounts ?? throw new ArgumentNullException(nameof(accounts));
    return this;
  }

  /// <inheritdoc cref="ITwitterTweetButtonWidget.RelatedAccounts()"/>
  public IEnumerable<string> RelatedAccounts() => AccountsProperty;

  /// <inheritdoc cref="ITwitterTweetButtonWidget.Size(string)"/>
  public ITwitterTweetButtonWidget Size(string size)
  {
    if (size is null) throw new ArgumentNullException(nameof(size));
    if (size.IsEmpty()) throw new ArgumentException(nameof(size));

    SizeProperty = size;
    return this;
  }

  /// <inheritdoc cref="ITwitterTweetButtonWidget.Size()"/>
  public string Size() => SizeProperty;

  /// <inheritdoc cref="ITwitterTweetButtonWidget.Text(string)"/>
  public ITwitterTweetButtonWidget Text(string text)
  {
    if (text is null) throw new ArgumentNullException(nameof(text));
    if (text.IsEmpty()) throw new ArgumentException(nameof(text));

    TextProperty = text;
    return this;
  }

  /// <inheritdoc cref="ITwitterTweetButtonWidget.Text()"/>
  public string Text() => TextProperty;

  /// <inheritdoc cref="ITwitterTweetButtonWidget.Url(string)"/>
  public ITwitterTweetButtonWidget Url(string url)
  {
    if (url is null) throw new ArgumentNullException(nameof(url));
    if (url.IsEmpty()) throw new ArgumentException(nameof(url));

    UrlProperty = url;
    return this;
  }

  /// <inheritdoc cref="ITwitterTweetButtonWidget.Url()"/>
  public string Url() => UrlProperty;

  /// <inheritdoc cref="ITwitterTweetButtonWidget.Via(string)"/>
  public ITwitterTweetButtonWidget Via(string account)
  {
    if (account is null) throw new ArgumentNullException(nameof(account));
    if (account.IsEmpty()) throw new ArgumentException(nameof(account));

    ViaProperty = account;
    return this;
  }

  /// <inheritdoc cref="ITwitterTweetButtonWidget.Via()"/>
  public string Via() => ViaProperty;

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
      .CssClass(TagsProperty.Any() ? "twitter-hashtag-button" : "twitter-share-button")
      .ToString();
}