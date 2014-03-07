using System;
using System.IO;
using System.Threading;
using System.Web;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para>Renders Twitter "Follow" button.</para>
  ///   <para>Requires <see cref="WidgetsScriptsBundles.Twitter"/> scripts bundle to be included.</para>
  ///   <seealso cref="https://dev.twitter.com/docs/follow-button"/>
  /// </summary>
  public sealed class TwitterFollowButtonWidget : HtmlWidgetBase<ITwitterFollowButtonWidget>, ITwitterFollowButtonWidget
  {
    private string account;
    private string language;
    private string size;
    private string alignment;
    private bool? count;
    private bool? screenName;
    private bool? optOut;
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
    ///   <para>Whether to display user's followers count. Default is <c>false</c>.</para>
    /// </summary>
    /// <param name="count"><c>true</c> to show followers count, <c>false</c> to hide.</param>
    /// <returns>Reference to the current widget.</returns>
    public ITwitterFollowButtonWidget Count(bool count = true)
    {
      this.count = count;
      return this;
    }

    /// <summary>
    ///   <para>Whether to show user's screen name. Default is <c>true</c>.</para>
    /// </summary>
    /// <param name="screenName"><c>true</c> to show screen name, <c>false</c> to hide.</param>
    /// <returns>Reference to the current widget.</returns>
    public ITwitterFollowButtonWidget ScreenName(bool screenName = true)
    {
      this.screenName = screenName;
      return this;
    }

    /// <summary>
    ///   <para>Whether to opt-out of twitter suggestions. Default is <c>false</c>.</para>
    /// </summary>
    /// <param name="optOut"><c>true</c> to opt-out, <c>false</c> to opt-in.</param>
    /// <returns>Reference to the current widget.</returns>
    public ITwitterFollowButtonWidget OptOut(bool show = true)
    {
      this.optOut = show;
      return this;
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
    ///   <para>Generates and writes HTML markup of widget, using specified text writer.</para>
    /// </summary>
    /// <param name="writer">Text writer to use as output destination.</param>
    public override void Write(TextWriter writer)
    {
      Assertion.NotNull(writer);

      if (this.account.IsEmpty())
      {
        return;
      }

      writer.Write(this.ToTag("a", tag => tag
        .Attribute("href", "https://twitter.com/{0}".FormatSelf(this.account))
        .Attribute("data-lang", this.language ?? (HttpContext.Current != null ? HttpContext.Current.Request.Language() : Thread.CurrentThread.CurrentCulture.TwoLetterISOLanguageName))
        .Attribute("data-show-count", this.count)
        .Attribute("data-size", this.size)
        .Attribute("data-width", this.width)
        .Attribute("data-align", this.alignment)
        .Attribute("data-show-screen-name", this.screenName)
        .Attribute("data-dnt", this.optOut)
        .AddCssClass("twitter-follow-button")));
    }
  }
}