using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="ITwitterFollowButtonWidget"/>
public class TwitterFollowButtonWidget : WebWidget, ITwitterFollowButtonWidget
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string AccountProperty { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string LanguageProperty { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string SizeProperty { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string AlignmentProperty { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual bool? CounterProperty { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual bool? ScreenNameProperty { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual bool? SuggestionsProperty { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string WidthProperty { get; set; }

  /// <inheritdoc cref="ITwitterFollowButtonWidget.Account(string)"/>
  public virtual ITwitterFollowButtonWidget Account(string account)
  {
    if (account is null) throw new ArgumentNullException(nameof(account));
    if (account.IsEmpty()) throw new ArgumentException(nameof(account));

    AccountProperty = account;
    return this;
  }

  /// <inheritdoc cref="ITwitterFollowButtonWidget.Alignment(string)"/>
  public virtual ITwitterFollowButtonWidget Alignment(string alignment)
  {
    if (alignment is null) throw new ArgumentNullException(nameof(alignment));
    if (alignment.IsEmpty()) throw new ArgumentException(nameof(alignment));

    AlignmentProperty = alignment;
    return this;
  }

  /// <inheritdoc cref="ITwitterFollowButtonWidget.Counter(bool)"/>
  public virtual ITwitterFollowButtonWidget Counter(bool enabled)
  {
    CounterProperty = enabled;
    return this;
  }

  /// <inheritdoc cref="ITwitterFollowButtonWidget.Language(string)"/>
  public virtual ITwitterFollowButtonWidget Language(string language)
  {
    if (language is null) throw new ArgumentNullException(nameof(language));
    if (language.IsEmpty()) throw new ArgumentException(nameof(language));

    LanguageProperty = language;
    return this;
  }

  /// <inheritdoc cref="ITwitterFollowButtonWidget.ScreenName(bool)"/>
  public virtual ITwitterFollowButtonWidget ScreenName(bool enabled)
  {
    ScreenNameProperty = enabled;
    return this;
  }

  /// <inheritdoc cref="ITwitterFollowButtonWidget.Size(string)"/>
  public virtual ITwitterFollowButtonWidget Size(string size)
  {
    if (size is null) throw new ArgumentNullException(nameof(size));
    if (size.IsEmpty()) throw new ArgumentException(nameof(size));

    SizeProperty = size;
    return this;
  }

  /// <inheritdoc cref="ITwitterFollowButtonWidget.Suggestions(bool)"/>
  public virtual ITwitterFollowButtonWidget Suggestions(bool enabled)
  {
    SuggestionsProperty = enabled;
    return this;
  }

  /// <inheritdoc cref="ITwitterFollowButtonWidget.Width(string)"/>
  public virtual ITwitterFollowButtonWidget Width(string width)
  {
    if (width is null) throw new ArgumentNullException(nameof(width));
    if (width.IsEmpty()) throw new ArgumentException(nameof(width));

    WidthProperty = width;
    return this;
  }

  /// <inheritdoc cref="IHtmlContent.ToHtml()"/>
  public override string ToHtml() => AccountProperty.IsUnset() ? string.Empty : 
    new TagBuilder("a")
      .Attribute("href", $"https://twitter.com/${AccountProperty}")
      .Attribute("data-lang", LanguageProperty ?? Thread.CurrentThread.CurrentCulture.TwoLetterISOLanguageName)
      .Attribute("data-show-count", CounterProperty)
      .Attribute("data-size", SizeProperty)
      .Attribute("data-width", WidthProperty)
      .Attribute("data-align", AlignmentProperty)
      .Attribute("data-show-screen-name", ScreenNameProperty)
      .Attribute("data-dnt", !SuggestionsProperty)
      .CssClass("twitter-follow-button")
      .ToString();
}