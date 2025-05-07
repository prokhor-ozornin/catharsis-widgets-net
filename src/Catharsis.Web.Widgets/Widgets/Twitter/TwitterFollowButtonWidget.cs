using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="ITwitterFollowButtonWidget"/>
public class TwitterFollowButtonWidget : WebWidget, ITwitterFollowButtonWidget
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string AccountValue { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string LanguageValue { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string SizeValue { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string AlignmentValue { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual bool? CounterValue { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual bool? ScreenNameValue { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual bool? SuggestionsValue { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  protected virtual string WidthValue { get; set; }

  /// <inheritdoc cref="ITwitterFollowButtonWidget.Account(string)"/>
  public virtual ITwitterFollowButtonWidget Account(string account)
  {
    if (account is null) throw new ArgumentNullException(nameof(account));
    if (account.IsEmpty()) throw new ArgumentException(nameof(account));

    AccountValue = account;
    return this;
  }

  /// <inheritdoc cref="ITwitterFollowButtonWidget.Alignment(string)"/>
  public virtual ITwitterFollowButtonWidget Alignment(string alignment)
  {
    if (alignment is null) throw new ArgumentNullException(nameof(alignment));
    if (alignment.IsEmpty()) throw new ArgumentException(nameof(alignment));

    AlignmentValue = alignment;
    return this;
  }

  /// <inheritdoc cref="ITwitterFollowButtonWidget.Counter(bool)"/>
  public virtual ITwitterFollowButtonWidget Counter(bool enabled)
  {
    CounterValue = enabled;
    return this;
  }

  /// <inheritdoc cref="ITwitterFollowButtonWidget.Language(string)"/>
  public virtual ITwitterFollowButtonWidget Language(string language)
  {
    if (language is null) throw new ArgumentNullException(nameof(language));
    if (language.IsEmpty()) throw new ArgumentException(nameof(language));

    LanguageValue = language;
    return this;
  }

  /// <inheritdoc cref="ITwitterFollowButtonWidget.ScreenName(bool)"/>
  public virtual ITwitterFollowButtonWidget ScreenName(bool enabled)
  {
    ScreenNameValue = enabled;
    return this;
  }

  /// <inheritdoc cref="ITwitterFollowButtonWidget.Size(string)"/>
  public virtual ITwitterFollowButtonWidget Size(string size)
  {
    if (size is null) throw new ArgumentNullException(nameof(size));
    if (size.IsEmpty()) throw new ArgumentException(nameof(size));

    SizeValue = size;
    return this;
  }

  /// <inheritdoc cref="ITwitterFollowButtonWidget.Suggestions(bool)"/>
  public virtual ITwitterFollowButtonWidget Suggestions(bool enabled)
  {
    SuggestionsValue = enabled;
    return this;
  }

  /// <inheritdoc cref="ITwitterFollowButtonWidget.Width(string)"/>
  public virtual ITwitterFollowButtonWidget Width(string width)
  {
    if (width is null) throw new ArgumentNullException(nameof(width));
    if (width.IsEmpty()) throw new ArgumentException(nameof(width));

    WidthValue = width;
    return this;
  }

  /// <inheritdoc cref="ICloneable.Clone()"/>
  public override object Clone() => new TwitterFollowButtonWidget
  {
    AccountValue = AccountValue,
    LanguageValue = LanguageValue,
    SizeValue = SizeValue,
    AlignmentValue = AlignmentValue,
    CounterValue = CounterValue,
    ScreenNameValue = ScreenNameValue,
    SuggestionsValue = SuggestionsValue,
    WidthValue = WidthValue
  };

  /// <inheritdoc cref="IWebWidget.ToHtml()"/>
  public override string ToHtml() => AccountValue.IsUnset() ? string.Empty : 
    new TagBuilder("a")
      .Attribute("href", $"https://twitter.com/${AccountValue}")
      .Attribute("data-lang", LanguageValue ?? Thread.CurrentThread.CurrentCulture.TwoLetterISOLanguageName)
      .Attribute("data-show-count", CounterValue)
      .Attribute("data-size", SizeValue)
      .Attribute("data-width", WidthValue)
      .Attribute("data-align", AlignmentValue)
      .Attribute("data-show-screen-name", ScreenNameValue)
      .Attribute("data-dnt", !SuggestionsValue)
      .CssClass("twitter-follow-button")
      .ToString();
}