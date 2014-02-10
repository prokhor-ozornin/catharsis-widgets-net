using System.IO;
using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  public sealed class IntenseDebateCommentsWidget : HtmlWidgetBase<IIntenseDebateCommentsWidget>, IIntenseDebateCommentsWidget
  {
    private string account;
    private string postId;
    private string postUrl;
    private string postTitle;

    public IIntenseDebateCommentsWidget Account(string account)
    {
      Assertion.NotEmpty(account);

      this.account = account;
      return this;
    }

    public IIntenseDebateCommentsWidget PostId(string postId)
    {
      Assertion.NotEmpty(postId);

      this.postId = postId;
      return this;
    }

    public IIntenseDebateCommentsWidget PostUrl(string postUrl)
    {
      Assertion.NotEmpty(postUrl);

      this.postUrl = postUrl;
      return this;
    }

    public IIntenseDebateCommentsWidget PostTitle(string postTitle)
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

      writer.Write(resources.intensedebate_comments.FormatValue(this.account, this.postId, this.postUrl, this.postTitle));
    }
  }
}