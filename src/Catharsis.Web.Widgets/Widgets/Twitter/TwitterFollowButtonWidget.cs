using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="ITwitterFollowButtonWidget"/>
public class TwitterFollowButtonWidget : WebWidget, ITwitterFollowButtonWidget
{
  private string AccountProperty { get; set; }
  private string LanguageProperty { get; set; }
  private string SizeProperty { get; set; }
  private string AlignmentProperty { get; set; }
  private bool? CounterProperty { get; set; }
  private bool? ScreenNameProperty { get; set; }
  private bool? SuggestionsProperty { get; set; }
  private string WidthProperty { get; set; }

  /// <inheritdoc cref="ITwitterFollowButtonWidget.Account(string)"/>
  public ITwitterFollowButtonWidget Account(string account)
  {
    if (account is null) throw new ArgumentNullException(nameof(account));
    if (account.IsEmpty()) throw new ArgumentException(nameof(account));

    AccountProperty = account;
    return this;
  }

  /// <inheritdoc cref="ITwitterFollowButtonWidget.Account()"/>
  public string Account() => AccountProperty;

  /// <inheritdoc cref="ITwitterFollowButtonWidget.Alignment(string)"/>
  public ITwitterFollowButtonWidget Alignment(string alignment)
  {
    if (alignment is null) throw new ArgumentNullException(nameof(alignment));
    if (alignment.IsEmpty()) throw new ArgumentException(nameof(alignment));

    AlignmentProperty = alignment;
    return this;
  }

  /// <inheritdoc cref="ITwitterFollowButtonWidget.Alignment()"/>
  public string Alignment() => AlignmentProperty;

  /// <inheritdoc cref="ITwitterFollowButtonWidget.Counter(bool)"/>
  public ITwitterFollowButtonWidget Counter(bool enabled)
  {
    CounterProperty = enabled;
    return this;
  }

  /// <inheritdoc cref="ITwitterFollowButtonWidget.Counter()"/>
  public bool? Counter() => CounterProperty;

  /// <inheritdoc cref="ITwitterFollowButtonWidget.Language(string)"/>
  public ITwitterFollowButtonWidget Language(string language)
  {
    if (language is null) throw new ArgumentNullException(nameof(language));
    if (language.IsEmpty()) throw new ArgumentException(nameof(language));

    LanguageProperty = language;
    return this;
  }

  /// <inheritdoc cref="ITwitterFollowButtonWidget.Language()"/>
  public string Language() => LanguageProperty;

  /// <inheritdoc cref="ITwitterFollowButtonWidget.ScreenName(bool)"/>
  public ITwitterFollowButtonWidget ScreenName(bool enabled)
  {
    ScreenNameProperty = enabled;
    return this;
  }

  /// <inheritdoc cref="ITwitterFollowButtonWidget.ScreenName()"/>
  public bool? ScreenName() => ScreenNameProperty;

  /// <inheritdoc cref="ITwitterFollowButtonWidget.Size(string)"/>
  public ITwitterFollowButtonWidget Size(string size)
  {
    if (size is null) throw new ArgumentNullException(nameof(size));
    if (size.IsEmpty()) throw new ArgumentException(nameof(size));

    SizeProperty = size;
    return this;
  }

  /// <inheritdoc cref="ITwitterFollowButtonWidget.Size()"/>
  public string Size() => SizeProperty;

  /// <inheritdoc cref="ITwitterFollowButtonWidget.Suggestions(bool)"/>
  public ITwitterFollowButtonWidget Suggestions(bool enabled)
  {
    SuggestionsProperty = enabled;
    return this;
  }

  /// <inheritdoc cref="ITwitterFollowButtonWidget.Suggestions()"/>
  public bool? Suggestions() => SuggestionsProperty;

  /// <inheritdoc cref="ITwitterFollowButtonWidget.Width(string)"/>
  public ITwitterFollowButtonWidget Width(string width)
  {
    if (width is null) throw new ArgumentNullException(nameof(width));
    if (width.IsEmpty()) throw new ArgumentException(nameof(width));

    WidthProperty = width;
    return this;
  }

  /// <inheritdoc cref="ITwitterFollowButtonWidget.Width()"/>
  public string Width() => WidthProperty;

  /// <inheritdoc cref="IHtmlContent.ToHtml()"/>
  public override string ToHtml() => Account().IsEmpty() ? string.Empty : 
    new TagBuilder("a")
      .Attribute("href", $"https://twitter.com/${Account()}")
      .Attribute("data-lang", Language() ?? Thread.CurrentThread.CurrentCulture.TwoLetterISOLanguageName)
      .Attribute("data-show-count", Counter())
      .Attribute("data-size", Size())
      .Attribute("data-width", Width())
      .Attribute("data-align", Alignment())
      .Attribute("data-show-screen-name", ScreenName())
      .Attribute("data-dnt", Suggestions() is null ? null : !Suggestions())
      .CssClass("twitter-follow-button")
      .ToString();
}