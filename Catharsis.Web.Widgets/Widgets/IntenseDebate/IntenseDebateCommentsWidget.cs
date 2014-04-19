using Catharsis.Commons;

namespace Catharsis.Web.Widgets
{
  public class IntenseDebateCommentsWidget : HtmlWidgetBase, IIntenseDebateCommentsWidget
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

    /// <summary>
    ///   <para>Returns HTML markup text of widget.</para>
    /// </summary>
    /// <returns>Widget's HTML markup.</returns>
    public override string ToHtmlString()
    {
      if (this.account.IsEmpty())
      {
        return string.Empty;
      }

      return resources.intensedebate_comments.FormatSelf(this.account, this.postId, this.postUrl, this.postTitle);
    }
  }
}