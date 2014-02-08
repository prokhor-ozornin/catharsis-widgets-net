using System.IO;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  public sealed class TwitterFollowButtonWidget : HtmlWidgetBase<ITwitterFollowButtonWidget>, ITwitterFollowButtonWidget
  {
    private string account;
    private string language;
    private string size;
    private string alignment;
    private bool? showCount;
    private bool? showScreenName;
    private bool? optOut;
    private string width;

    public ITwitterFollowButtonWidget Account(string account)
    {
      Assertion.NotEmpty(account);

      this.account = account;
      return this;
    }

    public ITwitterFollowButtonWidget Language(string language)
    {
      Assertion.NotEmpty(language);

      this.language = language;
      return this;
    }

    public ITwitterFollowButtonWidget Size(string size)
    {
      Assertion.NotEmpty(size);

      this.size = size;
      return this;
    }

    public ITwitterFollowButtonWidget Alignment(string alignment)
    {
      Assertion.NotEmpty(alignment);

      this.alignment = alignment;
      return this;
    }

    public ITwitterFollowButtonWidget ShowCount(bool show = true)
    {
      this.showCount = show;
      return this;
    }

    public ITwitterFollowButtonWidget ShowScreenName(bool show = true)
    {
      this.showScreenName = show;
      return this;
    }

    public ITwitterFollowButtonWidget OptOut(bool show = true)
    {
      this.optOut = show;
      return this;
    }

    public ITwitterFollowButtonWidget Width(string width)
    {
      Assertion.NotEmpty(width);

      this.width = width;
      return this;
    }

    public override void Write(TextWriter writer)
    {
      Assertion.NotNull(writer);

      if (this.account.IsEmpty())
      {
        return;
      }

      writer.Write(this.ToTag("a", tag => tag
        .Attribute("href", "https://twitter.com/{0}".FormatValue(this.account))
        .Attribute("data-lang", this.language ?? (HttpContext.Current != null ? HttpContext.Current.Request.Language() : Thread.CurrentThread.CurrentCulture.TwoLetterISOLanguageName))
        .Attribute("data-show-count", this.showCount)
        .Attribute("data-size", this.size)
        .Attribute("data-width", this.width)
        .Attribute("data-align", this.alignment)
        .Attribute("data-show-screen-name", this.showScreenName)
        .Attribute("data-dnt", this.optOut)
        .AddCssClass("twitter-follow-button")));
    }
  }
}