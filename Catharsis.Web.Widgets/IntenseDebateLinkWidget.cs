using System.IO;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  public sealed class IntenseDebateLinkWidget : HtmlWidgetBase<IIntenseDebateLinkWidget>, IIntenseDebateLinkWidget
  {
    private string account;
    private string postId;
    private string postUrl;
    private string postTitle;

    public IIntenseDebateLinkWidget Account(string account)
    {
      Assertion.NotEmpty(account);

      this.account = account;
      return this;
    }

    public IIntenseDebateLinkWidget PostId(string postId)
    {
      Assertion.NotEmpty(postId);

      this.postId = postId;
      return this;
    }

    public IIntenseDebateLinkWidget PostUrl(string postUrl)
    {
      Assertion.NotEmpty(postUrl);

      this.postUrl = postUrl;
      return this;
    }

    public IIntenseDebateLinkWidget PostTitle(string postTitle)
    {
      Assertion.NotEmpty(postTitle);

      this.postTitle = postTitle;
      return this;
    }

    public override void Write(TextWriter writer)
    {
      Assertion.NotNull(writer);

      if (this.account.IsEmpty())
      {
        return;
      }

      writer.Write(resources.intensedebate_link.FormatSelf(this.account, this.postId, this.postUrl, this.postTitle));
    }
  }
}