using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="ITwitterTweetButtonWidget"/>
public class TwitterTweetButtonWidget : WebWidget, ITwitterTweetButtonWidget
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string UrlProperty { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string LanguageProperty { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string TextProperty { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string ViaProperty { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string SizeProperty { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string CountUrlProperty { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string CounterPositionProperty { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual bool? SuggestionsProperty { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual IEnumerable<string> AccountsProperty { get; set; } = [];

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual IEnumerable<string> TagsProperty { get; set; } = [];

  /// <inheritdoc cref="ITwitterTweetButtonWidget.CounterPosition(string)"/>
  public virtual ITwitterTweetButtonWidget CounterPosition(string position)
  {
    if (position is null) throw new ArgumentNullException(nameof(position));
    if (position.IsEmpty()) throw new ArgumentException(nameof(position));

    CounterPositionProperty = position;
    return this;
  }

  /// <inheritdoc cref="ITwitterTweetButtonWidget.CountUrl(string)"/>
  public virtual ITwitterTweetButtonWidget CountUrl(string url)
  {
    if (url is null) throw new ArgumentNullException(nameof(url));
    if (url.IsEmpty()) throw new ArgumentException(nameof(url));

    CountUrlProperty = url;
    return this;
  }

  /// <inheritdoc cref="ITwitterTweetButtonWidget.HashTags(IEnumerable{string})"/>
  public virtual ITwitterTweetButtonWidget HashTags(IEnumerable<string> tags)
  {
    TagsProperty = tags ?? throw new ArgumentNullException(nameof(tags));
    return this;
  }

  /// <inheritdoc cref="ITwitterTweetButtonWidget.Language(string)"/>
  public virtual ITwitterTweetButtonWidget Language(string language)
  {
    if (language is null) throw new ArgumentNullException(nameof(language));
    if (language.IsEmpty()) throw new ArgumentException(nameof(language));

    LanguageProperty = language;
    return this;
  }

  /// <inheritdoc cref="ITwitterTweetButtonWidget.Suggestions(bool)"/>
  public virtual ITwitterTweetButtonWidget Suggestions(bool enabled)
  {
    SuggestionsProperty = enabled;
    return this;
  }

  /// <inheritdoc cref="ITwitterTweetButtonWidget.RelatedAccounts(IEnumerable{string})"/>
  public virtual ITwitterTweetButtonWidget RelatedAccounts(IEnumerable<string> accounts)
  {
    AccountsProperty = accounts ?? throw new ArgumentNullException(nameof(accounts));
    return this;
  }

  /// <inheritdoc cref="ITwitterTweetButtonWidget.Size(string)"/>
  public virtual ITwitterTweetButtonWidget Size(string size)
  {
    if (size is null) throw new ArgumentNullException(nameof(size));
    if (size.IsEmpty()) throw new ArgumentException(nameof(size));

    SizeProperty = size;
    return this;
  }

  /// <inheritdoc cref="ITwitterTweetButtonWidget.Text(string)"/>
  public virtual ITwitterTweetButtonWidget Text(string text)
  {
    if (text is null) throw new ArgumentNullException(nameof(text));
    if (text.IsEmpty()) throw new ArgumentException(nameof(text));

    TextProperty = text;
    return this;
  }

  /// <inheritdoc cref="ITwitterTweetButtonWidget.Url(string)"/>
  public virtual ITwitterTweetButtonWidget Url(string url)
  {
    if (url is null) throw new ArgumentNullException(nameof(url));
    if (url.IsEmpty()) throw new ArgumentException(nameof(url));

    UrlProperty = url;
    return this;
  }

  /// <inheritdoc cref="ITwitterTweetButtonWidget.Via(string)"/>
  public virtual ITwitterTweetButtonWidget Via(string account)
  {
    if (account is null) throw new ArgumentNullException(nameof(account));
    if (account.IsEmpty()) throw new ArgumentException(nameof(account));

    ViaProperty = account;
    return this;
  }

  /// <inheritdoc cref="IHtmlContent.ToHtml()"/>
  public override string ToHtml() => new TagBuilder("a")
      .Attribute("href", "https://twitter.com/share")
      .Attribute("data-lang", LanguageProperty ?? Thread.CurrentThread.CurrentCulture.TwoLetterISOLanguageName)
      .Attribute("data-url", UrlProperty)
      .Attribute("data-via", ViaProperty)
      .Attribute("data-text", TextProperty)
      .Attribute("data-related", AccountsProperty.Any() ? AccountsProperty.Join(",") : null)
      .Attribute("data-count", CounterPositionProperty)
      .Attribute("data-counturl", CountUrlProperty)
      .Attribute("data-hashtags", TagsProperty.Any() ? TagsProperty.Join(" ") : null)
      .Attribute("data-size", SizeProperty)
      .Attribute("data-dnt", !SuggestionsProperty)
      .CssClass(TagsProperty.Any() ? "twitter-hashtag-button" : "twitter-share-button")
      .ToString();
}