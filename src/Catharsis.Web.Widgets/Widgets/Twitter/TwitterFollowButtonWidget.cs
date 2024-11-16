using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="ITwitterFollowButtonWidget"/>
public class TwitterFollowButtonWidget : WebWidget, ITwitterFollowButtonWidget
{
  private string account;
  private string language;
  private string size;
  private string alignment;
  private bool? counter;
  private bool? screenName;
  private bool? suggestions;
  private string width;

  /// <inheritdoc cref="ITwitterFollowButtonWidget.Account(string)"/>
  public ITwitterFollowButtonWidget Account(string account)
  {
    if (account is null) throw new ArgumentNullException(nameof(account));
    if (account.IsEmpty()) throw new ArgumentException(nameof(account));

    this.account = account;
    return this;
  }

  /// <inheritdoc cref="ITwitterFollowButtonWidget.Account()"/>
  public string Account() => account;

  /// <inheritdoc cref="ITwitterFollowButtonWidget.Alignment(string)"/>
  public ITwitterFollowButtonWidget Alignment(string alignment)
  {
    if (alignment is null) throw new ArgumentNullException(nameof(alignment));
    if (alignment.IsEmpty()) throw new ArgumentException(nameof(alignment));

    this.alignment = alignment;
    return this;
  }

  /// <inheritdoc cref="ITwitterFollowButtonWidget.Alignment()"/>
  public string Alignment() => alignment;

  /// <inheritdoc cref="ITwitterFollowButtonWidget.Counter(bool)"/>
  public ITwitterFollowButtonWidget Counter(bool show)
  {
    counter = show;
    return this;
  }

  /// <inheritdoc cref="ITwitterFollowButtonWidget.Counter()"/>
  public bool? Counter() => counter;

  /// <inheritdoc cref="ITwitterFollowButtonWidget.Language(string)"/>
  public ITwitterFollowButtonWidget Language(string language)
  {
    if (language is null) throw new ArgumentNullException(nameof(language));
    if (language.IsEmpty()) throw new ArgumentException(nameof(language));

    this.language = language;
    return this;
  }

  /// <inheritdoc cref="ITwitterFollowButtonWidget.Language()"/>
  public string Language() => language;

  /// <inheritdoc cref="ITwitterFollowButtonWidget.ScreenName(bool)"/>
  public ITwitterFollowButtonWidget ScreenName(bool screenName)
  {
    this.screenName = screenName;
    return this;
  }

  /// <inheritdoc cref="ITwitterFollowButtonWidget.ScreenName()"/>
  public bool? ScreenName() => screenName;

  /// <inheritdoc cref="ITwitterFollowButtonWidget.Size(string)"/>
  public ITwitterFollowButtonWidget Size(string size)
  {
    if (size is null) throw new ArgumentNullException(nameof(size));
    if (size.IsEmpty()) throw new ArgumentException(nameof(size));

    this.size = size;
    return this;
  }

  /// <inheritdoc cref="ITwitterFollowButtonWidget.Size()"/>
  public string Size() => size;

  /// <inheritdoc cref="ITwitterFollowButtonWidget.Suggestions(bool)"/>
  public ITwitterFollowButtonWidget Suggestions(bool enabled)
  {
    suggestions = enabled;
    return this;
  }

  /// <inheritdoc cref="ITwitterFollowButtonWidget.Suggestions()"/>
  public bool? Suggestions() => suggestions;

  /// <inheritdoc cref="ITwitterFollowButtonWidget.Width(string)"/>
  public ITwitterFollowButtonWidget Width(string width)
  {
    if (width is null) throw new ArgumentNullException(nameof(width));
    if (width.IsEmpty()) throw new ArgumentException(nameof(width));

    this.width = width;
    return this;
  }

  /// <inheritdoc cref="ITwitterFollowButtonWidget.Width()"/>
  public string Width() => width;

  /// <inheritdoc cref="IWebWidget.ToHtml()"/>
  public override string ToHtml()
  {
    if (Account().IsEmpty())
    {
      return string.Empty;
    }

    return new TagBuilder("a")
      .Attribute("href", $"https://twitter.com/${Account()}")
      .Attribute("data-lang", Language() ?? (HttpContext.Current is not null ? HttpContext.Current.Request.Language() : Thread.CurrentThread.CurrentCulture.TwoLetterISOLanguageName))
      .Attribute("data-show-count", Counter())
      .Attribute("data-size", Size())
      .Attribute("data-width", Width())
      .Attribute("data-align", Alignment())
      .Attribute("data-show-screen-name", ScreenName())
      .Attribute("data-dnt", Suggestions() is null ? null : !Suggestions())
      .CssClass("twitter-follow-button")
      .ToString();
  }
}