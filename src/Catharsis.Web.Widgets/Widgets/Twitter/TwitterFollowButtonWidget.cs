using System.Web.Mvc;
using Catharsis.Extensions;

namespace Catharsis.Web.Widgets;

/// <inheritdoc cref="ITwitterFollowButtonWidget"/>
public class TwitterFollowButtonWidget : HtmlWidget, ITwitterFollowButtonWidget
{
  private string account;
  private string language;
  private string size;
  private string alignment;
  private bool? counter;
  private bool? screenName;
  private bool? suggestions;
  private string width;

  /// <summary>
  ///   <para>Twitter account name.</para>
  /// </summary>
  /// <param name="account">Account name.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="account"/> is a <c>null</c> reference.</exception>
  /// <exception cref="ArgumentException">If <paramref name="account"/> is <see cref="string.Empty"/> string.</exception>
  /// <remarks>This attribute is required.</remarks>
  public ITwitterFollowButtonWidget Account(string account)
  {
    if (account is null) throw new ArgumentNullException(nameof(account));
    if (account.IsEmpty()) throw new ArgumentException(nameof(account));

    this.account = account;
    return this;
  }

  /// <summary>
  ///   <para>Twitter account name.</para>
  /// </summary>
  /// <returns>Account name.</returns>
  public string Account() => account;

  /// <summary>
  ///   <para>Horizontal alignment of the button.</para>
  /// </summary>
  /// <param name="alignment">Horizontal alignment of button.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="alignment"/> is a <c>null</c> reference.</exception>
  /// <exception cref="ArgumentException">If <paramref name="alignment"/> is <see cref="string.Empty"/> string.</exception>
  public ITwitterFollowButtonWidget Alignment(string alignment)
  {
    if (alignment is null) throw new ArgumentNullException(nameof(alignment));
    if (alignment.IsEmpty()) throw new ArgumentException(nameof(alignment));

    this.alignment = alignment;
    return this;
  }

  /// <summary>
  ///   <para>Horizontal alignment of the button.</para>
  /// </summary>
  /// <returns>Horizontal alignment of button.</returns>
  public string Alignment() => alignment;

  /// <summary>
  ///   <para>Whether to display user's followers count. Default is <c>false</c>.</para>
  /// </summary>
  /// <param name="show"><c>true</c> to show followers count, <c>false</c> to hide.</param>
  /// <returns>Reference to the current widget.</returns>
  public ITwitterFollowButtonWidget Counter(bool show)
  {
    counter = show;
    return this;
  }

  /// <summary>
  ///   <para>Whether to display user's followers count. Default is <c>false</c>.</para>
  /// </summary>
  /// <returns><c>true</c> to show followers count, <c>false</c> to hide.</returns>
  public bool? Counter() => counter;

  /// <summary>
  ///   <para>Language for the "Follow" button. Default is either request locale's language or language of the current thread.</para>
  /// </summary>
  /// <param name="language">Interface language for button.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="language"/> is a <c>null</c> reference.</exception>
  /// <exception cref="ArgumentException">If <paramref name="language"/> is <see cref="string.Empty"/> string.</exception>
  public ITwitterFollowButtonWidget Language(string language)
  {
    if (language is null) throw new ArgumentNullException(nameof(language));
    if (language.IsEmpty()) throw new ArgumentException(nameof(language));

    this.language = language;
    return this;
  }

  /// <summary>
  ///   <para>Language for the "Follow" button. Default is either request locale's language or language of the current thread.</para>
  /// </summary>
  /// <returns>Interface language for button.</returns>
  public string Language() => language;

  /// <summary>
  ///   <para>Whether to show user's screen name. Default is <c>true</c>.</para>
  /// </summary>
  /// <param name="screenName"><c>true</c> to show screen name, <c>false</c> to hide.</param>
  /// <returns>Reference to the current widget.</returns>
  public ITwitterFollowButtonWidget ScreenName(bool screenName)
  {
    this.screenName = screenName;
    return this;
  }

  /// <summary>
  ///   <para>Whether to show user's screen name. Default is <c>true</c>.</para>
  /// </summary>
  /// <returns><c>true</c> to show screen name, <c>false</c> to hide.</returns>
  public bool? ScreenName() => screenName;

  /// <summary>
  ///   <para>The size of the rendered button. Default is "medium".</para>
  /// </summary>
  /// <param name="size">Size of button.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="size"/> is a <c>null</c> reference.</exception>
  /// <exception cref="ArgumentException">If <paramref name="size"/> is <see cref="string.Empty"/> string.</exception>
  public ITwitterFollowButtonWidget Size(string size)
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
  public string Size() => size;

  /// <summary>
  ///   <para>Whether to enable twitter suggestions. Default is <c>true</c>.</para>
  /// </summary>
  /// <param name="enabled"><c>true</c> to not opt-out of suggestions, <c>false</c> to opt-in.</param>
  /// <returns>Reference to the current widget.</returns>
  public ITwitterFollowButtonWidget Suggestions(bool enabled)
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
  ///   <para>Width of the button.</para>
  /// </summary>
  /// <param name="width">Width of button.</param>
  /// <returns>Reference to the current widget.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="width"/> is a <c>null</c> reference.</exception>
  /// <exception cref="ArgumentException">If <paramref name="width"/> is <see cref="string.Empty"/> string.</exception>
  public ITwitterFollowButtonWidget Width(string width)
  {
    if (width is null) throw new ArgumentNullException(nameof(width));
    if (width.IsEmpty()) throw new ArgumentException(nameof(width));

    this.width = width;
    return this;
  }

  /// <summary>
  ///   <para>Width of the button.</para>
  /// </summary>
  /// <returns>Width of button.</returns>
  public string Width() => width;

  /// <inheritdoc cref="IHtmlWidget.ToHtmlString()"/>
  public override string ToHtmlString()
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