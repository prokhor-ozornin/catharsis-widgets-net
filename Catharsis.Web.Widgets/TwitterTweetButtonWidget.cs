using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Web;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  public sealed class TwitterTweetButtonWidget : HtmlWidgetBase<ITwitterTweetButtonWidget>, ITwitterTweetButtonWidget
  {
    private string url;
    private string language;
    private string text;
    private string via;
    private string size;
    private string countUrl;
    private string countPosition;
    private bool? optOut;
    private IEnumerable<string> accounts = Enumerable.Empty<string>();
    private IEnumerable<string> tags = Enumerable.Empty<string>();

    public ITwitterTweetButtonWidget Url(string url)
    {
      Assertion.NotEmpty(url);

      this.url = url;
      return this;
    }

    public ITwitterTweetButtonWidget Language(string language)
    {
      Assertion.NotEmpty(language);

      this.language = language;
      return this;
    }

    public ITwitterTweetButtonWidget Text(string text)
    {
      Assertion.NotEmpty(text);

      this.text = text;
      return this;
    }

    public ITwitterTweetButtonWidget Via(string account)
    {
      Assertion.NotEmpty(account);

      this.via = account;
      return this;
    }

    public ITwitterTweetButtonWidget Size(string size)
    {
      Assertion.NotEmpty(size);

      this.size = size;
      return this;
    }

    public ITwitterTweetButtonWidget CountUrl(string url)
    {
      Assertion.NotEmpty(url);

      this.countUrl = url;
      return this;
    }

    public ITwitterTweetButtonWidget CountPosition(string position)
    {
      Assertion.NotEmpty(position);

      this.countPosition = position;
      return this;
    }

    public ITwitterTweetButtonWidget OptOut(bool optOut = true)
    {
      this.optOut = optOut;
      return this;
    }

    public ITwitterTweetButtonWidget HashTags(IEnumerable<string> tags)
    {
      Assertion.NotNull(tags);

      this.tags = tags;
      return this;
    }

    public ITwitterTweetButtonWidget RelatedAccounts(IEnumerable<string> accounts)
    {
      Assertion.NotNull(accounts);

      this.accounts = accounts;
      return this;
    }

    public override void Write(TextWriter writer)
    {
      Assertion.NotNull(writer);

      writer.Write(this.ToTag("a", tag => tag.Attribute("href", "https://twitter.com/share")
              .Attribute("data-lang", this.language ?? (HttpContext.Current != null ? HttpContext.Current.Request.Language() : Thread.CurrentThread.CurrentCulture.TwoLetterISOLanguageName))
              .Attribute("data-url", this.url)
              .Attribute("data-via", this.via)
              .Attribute("data-text", this.text)
              .Attribute("data-related", this.accounts.Any() ? this.accounts.Join(",") : null)
              .Attribute("data-count", this.countPosition)
              .Attribute("data-counturl", this.countUrl)
              .Attribute("data-hashtags", this.tags.Any() ? this.tags.Join(" ") : null)
              .Attribute("data-size", this.size)
              .Attribute("data-dnt", this.optOut)
              .AddCssClass(this.tags.Any() ? "twitter-hashtag-button" : "twitter-share-button")));
    }
  }
}