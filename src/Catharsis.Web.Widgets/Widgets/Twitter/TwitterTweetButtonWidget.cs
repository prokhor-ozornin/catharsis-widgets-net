using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="ITwitterTweetButtonWidget"/>
public class TwitterTweetButtonWidget : WebWidget, ITwitterTweetButtonWidget
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string UrlValue { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string LanguageValue { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string TextValue { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string ViaValue { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string SizeValue { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string CountUrlValue { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string CounterPositionValue { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual bool? SuggestionsValue { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual IEnumerable<string> AccountsValue { get; set; } = [];

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual IEnumerable<string> TagsValue { get; set; } = [];

  /// <inheritdoc cref="ITwitterTweetButtonWidget.CounterPosition(string)"/>
  public virtual ITwitterTweetButtonWidget CounterPosition(string position)
  {
    if (position is null) throw new ArgumentNullException(nameof(position));
    if (position.IsEmpty()) throw new ArgumentException(nameof(position));

    CounterPositionValue = position;
    return this;
  }

  /// <inheritdoc cref="ITwitterTweetButtonWidget.CountUrl(string)"/>
  public virtual ITwitterTweetButtonWidget CountUrl(string url)
  {
    if (url is null) throw new ArgumentNullException(nameof(url));
    if (url.IsEmpty()) throw new ArgumentException(nameof(url));

    CountUrlValue = url;
    return this;
  }

  /// <inheritdoc cref="ITwitterTweetButtonWidget.HashTags(IEnumerable{string})"/>
  public virtual ITwitterTweetButtonWidget HashTags(IEnumerable<string> tags)
  {
    TagsValue = tags ?? throw new ArgumentNullException(nameof(tags));
    return this;
  }

  /// <inheritdoc cref="ITwitterTweetButtonWidget.Language(string)"/>
  public virtual ITwitterTweetButtonWidget Language(string language)
  {
    if (language is null) throw new ArgumentNullException(nameof(language));
    if (language.IsEmpty()) throw new ArgumentException(nameof(language));

    LanguageValue = language;
    return this;
  }

  /// <inheritdoc cref="ITwitterTweetButtonWidget.Suggestions(bool)"/>
  public virtual ITwitterTweetButtonWidget Suggestions(bool enabled)
  {
    SuggestionsValue = enabled;
    return this;
  }

  /// <inheritdoc cref="ITwitterTweetButtonWidget.RelatedAccounts(IEnumerable{string})"/>
  public virtual ITwitterTweetButtonWidget RelatedAccounts(IEnumerable<string> accounts)
  {
    AccountsValue = accounts ?? throw new ArgumentNullException(nameof(accounts));
    return this;
  }

  /// <inheritdoc cref="ITwitterTweetButtonWidget.Size(string)"/>
  public virtual ITwitterTweetButtonWidget Size(string size)
  {
    if (size is null) throw new ArgumentNullException(nameof(size));
    if (size.IsEmpty()) throw new ArgumentException(nameof(size));

    SizeValue = size;
    return this;
  }

  /// <inheritdoc cref="ITwitterTweetButtonWidget.Text(string)"/>
  public virtual ITwitterTweetButtonWidget Text(string text)
  {
    if (text is null) throw new ArgumentNullException(nameof(text));
    if (text.IsEmpty()) throw new ArgumentException(nameof(text));

    TextValue = text;
    return this;
  }

  /// <inheritdoc cref="ITwitterTweetButtonWidget.Url(string)"/>
  public virtual ITwitterTweetButtonWidget Url(string url)
  {
    if (url is null) throw new ArgumentNullException(nameof(url));
    if (url.IsEmpty()) throw new ArgumentException(nameof(url));

    UrlValue = url;
    return this;
  }

  /// <inheritdoc cref="ITwitterTweetButtonWidget.Via(string)"/>
  public virtual ITwitterTweetButtonWidget Via(string account)
  {
    if (account is null) throw new ArgumentNullException(nameof(account));
    if (account.IsEmpty()) throw new ArgumentException(nameof(account));

    ViaValue = account;
    return this;
  }

  /// <inheritdoc cref="ICloneable.Clone()"/>
  public override object Clone() => new TwitterTweetButtonWidget
  {
    UrlValue = UrlValue,
    LanguageValue = LanguageValue,
    TextValue = TextValue,
    ViaValue = ViaValue,
    SizeValue = SizeValue,
    CountUrlValue = CountUrlValue,
    CounterPositionValue = CounterPositionValue,
    SuggestionsValue = SuggestionsValue,
    AccountsValue = AccountsValue?.ToArray(),
    TagsValue = TagsValue?.ToArray()
  };

  /// <inheritdoc cref="IWebWidget.ToHtml()"/>
  public override string ToHtml() => new TagBuilder("a")
      .Attribute("href", "https://twitter.com/share")
      .Attribute("data-lang", LanguageValue ?? Thread.CurrentThread.CurrentCulture.TwoLetterISOLanguageName)
      .Attribute("data-url", UrlValue)
      .Attribute("data-via", ViaValue)
      .Attribute("data-text", TextValue)
      .Attribute("data-related", AccountsValue.Any() ? AccountsValue.Join(",") : null)
      .Attribute("data-count", CounterPositionValue)
      .Attribute("data-counturl", CountUrlValue)
      .Attribute("data-hashtags", TagsValue.Any() ? TagsValue.Join(" ") : null)
      .Attribute("data-size", SizeValue)
      .Attribute("data-dnt", !SuggestionsValue)
      .CssClass(TagsValue.Any() ? "twitter-hashtag-button" : "twitter-share-button")
      .ToString();
}