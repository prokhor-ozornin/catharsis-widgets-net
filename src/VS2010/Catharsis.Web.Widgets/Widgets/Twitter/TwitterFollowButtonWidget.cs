using System;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Renders Twitter "Follow" button.</para>
  ///   <para>Requires Twitter scripts bundle to be included.</para>
  /// </summary>
  /// <seealso cref="https://dev.twitter.com/docs/follow-button"/>
  /// <seealso cref="IWidgetsScriptsRendererExtensions.Twitter(IWidgetsScriptsRenderer)"/>
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
      Assertion.NotEmpty(account);

      this.account = account;
      return this;
    }

    /// <summary>
    ///   <para>Twitter account name.</para>
    /// </summary>
    /// <returns>Account name.</returns>
    public string Account()
    {
      return this.account;
    }

    /// <summary>
    ///   <para>Horizontal alignment of the button.</para>
    /// </summary>
    /// <param name="alignment">Horizontal alignment of button.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="alignment"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="alignment"/> is <see cref="string.Empty"/> string.</exception>
    public ITwitterFollowButtonWidget Alignment(string alignment)
    {
      Assertion.NotEmpty(alignment);

      this.alignment = alignment;
      return this;
    }

    /// <summary>
    ///   <para>Horizontal alignment of the button.</para>
    /// </summary>
    /// <returns>Horizontal alignment of button.</returns>
    public string Alignment()
    {
      return this.alignment;
    }

    /// <summary>
    ///   <para>Whether to display user's followers count. Default is <c>false</c>.</para>
    /// </summary>
    /// <param name="show"><c>true</c> to show followers count, <c>false</c> to hide.</param>
    /// <returns>Reference to the current widget.</returns>
    public ITwitterFollowButtonWidget Counter(bool show)
    {
      this.counter = show;
      return this;
    }

    /// <summary>
    ///   <para>Whether to display user's followers count. Default is <c>false</c>.</para>
    /// </summary>
    /// <returns><c>true</c> to show followers count, <c>false</c> to hide.</returns>
    public bool? Counter()
    {
      return this.counter;
    }

    /// <summary>
    ///   <para>Language for the "Follow" button. Default is either request locale's language or language of the current thread.</para>
    /// </summary>
    /// <param name="language">Interface language for button.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="language"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="language"/> is <see cref="string.Empty"/> string.</exception>
    public ITwitterFollowButtonWidget Language(string language)
    {
      Assertion.NotEmpty(language);

      this.language = language;
      return this;
    }

    /// <summary>
    ///   <para>Language for the "Follow" button. Default is either request locale's language or language of the current thread.</para>
    /// </summary>
    /// <returns>Interface language for button.</returns>
    public string Language()
    {
      return this.language;
    }

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
    public bool? ScreenName()
    {
      return this.screenName;
    }

    /// <summary>
    ///   <para>The size of the rendered button. Default is "medium".</para>
    /// </summary>
    /// <param name="size">Size of button.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="size"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="size"/> is <see cref="string.Empty"/> string.</exception>
    public ITwitterFollowButtonWidget Size(string size)
    {
      Assertion.NotEmpty(size);

      this.size = size;
      return this;
    }

    /// <summary>
    ///   <para>The size of the rendered button. Default is "medium".</para>
    /// </summary>
    /// <returns>Size of button.</returns>
    public string Size()
    {
      return this.size;
    }

    /// <summary>
    ///   <para>Whether to enable twitter suggestions. Default is <c>true</c>.</para>
    /// </summary>
    /// <param name="enabled"><c>true</c> to not opt-out of suggestions, <c>false</c> to opt-in.</param>
    /// <returns>Reference to the current widget.</returns>
    public ITwitterFollowButtonWidget Suggestions(bool enabled)
    {
      this.suggestions = enabled;
      return this;
    }

    /// <summary>
    ///   <para>Whether to enable twitter suggestions. Default is <c>true</c>.</para>
    /// </summary>
    /// <returns><c>true</c> to not opt-out of suggestions, <c>false</c> to opt-in.</returns>
    public bool? Suggestions()
    {
      return this.suggestions;
    }

    /// <summary>
    ///   <para>Width of the button.</para>
    /// </summary>
    /// <param name="width">Width of button.</param>
    /// <returns>Reference to the current widget.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="width"/> is a <c>null</c> reference.</exception>
    /// <exception cref="ArgumentException">If <paramref name="width"/> is <see cref="string.Empty"/> string.</exception>
    public ITwitterFollowButtonWidget Width(string width)
    {
      Assertion.NotEmpty(width);

      this.width = width;
      return this;
    }

    /// <summary>
    ///   <para>Width of the button.</para>
    /// </summary>
    /// <returns>Width of button.</returns>
    public string Width()
    {
      return this.width;
    }

    /// <summary>
    ///   <para>Returns HTML markup text of widget.</para>
    /// </summary>
    /// <returns>Widget's HTML markup.</returns>
    public override string ToHtmlString()
    {
      if (this.Account().IsEmpty())
      {
        return string.Empty;
      }

      return new TagBuilder("a")
        .Attribute("href", "https://twitter.com/{0}".FormatSelf(this.Account()))
        .Attribute("data-lang", this.Language() ?? (HttpContext.Current != null ? HttpContext.Current.Request.Language() : Thread.CurrentThread.CurrentCulture.TwoLetterISOLanguageName))
        .Attribute("data-show-count", this.Counter())
        .Attribute("data-size", this.Size())
        .Attribute("data-width", this.Width())
        .Attribute("data-align", this.Alignment())
        .Attribute("data-show-screen-name", this.ScreenName())
        .Attribute("data-dnt", this.Suggestions() == null ? null : !this.Suggestions())
        .CssClass("twitter-follow-button")
        .ToString();
    }
  }
}